﻿using IAcademyOfDoom.App;
using IAcademyOfDoom.Logic.Actions;
using IAcademyOfDoom.Logic.GameSequence;
using IAcademyOfDoom.Logic.GameSettings;
using IAcademyOfDoom.Logic.Mobiles;
using IAcademyOfDoom.Logic.Places;
using IAcademyOfDoom.Logic.Skills;
using IAcademyOfDoom.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IAcademyOfDoom.Logic
{
    /// <summary>
    /// The class representing the game.
    /// Normally, only one instance at any time
    /// </summary>
    public class Game
    {
        #region public static (class-level) properties
        /// <summary>
        /// A random number generator (used everywhere).
        /// </summary>
        public static Random Random { get; } = new Random();



        /// <summary>
        /// The difficulty of the game.
        /// </summary>
        public static Difficulty Difficulty { get; set; } = Difficulty.Easy;
        /// <summary>
        /// The maximum X (highest index for columns, starting at 0).
        /// </summary>
        public static int MaxX { get; private set; } = Default.Columns - 1;
        /// <summary>
        /// The maximum Y (highest index for rows, starting at 0).
        /// </summary>
        public static int MaxY { get; private set; } = Default.Lines - 1;
        #endregion
        #region public read-only instance properties
      
        /// <summary>
        /// The current money of the player.
        /// </summary>
        public static int Money { get; private set; }
        #endregion
        #region private attributes
        private Phase currentPhase = Phase.Preparation;
        private int waveNumber = 1;
        private Wave wave = null;
        private int successes;
        private int failures;
        private int tired;
        private readonly List<Room> rooms = new List<Room>();
        private readonly List<Placeable> placeables = new List<Placeable>();
        private readonly List<GameAction> gameActions = new List<GameAction>();
        private readonly List<Botling> botlings = new List<Botling>();
        private Controller c = Controller.Instance;
        #endregion
        #region constructor
        /// <summary>
        /// Constructor.
        /// Sets up base values
        /// </summary>
        public Game()
        {
            rooms.Add(Room.SpawnArea());
            rooms.Add(Room.ExamRoom());
            placeables.Add(new Placeable(RoomType.Prof, SkillType.Classify, "Classification Professor"));
            placeables.Add(new Placeable(RoomType.Prof, SkillType.Produce, "Production Professor"));
            placeables.Add(new Placeable(RoomType.Prof, SkillType.Dialogue, "Dialogue Professor"));
            placeables.Add(new Placeable(RoomType.Prof, SkillType.Interpret, "Interpretation Professor"));
            placeables.Add(new Placeable(RoomType.Prof, SkillType.Synthetise, "Synthesis Professor"));
            placeables.Add(new Placeable(RoomType.Prof, SkillType.Present, "Presentation Professor"));
        }

        #endregion
        #region public methods
        public void initAfterWindow()
        {
            Money = Default.BaseMoney(Difficulty);
        }
        /// <summary>
        /// Simulates a dice roll and returns a random value between 1 and 6.
        /// The method uses a random number generator to simulate rolling a standard six-sided die.
        /// </summary>
        /// <returns>
        /// A random integer between 1 and 6, inclusive.
        /// </returns>
        public static int Dice()
        {
            return Random.Next(0, 6) + 1;

        }

        /// <summary>
        /// Adds a room at one position given a placeable item.
        /// </summary>
        /// <param name="x">the column</param>
        /// <param name="y">the row</param>
        /// <param name="placeable">the placeable item</param>
        public void AddRoomHere(int x, int y, int HP, Placeable placeable)
        {
            rooms.Add(placeable.MakeRoom(x, y, HP));
        }
        public void AddPlaceable(Placeable placeable)
        {
            placeables.Add(placeable);
        }
        public void AddAction(GameAction action)
        {
            gameActions.Add(action);
        }
        public void RemoveAction(GameAction action)
        {
            gameActions.Remove(action);
        }
        /// <summary>
        /// Provides a copy of the list of placeable items.
        /// </summary>
        /// <returns>a new list</returns>
        public List<Placeable> Placeables() => new List<Placeable>(placeables);
        public List<GameAction> GameActions() => new List<GameAction>(gameActions);
        public List<Room> Rooms()
        {
            return new List<Room>(rooms);
        }
        public List<Room> getRooms() { return rooms; }
        public List<Botling> getBotlings() { return botlings; }
        /// <summary>
        /// Attempts to place a placeable item at some position.
        /// </summary>
        /// <param name="x">the column</param>
        /// <param name="y">the row</param>
        /// <param name="placeable">the candidate placeable item</param>
        /// <returns>true iff the placeable has been correctly placed</returns>
        public bool PlaceThisHere(int x, int y, Placeable placeable)
        {
            if (placeables.Contains(placeable))
            {
                AddRoomHere(x, y, Default.BaseProfHitPoints, placeable);
                placeables.Remove(placeable);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Ends the preparation phase and goes into the assault phase.
        /// </summary>
        public void EndPreparations()
        {
            currentPhase = Phase.Assault;
            successes = failures = tired = 0;
            wave = new Wave(waveNumber);

        }


        /// <summary>
        /// Progresses in the assault phase.
        /// </summary>
        public void NextInAssault()
        {
            bool change = false;
            List<Botling> spawnedNow = null;
            List<Botling> terminatedNow = new List<Botling>();
            List<Botling> toProcess = botlings.ToList();
            if (wave != null && wave.Turn != null)
            {
                spawnedNow = wave.Turn.SpawnOrNull();
            }
            if (botlings.Count > 0)
            {
                foreach (Botling botling in toProcess)
                {
                    botling.Move();
                    (int x, int y) = (botling.X, botling.Y);
                    Room entered = FindRoomAt(x, y);
                    object result = entered?.ActOnEntry(botling);

                    if (result is ExamResult examResult)
                    {
                        StoreExamResult(examResult);

                        if (botling.Type == BotType.Persistent && examResult == ExamResult.Failure)
                        {

                            botling.Repeater();

                        }
                        else
                        {
                            terminatedNow.Add(botling);
                        }
                    }
                    else if (result is bool b)
                    {
                        c.LessonResult(botling, b);
                        if (!b && botling.HP <= 0)
                        {
                            StoreExamResult(ExamResult.Tired);
                            terminatedNow.Add(botling);
                        }
                    }
                }
                change = true;
            }
            if (spawnedNow?.Count > 0)
            {
                botlings.AddRange(spawnedNow);
                change = true;
            }
            if (change)
            {
                foreach (Botling removable in terminatedNow)
                {
                    botlings.Remove(removable);
                }
                c.BotRemove(terminatedNow);
                c.BotChange(botlings);

                foreach (Room room in rooms)
                {
                    room.SetIsLessons(true);
                }
            }
            else
            {
                currentPhase = Phase.Result;
                wave = null;
                c.EndAssault();
            }

        }
        /// <summary>
        /// Accesses the current results of the assault.
        /// </summary>
        /// <returns>a success - failures pair</returns>
        public (int successes, int failures, int tired) GetResults()
        {
            return (successes, failures, tired);
        }
        /// <summary>
        /// Removes a room.
        /// </summary>
        /// <param name="profRoom">the room to remove</param>
        public void DestroyRoom(Room profRoom)
        {
            rooms.Remove(profRoom);
        }
        /// <summary>
        /// Goes to the next wave.
        /// </summary>
        /// <returns>false: game over</returns>
        public bool NextWave()
        {
            waveNumber++;
            wave = new Wave(waveNumber);

            return (wave.Turn != null);
        }

        /// <summary>
        /// Remove the specified amount of money from the current money
        /// </summary>
        /// <param name="amount"> the amount to remove</param>
        /// <returns>true if the money was removed, false if not enough money</returns>
        public static bool RemoveMoney(int amount)
        {
            if (Money - amount >= 0)
            {
                Money -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Add the specified ammount of money to the current money
        /// </summary>
        /// <param name="amount"> the amount to add </param>
        public static void AddMoney(int amount)
        {
            Money += amount;

        }
        /// <summary>
        /// Checks if a room at the specified coordinates is occupied by a bot.
        /// </summary>
        /// <param name="x">The X coordinate of the room to check.</param>
        /// <param name="y">The Y coordinate of the room to check.</param>
        /// <returns>
        /// True if any bot occupies the room at the specified coordinates, otherwise false.
        /// </returns>
        public bool IsRoomOccupiedByBot(int x, int y)
        {
            foreach (Botling botling in botlings)
            {
                if (botling.NextMove.x == x && botling.NextMove.y == y)
                {
                    return true;
                }
            }

            return false;
        }
        /// <summary>
        /// Checks if all the bots in the list are of the same type as the provided bot.
        /// </summary>
        /// <param name="botling">The bot to compare types with.</param>
        /// <returns>
        /// True if all bots in the list are of the same type as the provided bot, otherwise false.
        /// </returns>
        public bool IsSameTypeOfBotling(Botling botling)
        {
            foreach (Botling bot in botlings)
            {
                if (bot.Type != botling.Type)
                {
                    return false;
                }
            }
            return true;
        }

        #endregion
        #region private methods
        /// <summary>
        /// Stores the result of an exam (success, failure, or tired).
        /// </summary>
        /// <param name="examResult">The result of the exam to store.</param>
        private void StoreExamResult(ExamResult examResult)
        {
            switch (examResult)
            {
                case ExamResult.Success:
                    successes++;
                    break;
                case ExamResult.Failure:
                    failures++;
                    break;
                case ExamResult.Tired:
                    tired++;
                    break;
            }
        }
        /// <summary>
        /// Finds and returns the room at the specified coordinates (x, y).
        /// Optionally, it can exclude cycle rooms based on the `isCycleRoom` parameter.
        /// </summary>
        /// <param name="x">The X coordinate of the room to find.</param>
        /// <param name="y">The Y coordinate of the room to find.</param>
        /// <param name="isCycleRoom">Indicates whether to exclude cycle rooms. Defaults to true.</param>
        /// <returns>
        /// The room at the specified coordinates if found, otherwise null. 
        /// If `isCycleRoom` is false, and the room is a cycle room, null will be returned.
        /// </returns>
        public Room FindRoomAt(int x, int y, bool isCycleRoom = true)
        {
            int i = 0;
            int index = -1;
            while (index == -1 && i < rooms.Count)
            {
                if (rooms[i]?.X == x && rooms[i]?.Y == y)
                {
                    index = i;
                }
                else
                {
                    i++;
                }
            }
            if (index == -1)
            {
                return null;
            }
            else
            {
                if (!isCycleRoom && rooms[index].Type == RoomType.Cycle)
                    return null;

                return rooms[index];
            }
        }
        #endregion
    }
}