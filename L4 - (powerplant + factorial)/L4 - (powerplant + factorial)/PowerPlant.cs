using static L4____powerplant___factorial_.WarningExtension;

namespace L4____powerplant___factorial_
{
    public class PowerPlant
    {
        private Warning? warningDelegate;
        private Random random = new Random();

        public PowerPlant()
        {
            warningDelegate = null;
        }

        public void SetWarning(Warning wa)
        {
            warningDelegate += wa;
        }

        public void TriggerWarning()
        {
            // Tjekker om der er tilknyttet en metode til warningDelegate
            warningDelegate?.Invoke();
        }

        public void HeatUp()
        {
            // generate random number between 0 and 100
            int randomNum = random.Next(0, 100) + 1;
            if (randomNum > 50)
            {
                TriggerWarning();
            }
        }
    }
}
