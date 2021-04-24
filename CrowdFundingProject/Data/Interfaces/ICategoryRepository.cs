using CrowdFundingProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdFundingProject.Data.Interfaces
{
    public class ICategoryRepository
    {
        IEnumerable<Category> Categories { get; }
    }
}
