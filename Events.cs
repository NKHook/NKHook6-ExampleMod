using NKHook6.API.Bloons;
using NKHook6.API.Events;
using NKHook6.API.Events._Bloons;

namespace ExampleMod {
    public class Events {
        [EventAttribute("BloonMoveEvent")]
        public static void onMove(BloonEvents.MoveEvent e)
        {
            
        }
    }
}