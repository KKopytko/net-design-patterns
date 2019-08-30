namespace Patterns.Examples.State
{
    class StateExample : RunnableExample
    {
        public override void Run()
        {
            var dam = new Dam("Zapora Porabka (49.48.26N 19.12.07E)");

            dam.WaterIncreased(70);
            dam.WaterDecreased(100);
            dam.WaterIncreased(150);
            dam.WaterIncreased(200);
            dam.OpenEmergencyGate();
        }
    }
}