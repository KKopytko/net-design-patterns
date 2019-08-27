using System;
using System.IO;
using System.Text;

namespace Patterns.Examples.Singleton
{
    /*
        It has almost the same behavior as Console. Example only.
    */
    sealed public class MultiLogger
    {
        private static MultiLogger logger;

        private FileStream streamOutput;

        private MultiLogger()
        {
            streamOutput = new FileStream("output.txt", FileMode.OpenOrCreate);
        }

        ~MultiLogger()
        {
            if (streamOutput == null)
            {
                return;
            }

            // it may be already disposed
            try
            {
                streamOutput.Dispose();
            }
            catch (ObjectDisposedException) {}
        }

        public static MultiLogger GetLogger()
        {
            return logger ?? (logger = new MultiLogger());
        }

        public void WriteLine(string line)
        {
            Write($"{line}\n");
        }

        public void Write(string line)
        {
            Console.Write(line);

            var bytes = Encoding.UTF8.GetBytes(line);
            streamOutput.Write(bytes, 0, bytes.Length);
            streamOutput.Flush();
        }
    }
}