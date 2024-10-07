// *************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.AMS.Market.Service
// *************************************************

namespace Undersoft.AMS.Document.Service.Clients.Abstractions
{

    public interface IDocumentCenterStore : IDocumentFinancialStore, IDocumentCommercialStore, IDocumentLegalStore, IDocumentProductionalStore
    {
    }
}
