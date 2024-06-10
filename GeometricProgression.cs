namespace pr4._7
{
    internal class GeometricProgression : Progression
    {
        public GeometricProgression(int b0, double q) 
        {
           this.a0 = b0;
            this.q  = q;
        }
        
        //знаменатель геометрической прогрессии
        private double q;

        override public double GetElement(int k)
        {
            double bk = a0 * Math.Pow(q,k-1);
            return bk;
        }

    }
}
