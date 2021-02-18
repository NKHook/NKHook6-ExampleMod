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
        //This will get called every time a bloon leaks
        [Event]
        public static void OnLeak(BloonEvents.LeakedEvent e)
        {
            //Get the bloon instance
            IBloonEntity bloon = e.GetBloon();
            //Get the bloon type
            IBloon bloonType = bloon.GetType();
            //Get the amount of leak damage
            float leakDamage = bloonType.GetLeakDamage();
        }
    }
}