using System;
using System.Speech.Synthesis;
namespace SpeechSynthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Speak(Console.ReadLine());
        }
    }
}
