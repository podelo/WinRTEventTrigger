using Cirrious.MvvmCross.ViewModels;
using Cirrious.MvvmCross.WindowsStore.Platform;
using Windows.UI.Xaml.Controls;

namespace CommandParameterInEventTrigger.WinRT
{
    public class Setup : MvxStoreSetup
    {
        public Setup(Frame rootFrame) : base(rootFrame)
        {
        }

        protected override IMvxApplication CreateApp()
        {
          //  return new Core.App(); With DLL WinRT
            return new CorePCL.App(); // With PCL
        }
    }
}