using IAcademyOfDoom.Logic.GameSettings;
using IAcademyOfDoom.Logic.Mobiles;
using IAcademyOfDoom.Logic.Skills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using IAcademyOfDoom.App;


namespace IAcademyOfDoom.Logic.Places
{
    internal class RoomOrientation : Room
    {
        public RoomOrientation(int x, int y, int HP) : base(x, y, HP)
        {
            Type = RoomType.Facility;
            Name = "Orientation Office";
        }

        public override object ActOnEntry(Botling botling)
        {
            //Page 33
            int compare = -1;
            SkillType? weakestSkill = null;
            List<Room> currentRooms = Controller.Instance.Rooms();
            
            foreach (KeyValuePair<SkillType, int> skillEntry in botling.Skills)
            {
                if (skillEntry.Key.IsBaseSkill())
                {
                    if (skillEntry.Value < compare)
                    {
                        compare = skillEntry.Value;
                        weakestSkill = skillEntry.Key;
                    }
                }
            }

            if (weakestSkill.HasValue)
            {
                // A CONTINUER
                foreach (Room room in currentRooms)
                {
                    string roomName = room.Name;           // Nom de la salle 
                    RoomType roomType = room.Type;         // Type de salle 
                    int roomX = room.X;                    // Coordonnée X (colonne)
                    int roomY = room.Y;                    // Coordonnée Y (ligne)
                    int roomHP = room.HP;                  // Points de vie actuels de la salle
                    
                    if (room?.Type == RoomType.Prof && room is ProfRoom profRoom)
                    {

                    }
                }
            }

            return null;
        }

    }
}