// Namespaces to include in our code
using NKHook6.API.Bloons;
using NKHook6.API.Events;
using NKHook6.API.Events._Bloons;
using NKHook6_Impl.Implementations.Bloons;

//Our mod's main namespace
namespace ExampleMod 
{
    // Class for handling events (this can be any class)
    public class Events 
    {
        // Mark this function to be used for a BloonMoveEvent
        [Event]
        public static void onMove(BloonEvents.MoveEvent e) // Create the function
        {
            IBloonEntity bloon = e.GetBloon(); // Get the bloon
            if(bloon is GreenCamoBloon) // Check if the bloon is Green and Camo
            {
                float prog = bloon.GetProgress(); // Get the bloon's progress
                if(prog > 500.0f) // If the progress is over 500
                {
                    e.SetCancelled(true); // Cancel the event (The bloon will not move)
                }
            }
            else {
                if(bloon.GetProgress() > 1000.0f) // If the progress is over 1000
                {
                    e.SetCancelled(true); // Cancel the event
                }
            }
        }
    }
}