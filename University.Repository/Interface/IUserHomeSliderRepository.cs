﻿using University.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Repository.Interface
{
   public interface IUserHomeSliderRepository
    {
        List<HomeSlider> GetProductUserGuideList();
        //List<ProductUserGuide> GetSearchUserGuides(string SearchTxt);
    }
}
