using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace NCSolution.Modules
{
    public class ServiceModule : Autofac.Module
    {

        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterAssemblyTypes(Assembly.Load("NCSolution.BussinessLayer"))

                      .Where(t => t.Name.EndsWith("Service"))

                      .AsImplementedInterfaces()

                      .InstancePerLifetimeScope();

        }

    }
}