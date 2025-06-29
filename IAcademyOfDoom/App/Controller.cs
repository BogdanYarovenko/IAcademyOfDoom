﻿using IAcademyOfDoom.Logic;
using IAcademyOfDoom.Logic.GameSettings;
using IAcademyOfDoom.Logic.Mobiles;
using IAcademyOfDoom.Logic.Places;
using IAcademyOfDoom.View;
using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;
using IAcademyOfDoom.Logic.Actions;

namespace IAcademyOfDoom.App
{
    /// <summary>
    /// The controller. One single instance serving as in-between for the logic and view parts.
    /// </summary>
    public class Controller
    {
        public string Name { get; set; }
        #region attributes, properties, constructor and method for the single instance
        private Game game;
        private MainWindow window;
        /// <summary>
        /// The single instance of the controller.
        /// </summary>
        public static Controller Instance { get; private set; } = new Controller();
      
        private Controller()
        {
        }
        /// <summary>
        /// Method used to set the game and the window.
        /// </summary>
        /// <param name="window">the window (from which this method is called)</param>
        /// <param name="name">optional name for the player</param>
        /// <param name="difficulty">optional difficulty for the game</param>
        public void Associate(MainWindow window, string name = null, Difficulty? difficulty = null)
        {
            this.window = window;
            game = new Game();
            if (name != null)
            {
                Name = name;
            }
            if (difficulty != null)
            {
                Game.Difficulty = difficulty.Value;
            }
            game.initAfterWindow();
            window.WriteLine("Init new game...");
            window.PreviewPlaceableItems(game.Placeables());
        }
        #endregion
        #region public methods
        /// <summary>
        /// Bridge to the same method in the game.
        /// </summary>
        /// <returns>the game's list of rooms</returns>
        public List<Room> Rooms() => game.Rooms();
        /// <summary>
        /// Bridge to the same method in the game.
        /// </summary>
        /// <returns>the game's list of placeables</returns>
        public List<Placeable> Placeables() => game.Placeables();
        public List<GameAction> GameActions() => game.GameActions();
        public List<Room> getRooms() { return game.getRooms(); }
        public List<Botling> getBotlings() { return game.getBotlings(); }
        /// <summary>
        /// Method called by the window when preparations are over.
        /// </summary>
        public void EndPreparations()
        {
            window.WriteLine("Preparations ended.");
            game.EndPreparations();
            window.SetToAssault();
        }
        /// <summary>
        /// Method called by the window when the assault continues.
        /// </summary>
        public void NextInAssault()
        {
            game.NextInAssault();
            window.AssaultUpdate();
        }
        /// <summary>
        /// Method called by the game at the end of the assault phase.
        /// </summary>
        public void EndAssault()
        {
            window.DisplayResults(game.GetResults());
        }

        /// <summary>
        /// Method called whenever botling mobiles should be updated.
        /// </summary>
        /// <param name="botlings">the current list of botlings</param>
        public void BotChange(List<Botling> botlings)
        {
            window.UpdateBots(botlings);
        }
        /// <summary>
        /// Method called whenever botling mobiles should be removed.
        /// </summary>
        /// <param name="botlings">the list of botlings to remove</param>
        public void BotRemove(List<Botling> removed)
        {
            window.RemoveBots(removed);
        }
        /// <summary>
        /// Method checking whether all mandatory placeable items are placed.
        /// </summary>
        /// <returns>true iff preparations can be ended</returns>
        public bool CanEndPreparations()
        {
            return game.Placeables().Count == 0;
        }
        /// <summary>
        /// Method to add placeable item to the list of placeable
        /// </summary>
        /// <param name="placeable"> placeable to add</param>
        public void AddPlaceable(Placeable placeable)
        {
            game.AddPlaceable(placeable);
        }
        public void AddAction(GameAction action)
        {
            game.AddAction(action);
        }
        public void RemoveAction(GameAction action)
        {
            game.RemoveAction(action);
        }

