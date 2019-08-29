namespace Patterns.Examples.State
{
    class RegularLevel : DamState
    {
        public override string LevelName => "Regular level of water";

        public RegularLevel(int currentWaterLevel, Dam dam)
        {
            WaterLevel = currentWaterLevel;
            lowerLever = 100;
            upperLever = 300;
            Dam = dam;
        }

        public RegularLevel(DamState damState) : this(damState.WaterLevel, damState.Dam)
        {
        }

        public override void OpenEmergencyGate()
        {
            WaterDecreased(50);
            WaterLevelChanged();
        }

        public override void WaterDecreased(int howManyCentimeters)
        {
            WaterLevel -= howManyCentimeters;
            WaterLevelChanged();
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
                Dam.DamState = new AlarmLevel(this);
                return;
            }

            if (WaterLevel < lowerLever)
            {
                Dam.DamState = new LowLevel(this);
            }
        }
    }
}