// *************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.AMS.Service
// *************************************************


using Undersoft.AMS.Document.Service.Clients.Abstractions;

namespace Undersoft.AMS.Service.Clients.Abstractions
{
    public interface IDocumentStore : IDocumentCommercialStore, IDocumentFinancialStore, IDocumentLegalStore, IDocumentLogisticalStore, IDocumentProductionalStore
    {
    }
}
