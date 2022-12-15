using System.Runtime.InteropServices;

namespace RemoveDup
{
    internal static class Program
    {
        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            //pass arguments to the app using command line
            if (args.Length == 1)
            {
                string inputFilePath = args[0];
                string ext = Path.GetExtension(inputFilePath);
                string outputFilePath = string.IsNullOrEmpty(ext) ? inputFilePath + "_NoDuplicates.txt" : inputFilePath.Replace(ext, "_NoDuplicates" + ext);
                Console.WriteLine("Output File: {0}", outputFilePath);
                Form1.RemoveDuplicates(inputFilePath, outputFilePath, true);
                return;
            }
            else if (args.Length == 2)
            {
                string inputFilePath = args[0];
                string outputFilePath = args[1];
                Form1.RemoveDuplicates(inputFilePath, outputFilePath, true);
                return;
            }

            // hide console while using windows forms
            const int SW_HIDE = 0;
            var handle = GetConsoleWindow();
            ShowWindow(handle, SW_HIDE);

            //Run Windows forms
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}