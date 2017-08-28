﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webdictaat.Domain.Assignments;

namespace Webdictaat.Domain.User
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<DictaatDetails> OwnedDictaten { get; set; }

        public ICollection<DictaatContributer> ContributedDictaten { get; set; }

        public ICollection<AssignmentSubmission> AssignmentSubmissions { get; set; }

    }
}
