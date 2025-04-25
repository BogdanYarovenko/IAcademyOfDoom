using IAcademyOfDoom.Logic.Places;
using IAcademyOfDoom.Logic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using IAcademyOfDoom.Logic.Actions;
using System.Text;
using IAcademyOfDoom.Logic.Skills;

namespace IAcademyOfDoom.View
{
    public partial class ActionsWindow : Form
    {
        private List<GameAction> _availableActions;
        private Dictionary<GameAction, int> _remainingCopies = new Dictionary<GameAction, int>();
        private Dictionary<GameAction, int> _purchasedActions = new Dictionary<GameAction, int>();
        private Dictionary<GameAction, Label> _remainingCopiesLabels = new Dictionary<GameAction, Label>();
        private int _localMoney;

        public ActionsWindow()
        {
            InitializeComponent();
            this.Load += ActionsWindow_Load;
        }

        /// <summary>
        /// Event handler for the form load event. Initializes the game state and UI elements.
        /// </summary>
        private void ActionsWindow_Load(object sender, EventArgs e)
        {
            _localMoney = Game.Money;
            BalanceInMagasin.Text = "Balance is : " + _localMoney.ToString() + " €";
            purchasedActionLabel.Text = "";
            resultOfPurchase.Text = "";
            _availableActions = GetAvailableActions();
            InitializeRemainingCopies();
            InitActionsUI();
        }

        /// <summary>
        /// Initializes the UI components for available actions, their remaining copies, and purchase buttons.
        /// The actions are displayed in two columns based on the number of available actions.
        /// </summary>
        private void InitActionsUI()
        {
            int yOffsetLeft = 40;
            int yOffsetRight = 40;
            int columnSpacing = 400;
            int maxItemsPerColumn = (_availableActions.Count + 1) / 2;

            // Iterating over each available action to add to the UI
            for (int i = 0; i < _availableActions.Count; i++)
            {
                var action = _availableActions[i];
                bool isLeftColumn = i < maxItemsPerColumn;

                int xBase = isLeftColumn ? 20 : 20 + columnSpacing;
                int yOffset = isLeftColumn ? yOffsetLeft : yOffsetRight;

                // Create action label
                Label actionLabel = new Label
                {
                    Text = action.ToString(),
                    Location = new Point(xBase, yOffset),
                    Size = new Size(200, 20),
                    Font = new Font("Microsoft Tai Le", 9.75f, FontStyle.Bold),
                    BackColor = Color.Transparent
                };

                // Create label for remaining copies
                Label remainingCopiesLabel = new Label
                {
                    Text = "{" + _remainingCopies[action] + "}",
                    Location = new Point(xBase + 230, yOffset),
                    Size = new Size(50, 20),
                    Font = new Font("Microsoft Tai Le", 9.75f, FontStyle.Bold),
                    BackColor = Color.Transparent
                };
                _remainingCopiesLabels[action] = remainingCopiesLabel;

                // Create button to buy the action
                Button buyButton = new Button
                {
                    Text = "Buy",
                    Location = new Point(xBase + 290, yOffset),
                    Size = new Size(60, 20),
                    Font = new Font("Microsoft Tai Le", 9.75f, FontStyle.Bold),
                    Tag = action
                };

                // Handle the purchase button click event
                buyButton.Click += (s, e) =>
                {
                    GameAction selectedAction = (GameAction)((Button)s).Tag;

                    // Check if the user can afford and if there are remaining copies
                    if (_remainingCopies[selectedAction] > 0 && _localMoney >= selectedAction.Cost)
                    {
                        _remainingCopies[selectedAction]--;
                        _localMoney -= selectedAction.Cost;
                        BalanceInMagasin.Text = "Your balance is : " + _localMoney + " €";

                        _remainingCopiesLabels[selectedAction].Text = "{" + _remainingCopies[selectedAction] + "}";

                        AddPurchasedActionToList(selectedAction);
                        resultOfPurchase.Text = "Purchase successful";
                    }
                    else if (_localMoney < selectedAction.Cost)
                    {
                        resultOfPurchase.Text = "Not enough money!";
                    }
                    else
                    {
                        resultOfPurchase.Text = "No copies left for this action.";
                    }
                };

                // Add the controls to the form
                this.Controls.Add(actionLabel);
                this.Controls.Add(remainingCopiesLabel);
                this.Controls.Add(buyButton);

                if (isLeftColumn)
                    yOffsetLeft += 30;
                else
                    yOffsetRight += 30;
            }
        }


