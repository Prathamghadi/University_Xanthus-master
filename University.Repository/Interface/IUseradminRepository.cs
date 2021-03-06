﻿using University.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Repository.Interface
{
    public interface IUseradminRepository
    {
        IEnumerable<Login_tbl> GetUserList();
        //CategoryMaster GetCategory(Decimal id);
        //bool AddOrUpdateCategory(CategoryMaster model);
        bool DeleteUser(Decimal id);
        //List<CategoryMaster> GetCategoryMasters();
        //List<SmartSerach_Result> SmartSearch(string freeText);
        (bool, bool) RegisterUser(Login_tbl Login_tbl);
        (bool, bool) SaveEditUserDetails(Login_tbl Login_tbl);
        List<Customer> GetCustomerList();
        Login_tbl EditUser(int id);
    }
}
