using Cirrious.CrossCore.IoC;

namespace CommandParameterInEventTrigger.CorePCL
{
    public class App : Cirrious.MvvmCross.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();
				
            RegisterAppStart<CorePCL.ViewModels.FirstViewModel>();
        }
    }
}