using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;
namespace AsyncAwaitDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Task<string> mytask = new Task<string>(LongRunnintTask);
            mytask.Start();

            string result = await mytask;

            label1.Text = result;
            //LongRunnintTask();
        }

        string LongRunnintTask()
        {
            Thread.Sleep(6000);
            return "Returned from long running task";
        }
    }
}
