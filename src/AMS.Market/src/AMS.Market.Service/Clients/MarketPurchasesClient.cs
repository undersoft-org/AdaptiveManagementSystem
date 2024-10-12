using Microsoft.OData.Edm;
using Undersoft.AMS.Market.Service.Clients.Abstractions;

// *************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.AMS.Market.Service
// *************************************************


namespace Undersoft.AMS.Market.Service.Clients
{
    public class MarketPurchasesClient : DataClient<IMarketPurchasesStore>
    {
        public MarketPurchasesClient(Uri serviceUri) : base(serviceUri) { }

        protected override IEdmModel OnModelCreating(IEdmModel builder)
        {

            return base.OnModelCreating(builder);
        }
    }
}