        /// <summary>
        /// Method called to place a placeable item.
        /// </summary>
        /// <param name="x">the logical column number</param>
        /// <param name="y">the logical row number</param>
        /// <param name="placeable">the placeable item</param>
        public void PlaceHere(int x, int y, Placeable placeable)
        {
            bool a = game.PlaceThisHere(x, y, placeable);
            window.WriteLine("Placed:" + placeable.ToString());
            window.PreviewPlaceableItems(game.Placeables());
            window.SyncRooms();
            window.Refresh();
        }

        /// <summary>
        /// Checks if a room exists at the specified coordinates (x, y) and optionally excludes cycle rooms.
        /// </summary>
        /// <param name="x">The X coordinate of the room to check.</param>
        /// <param name="y">The Y coordinate of the room to check.</param>
        /// <param name="isCycleRoom">Indicates whether to exclude cycle rooms. Defaults to true.</param>
        /// <returns>
        /// The room at the specified coordinates if it exists, otherwise null.
        /// If `isCycleRoom` is false and the room is a cycle room, null will be returned.
        /// </returns>
        public Room IsRoomHere(int x, int y, bool isCycleRoom = true)
        {
            return game.FindRoomAt(x, y, isCycleRoom);
        }
        /// <summary>
        /// Checks if a room of the specified type exists at the given coordinates (x, y).
        /// </summary>
        /// <param name="x">The X coordinate of the room to check.</param>
        /// <param name="y">The Y coordinate of the room to check.</param>
        /// <param name="type">The type of room to check for.</param>
        /// <returns>
        /// True if the room at the specified coordinates matches the given room type, otherwise false.
        /// </returns>
        public bool IsRoomTypeHere(int x, int y, RoomType type)
        {
            Room room = IsRoomHere(x, y);
            return room != null && room.Type == type;
        }


        /// <summary>
        /// Checks if the room at the specified coordinates (x, y) is occupied by a bot.
        /// </summary>
        /// <param name="x">The X coordinate of the room to check.</param>
        /// <param name="y">The Y coordinate of the room to check.</param>
        /// <returns>
        /// True if the room is occupied by a bot, otherwise false.
        /// </returns>
        public bool IsRoomOccupiedByBot(int x, int y)
        {
            return game.IsRoomOccupiedByBot(x, y);
        }
        /// <summary>
        /// Checks if the provided bot is of the same type as the bots in the game.
        /// </summary>
        /// <param name="bot">The bot to compare against the bots in the game.</param>
        /// <returns>
        /// True if the provided bot is of the same type as the bots in the game, otherwise false.
        /// </returns>
        public bool IsSameTypeOfBotling(Botling bot)
        {
            return game.IsSameTypeOfBotling(bot);
        }
        /// <summary>
        /// Retrieves the last recorded results, including successes, failures, and tired outcomes.
        /// Displays the results in a message box and returns them as a tuple.
        /// </summary>
        /// <returns>
        /// A tuple containing the counts of successes, failures, and tired outcomes.
        /// </returns>
        public (int successes, int failures, int Tired) GetLastResults()
        {
            var results = game.GetResults();

            MessageBox.Show($"✅ Successes: {results.successes}\n❌ Failures: {results.failures}\n☠️ Tired: {results.tired} \n  ");

            return results;
        }
        /// <summary>
        /// Method called from the game when a botling's lesson has ended.
        /// </summary>
        /// <param name="botling">the botling</param>
        /// <param name="b">true iff the lesson was successful</param>
        public void LessonResult(Botling botling, bool b)
        {
            window.WriteLine(botling.Name + " was lectured!" + (b ? " And succeeded!" : " ...And failed."));
            window.DisplayStateOf(botling);
        }
        /// <summary>
        /// Method called from the game when a prof room is removed.
        /// </summary>
        /// <param name="profRoom">the room being removed</param>
        public void DestroyRoom(Room room)
        {
            game.DestroyRoom(room);
            window.SyncRooms();
            window.WriteLine(room.Name + ", exhausted, retires after one final lesson.");
        }
        /// <summary>
        /// Method used to make the game advance to the next wave.
        /// </summary>
        public void NextWave()
        {
            bool b = game.NextWave();
            if (b)
            {
                window.WriteLine("Next wave !");
                window.PreviewPlaceableItems(game.Placeables());
            }
            else
            {
                window.GameOver();
            }
        }
        #endregion
    }
}