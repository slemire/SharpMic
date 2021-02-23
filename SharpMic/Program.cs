using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SharpMic
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2) {
                Console.WriteLine(@"[!] Usage: SharpMic.exe <output_file (.wav)> <duration (sec)>");
                return;
            }

            int duration = int.Parse(args[1]) * 1000;

            Recorder myRecorder = new Recorder();            
            myRecorder.StartRecording(args[0]);
            Console.WriteLine("[+] Waiting " + args[1] + " seconds...");
            Thread.Sleep(duration);
            myRecorder.StopRecording();
        }
    }
}
