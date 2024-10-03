// *************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.AMS
// *************************************************

namespace Undersoft.AMS.Domain.Entities.Enums
{
    /// <summary>
    /// The contact types.
    /// </summary>
    public enum ActivityType
    {
        None,
        Sale,
        SaleOrder,
        SaleOffer,
        Shipment,
        ShipmentOffer,
        ShipmentOrder,
        Purchase,
        PurchaseOrder,
        PurchaseOffer,
        SaleInvoice,
        PurchaseInvoice,
        SalePayment,
        PurchasePayment,
        Delivery,
        DeliveryOrder,
        DeliveryOffer,
        DeliveryInvoice,
        DeliveryPayment,
        ShipmentPayment,
        ShipmentInvoice,
        ShipmentTask,
        DeliveryTask,
        SaleTask,
        PurchaseTask
    }
}