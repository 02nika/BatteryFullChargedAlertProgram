using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    static class MainVoice
    {
        public static void Start(int rushNumber)
        {
            //SpeechSynthesizer synth = new SpeechSynthesizer();
            //synth.Volume = 100;
            
            // დიქშენერიში ვინახავთ მთლიან ინფორმაციას.
            Dictionary<string, object> info = Batteries.BatteryInformation();
            object value = info["EstimatedChargeRemaining"];
            // ინტში ვინახავთ მხოლოდ ბატარიის პროცენტულობას
            int value2 = int.Parse(value.ToString());
                            
            while (value2 < rushNumber)
            {
                Thread.Sleep(2000);

                //ეს 4 კოდი ლაინი ინფორმაციას ანახლებს 
                info = Batteries.BatteryInformation();
                value = info["EstimatedChargeRemaining"];
                value2 = int.Parse(value.ToString());
            }

        }
    }
}
