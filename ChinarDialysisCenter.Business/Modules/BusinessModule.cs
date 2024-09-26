using Autofac;
using ChinarDialysisCenter.Business.Implementation;
using ChinarDialysisCenter.Business.Interfaces;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinarDialysisCenter.Business.Modules
{
    public class BusinessModule : Module
    {
        protected override void Load(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterType<ManageMemberships>().As<IManageMemberships>().InstancePerDependency();
            containerBuilder.RegisterType<ManageDonations>().As<IManageDonations>().InstancePerDependency();
        }
    }
}
