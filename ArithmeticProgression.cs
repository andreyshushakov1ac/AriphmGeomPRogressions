namespace pr4._7
{
    internal class ArithmeticProgression : Progression
    {
        public ArithmeticProgression(int a0, int d)
        {
            this.a0 = a0;
            this.d = d;
        }

        //разность арифметической прогрессии
        private int d;


        override public double GetElement(int k)
        {
            int ak = a0 + (k - 1) * d;
            return ak;
        }

    }
}
