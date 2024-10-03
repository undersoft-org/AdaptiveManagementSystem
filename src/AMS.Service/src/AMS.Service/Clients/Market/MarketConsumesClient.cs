using Microsoft.OData.Edm;
using Undersoft.AMS.Service.Clients.Abstractions;

// *************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.AMS.Market.Service
// *************************************************


namespace Undersoft.AMS.Service.Clients
{
    /// <summary>
    /// The service client.
    /// </summary>
    public class MarketConsumesClient : OpenDataClient<IMarketConsumesStore>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarketServiceClient"/>
        /// class.
        /// </summary>
        /// <param name="serviceUri">The service uri.</param>
        public MarketConsumesClient(Uri serviceUri) : base(serviceUri) { }

        /// <summary>
        /// On model creating.
        /// </summary>
        /// <param name="builder">The builder.</param>
        /// <returns>An <see cref="IEdmModel"/></returns>
        protected override IEdmModel OnModelCreating(IEdmModel builder)
        {

            return base.OnModelCreating(builder);
        }
    }
}