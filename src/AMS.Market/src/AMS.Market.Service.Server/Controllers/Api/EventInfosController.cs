﻿using Microsoft.AspNetCore.Mvc;

// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.AMS.Market.Service.Server
// ********************************************************

using Undersoft.SDK.Service.Data.Store;
using Undersoft.SDK.Service.Server.Controller.Api;

namespace Undersoft.AMS.Market.Service.Server.Controllers.Api;

/// <summary>
/// The events controller.
/// </summary>
[Route($"{StoreRoutes.ApiEventRoute}/EventInfo")]
public class EventInfosController : ApiEventController<long, IEventStore, Event, EventInfo>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EventInfosController"/> class.
    /// </summary>
    /// <param name="servicer">The servicer.</param>
    public EventInfosController(IServicer servicer) : base(servicer) { }
}