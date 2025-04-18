using System;
using System.Drawing;
using IAcademyOfDoom.Logic.Actions;
using IAcademyOfDoom.View;

namespace IAcademyOfDoom.View
{
    public class ActionView
    {
        /// <summary>
        /// The logical action represented by this graphical object.
        /// </summary>
        public GameAction Action { get; private set; }

        /// <summary>
        /// The top-left corner location of the graphic display.
        /// </summary>
        public Point Location { get; set; }

        /// <summary>
        /// Constructor with parameters.
        /// </summary>
        /// <param name="action">The logical action</param>
        /// <param name="location">The screen location (top-left corner)</param>
        public ActionView(GameAction action, Point location)
        {
            Action = action;
            Location = location;
        }

        /// <summary>
        /// Renders the action as a rectangle with its name.
        /// </summary>
        /// <param name="graphics">The graphics context</param>
        public void Draw(Graphics graphics)
        {
            Point textPosition = new Point(Location.X + Settings.TextOffset.Width, Location.Y);
            Rectangle rectangle = new Rectangle(Location, Settings.ActionSquare); 
            graphics.FillRectangle(Settings.ActionBrush, rectangle); 
            graphics.DrawRectangle(Pens.DarkTurquoise, rectangle);
            graphics.DrawString("Action: " + Action.ToString(), Settings.ActionFont, Settings.TextBrush, textPosition);
        }

        /// <summary>
        /// Checks if a given point is inside the clickable action rectangle.
        /// </summary>
        /// <param name="point">The point to test</param>
        /// <returns>true if inside</returns>
        public bool OnSquare(Point point)
        {
            Rectangle rectangle = new Rectangle(Location, Settings.ActionSquare);
            return rectangle.Contains(point);
        }
    }
}
