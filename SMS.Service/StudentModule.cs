using Autofac;
using MySql.Data.MySqlClient;
using SMS.Service.DatabaseContext;
using SMS.Service.DbProvider;
using SMS.Service.Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Service
{
    public class StudentModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.Register(options =>
            {
                var connectionString = ConfigurationManager.AppSettings["connectionStrings"];

                var connection = new MySqlConnection(connectionString);
                return new StudentContext(connection);
            }).As<IStudentContext>().InstancePerLifetimeScope();

            builder.RegisterType<StudentService>().As<IStudentService>().InstancePerLifetimeScope();
        }
    }
}
