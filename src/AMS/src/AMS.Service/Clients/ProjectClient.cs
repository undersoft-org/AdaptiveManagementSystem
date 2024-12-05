using Microsoft.OData.Edm;
using Undersoft.AMS.Service.Clients.Abstractions;
using Undersoft.AMS.Service.Contracts;
using Undersoft.SDK.Service.Data.Remote;

// *************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.AMS.Service
// *************************************************

namespace Undersoft.AMS.Service.Clients
{
    public class ProjectClient : DataClient<IProjectStore>
    {
        public ProjectClient(Uri serviceUri) : base(serviceUri) { }

        protected override IEdmModel OnModelCreating(IEdmModel builder)
        {
            this.RemoteSetToSet<Activity, Resource>(rl => rl.RightEntityId, k => k.Id)
                .RemoteSetToSet<Activity, Participant>(rl => rl.RightEntityId, k => k.Id)
                .RemoteOneToOne<Item, Participant>(o => o.ParticipantId, t => t.Id)
                .RemoteOneToOne<Item, Subject>(o => o.SubjectId, t => t.Id);

            return base.OnModelCreating(builder);
        }
    }
}
