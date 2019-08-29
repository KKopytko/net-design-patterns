using System;

namespace Patterns.Examples.State
{
    class LowLevel : DamState
    {
        public override string LevelName => "Low level of water";

        public LowLevel(int currentWaterLevel, Dam dam)
        {
            WaterLevel = currentWaterLevel;
            upperLever = 100;
            Dam = dam;

            WaterIncreased(currentWaterLevel);
        }

        public LowLevel(DamState damState) : this(damState.WaterLevel, damState.Dam)
        {
        }

        public override void OpenEmergencyGate()
        {
            // nothing happen
        }

        public override void WaterDecreased(int howManyCentimeters)
        {
            WaterLevel = Math.Min(0, WaterLevel - howManyCentimeters);
        }

        public override void WaterIncreased(int howManyCentimeters)
        {
            WaterLevel += howManyCentimeters;

            WaterLevelChanged();
        }

        protected override void WaterLevelChanged()
        {
            if (WaterLevel > upperLever)
            {
                Dam.DamState = new RegularLevel(this);
            }
        }
    }
}