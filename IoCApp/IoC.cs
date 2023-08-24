using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using System.Configuration;

namespace IoCApp
{
    public class IoC : NinjectModule
    {
        public override void Load()
        {
            Bind<IRegistrationService>().To<RegistrationService>();
            Bind<IDataBaseConnection>().ToMethod(x => 
            {
                //hier könnte bspw. die Configuration ausgwertet und der Connection String weitergereicht werden
                //var config = x.Kernel.Get<MyConfiguration> ();
                return new DataBaseConnection("Server=.;Database=IoC;Trusted_Connection=True;");
            }).InSingletonScope();
            Bind<IUserRepository>().To<UserRepository>();
            Bind<IMailService>().To<MailService>();
            Bind<Registration>().ToSelf();
        }
    }
    
}
