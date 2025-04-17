    using System.Collections.Generic;
    using IAcademyOfDoom.Logic.Mobiles;
    using IAcademyOfDoom.Logic.Skills;

    namespace IAcademyOfDoom.Logic.Places
    {
        // AKA Party room
        internal class RoomLounge : Room
        {
            public RoomLounge(int x, int y, int HP) : base(x, y,HP)
            {
                Type = RoomType.Facility; 
                Name = "Lounge Room";
            }

            public override object ActOnEntry(Botling botling)
            {
                int hpLoose;
                if (botling.HP <= 3 && botling.HP > 0)
                {
                    hpLoose = botling.HP;
                    botling.HP = 1;
                    hpLoose = hpLoose - botling.HP;

                    foreach (KeyValuePair<SkillType, int> skillEntry in botling.Skills)
                    {
                        if (skillEntry.Key.IsBaseSkill())
                        { 
                            Botling.updateSkill(skillEntry.Key, botling, hpLoose); 
                        }

                    }
                }
                return null;
            }
        }
    }
