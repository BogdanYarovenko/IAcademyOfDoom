using IAcademyOfDoom.App;
using IAcademyOfDoom.Logic;
using IAcademyOfDoom.Logic.Actions;
using IAcademyOfDoom.Logic.GameSettings;
using IAcademyOfDoom.Logic.Mobiles;
using IAcademyOfDoom.Logic.Places;
using IAcademyOfDoom.Logic.Skills;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace IAcademyOfDoom.View
{
    /// <summary>
    /// The main window.
    /// </summary>
    public partial class MainWindow : Form
    {
        #region private attributes
        private Controller c = Controller.Instance;
        private readonly List<BotlingView> bots = new List<BotlingView>();

        private readonly List<RoomView> rooms = new List<RoomView>();
        private RoomView m_selectedRoom = null;
        private readonly List<PlaceableView> placeables = new List<PlaceableView>();
        private readonly List<ActionView> gameActions = new List<ActionView>();
        private PlaceableView m_placeableSelected = null;
        private ActionView m_actionSelected = null;
        private int m_selectIndexPlaceables = 0;
        private int m_selectIndexAction = 0;
        private BotlingView hoveredBotlingView;
        Magasin magasin = null;
        ActionsWindow actMagasin = null;
        private System.Windows.Forms.Timer assaultTimer;
        private bool isAutoMode = false;


        #endregion
        #region constructor
        /// <summary>
        /// Empty constructor.
        /// </summary>
        public MainWindow()
        {
            Difficulty? difficulty = null;
            string name = null;
            DifficultySelect select = new DifficultySelect();
            if (select.ShowDialog() == DialogResult.OK)
            {
                name = select.InputName;
                difficulty = select.Difficulty;
            }
            InitializeComponent();
            InitializeTimer();
            c.Associate(this, name, difficulty);
            if (c.Name != null)
            {
                playerNameLabel.Text = c.Name + "'s game";
                playerNameLabel.Visible = true;
            }
            else
            {
                playerNameLabel.Visible = false;
            }
            SyncRooms();
        }

        public void InitializeTimer()
        {
            assaultTimer = new System.Windows.Forms.Timer();
            assaultTimer.Interval = 150;
            assaultTimer.Tick += AssaultTimer_Clock;
        }
        #endregion
        #region event handling methods
        /// <summary>
        /// Event handling: Paint
        /// </summary>
        /// <param name="sender">ignored</param>
        /// <param name="e">used to get the graphic context</param>
        private void MainWindow_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.Gray, Settings.PlaceableObjetsSquareArea);
            e.Graphics.DrawString("Placeables", Settings.TitleFont, Brushes.Black,
                new PointF(Settings.PlaceableObjetsSquareArea.X + 70, Settings.PlaceableObjetsSquareArea.Y - 20));
            e.Graphics.DrawRectangle(Pens.Gray, Settings.ActionsObjectsSquareArea);
            e.Graphics.DrawString("Available actions", Settings.TitleFont, Brushes.Black,
               new PointF(Settings.ActionsObjectsSquareArea.X + 50, Settings.ActionsObjectsSquareArea.Y - 20));
 
            numberOfBotlingsContentLabel.Text = bots.Count.ToString();
            numberOfCoins.Text = "Your balance is : " + Game.Money.ToString() + " €";
            BackgroundGrid(e.Graphics);

            foreach (RoomView room in rooms)
            {
                room.Draw(e.Graphics);
            }
            foreach (BotlingView bot in bots)
            {
                bot.Draw(e.Graphics);
            }
            foreach (PlaceableView placeable in placeables)
            {
                placeable.Draw(e.Graphics);
            }
            foreach (ActionView action in gameActions)
            {
                action.Draw(e.Graphics);
            }
            if (hoveredBotlingView != null)
            {
                DrawDirectionHint(e.Graphics, hoveredBotlingView);
            }
        }

        /// <summary>
        /// Draws an moving direction arrow of selected BotlingView that is hovered
        /// </summary>
        /// <param name="graphics">graphics where to draw</param>
        /// <param name="botlingView">botlingView to draw arrow onto</param>
        private void DrawDirectionHint(Graphics graphics, BotlingView botlingView)
        {
            if (!botlingView.IsHovered)
                return;

            int prevX = botlingView.Botling.X;
            int prevY = botlingView.Botling.Y;
            (int x, int y) positionNext = botlingView.Botling.NextMove;

            if (!(positionNext != (0, 0) && (positionNext.x != prevX || positionNext.y != prevY)))
                return;

            Point startPoint = botlingView.Center;
            int arrowLength = 20;
            Point vector = new Point(positionNext.x - prevX, positionNext.y - prevY);
            double length = Math.Sqrt(vector.X * vector.X + vector.Y * vector.Y);
            Point normalized = new Point((int)(vector.X / length), (int)(vector.Y / length));
            Point endPoint = new Point(
                (int)(startPoint.X + normalized.X * arrowLength),
                (int)(startPoint.Y + normalized.Y * arrowLength)
            );
            Point arrowPosition = new Point((int)((endPoint.X - startPoint.X) * 0.7) + startPoint.X, (int)((endPoint.Y - startPoint.Y) * 0.7) + startPoint.Y);

            Pen arrowPen = new Pen(Color.Red, 2);
            graphics.DrawLine(arrowPen, startPoint, endPoint);
            const int arrowHeadSize = 5;
            Point arrowHead1 = new Point(
                (int)(arrowPosition.X + arrowHeadSize * (-normalized.Y)),
                (int)(arrowPosition.Y + arrowHeadSize * normalized.X)
            );
            Point arrowHead2 = new Point(
                (int)(arrowPosition.X + arrowHeadSize * normalized.Y),
                (int)(arrowPosition.Y + arrowHeadSize * (-normalized.X))
            );
            graphics.DrawLine(arrowPen, endPoint, arrowHead1);
            graphics.DrawLine(arrowPen, endPoint, arrowHead2);
        }

        /// <summary>
        /// End preparation button click event
        /// </summary>
        /// <param name="sender">ignored</param>
        /// <param name="e">ignored</param>
        private void EndPrepButton_Click(object sender, EventArgs e)
        {
            if (c.CanEndPreparations())
            {
                c.EndPreparations();
            }
            else
            {
                MessageBox.Show("Preparations are not complete yet.");
                WriteLine("Preparations are not complete yet.");
            }
        }

        /// <summary>
        /// Event handling: click on quit button.
        /// </summary>
        /// <param name="sender">ignored</param>
        /// <param name="e">ignored</param>
        private void QuitButton_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        /// <summary>
        /// Event handling: Mouse button down
        /// </summary>
        /// <param name="sender">ignored</param>
        /// <param name="e">used for pointer location and mouse button id</param>
        private void MainWindow_MouseDown(object sender, MouseEventArgs e)
        {
            (int x, int y) = PointCoordinates(e.Location);
            if (e.Button == MouseButtons.Left && endPrepButton.Enabled)
            {
                m_selectedRoom = RoomHere(e.Location);
                if (m_selectedRoom != null && m_selectedRoom.Room.Type == RoomType.Cycle)
                    m_selectedRoom = null;

                if (m_selectedRoom == null && m_placeableSelected == null && placeables.Count > 0)
                {
                    m_selectIndexPlaceables = 0;
                    m_PlaceRoom(e.Location);
                }

                if (selectPlaceableView(e.Location))
                {
                    
                }
            }
            if (e.Button == MouseButtons.Right)
            {
                RoomView roomHit = RoomHere(e.Location);
                if (roomHit != null)
                {
                    DisplayStateOf(roomHit, true);
                    return;
                }

                Botling target = BotlingHere(e.Location);
                if (target != null)
                {
                    DisplayStateOf(target, true);
                    return;
                }
            }

            if (!endPrepButton.Enabled)
            {
                if (selectActionView(e.Location))
                {
                    GameAction action = m_actionSelected.Action;
                    if (action.Type == ActionType.RoomRepair || action.Type == ActionType.RemedialCourse)
                    {
                        
                    }
                    else
                    {
                        action.actionOnBotlings();
                        action.actionOnRooms();

                        if (action.Type == ActionType.SuddenReform)
                        {
                            foreach (RoomView roomView in rooms)
                            {
                                roomView.refresh();
                            }
                        }

                        c.RemoveAction(action);
                        MessageBox.Show(action.GetActionEffectMessage());
                        PreviewActionItems(c.GameActions());
                        m_actionSelected = null;
                    }

                }
            }

            Refresh();
        }
        /// <summary>
        /// Method to handles the MouseUp event for the main window, finalizing actions initiated by MouseDown.
        /// </summary>
        /// <param name="sender">Object that raised the event</param>
        /// <param name="e">Mouse event</param>

        private void MainWindow_MouseUp(object sender, MouseEventArgs e)
        {
            if (m_placeableSelected != null)
            {
                bool isPlaced = m_PlaceRoom(e.Location);
                if (!isPlaced)
                {
                    PreviewPlaceableItems(c.Placeables());
                }
            }
            else if (m_selectedRoom != null)
            {
                (int x, int y) = PointCoordinates(e.Location);
                m_selectedRoom.refresh();
                if (Settings.PlaceableObjetsSquareArea.Contains(e.Location))
                {
                    SkillType? skill = null;
                    if (m_selectedRoom.Room.Type == RoomType.Prof)
                    {
                        skill = ((ProfRoom)m_selectedRoom.Room).SkillType;
                    }
                    else if (m_selectedRoom.Room.Type == RoomType.Facility && m_selectedRoom.Room.Name.Equals("TutorRoom"))
                    {
                        skill = ((RoomTutor)m_selectedRoom.Room).SkillType;
                    }

                    c.AddPlaceable(new Placeable(m_selectedRoom.Room.Type, skill, m_selectedRoom.Room.Name));

                    c.DestroyRoom(m_selectedRoom.Room);
                    PreviewPlaceableItems(c.Placeables());
                }
                else if (RoomHere(e.Location) == null && !(x, y).Equals((-1, -1)))
                {
                    m_selectedRoom.Room.moveTo(x, y);
                    m_selectedRoom.refresh();
                }
            }
            else if (m_actionSelected != null)
            {
                RoomView roomHit = RoomHere(e.Location);
                if (roomHit != null)
                {
                    m_actionSelected.Action.actionOnRoom(roomHit.Room);
                    c.RemoveAction(m_actionSelected.Action);
                }

                PreviewActionItems(c.GameActions());
            }

            m_selectedRoom = null;
            m_actionSelected = null;
            m_placeableSelected = null;
            m_selectIndexPlaceables = 0;
            Refresh();
        }

        /// <summary>
        /// Method to handles the MouseMove event for the main window.
        /// Updates the position of visual elements.
        /// Also handles the drag of room via MouseDown.
        /// </summary>
        /// <param name="sender">The main window</param>
        /// <param name="e">Mouse event</param>
        private void MainWindow_MouseMove(object sender, MouseEventArgs e)
        {
            if (m_placeableSelected != null)
            {
                m_placeableSelected.Location = Utils.getCenteredPosition(e.Location, Settings.PlaceableSquare);
            }
            else if (m_actionSelected != null)
            {
                m_actionSelected.Location = Utils.getCenteredPosition(e.Location, Settings.PlaceableSquare);
            }

            if (m_selectedRoom != null)
            {
                m_selectedRoom.Location = Utils.getCenteredPosition(e.Location, new Size(Settings.Width, Settings.Height));
            }
            foreach (BotlingView bot in bots)
            {
                if (bot.Contains(e.Location))
                {
                    bot.IsHovered = true;
                    hoveredBotlingView = bot;

                }
                else
                {
                    bot.IsHovered = false;
                }

            }
            Refresh();
        }

        #endregion
        #region public methods
        /// <summary>
        /// Method called by the controller to set the window to assault mode.
        /// </summary>
        public void SetToAssault()
        {
            endPrepButton.Enabled = false;
            nextInAssaultButton.Enabled = true;
            autoButton.Enabled = true;
           
            WriteLine("Assault!");
        }
        /// <summary>
        /// Method called by the controller to update the display in asault mode.
        /// </summary>
        public void AssaultUpdate()
        {
            if (nextInAssaultButton.Enabled)
            {
                WriteLine("Assault continuation!");
            }
        }
        /// <summary>
        /// Method called by the controller to set the window to results mode.
        /// </summary>
        /// <param name="results">the results of the previous wave, as a pair</param>        
        public void DisplayResults((int successes, int failures, int tired) results)
        {
            assaultTimer.Stop();
            c.GetLastResults();
            WriteLine($"Assault ended! {results.successes} successes, {results.failures} failures and  {results.tired} are tired");
            endPrepButton.Enabled = true;
            nextInAssaultButton.Enabled = false;
            autoButton.Enabled = false;
        
           // gameActions.Clear();
            Game.AddMoney(results.successes);
            Refresh();
            c.NextWave();
        }

        private void showResultsButton_Click(object sender, EventArgs e)
        {
            if (endPrepButton.Enabled)
            {
                MessageBox.Show("Assault do not started yet");
            }
            else { c.GetLastResults(); }


        }
        /// <summary>
        /// Method called by the controller to update the botling mobiles.
        /// </summary>
        /// <param name="botlings"></param>
        public void UpdateBots(List<Botling> botlings)
        {
            Dictionary<(int x, int y), List<Botling>> newBotlingsByRoom = new Dictionary<(int x, int y), List<Botling>>();
            Dictionary<(int x, int y), List<Botling>> oldBotlingsByRoom = new Dictionary<(int x, int y), List<Botling>>();
            foreach (Botling botling in botlings)
            {
                bool add = true;
                int i = 0;
                while (i < bots.Count && add)
                {
                    if (bots[i].Botling.Equals(botling))
                    {
                        add = false;
                    }
                    else
                    {
                        i++;
                    }
                }
                if (add)
                {
                    PutBotlingInListByRoom(newBotlingsByRoom, botling);
                    WriteLine(botling.Name + ": New botling at:" + (botling.X, botling.Y));
                }
                else
                {
                    PutBotlingInListByRoom(oldBotlingsByRoom, botling);
                    WriteLine(botling.Name + ": Botling move to:" + (botling.X, botling.Y));
                }
            }
            foreach ((int x, int y) in newBotlingsByRoom.Keys)
            {
                int deltaX = 0, deltaY = 0;
                foreach (Botling botling in newBotlingsByRoom[(x, y)])
                {
                    Point point = ConvertCoordinates(x, y);
                    bots.Add(new BotlingView(new Point(point.X + deltaX, point.Y + deltaY), botling));
                    deltaX += Settings.BotlingSize.Width * 2;
                    if (deltaX > Settings.Width - Settings.BotlingSize.Width)
                    {
                        deltaX = 0;
                        deltaY += Settings.BotlingSize.Height * 2;
                    }
                }
            }
            foreach ((int x, int y) in oldBotlingsByRoom.Keys)
            {
                int deltaX = 0, deltaY = 0;
                foreach (Botling botling in oldBotlingsByRoom[(x, y)])
                {
                    BotlingView view = null;
                    int i = 0;
                    while (i < bots.Count && view == null)
                    {
                        if (bots[i].Botling.Equals(botling))
                        {
                            view = bots[i];
                        }
                        else
                        {
                            i++;
                        }
                    }
                    if (view != null)
                    {
                        (int baseX, int baseY) = ConvertCoordinates(view.Location);
                        Point newLoc = ConvertCoordinates(x, y);
                        Point arrival = new Point(newLoc.X + (baseX + deltaX) % Settings.Width, newLoc.Y + (baseY + deltaY) % Settings.Width);
                        view.Location = arrival;
                        deltaX += Settings.BotlingSize.Width * 2;
                        if (baseX + deltaX > Settings.Width - Settings.BotlingSize.Width)
                        {
                            deltaX = 0;
                            deltaY += Settings.BotlingSize.Height * 2;
                        }
                    }
                }
            }
            Refresh();
        }
        /// <summary>
        /// Writes to the output list box.
        /// </summary>
        /// <param name="s">the string to be written</param>
        public void WriteLine(string s)
        {
            List<string> strs = s.Split('\n').ToList();
            foreach (string str in strs)
            {
                outputListBox.Items.Add(str);
            }
            if (outputListBox.Items.Count > 0)
            {
                outputListBox.SelectedIndex = outputListBox.Items.Count - 1;
            }
            outputListBox.Refresh();
        }
        /// <summary>
        /// Converts a logical pair of coordinates to a graphic point.
        /// </summary>
        /// <param name="x">the column id</param>
        /// <param name="y">the row id</param>
        /// <returns>the top left corner of the graphical cell or a problematic point if outside of the range</returns>
        public static Point ConvertCoordinates(int x, int y)
        {
            return new Point(Settings.Left + x * Settings.Width, Settings.Top + y * Settings.Height);
        }
        /// <summary>
        /// Converts a point to the offset from the top-left corner of its cell.
        /// </summary>
        /// <param name="point">the point</param>
        /// <returns>a pair of offset coordinates, in pixels</returns>
        public static (int x, int y) ConvertCoordinates(Point point)
        {
            return ((point.X - Settings.Left) % Settings.Width, (point.Y - Settings.Top) % Settings.Height);
        }
        /// <summary>
        /// Method called by the controller to remove some botlings.
        /// </summary>
        /// <param name="removed">a list of logical botlings to remove</param>
        public void RemoveBots(List<Botling> removed)
        {
            List<BotlingView> views = new List<BotlingView>();
            foreach (Botling bot in removed)
            {
                foreach (BotlingView view in bots)
                {
                    if (view.Botling.Equals(bot))
                    {
                        views.Add(view);
                    }
                }
            }
            foreach (BotlingView view in views)
            {
                bots.Remove(view);
            }
        }
        /// <summary>
        /// Method called by the controller to update the placeable items.
        /// </summary>
        /// <param name="placeables">the current list of placeables</param>
        public void PreviewPlaceableItems(List<Placeable> placeables)
        {
            this.placeables.Clear();
            if (placeables.Count == 0)
            {
                WriteLine("All items placed !");
                return;
            }

            string items = "";
            int x = Settings.PlaceableLeft;
            int y = Settings.PlaceableTop;

            int i = 0;
            foreach (Placeable placeable in placeables)
            {
                items += " " + placeable.ToString();
                PlaceableView newPlaceableView = new PlaceableView(placeable, new Point(x, y));

                this.placeables.Add(newPlaceableView);

                y += Settings.PlaceableOffset;
                i++;
            }
            WriteLine("Preparations: please place the following...");
            WriteLine("Items:" + items);
            Refresh();
        }
        /// <summary>
        /// Method to display the list of action available.
        /// </summary>
        /// <param name="actions">The current list of action</param>
        public void PreviewActionItems(List<GameAction> actions)
        {
            this.gameActions.Clear();
            if (actions.Count == 0)
            {
                WriteLine("All items placed !");
                return;
            }

            string items = "";
            int x = Settings.ActionLeft;
            int y = Settings.ActionTop;

            int i = 0;
            foreach (GameAction action in actions)
            {
                items += " " + action.ToString();
                ActionView newActionView = new ActionView(action, new Point(x, y));
                this.gameActions.Add(newActionView);
                y += Settings.ActionsOffset;
                i++;
            }
            WriteLine("Preparations: please place the following...");
            WriteLine("Items:" + items);
            Refresh();
        }
        /// <summary>
        /// Method displaying the current status of a logical botling mobile.
        /// </summary>
        /// <param name="botling">the logical botling</param>
        public void DisplayStateOf(Botling botling, bool isMessageBox = false)
        {
            string name = botling.Name;
            string hp = botling.HP.ToString() + " HP";
            string skills = "Skills: ";
            string type = botling.Type.ToString();
            foreach (SkillType skill in botling.Skills.Keys)
            {
                skills += "[ " + skill.ToString() + " ]" + " =" + botling.Skills[skill] + " ";
            }
            string badges = "Badges:";
            foreach (SkillType skill in botling.Badges.Keys)
            {
                if (botling.Badges[skill])
                {
                    badges += "[" + skill.ToString() + "] ";
                }
            }
            if (badges.EndsWith(":"))
            {
                badges += " none";
            }

            if (isMessageBox)
            {
                MessageBox.Show(
                    $"Botling: {name}\n\n" +
                    $"* Type: {type}\n" +
                    $"* Coordonates: {{ {botling.X} , {botling.Y} }}\n" +
                    $"* HP: {hp}\n" +
                    $"* Skills: {skills}\n" +
                    $"* Badges: {badges}");
            }
            else
            {
                WriteLine("Botling " + name + ": " + hp);
                WriteLine("  " + skills);
                WriteLine("  " + badges);
            }
        }
        /// <summary>
        /// Method displaying the current status of a Room.
        /// </summary>
        /// <param name="roomView">The selected room</param>
        public void DisplayStateOf(RoomView roomView, bool isMessageBox = false)
        {
            if (isMessageBox)
            {

                string skillText = "";

                if (roomView.Room?.Type == RoomType.Prof && roomView.Room is ProfRoom profRoom)
                {

                    skillText = $"* Skill Type: {profRoom.SkillType}\n";
                }

                MessageBox.Show(
                    $"Room Label: {roomView.Label}\n\n" +
                    $"* Room HP : {roomView.Room.HP}\n" +
                    $"* Room Name: {roomView.Room?.Name}\n" +
                    $"* Room Type: {roomView.Room?.Type.ToString()}\n" +
                    $"* Coordinates: {roomView.Room?.X} , {roomView.Room?.Y}\n" +
                    skillText
                );
            }
            else
            {
                WriteLine(roomView.Label);
                Room room = roomView.Room;
                if (room != null)
                {
                    WriteLine(room.Name);
                    WriteLine(room.Type.ToString());
                    WriteLine(room.X + " " + room.Y);
                }
            }
        }
        /// <summary>
        /// Method called by the controller when the game is over.
        /// </summary>
        public void GameOver()
        {
            WriteLine("Game over.");
            nextInAssaultButton.Enabled = false;
            endPrepButton.Enabled = false;
            quitButton.Enabled = true;
            quitButton.Visible = true;
        }
        #endregion
        #region private mehods

        /// <summary>
        /// Checks and returns the botling at precise position
        /// </summary>
        /// <param name="location">a position to check</param>
        /// <returns>a botling at selected position, else null</returns>
        private Botling BotlingHere(Point location)
        {
            int i = 0;
            int index = -1;
            while (index == -1 && i < bots.Count)
            {
                if (bots[i].Contains(location))
                {
                    index = i;
                }
                else
                {
                    i++;
                }
            }
            if (index == -1)
            {
                return null;
            }
            else
            {
                return bots[index].Botling;
            }
        }

        /// <summary>
        /// Method to transform the current position of the cursor to a grid coordinates.
        /// </summary>
        /// <param name="point">The cursor position</param>
        /// <returns>A tuple of the grid coordinates. Returns (-1, -1) if the point is outside the grid</returns>
        private (int x, int y) PointCoordinates(Point point)
        {
            int posX = point.X;
            int posY = point.Y;
            if (posX >= Settings.Left && posY >= Settings.Top &&
                posX < Settings.Width * Settings.Cols + Settings.Left &&
                posY < Settings.Height * Settings.Rows + Settings.Top)
            {
                return ((posX - Settings.Left) / Settings.Width, (posY - Settings.Top) / Settings.Height);
            }
            else
            {
                return (-1, -1);
            }
        }

        /// <summary>
        /// Method to update the room representation obtained via the controller.
        /// </summary>
        public void SyncRooms()
        {
            HashSet<Room> currentRooms = new HashSet<Room>(c.Rooms());
            rooms.RemoveAll(rv => !currentRooms.Contains(rv.Room));
            HashSet<Room> existingRooms = new HashSet<Room>(rooms.Select(rv => rv.Room));
            foreach (Room room in currentRooms)
            {
                if (!existingRooms.Contains(room))
                {
                    rooms.Add(RoomView.CreateFromRoom(room));
                }
            }
        }

        /// <summary>
        /// Method to place the currently selected Placeable item.
        /// </summary>
        /// <param name="pos">The cursor position</param>
        /// <returns>True if the room was successfully placed</returns>
        private bool m_PlaceRoom(Point pos)
        {
            (int x, int y) = PointCoordinates(pos);
            if (RoomHere(pos) == null && !(x, y).Equals((-1, -1)))
            {
                Placeable placeable = c.Placeables()[m_selectIndexPlaceables];
                c.PlaceHere(x, y, placeable);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Metho to draw the background grid onto the specified graphic.
        /// </summary>
        /// <param name="graphics">Where to draw the grid</param>

        private static void BackgroundGrid(Graphics graphics)
        {
            for (int i = 0; i < Settings.Cols; i++)
            {
                for (int j = 0; j < Settings.Rows; j++)
                {
                    Rectangle r = new Rectangle(ConvertCoordinates(i, j), new Size(Settings.Width, Settings.Height));
                    graphics.DrawRectangle(Settings.Pen, r);
                }
            }
        }

        /// <summary>
        /// Method to find and returns the RoomView located at the position of the cursor.
        /// </summary>
        /// <param name="location">The cursor position</param>
        /// <returns>The RoomView found at the specified location</returns>
        private RoomView RoomHere(Point location)
        {
            int i = 0;
            int index = -1;
            while (index == -1 && i < rooms.Count)
            {
                if (rooms[i].Contains(location) && !(m_selectedRoom != null && !m_selectedRoom.Equals(m_selectedRoom)))
                {
                    index = i;
                }
                else
                {
                    i++;
                }
            }
            if (index == -1)
            {
                return null;
            }
            else
            {
                return rooms[index];
            }
        }

        /// <summary>
        /// Method to check if there is a Placeable, define the index of the room.
        /// </summary>
        /// <param name="p">The cursor position</param>
        /// <returns>True if a room was selected at the given point</returns>
        private bool selectPlaceableView(Point p)
        {
            int indexPlaceable = 0;
            foreach (PlaceableView placeable in placeables)
            {
                if (placeable.OnSquare(p))
                {
                    m_placeableSelected = placeable;
                    m_selectIndexPlaceables = indexPlaceable;
                    return true;
                }
                indexPlaceable++;
            }

            return false;
        }

        /// <summary>
        /// Method to check if a given point (mouse click) is on the clickable area.
        /// Select an action from a selected position.
        /// </summary>
        /// <param name="p">The cursor position</param>
        /// <returns>True if an action was selected at the given point</returns>
        private bool selectActionView(Point p)
        {
            int index = 0;
            foreach (ActionView action in gameActions)
            {
                if (action.OnSquare(p))
                {
                    m_actionSelected = action;
                    m_selectIndexAction = index;
                    return true;
                }
                index++;
            }

            return false;
        }

        /// <summary>
        /// Method to add the botling to a dictionary grouped by their coordinates.
        /// </summary>
        /// <param name="list">The dictionary with two int x,y</param>
        /// <param name="botling">The botling to add</param>
        private void PutBotlingInListByRoom(Dictionary<(int x, int y), List<Botling>> list, Botling botling)
        {
            if (!list.ContainsKey((botling.X, botling.Y)))
            {
                list.Add((botling.X, botling.Y), new List<Botling>());
            }
            list[(botling.X, botling.Y)].Add(botling);
        }

        #endregion

        /// <summary>
        /// Method to check display the Magasin form when clicked.
        /// If items are purchased (DialogResult.OK), retrieves the purchased Room items.
        /// </summary>
        /// <param name="sender">The button</param>
        /// <param name="e">ignored</param>
        private void MagasinDesign_Click(object sender, EventArgs e)
        {
            if (magasin == null)
            {
                magasin = new Magasin();
            }

            if (magasin.ShowDialog() == DialogResult.OK)
            {
                List<Placeable> placeables = magasin.GetPurchasedPlaceables();
                foreach (Placeable placeable in placeables)
                {
                    c.AddPlaceable(placeable);
                }
                PreviewPlaceableItems(c.Placeables());
            }
        }

        /// <summary>
        /// Method to display the Action form when clicked.
        /// If action are purchased (DialogResult.OK), retrieves the purchased Action items.
        /// </summary>
        /// <param name="sender">The button</param>
        /// <param name="e">ignored</param>
        private void ActionsMagasin_Click(object sender, EventArgs e)
        {
            
                if (actMagasin == null)
                {
                    actMagasin = new ActionsWindow();
                }
                if (actMagasin.ShowDialog() == DialogResult.OK)
                {
                    List<GameAction> actions = actMagasin.GetPurchasedActions();
                    foreach (GameAction action in actions)
                    {
                        c.AddAction(action);
                    }
                    PreviewActionItems(c.GameActions());
                }
        }

        /// <summary>
        ///  It toggles visibility hides or shows.
        /// </summary>
        /// <param name="sender">The button</param>
        /// <param name="e">ignored</param>
        private void OutputButton_Click(object sender, EventArgs e)
        {
            outputListBox.Visible = !outputListBox.Visible;
            if (outputListBox.Visible)
            {
                outputButton.Text = "Hide output";
            }
            else
            {
                outputButton.Text = "Show output";
            }
        }
        
        /// <summary>
        /// Handle the tick of the assault timer.
        /// Also handle the AutoGames mode.
        /// </summary>
        /// <param name="sender">The timer</param>
        /// <param name="e">ignored</param>
        private void AssaultTimer_Clock(object sender, EventArgs e)
        {
            if (nextInAssaultButton.Enabled && !endPrepButton.Enabled)
            {
                c.NextInAssault();
            }
            else
            {
                assaultTimer.Stop();
            }

            // AutoGame
            if ((nextInAssaultButton.Enabled && !endPrepButton.Enabled) && isAutoMode)
            {
                c.NextInAssault();
            }
            else
            {
                assaultTimer.Stop();
                isAutoMode = false;
                autoButton.Text = "Start Auto";
            }
        }
        
        /// <summary>
        /// Handle the MouseDown NextAssaultButton.
        /// Handle the starts continuous assault.
        /// </summary>
        /// <param name="sender">The button</param>
        /// <param name="e">ignored</param>
        private void NextInAssaultButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && nextInAssaultButton.Enabled)
            {
                c.NextInAssault();
                assaultTimer.Start();
            }
        }

        /// <summary>
        /// Handle the MouseUp NextAssaultButton.
        /// Handle the stop continuous assault.
        /// </summary>
        /// <param name="sender">The button</param>
        /// <param name="e">ignored</param>
        private void NextInAssaultButton_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                assaultTimer.Stop();
            }
        }

        /// <summary>
        ///Handles the Click event for the 'AutoGame' button (autoButton).
        /// Toggles the AutoGame mode state (enabled/disabled).
        /// </summary>
        /// <param name="sender">The button</param>
        /// <param name="e">ignored</param>
        private void AutoButton_Click(object sender, EventArgs e)
        {
            isAutoMode = !isAutoMode; 

            if (isAutoMode && nextInAssaultButton.Enabled && !endPrepButton.Enabled)
            {
                c.NextInAssault();
                assaultTimer.Start();
                autoButton.Text = "Stop Auto"; 
            }
            else
            {
                assaultTimer.Stop();
                autoButton.Text = "Start Auto"; 
            }

        }
    }
}