using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Member_Organisations.ViewModels
{
    public class RegisterMemberViewModel
    {
        public List<Organisation> orgs { get; set;  }
        public Member member { get; set;  }

        public RegisterMemberViewModel()
        {
            orgs = new List<Organisation>();
            member = new Member();
        }
        public RegisterMemberViewModel(List<Organisation> orgs)
        {
            this.orgs = orgs;
            member = new Member();
        }
        public RegisterMemberViewModel(Member member)
        {
            orgs = new List<Organisation>();
            this.member = member;
        }
        public RegisterMemberViewModel(List<Organisation> orgs, Member member)
        {
            this.orgs = orgs;
            this.member = member;
        }

    }
}