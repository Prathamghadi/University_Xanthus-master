﻿using University.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Repository.Interface
{
    public interface ISubCategoryRepository
    {
        IEnumerable<SubCategoryMaster> GetSubCategoryList();
        List<SubCategoryMaster> GetSubCategoryListById(Decimal id);
        SubCategoryMaster GetSubCategory(Decimal id);
        bool AddOrUpdateSubCategory(SubCategoryMaster model);
        bool DeleteSubCategory(Decimal id);
        IEnumerable<SubCategoryMaster> GetSubCategoryList(Decimal CategoryId);
        IEnumerable<SubCategoryMaster> GetSubCategoryListOnlyHaveProduct();
    }
}
