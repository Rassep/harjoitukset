using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus_3
{
    class Kiuas
    {
        private bool switchedOn { get; set; }

        private int temperature { get; set; }
        private int humidity { get; set; }

        public Kiuas(bool _switchedOn, int _temperature, int _humidity)
        {
            switchedOn = _switchedOn;
            temperature = _temperature;
            humidity = _humidity;
        }

        public void toggle()
        {
            switchedOn = !switchedOn;
            Console.WriteLine(string.Format("Kiuas laitettiin {0}", switchedOn ? "päälle" : "pois päältä"));
        }

        public void toggleOn()
        {
            switchedOn = true;
            Console.WriteLine("Kiuas laitettiin päälle");
        }

        public void toggleOff()
        {
            switchedOn = false;
            Console.WriteLine("Kiuas laitettiin pois päältä");
        }

        public void setTemperature(int _temperature)
        {
            temperature = _temperature;
            Console.WriteLine(string.Format("Kiukaan lämpö on {0} astetta", temperature));
        }

        public void setHumidity(int _humidity)
        {
            humidity = _humidity;
            Console.WriteLine(string.Format("Kiukaan kosteus on {0}%", humidity));
        }
    }
}