        /// <summary>
        /// Adds a purchased action to the list of purchased actions and updates the UI with the purchase summary.
        /// </summary>
        /// <param name="action"> action to add for the purchased list</param>
        private void AddPurchasedActionToList(GameAction action)
        {
            if (_purchasedActions.ContainsKey(action))
            {
                _purchasedActions[action]++;
            }
            else
            {
                _purchasedActions.Add(action, 1);
            }

            int columnWidth = 30;
            int quantityWidth = 8;
            int rowIndex = 0;

            StringBuilder sbLeft = new StringBuilder();
            StringBuilder sbRight = new StringBuilder();

            string header = "Action Name".PadRight(columnWidth) + "Quantity".PadLeft(quantityWidth) + "\n" +
                            new string('-', columnWidth + quantityWidth) + "\n";

            sbLeft.Append(header);

            bool useRightColumn = _purchasedActions.Count > 5;
            if (useRightColumn)
            {
                sbRight.Append(header);
            }

            foreach (KeyValuePair<GameAction, int> entry in _purchasedActions)
            {
                string line = entry.Key.Name.PadRight(columnWidth) + entry.Value.ToString().PadLeft(quantityWidth) + "\n";

                if (rowIndex < 5)
                {
                    sbLeft.Append(line);
                }
                else
                {
                    sbRight.Append(line);
                }

                rowIndex++;
            }

            StringBuilder finalText = new StringBuilder();

            if (useRightColumn)
            {
                string[] leftLines = sbLeft.ToString().Split('\n');
                string[] rightLines = sbRight.ToString().Split('\n');
                int maxLines = Math.Max(leftLines.Length, rightLines.Length);

                for (int i = 0; i < maxLines; i++)
                {
                    string left = i < leftLines.Length ? leftLines[i].PadRight(columnWidth + quantityWidth + 5) : "".PadRight(columnWidth + quantityWidth + 5);
                    string right = i < rightLines.Length ? rightLines[i] : "";
                    finalText.AppendLine(left + right);
                }
            }
            else
            {
                finalText.Append(sbLeft);
            }

            purchasedActionLabel.Text = finalText.ToString();
        }



        /// <summary>
        /// Gets a list of all available actions that can be purchased in the game.
        /// </summary>
        /// <returns>A list of objects representing the available actions.</returns>
        public static List<GameAction> GetAvailableActions()
        {
            return new List<GameAction>
            {
                new RoomRepairAction(),
                new EminentVisitorAction(),
                new TeacherStrikeAction(),
                new StudentStrikeAction(),
                new HolidaysAction(),
                new RemedialCourseAction(),
                new RemoteClassAction(SkillType.Analyse),
                new RemoteClassAction(SkillType.Recognise),
                new RemoteClassAction(SkillType.Generate),
                new RemoteClassAction(SkillType.Communicate),
                new BudgetCutsAction(),
                new MassiveCorruptionAction(),
                new JuryLeniencyAction(),
                new SuddenReformAction()
            };
        }
        /// <summary>
        /// Initializes the remaining copies for each available action.
        /// </summary>
        private void InitializeRemainingCopies()
        {

            foreach (GameAction action in _availableActions)
            {
                if (!_remainingCopies.ContainsKey(action))
                {

                    int quantity = GetActionQuantity(action);
                    _remainingCopies.Add(action, quantity);
                }
            }
        }
        /// <summary>
        /// Gets the quantity of remaining copies for each specific action.
        /// </summary>
        /// <param name="action"> GameAction for which the quantity is being retrieved.</param>
        /// <returns>The number of remaining copies of the action.</returns>
        private int GetActionQuantity(GameAction action)
        {
            if (action is RoomRepairAction) return 3;
            if (action is EminentVisitorAction) return 3;
            if (action is TeacherStrikeAction) return 2;
            if (action is StudentStrikeAction) return 2;
            if (action is HolidaysAction) return 2;
            if (action is RemedialCourseAction) return 2;
            if (action is RemoteClassAction) return 1;
            if (action is BudgetCutsAction) return 1;
            if (action is MassiveCorruptionAction) return 1;
            if (action is JuryLeniencyAction) return 1;
            if (action is SuddenReformAction) return 1;


            return 0;
        }

        /// <summary>
        /// Event handler for the cancel button click. Reinitializes the window and closes it.
        /// </summary>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Reinitialise();
            this.Close();
        }

        /// <summary>
        /// Event handler for the form closing event. Ensures reinitialization if the dialog result is not OK.
        /// </summary>
        private void ActionsWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult != DialogResult.OK) Reinitialise();
        }

        /// <summary>
        /// Reinitializes the game state when the window is closed or canceled. Resets the remaining copies and purchased actions.
        /// </summary>
        private void Reinitialise()
        {
            this.DialogResult = DialogResult.Cancel;

            foreach (var action in _purchasedActions.Keys)
            {
                if (_remainingCopies.ContainsKey(action))
                {
                    _remainingCopies[action] += _purchasedActions[action];
                }
            }
            foreach (GameAction action in _remainingCopies.Keys)
            {
                if (_remainingCopiesLabels.ContainsKey(action))
                {
                    _remainingCopiesLabels[action].Text = "{" + _remainingCopies[action] + "}";
                }
            }

            _purchasedActions.Clear();
        }

        /// <summary>
        /// Event handler for the OK button click. Finalizes the purchase process and updates the game state.
        /// </summary>
        private void OkButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Game.RemoveMoney(Game.Money - _localMoney);
            this.Close();
        }

        /// <summary>
        /// Returns a list of all purchased actions.
        /// </summary>
        /// <returns>A list of objects that the user has purchased.</returns>
        public List<GameAction> GetPurchasedActions()
        {
            List<GameAction> actions = new List<GameAction>();

            foreach (GameAction action in _purchasedActions.Keys)
            {
                for (int i = 0; i < _purchasedActions[action]; i++)
                {
                    actions.Add(action);
                }
            }

            _purchasedActions.Clear();
            return actions;
        }
    }
}
