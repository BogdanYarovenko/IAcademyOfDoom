using IAcademyOfDoom.App;
using IAcademyOfDoom.Logic.GameSettings;
using IAcademyOfDoom.Logic.Skills;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace IAcademyOfDoom.Logic.Mobiles
{
    /// <summary>
    /// A class representing one logical botling mobile.
    /// </summary>
    public class Botling
    {
        private bool m_isEasyToPass = false;
        protected Controller c = Controller.Instance;
        /// <summary>
        /// The current values for each basic skill.
        /// </summary>
        public Dictionary<SkillType, int> Skills { get; } = new Dictionary<SkillType, int>();
        /// <summary>
        /// For each combo skill, true iff the bot has earned a badge for this skill.
        /// </summary>
        public Dictionary<SkillType, bool> Badges { get; } = new Dictionary<SkillType, bool>();
        /// <summary>
        /// The botling's hit points, 0 or less: exhausted.
        /// </summary>
        public int HP { get; set; }
        /// <summary>
        /// A printable name for the botling.
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// The botling's type.
        /// </summary>
        public BotType Type { get; private set; } = BotType.None;
        /// <summary>
        /// Current column.
        /// </summary>
        public int X { get; set; } = 0;
        /// <summary>
        /// Current row.
        /// </summary>
        public int Y { get; set; } = 0;
        /// <summary>
        /// This botling will move there next.
        /// </summary>
        public (int x, int y) NextMove { get; set; }
        
        public int? TargetX { get; set; } = null;
        public int? TargetY { get; set; } = null;
        
        /// <summary>
        /// Empty constructor, use with caution.
        /// </summary>
        public Botling()
        {
            NextMove = Next();
        }
        /// <summary>
        /// Parametered constructor.
        /// </summary>
        /// <param name="type">the type of the botling</param>
        public Botling(BotType type) : this()
        {
            Type = type;
            Name = Names.Next();
            SetInitialSetOfSkills();
            HP = Default.BaseHitPoints(Game.Difficulty);
        }
        /// <summary>
        /// Enact the move.
        /// </summary>
        public virtual void Move()
        {
            (X, Y) = NextMove;
            NextMove = Next();

        }
        /// <summary>
        /// A diceroll-based test for a skill.
        /// </summary>
        /// <param name="skill">the skill to test (basic or combo)</param>
        /// <param name="difficulty">the level needed to pass</param>
        /// <returns></returns>
        public bool TestSkill(SkillType skill, int difficulty)
        {
            if (HP <= 0)
            {
                return false;
            }
            
            if (m_isEasyToPass)
            {
                m_isEasyToPass = false;
                return true;
            }

            Random random = Game.Random;
            if (skill.IsBaseSkill())
            {
                return Skills[skill] + random.Next(0, Default.DieSize) + 1 > difficulty;
            }
            else
            {
                if (Badges[skill])
                {
                    return true;
                }
                else
                {
                    (SkillType s1, SkillType s2) = skill.BasePair().Value;
                    return Skills[s1] + Skills[s2] + random.Next(0, Default.DieSize) + 1 > difficulty;
                }
            }
        }
        /// <summary>
        /// Conduct a lesson for the bot in somme skill.
        /// </summary>
        /// <param name="skill">the skill, basic or combo</param>
        /// <returns>true iff the lesson is successful</returns>
        public bool GetLessonIn(SkillType skill)
        {
            if (TestSkill(skill, Default.LessonDifficulty(Game.Difficulty, skill.IsBaseSkill() ? 1 : 2)))
            {
                if (skill.IsBaseSkill())
                {
                    Skills[skill] += Default.TutorReward;
                }
                else
                {
                    (SkillType s1, SkillType s2) = skill.BasePair().Value;
                    Skills[s1]++;
                    Skills[s2]++;
                    Badges[skill] = true;
                }
                return true;
            }
            else
            {
                if (skill.IsBaseSkill())
                {
                    Skills[skill]++;
                    HP--;
                }
                else
                {
                    (SkillType s1, SkillType s2) = skill.BasePair().Value;
                    Skills[s1]++;
                    Skills[s2]++;
                    HP -= 2;
                }
                return false;
            }
        }
        /// <summary>
        /// Performs the final exam.
        /// </summary>
        /// <returns>the exam result</returns>
        public ExamResult Exam()
        {
            List<SkillType> subjects = SkillTypeUtils.AllCombinatedSkills();
            SkillType examinated = subjects[Game.Random.Next(0, subjects.Count)];
            return TestSkill(examinated, Default.ExamDifficulty(Game.Difficulty)) ? ExamResult.Success : ExamResult.Failure;
        }
        /// <summary>
        /// Initializes the set of skills for the entity by distributing skill points randomly 
        /// across all base skill types. The method also sets the initial status for all combinatory skills.
        /// </summary>
        private void SetInitialSetOfSkills()
        {
            int distribute = Default.SkillPoints;
            int max = Default.MaxSkillLevel;
            Random random = Game.Random;
            List<SkillType> skillTypes = SkillTypeUtils.AllBaseSkills();
            int[] ints = new int[skillTypes.Count];
            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = 0;
            }
            while (distribute > 0)
            {
                int i = 0;
                while (i < skillTypes.Count && distribute > 0)
                {
                    if (random.Next() % 2 == 0 && ints[i] < max)
                    {
                        ints[i]++;
                        distribute--;
                    }
                    i++;
                }
            }
            int j = 0;
            foreach (SkillType skill in skillTypes)
            {
                Skills.Add(skill, ints[j++]);
            }
            foreach (SkillType skill in SkillTypeUtils.AllCombinatedSkills())
            {
                Badges.Add(skill, false);
            }
        }

        public static void updateSkill(SkillType skill,Botling bot, int value)
        {
            bot.Skills[skill] += value;
        }
        /// <summary>
        /// Calculates the next position for the entity based on the current position.
        /// </summary>
        /// <returns>
        /// A tuple representing the next coordinates (x, y)
        /// </returns>
        protected virtual (int x, int y) Next()
        {
            if (X == Game.MaxX && Y == Game.MaxY)
            {
                return (X, Y);
            }
            if (X == Game.MaxX)
            {
                return (X, Y + 1);
            }
            if (Y == Game.MaxY)
            {
                return (X + 1, Y);
            }
            if (Game.Random.Next() % 2 == 0)
            {
                return (X, Y + 1);
            }
            return (X + 1, Y);
        }
        
        /// <summary>
        /// Define for a specified bottling where to go
        /// </summary>
        /// <param name="x">Coordinate West/East</param>
        /// <param name="y">Coordinate North/South</param>
        public void SetTarget(int x, int y)
        {
            TargetX = x;
            TargetY = y;
            NextMove = Next();
        }

        /// <summary>
        /// Method to remove the target of a bot if the bottling has reach the case or it's null
        /// </summary>
        public void ClearTarget()
        {
            TargetX = null;
            TargetY = null;
        }
        
        /// <summary>
        /// Indicates if a bottling is oriented or is not
        /// </summary>
        /// <returns>True if it's oriented</returns>
        public bool HasSpecificTarget()
        {
            return TargetX.HasValue && TargetY.HasValue;
        }
        
        
        
        /// <summary>
        /// Moves the entity to a specified position (x, y) if the position is valid within the map bounds.
        /// </summary>
        /// <param name="x">The X-coordinate to move to.</param>
        /// <param name="y">The Y-coordinate to move to.</param>
        public void MoveTo(int x, int y)
        {
            if (isInMap(x, y))
            {
                X = x;
                Y = y;
            }
        }
        /// <summary>
        /// Resets the entity's position to (0, 0) and calculates the next move.
        /// </summary>
        public void Repeater()
        {
            MoveTo(0, 0);
            NextMove = Next();
        }

        public void SetPassExamNextTurn()
        {
            m_isEasyToPass = true;
        }

        /// <summary>
        /// Checks whether the given coordinates (x, y) are within the valid bounds of the map.
        /// </summary>
        /// <param name="x">The X-coordinate to check.</param>
        /// <param name="y">The Y-coordinate to check.</param>
        /// <returns>
        /// True if the coordinates are within the bounds of the map, false otherwise.
        /// </returns>
        protected bool isInMap(int x, int y)
        {
            return x >= 0 && y >= 0 && x <= Game.MaxX && y <= Game.MaxY;
        }
    }
}
