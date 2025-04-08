using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Buisness
{
    public class clsTestTypeBuisnessLayer
    {












        public static DataTable GetAllInfoTestType()
        {
            return clsTestTypeDataAccess.GetAllInfoTestType();
        }







    }
}
