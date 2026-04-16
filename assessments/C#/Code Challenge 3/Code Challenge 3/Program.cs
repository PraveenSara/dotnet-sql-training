using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Challenge_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. 
            Console.Write("Enter no of matches : ");
            int matches = int.Parse(Console.ReadLine());

            CricketTeam team = new CricketTeam();
            team.PointCalculator(matches);

            //2.

            AppendFile af = new AppendFile();
            af.AppendingFile();

            //3.

            MobilePhone phone = new MobilePhone();

            RingtonePlayer ring = new RingtonePlayer();
            ScreenDisplay screen = new ScreenDisplay();
            VibrationMotor vib = new VibrationMotor();

            phone.OnRing += ring.Ringtone;
            phone.OnRing += screen.DisplayCaller;
            phone.OnRing += vib.Vibrate;

            phone.ReceiveCall();


            //
            Console.Read();
        }
    }
}
