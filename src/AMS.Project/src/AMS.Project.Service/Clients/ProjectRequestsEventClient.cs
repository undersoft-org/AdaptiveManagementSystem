using Undersoft.AMS.Project.Service.Clients.Abstractions;

// *************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.AMS.Project.Service
// *************************************************

namespace Undersoft.AMS.Project.Service.Clients;

public class ProjectRequestsEventClient(Uri uri) : DataClient<IProjectRequestsEventStore>(uri) { }
