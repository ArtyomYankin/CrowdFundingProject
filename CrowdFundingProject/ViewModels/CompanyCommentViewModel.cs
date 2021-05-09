using CrowdFundingProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdFundingProject.ViewModels
{
    public class CompanyCommentViewModel
    {
        public string Title { get; set; }
        public List<CompanyComment> ListOfComments { get; set; }
        public string Comment { get; set; }
        public int CompanyId { get; set; }
        public int Rating { get; set; }
    }
}
