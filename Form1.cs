using System.Diagnostics;

namespace RemoveDup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ProceedBtn_Click(object sender, EventArgs e)
        {
            RemoveDuplicates(InputRTB.Text, OutputRTB.Text, false);
        }

        public static void RemoveDuplicates(string inputFilePath, string outputFilePath, bool isConsoleApp)
        {
            if (!File.Exists(inputFilePath))
            {
                string errorMessage = "Error, please check the input file path is correct to remove duplicate lines.";
                PrintMessage(errorMessage, isConsoleApp);
                return;
            }
            else if (string.IsNullOrEmpty(outputFilePath))
            {
                string errorMessage = "Error, please choose a destination file path to save new file without duplicate lines.";
                PrintMessage(errorMessage, isConsoleApp);
                return;
            }

            try
            {
                var sw = new Stopwatch(); sw.Start();
                string content = File.ReadAllText(inputFilePath);
                List<string> repeatedList = content.Split(new string[] { Environment.NewLine }, StringSplitOptions.None).ToList();
                List<string> distinctList = repeatedList.Distinct().ToList();
                File.WriteAllLines(outputFilePath, distinctList.ToArray());
                sw.Stop();
                var elapased = sw.Elapsed;
                string message = $"File is created successfully in {elapased.TotalSeconds:0.0000} seconds.";
                PrintMessage(message, isConsoleApp);
            }
            catch (Exception exp)
            {
                string errorMessage = "Error. " + exp.Message;
                PrintMessage(errorMessage, isConsoleApp);
            }
            finally
            { GC.Collect(); }
        }

        private static void PrintMessage(string message, bool isConsoleApp)
        {
            if (isConsoleApp)
                Console.WriteLine(message);
            else
                MessageBox.Show(message);
        }

        private void InputBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                InputRTB.Text = openFileDialog1.FileName;

                string ext = Path.GetExtension(InputRTB.Text);
                OutputRTB.Text = openFileDialog1.FileName.Replace(ext, "_NoDuplicates" + ext);
            }
        }

        private void OutputBrowse_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "All Files (*.*)|*.*";
            DialogResult result = saveFileDialog1.ShowDialog();
            saveFileDialog1.InitialDirectory = InputRTB.Text;

            if (result == DialogResult.OK)
            {
                OutputRTB.Text = saveFileDialog1.FileName;
            }
        }
    }
}