using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace SpeechSynthesizerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SpeechSynthesizer Robot = new SpeechSynthesizer();
            Robot.SelectVoiceByHints(VoiceGender.Female);
            Robot.Volume = 70;
            Robot.Rate = -1;

            Robot.SpeakAsync("Hello, what is your name?");
            Console.WriteLine("Hello, what is your name?");
            var name = Console.ReadLine();

            Robot.SpeakAsync("Hello " + name);
            Console.WriteLine("Hello " + name);
            Console.ReadLine();

            Robot.SetOutputToWaveFile(@"C:\Users\a2aka\app.wav");
            Robot.Speak("Application is complete, please vist us again");
            

        }
    }
}
