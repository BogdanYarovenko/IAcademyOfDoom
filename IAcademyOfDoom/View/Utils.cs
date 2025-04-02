using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAcademyOfDoom.View
{
    public class Utils
    {
        public static Point getCenteredPosition(Point position, Size rectSize)
        {
            return new Point(position.X - rectSize.Width / 2, position.Y - rectSize.Height / 2);
        }
    }
}
