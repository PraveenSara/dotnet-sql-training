using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Challenge_3
{
    public class MobilePhone
    {
        public delegate void RingEventHandler();
        public event RingEventHandler OnRing;

        public void ReceiveCall()
        {
            Console.WriteLine("Someone is calling..");

            OnRing?.Invoke();
        }
    }

    internal class RingtonePlayer
    {
        public void Ringtone()
        {
            Console.WriteLine("Ringtone Playing..");
        }
    }

    internal class ScreenDisplay
    {
        public void DisplayCaller()
        {
            Console.WriteLine("Displaying caller information..");
        }
    }

    internal class VibrationMotor
    {
        public void Vibrate()
        {
            Console.WriteLine("Phone is vibrating..");
        }
    }
}
