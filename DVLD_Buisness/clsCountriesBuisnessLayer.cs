﻿using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Buisness
{
    public class clsCountriesBuisnessLayer
    {










        public static DataTable GetAllCountries()
        {
            return clsCountriesDataAccess.GetAllCountries();
        }








    }
}
