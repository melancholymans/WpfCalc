using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace WpfCalc
{
    internal class CalcViewModel:ViewModelBase
    {
        public string Label { get; private set; } = "0";
        public void NumCommand(object content)
        {
            Label = (string)content;
            OnPropertyChanged(nameof(Label));
        }
    }
    abstract class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(name));
        }
    }

}
