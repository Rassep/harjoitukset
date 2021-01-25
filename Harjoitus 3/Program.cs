using System;

namespace Harjoitus_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Kiuas kiuas = new Kiuas(false, 20, 50);

            kiuas.toggle();
            kiuas.setTemperature(70);
            kiuas.setHumidity(90);

            kiuas.toggleOff();
            kiuas.setTemperature(22);
            kiuas.setHumidity(50);

            kiuas.toggleOn();
            kiuas.setTemperature(80);
            kiuas.setHumidity(100);
        }
    }
}
