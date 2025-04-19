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
            this.Paint += ActionsWindow_Paint;
        }

        private void ActionsWindow_Load(object sender, EventArgs e)
        {
            _localMoney = Game.Money;
            BalanceInMagasin.Text = "Your balance is : " + _localMoney.ToString() + " €";
            purchasedActionLabel.Text = "";
            resultOfPurchase.Text = "";
            _availableActions = GetAvailableActions();
            InitializeRemainingCopies();
            InitActionsUI();
        }

        private void ActionsWindow_Paint(object sender, PaintEventArgs e)
        {
        }

        private void InitActionsUI()
        {
            int yOffset = 40;

            foreach (var action in _availableActions)
            {
                Label actionLabel = new Label
                {
                    Text = action.ToString(),
                    Location = new Point(20, yOffset),
                    Size = new Size(200, 20),
                    Font = new Font("Microsoft Tai Le", 9.75f, FontStyle.Bold),
                    BackColor = Color.Transparent
                };


                Label remainingCopiesLabel = new Label
                {
                    Text = "{" + _remainingCopies[action] + "}",
                    Location = new Point(250, yOffset),
                    Size = new Size(50, 20),
                    Font = new Font("Microsoft Tai Le", 9.75f, FontStyle.Bold),
                    BackColor = Color.Transparent
                };
                _remainingCopiesLabels[action] = remainingCopiesLabel;

                Button buyButton = new Button
                {
                    Text = "Buy",
                    Location = new Point(300, yOffset),
                    Size = new Size(60, 20),
                    Font = new Font("Microsoft Tai Le", 9.75f, FontStyle.Bold),
                    Tag = action
                };

                buyButton.Click += (s, e) =>
                {
                    GameAction selectedAction = (GameAction)((Button)s).Tag;

                    if (selectedAction is RemoteClassAction)
                    {
                        ComboBox skillChooser = new ComboBox
                        {
                            Location = new Point(370, buyButton.Location.Y),
                            Size = new Size(140, 20),
                            DropDownStyle = ComboBoxStyle.DropDownList
                        };

                        SkillType[] skills = new SkillType[]
                        {
                            SkillType.Analyse,
                            SkillType.Recognise,
                            SkillType.Generate,
                            SkillType.Communicate
                        };

                        foreach (var skill in skills) skillChooser.Items.Add(skill.ToString());

                        this.Controls.Add(skillChooser);
                        skillChooser.BringToFront();

                        skillChooser.SelectedIndexChanged += (senderCombo, ev) =>
                        {
                            if (skillChooser.SelectedItem != null)
                            {
                                SkillType chosenSkill = (SkillType)Enum.Parse(typeof(SkillType), skillChooser.SelectedItem.ToString());

                                // Prevent duplicate purchase for the same skill
                                bool alreadyBought = _purchasedActions.Keys
                                    .OfType<RemoteClassAction>()
                                    .Any(a => a.skillName == chosenSkill);

                                if (alreadyBought)
                                {
                                    resultOfPurchase.Text = $"You already purchased Remote Class for {chosenSkill}!";
                                    this.Controls.Remove(skillChooser);
                                    return;
                                }

                                GameAction customRemoteClass = new RemoteClassAction(chosenSkill);

                            if (_remainingCopies[selectedAction] > 0 && _localMoney >= customRemoteClass.Cost)
                                {
                                    _remainingCopies[selectedAction]--;
                                    _localMoney -= customRemoteClass.Cost;
                                    BalanceInMagasin.Text = "Your balance is : " + _localMoney + " €";

                                    _remainingCopiesLabels[selectedAction].Text = "{" + _remainingCopies[selectedAction] + "}";

                                    AddPurchasedActionToList(customRemoteClass);
                                    resultOfPurchase.Text = "Purchase successful";

                                    this.Controls.Remove(skillChooser);
                                }
                            else
                                {
                                    resultOfPurchase.Text = "Not enough money or no copies left.";
                                    this.Controls.Remove(skillChooser);
                                }
                            }
                        };
                    }
                    else
                    {
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
                    }
                };

                this.Controls.Add(actionLabel);
                this.Controls.Add(remainingCopiesLabel);
                this.Controls.Add(buyButton);

                yOffset += 30;
            }
        }


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

            StringBuilder sb = new StringBuilder();
            int columnWidth = 30;

            sb.Append("Action Name".PadRight(columnWidth)).Append("Quantity").Append("\n");
            sb.Append(new string('-', columnWidth + 20)).Append("\n");

            foreach (var entry in _purchasedActions)
            {
                sb.Append(entry.Key.Name.PadRight(columnWidth))
                  .Append(entry.Value.ToString())
                  .Append("\n");
            }

            purchasedActionLabel.Text = sb.ToString();
        }

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
                new BudgetCutsAction(),
                new MassiveCorruptionAction(),
                new JuryLeniencyAction(),
                new SuddenReformAction()
            };
        }

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

        private int GetActionQuantity(GameAction action)
        {
            if (action is RoomRepairAction) return 3;
            if (action is EminentVisitorAction) return 3;
            if (action is TeacherStrikeAction) return 2;
            if (action is StudentStrikeAction) return 2;
            if (action is HolidaysAction) return 2;
            if (action is RemedialCourseAction) return 2;
            if (action is RemoteClassAction) return 4;
            if (action is BudgetCutsAction) return 1;
            if (action is MassiveCorruptionAction) return 1;
            if (action is JuryLeniencyAction) return 1;
            if (action is SuddenReformAction) return 1;


            return 0;
        }


        private void cancelButton_Click(object sender, EventArgs e)
        {
            reinitialise();
            this.Close();
        }

        private void ActionsWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult != DialogResult.OK) reinitialise();
        }

        private void reinitialise()
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

        private void okButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Game.RemoveMoney(Game.Money - _localMoney);
            this.Close();
        }

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
