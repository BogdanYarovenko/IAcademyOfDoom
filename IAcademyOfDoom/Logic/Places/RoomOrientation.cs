using IAcademyOfDoom.App;
using IAcademyOfDoom.Logic.GameSettings;
using IAcademyOfDoom.Logic.Mobiles;
using IAcademyOfDoom.Logic.Skills;

namespace IAcademyOfDoom.Logic.Places
{
    internal class RoomOrientation : Room
    {
        public RoomOrientation(int x, int y, int HP) : base(x, y, HP)
        {
            Type = RoomType.Facility;
            Name = "Orientation Office";
            HP = Default.BaseProfHitPoints;
        }

        public override object ActOnEntry(Botling botling)
        {
            // Page 33

            var compare = int.MaxValue;
            SkillType? weakestSkill = null;
            foreach (var skillEntry in botling.Skills)
                if (skillEntry.Key.IsBaseSkill())
                    if (skillEntry.Value < compare)
                    {
                        compare = skillEntry.Value;
                        weakestSkill = skillEntry.Key;
                    }

            if (weakestSkill.HasValue)
            {
                var currentRooms = Controller.Instance.Rooms();
                Room targetRoom = null;

                foreach (var room in currentRooms)
                    if (room.Type == RoomType.Prof && room is ProfRoom profRoom)
                    {
                        (SkillType?, SkillType?)? check = profRoom.SkillType.BasePair();

                        if (check.HasValue && (check.Value.Item1 == weakestSkill.Value ||
                                               check.Value.Item2 == weakestSkill.Value))
                        {
                            targetRoom = room;
                            break;
                        }
                    }

                if (targetRoom != null)
                    botling.SetTarget(targetRoom.X, targetRoom.Y);
                else
                    botling.ClearTarget();
            }
            else
            {
                botling.ClearTarget();
            }

            return null;
        }
    }
}