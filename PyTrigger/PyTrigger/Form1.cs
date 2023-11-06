using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PyTrigger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PB_Browse_Click(object sender, EventArgs e)
        {
            // Create an instance of the OpenFileDialog class.
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select Python File";
            openFileDialog.Filter = "Python Files|*.py";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                TB_PyDirPath.Text = selectedFilePath;
            }
        }

        private void CB_Record_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_Record.Checked)
            {
                backgroundWorker1.RunWorkerAsync();
            }
            else
            {
                backgroundWorker1.CancelAsync();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            while (!worker.CancellationPending)
            {
                // Get the path to the Python script
                string pythonScriptPath = TB_PyDirPath.Text;

                // You can add arguments to the Python script here if needed
                string arguments = "";

                // Create a process to run the Python script
                Process process = new Process();
                process.StartInfo.FileName = "python.exe"; // Use the path to your Python interpreter
                process.StartInfo.Arguments = $"{pythonScriptPath} {arguments}";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.CreateNoWindow = true;

                // Set up event handlers for output and completion
                process.OutputDataReceived += new DataReceivedEventHandler((senderProcess, output) =>
                {
                    if (!String.IsNullOrEmpty(output.Data))
                    {
                        // Output from the Python script is available in output.Data
                        // You can display it in your application or handle it as needed
                    }
                });

                process.Exited += new EventHandler((senderProcess, exitEvent) =>
                {
                    // The Python script has exited
                });

                process.Start();
                process.BeginOutputReadLine();
                // Sleep for a short time before the next update
                Thread.Sleep(Convert.ToInt32(TB_PlottingTime.Text) * 1000); // Sleep for 1 second
            }
        }
    }
}