namespace Patterns.Examples.State
{
    class AlarmLevel : DamState
    {
        public override string LevelName => "Above safe maximum";

        public AlarmLevel(int currentWaterLevel, Dam dam)
        {
            WaterLevel = currentWaterLevel;
            lowerLever = 400;
            Dam = dam;
        }

        public AlarmLevel(DamState damState) : this(damState.WaterLevel, damState.Dam)
        {
        }

        public override void OpenEmergencyGate()
        {
            WaterDecreased(100);
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
            if (WaterLevel < lowerLever)
            {
                Dam.DamState = new RegularLevel(this);
            }
        }
    }
}