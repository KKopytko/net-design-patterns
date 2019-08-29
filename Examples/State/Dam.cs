using System;

namespace Patterns.Examples.State
{
    class Dam
    {
        public DamState DamState { get; set; }
        public string Name { get; private set; }

        public Dam(string name)
        {
            Name = name;
            DamState = new LowLevel(40, this);
        }

        public string LevelDescription => DamState.LevelName;
        public int WaterLevel => DamState.WaterLevel;

        public void WaterIncreased(int howManyCentimeters)
        {
            DamState.WaterIncreased(howManyCentimeters);
            DisplayState("Water level increased");
        }

        public void WaterDecreased(int howManyCentimeters)
        {
            DamState.WaterDecreased(howManyCentimeters);
            DisplayState("Water level decreased");
        }

        public void OpenEmergencyGate()
        {
            DamState.OpenEmergencyGate();
            DisplayState("Emergency gate openned for a moment");
        }

        private void DisplayState(string title)
        {
            Console.WriteLine($"- {title}:");
            Console.WriteLine($"    Status: {LevelDescription}");
            Console.WriteLine($"    Level:  {WaterLevel} cm\n");
        }
    }
}