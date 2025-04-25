using IAcademyOfDoom.Logic.Mobiles;
using IAcademyOfDoom.Logic.Places;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace IAcademyOfDoom.View
{
    /// <summary>
    /// This non-instanciated class contains the settings for the graphics display.
    /// </summary>
    public static class Settings
    {
        public static int Cols { get; } = 6;
        public static int Rows { get; } = 5;
        public static int Width { get; } = 80;
        public static int Height { get; } = 70;
        public static int Left { get; } = 40;
        public static int Top { get; } = 100;
        public static Pen Pen { get; } = Pens.Black;
        public static Size BotlingSize { get; } = new Size(10, 10);
        public static Size TextOffset { get; } = new Size(8, Height/2);
        public static Brush TextBrush { get; } = Brushes.Black;
        public static Brush ActionBrush { get; } = Brushes.Black;
        public static Font RoomFont { get; } = SystemFonts.IconTitleFont;
        public static Font ActionFont { get; } = SystemFonts.IconTitleFont;


        public static int HP_Room {  get; } = 5;
        public static Font TitleFont { get; } = new Font("Arial", 12, FontStyle.Bold);
        public static int PlaceableLeft = Left + Width * Cols + 50;
        public static int PlaceableTop = Top + 5;
        public static int ActionLeft = PlaceableLeft + 230 + 20;
        public static int ActionTop = PlaceableTop;
        public static Size ObjectsBoxSize = new Size(230, 350);

        public static readonly Rectangle PlaceableObjetsSquareArea =
                new Rectangle(x: PlaceableLeft - 5, y: PlaceableTop - 5,  
                            width: ObjectsBoxSize.Width, height: ObjectsBoxSize.Height);

        public static readonly Rectangle ActionsObjectsSquareArea =
                new Rectangle(x: ActionLeft - 5, y: ActionTop - 5, 
                            width: ObjectsBoxSize.Width, height: ObjectsBoxSize.Height);

        public static readonly Rectangle ActionsMagasin =
                new Rectangle(x: 100, y: ActionTop - 5,
                            width: ObjectsBoxSize.Width, height: ObjectsBoxSize.Height);

        public static Size PlaceableSquare { get; } = new Size(10, 10);
        public static Size ActionSquare { get; } = new Size(10,10);
        public static Brush PlaceableSquareBrush { get; } = Brushes.Firebrick;
        public static Brush ActionsSquareBrush { get; } = Brushes.Firebrick;

        public static int PlaceableOffset { get; } = 20;
        public static int ActionsOffset { get; } = 20;

        /// <summary>
        /// Color for each type of room
        /// </summary>
        /// <param name="type">type of room</param>
        /// <returns>a color which depends on type of room</returns>
        public static Color GetRoomColourFor(RoomType type)
        {
            switch (type)
            {
                case RoomType.Cycle:
                    return Color.SlateGray;
                case RoomType.Prof:
                    return Color.Aquamarine;
                case RoomType.Facility:
                    return Color.LightYellow;
                default:
                    return Color.LightGray;
            }   
        }

        /// <summary>
        /// Color for each type of botling
        /// </summary>
        /// <param name="type">type of botling</param>
        /// <returns>a color which depends on type of botling</returns>
        public static Color GetBotColourFor(BotType type)
        {
            switch(type)
            {
                case BotType.Speedster: return Color.Red;
                case BotType.Perfectionnist: return Color.Blue;
                case BotType.Introvert: return Color.Green;
                case  BotType.Lucky: return Color.Gold;
                case BotType.Aimless: return Color.Purple;
                case BotType.Persistent: return Color.Orange;
                default: return Color.CadetBlue;
            };
        }
    }
}
