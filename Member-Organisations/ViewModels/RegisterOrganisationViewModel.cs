using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Member_Organisations.ViewModels
{
    public class RegisterOrganisationViewModel
    {
        public List<Organisation> orgs { get; set; }
        public Organisation org { get; set; }

        public RegisterOrganisationViewModel()
        {
            orgs = new List<Organisation>();
            org = new Organisation();
        }
        public RegisterOrganisationViewModel(List<Organisation> orgs)
        {
            this.orgs = orgs;
            org = new Organisation();
        }
        public RegisterOrganisationViewModel(Organisation org)
        {
            orgs = new List<Organisation>();
            this.org = org;
        }
        public RegisterOrganisationViewModel(List<Organisation> orgs, Organisation org)
        {
            this.orgs = orgs;
            this.org = org;
        }
    }
}