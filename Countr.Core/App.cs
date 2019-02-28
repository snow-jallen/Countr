using Countr.Core.ViewModels;
using MvvmCross.IoC;
using MvvmCross.ViewModels;

namespace Countr.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            CreatableTypes()
                .EndingWith("Repository")
                .AsInterfaces()
                .RegisterAsLazySingleton();
            
            RegisterAppStart<CountersViewModel>();
        }
    }
}
