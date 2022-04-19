using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsumingEvents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrimes_Click(object sender, EventArgs e)
        {
            lblNumberOfPrimes.Text = "Unknown";
            //lblNumberOfPrimes.Text = HowManyPrimeNumbers(txtNumber.Text).ToString();
            BackgroundWorker bgw = new BackgroundWorker();
            bgw.WorkerReportsProgress = true;

            //bgw.DoWork += Bgw_DoWork;
            //bgw.RunWorkerCompleted += Bgw_RunWorkerCompleted;
            //bgw.ProgressChanged += Bgw_ProgressChanged;

            bgw.DoWork += (o,e2) => { 
                BackgroundWorker bgWorker = sender as BackgroundWorker; 
                e2.Result = HowManyPrimeNumbers(txtNumber.Text, bgw); 
                };
            bgw.RunWorkerCompleted += (o,e2) => lblNumberOfPrimes.Text = ((int)e2.Result).ToString();
            bgw.ProgressChanged += (o,e2) => progressBar1.Value = e2.ProgressPercentage;

            bgw.RunWorkerAsync();
        }

        //private void Bgw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        //{
        //    progressBar1.Value = e.ProgressPercentage;
        //}

        //private void Bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        //{
        //    lblNumberOfPrimes.Text = ((int)e.Result).ToString();
        //}

        //private void Bgw_DoWork(object sender, DoWorkEventArgs e)
        //{
        //    BackgroundWorker bgWorker = sender as BackgroundWorker;
        //    e.Result = HowManyPrimeNumbers(txtNumber.Text, bgWorker);
        //}

        private static int HowManyPrimeNumbers(string strNumber, BackgroundWorker bgw)
        {
            long number;
            int numberOfPrimes = 0;
            if (long.TryParse(strNumber, out number))
            {

                for (int j = 3; j <= number; j++)
                {
                    if (IsPrime(j))
                    {
                        Console.WriteLine(j);
                        numberOfPrimes++;
                    }
                    bgw.ReportProgress((int)((j * 100) / number));
                }
            }
            return numberOfPrimes;
        }

        public static bool IsPrime(long number)
        {
            if (number == 1) return false;
            if (number == 2) return true;

            if (number % 2 == 0) return false;

            for (int i = 3; i < number / 2; i += 2)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}
