﻿using Microsoft.OData.Edm;

// *************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.AMS.Service
// *************************************************

using Undersoft.SDK.Service.Data.Store;

namespace Undersoft.AMS.Service.Clients
{
    /// <summary>
    /// The application client.
    /// </summary>
    public class ApplicationClient : DataClient<IDataStore>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationClient"/> class.
        /// </summary>
        /// <param name="serviceUri">The service uri.</param>
        public ApplicationClient(Uri serviceUri) : base(serviceUri) { }

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