using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Member_Organisations.ViewModels
{
    public class IndexViewModel
    {
        public List<Organisation> orgs { get; set; }
        public List<Member> members { get; set; }

        public IndexViewModel()
        {
            orgs = new List<Organisation>();
            members = new List<Member>();
        }
        public IndexViewModel(List<Organisation> orgs)
        {
            this.orgs = orgs;
            members = new List<Member>();
        }
        public IndexViewModel(List<Member> members)
        {
            orgs = new List<Organisation>();
            this.members = members;
        }
        public IndexViewModel(List<Organisation> orgs, List<Member> members)
        {
            this.orgs = orgs;
            this.members = members;
        }
    }
}