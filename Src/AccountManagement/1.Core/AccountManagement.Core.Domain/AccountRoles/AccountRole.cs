using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zamin.Core.Domain.Entities;

namespace AccountManagement.Core.Domain.AccountRoles
{
    class AccountRole : AggregateRoot
    {
        public long AccountId { get; set; }
        public long RoleId { get; set; }
    }

    //TODO: Hamed
    //contructor protected
}
