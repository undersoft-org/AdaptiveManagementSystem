using Microsoft.OData.Edm;
using Undersoft.AMS.Service.Clients.Abstractions;

// *************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.AMS.Service
// *************************************************


namespace Undersoft.AMS.Service.Clients
{

    public class LogisticClient : OpenDataClient<ILogisticStore>
    {

        public LogisticClient(Uri serviceUri) : base(serviceUri) { }

        protected override IEdmModel OnModelCreating(IEdmModel builder)
        {

            return base.OnModelCreating(builder);
        }
    }
}