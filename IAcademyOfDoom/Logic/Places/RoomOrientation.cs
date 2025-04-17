using IAcademyOfDoom.Logic.GameSettings;
using IAcademyOfDoom.Logic.Mobiles;
using IAcademyOfDoom.Logic.Skills;
using System;
using System.Collections.Generic;
using System.Linq;
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
            // Page 33

            int compare = int.MaxValue;
            SkillType? weakestSkill = null;
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
                List<Room> currentRooms = Controller.Instance.Rooms();
                Room targetRoom = null;

                foreach (Room room in currentRooms)
                {
                    if (room.Type == RoomType.Prof && room is ProfRoom profRoom) 
                    {
                        (SkillType?, SkillType?)? check = SkillTypeUtils.BasePair(profRoom.SkillType);

                        if (check.HasValue && (check.Value.Item1 == weakestSkill.Value ||
                                               check.Value.Item2 == weakestSkill.Value))
                        {
                            targetRoom = room; 
                            break; 
                        }
                    }
                }

                if (targetRoom != null)
                {
                    botling.SetTarget(targetRoom.X, targetRoom.Y);
                }
                else
                {
                    botling.ClearTarget(); 
                }
            }
            else
            {
                botling.ClearTarget(); 
            }

            return null;
        }
    }
}