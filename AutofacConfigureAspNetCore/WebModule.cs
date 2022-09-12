using Autofac;
using AutofacConfigureAspNetCore.Services;

namespace AutofacConfigureAspNetCore
{
    public class WebModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
           builder.RegisterType<StudentService>().AsSelf();
            //builder.RegisterType<CourseModel>().AsSelf();
            //builder.RegisterType<EmployeeService>().As<IEmployeeService>().InstancePerLifetimeScope();

            base.Load(builder);
        }
    }
}
