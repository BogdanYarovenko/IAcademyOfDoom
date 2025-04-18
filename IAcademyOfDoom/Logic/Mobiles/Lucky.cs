using IAcademyOfDoom.Logic.Mobiles;

using IAcademyOfDoom.Logic;

/// <summary>
/// Represents a subclass of Botling with special behavior related to luck. 
/// The Lucky botling has reduced starting HP but gains HP based on random dice rolls.
/// </summary>
public class Lucky : Botling
{
    /// <summary>
    /// The constructor decreases the botling's HP by 2/>.
    /// </summary>
    public Lucky() : base(BotType.Lucky)
    {
        HP -= 2;
    }

    /// <summary>
    /// Determines the next position for the Lucky botling and adjusts its HP based on a dice roll.
    /// The botling gains HP based on a random dice roll, and the dice value is adjusted under certain conditions.
    /// </summary>
    /// <returns>
    /// A tuple representing the new coordinates (x, y) after computing the next move.
    /// </returns>
    protected override (int x, int y) Next()
    {
        int initDiceValue = Game.Dice();
        if (initDiceValue == 1)
        {
            initDiceValue += Game.Dice();
        }
        HP += initDiceValue;

        return base.Next();
    }
}
