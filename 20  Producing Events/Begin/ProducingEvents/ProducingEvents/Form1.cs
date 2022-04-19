using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
            Console.WriteLine($"Main Thread = {Thread.CurrentThread.ManagedThreadId}");
            lblNumberOfPrimes.Text = "Unknown";
            BackgroundWorker bgw = new BackgroundWorker();

            bgw.DoWork += Bgw_DoWork;
            bgw.RunWorkerCompleted += Bgw_RunWorkerCompleted;

            bgw.RunWorkerAsync();
        }

        private void Bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Console.WriteLine($"Completion Thread = {Thread.CurrentThread.ManagedThreadId}");
            lblNumberOfPrimes.Text = ((int)e.Result).ToString();
        }

        private void Bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            Console.WriteLine($"DoWork Thread = {Thread.CurrentThread.ManagedThreadId}");
            e.Result = HowManyPrimeNumbers(txtNumber.Text);
        }

        private static int HowManyPrimeNumbers(string strNumber)
        {
            long number;
            int numberOfPrimes = 0;
            if (long.TryParse(strNumber, out number))
            {

                for (int j = 3; j <= number; j++)
                {
                    if (IsPrime(j))
                    {
                        //Console.WriteLine(j);
                        numberOfPrimes++;
                    }
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
