using Autofac;
using ChinarDialysisCenter.DbAccess.Repositories;
using ChinarDialysisCenter.DbAccess.Repositories.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinarDialysisCenter.DbAccess.Modules
{
    public class DatabaseModule : Module
    {
        protected override void Load(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterType<ManageMembershipsRepo>().As<IManageMembershipsRepo>().InstancePerDependency();
            containerBuilder.RegisterType<ManageDonationsRepo>().As<IManageDonationsRepo>().InstancePerDependency();
        }
    }
}
