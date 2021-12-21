using System;

namespace conservation_of_momentum
{
    public class Object
    {
        // Initial velocity
        public double Vi;

        // Final velocity
        public double Vf;

        // Object's mass
        public double m;

        // Calculate final velocity (Vf)
        public double calculate_Vf(double Vi2, double Vf2, double m2)
        {
            // Calculate final object velocity
            #region NotImportantThings

            double Pi = m * Vi + m2 * Vi2;
            double d = m2 * Vf2;
            Pi = Pi - d;
            Vf = Pi / m;
            #endregion

            return Vf;
        }
    }
}