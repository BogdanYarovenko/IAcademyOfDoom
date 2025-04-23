    using System.Collections.Generic;
    using IAcademyOfDoom.App;
    using IAcademyOfDoom.Logic.Mobiles;
    using IAcademyOfDoom.Logic.Skills;
    using IAcademyOfDoom.Logic.GameSettings;

    namespace IAcademyOfDoom.Logic.Places
    {
        // AKA Party room
        public class RoomLounge : Room
        {
            public RoomLounge(int x, int y, int HP) : base(x, y, HP)
            {
                Type = RoomType.Facility; 
                Name = "Lounge Room";
            }

            public override object ActOnEntry(Botling botling)
            {
                this.HP--;
                if (this.HP <=0)
                {
                    Controller.Instance.DestroyRoom(this);
                }
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
