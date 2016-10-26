using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Member_Organisations.Models
{
    public class RegisterMember
    {
        public List<Organisation> orgs;
        public Member member;
        public string OrganisationName;

        public RegisterMember(List<Organisation> orgs)
        {
            this.orgs = orgs;
            member = new Member();
        }
    }
}