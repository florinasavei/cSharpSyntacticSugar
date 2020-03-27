using System;

namespace Enums_End
{
    public enum PlayerStates
    {
        NotInitialized, // implicit = 0
        MediaLoaded, // implicit = 1
        Playing, // implicit = 2
        Paused, // implicit = 3
        Stopped // implicit = 4
    }

    public enum CustomPlayerStates
    {
        NotInitialized = 1,
        MediaLoaded = 2,
        Playing = 4,
        Paused = 8,
        Stopped = 16
    }

    class Program
    {
        static void Main(string[] args)
        {
            // initialization
            PlayerStates currentState = PlayerStates.NotInitialized;

            // check current value
            if (currentState == PlayerStates.MediaLoaded)
            {
                // start player
                Console.WriteLine("Start player");
            }

            // get the numeric value
            int playingNumber = (int)currentState;

            var allValues = Enum.GetValues(typeof(PlayerStates));


        }
    }
}
