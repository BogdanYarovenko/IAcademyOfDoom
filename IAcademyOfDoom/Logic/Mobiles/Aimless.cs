﻿using IAcademyOfDoom.Logic.Places;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace IAcademyOfDoom.Logic.Mobiles
{
    /// <summary>
    /// A class representing a bot of type Aimless
    /// </summary>
    public class Aimless : Botling
    {
        /// <summary>
        /// Constructor for the Aimless class
        /// </summary>
        public Aimless() : base(BotType.Aimless)
        {
        }

        /// <summary>
        /// If there is another type of botling on the map, this botling will go to random direction (top, left, right, bottom)
        /// While he goes randomly he couldn't enter to exam room.
        /// 
        /// If there is only Aimless type of botling on the map, it goes normaly directly to exam room.
        /// </summary>
        /// <returns></returns>
        protected override (int x, int y) Next()
        {
            if (c.IsSameTypeOfBotling(this))
            {
                return base.Next();
            }

            int[] directions = new int[2];
            directions[0] = -1;
            directions[1] = 1;

            int x, y;
            do
            {
                x = X;
                y = Y;

                if (Game.Random.Next(0, 2) == 0)
                {
                    x += directions[Game.Random.Next(0, 2)];
                }
                else
                {
                    y += directions[Game.Random.Next(0, 2)];
                }
            } while (!isInMap(x, y) || c.IsRoomTypeHere(x, y, RoomType.Cycle));

            return (x, y);
        }
    }

}
