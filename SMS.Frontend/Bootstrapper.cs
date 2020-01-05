using Autofac;
using Caliburn.Micro;
using Caliburn.Micro.Autofac;
using SMS.Frontend.ViewModels;
using SMS.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SMS.Frontend
{
    public class Bootstrapper : AutofacBootstrapper<IndexViewModel>
    {
        public Bootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<IndexViewModel>();
        }

        protected override void ConfigureBootstrapper()
        {
            base.ConfigureBootstrapper();
            EnforceNamespaceConvention = false;
        }

        protected override void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterModule<StudentModule>();
            builder.RegisterType<StudentsViewModel>();
        }
    }
}
