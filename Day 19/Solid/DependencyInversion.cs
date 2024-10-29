using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    public class GreenLightBulb:ILight
    {
        public void TurnOn() => Console.WriteLine("Light is on");
        public void TurnOff() => Console.WriteLine("Light is off");
    }
    public interface ILight
    {
        void TurnOn();
        void TurnOff();
    }

    public class LightSwitch
    {
        private readonly ILight _bulb;

        public LightSwitch(ILight bulb)
        {
            _bulb = bulb;
        }

        public void SwitchOn() => _bulb.TurnOn();
        public void SwitchOff() => _bulb.TurnOff();
    }

    
    internal class Program
    {
        static void Main(string[] args)
        {
            var bulb = new LightSwitch(new GreenLightBulb());
        }
    }
}
