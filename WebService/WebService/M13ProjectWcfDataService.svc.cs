//------------------------------------------------------------------------------
// <copyright file="WebDataService.svc.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Data.Services;
using System.Data.Services.Common;
using System.Data.Services.Providers;
using System.Linq;
using System.ServiceModel.Web;
using System.Web;

namespace WebService
{
    public class M13ProjectWcfDataService : EntityFrameworkDataService<m13_projectEntities1>
    {
        // This method is called only once to initialize service-wide policies.
        public static void InitializeService(DataServiceConfiguration config)
        {
            //config.SetEntitySetAccessRule("Comanda", EntitySetRights.AllRead);
            //config.SetEntitySetAccessRule("Producte", EntitySetRights.All);
            //config.SetEntitySetAccessRule("Usuari", EntitySetRights.All);
            //config.SetEntitySetAccessRule("Comercial", EntitySetRights.All);
            //config.SetEntitySetAccessRule("Administrador", EntitySetRights.All);
            //config.SetEntitySetAccessRule("Localitzacio", EntitySetRights.AllRead);
            //config.SetEntitySetAccessRule("Comanda_Producte", EntitySetRights.AllRead);
            //config.SetEntitySetAccessRule("Client", EntitySetRights.AllRead);
            //config.SetEntitySetAccessRule("Categoria", EntitySetRights.All);
            //config.SetEntitySetAccessRule("ProducteLog", EntitySetRights.AllRead);
            //config.SetEntitySetAccessRule("CategoriaLog", EntitySetRights.AllRead);

            config.SetEntitySetAccessRule("*", EntitySetRights.All);

            // config.SetServiceOperationAccessRule("MyServiceOperation", ServiceOperationRights.All);
            config.SetServiceOperationAccessRule("ara", ServiceOperationRights.AllRead);
            config.DataServiceBehavior.MaxProtocolVersion = DataServiceProtocolVersion.V3;
            config.UseVerboseErrors = true;
        }

        [WebGet]
        public DateTime ara()
        {
            return DateTime.Now;
        }
    }
}
