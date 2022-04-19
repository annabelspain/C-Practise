using System;
using System.Collections.Generic;
using System.Text;

namespace DI2
{
    class Controller
    {
        ViewModel viewModel { get; }
        public Controller(ViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        public void ControllerAction()
        {
            viewModel.ViewModelAction();
        }

    }

    class ViewModel
    {
        Model model { get; }
        public ViewModel(Model model)
        {
            this.model = model;
        }

        public void ViewModelAction()
        {
            model.ModelAction();
        }
    }

    class Model
    {
        ILog log { get; }
        public Model(ILog log)
        {
            this.log = log;
        }

        internal void ModelAction()
        {
            // do something
            log.Write("Done something");
        }
    }
}
