using System.Windows.Input;
using Cirrious.MvvmCross.ViewModels;
using Windows.UI.Xaml.Controls;

namespace CommandParameterInEventTrigger.Core.ViewModels
{
    public class FirstViewModel : MvxViewModel
    {
        public string _First = string.Empty;
        public string First
        {
            get
            {
                return _First;
            }

            set
            {
                if (_First == value)
                    return;

                _First = value;
                RaisePropertyChanged(() => First);
            }
        }

        public string _Second = string.Empty;
        public string Second
        {
            get
            {
                return _Second;
            }

            set
            {
                if (_Second == value)
                    return;

                _Second = value;
                RaisePropertyChanged(() => Second);
            }
        }


        public ICommand UpdateText
        {
            get
            {
                return new MvxCommand<object>((textSearch) =>
                    {
                        Second = ((TextBox)textSearch).Text;
                    });
            }
        }

    }
}
