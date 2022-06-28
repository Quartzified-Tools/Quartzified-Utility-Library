using UnityEngine;

namespace Quartzified.Mathematics.Science
{
    public static class Physics
    {
        public static class Atmosphere
        {
            // Density  ( kg/cu m )
            // Pressure ( K-Pa )
            // Temperature  ( ?C )
            // Height / Altitude ( m )

            public static float GetTemperatureByHeight(float altitude)
            {
                float temp;

                if (altitude < 11000)
                {
                    temp = 15.04f - (0.00649f * altitude);
                }
                else if (altitude < 25000)
                {
                    temp = -56.46f;
                }
                else
                {
                    temp = -131.21f + (0.00299f * altitude);
                }


                return temp;
            }

            public static float GetPressureByHeight(float altitude)
            {
                float temp = GetTemperatureByHeight(altitude);
                float pressure;

                if (altitude < 11000)
                {
                    pressure = 101.29f * Mathf.Pow((temp + 273.1f) / 288.08f, 5.256f);
                }
                else if (altitude < 25000)
                {
                    pressure = 22.65f * Mathf.Exp(1.73f - (0.000157f * altitude));
                }
                else
                {
                    pressure = 2.488f * Mathf.Pow((temp + 273.1f) / 216.6f, -11.388f);
                }

                return pressure;
            }

            public static float GetPressureByHeight(float altitude, float temp)
            {
                float pressure;

                if (altitude < 11000)
                {
                    pressure = 101.29f * Mathf.Pow((temp + 273.1f) / 288.08f, 5.256f);
                }
                else if (altitude < 25000)
                {
                    pressure = 22.65f * Mathf.Pow(2.71828f, 1.73f - (0.000157f * altitude));
                }
                else
                {
                    pressure = 2.488f * Mathf.Pow((temp + 273.1f) / 216.6f, -11.388f);
                }


                return pressure;
            }

            public static float GetDensityByHeight(float altitude)
            {
                float temp = GetTemperatureByHeight(altitude);
                float pressure = GetPressureByHeight(altitude, temp);

                return pressure / (0.2869f * (temp + 273.1f));
            }
        }

        // Coefficient ( Cl ) contains all the complex dependencies and is usally determined experimentally.

        public static float GetLift(float Cl, float density, float velocity, float wingArea)
        {
            return (Cl * density * Mathf.Sqrt(velocity) * wingArea) / 2;
        }

        public static float GetGravityByHeight(float altitude)
        {
            return 9.80665f * (1 - (altitude * 2) / 6371000f);
        }

    }
}
