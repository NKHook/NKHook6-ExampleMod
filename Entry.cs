using MelonLoader;
using NKHook6.API;
using NKHook6.API.Bloons;
using NKHook6.API.Events;
using NKHook6.API.Events._Bloons;
using NKHook6_Impl.Implementations.Bloons;
using NKHook6.API.Registry;

namespace ExampleMod
{
    public class Entry : MelonMod, BTDModStart
    {
        //Gets called after BTD6 has fully loaded, this way you can access most data without a NullPointerException.
        public void onModLoaded()
        {
            //Listen for events in this class
            EventRegistry.instance.listen(typeof(Entry));
        }
    }
}