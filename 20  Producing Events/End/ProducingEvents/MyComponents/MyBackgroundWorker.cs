using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace MyComponents
{
    public class MyBackgroundWorker
    {
        public event EventHandler<DoWorkEventArgs> DoWork;
        public event EventHandler<RunWorkerCompletedEventArgs> RunWorkerCompleted;

        public void RunWorkerAsync()
        {
            DoWorkEventArgs e = new DoWorkEventArgs(null);
            //DoWork?.Invoke(this,e);
            //RunWorkerCompleted?.Invoke(this, new RunWorkerCompletedEventArgs(e.Result,null, false) );

            Task.Run(() => {
                DoWork.Invoke(this, e);
            }).ContinueWith(t => RunWorkerCompleted.Invoke(this, new RunWorkerCompletedEventArgs(e.Result, null, false)),
                                        TaskScheduler.FromCurrentSynchronizationContext());
        }
    }
}
