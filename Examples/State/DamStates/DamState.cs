namespace Patterns.Examples.State
{
    abstract class DamState
    {
        public int WaterLevel { get; protected set; }
        public abstract string LevelName { get; }
        protected int lowerLever;
        protected int upperLever;

        public Dam Dam { get; set; }

        public abstract void WaterIncreased(int howManyCentimeters);
        public abstract void WaterDecreased(int howManyCentimeters);
        public abstract void OpenEmergencyGate();

        protected abstract void WaterLevelChanged();
    }
}