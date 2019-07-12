using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestEmployeeProject.DAL;
using System.Data;
using System.Data.SqlClient;

namespace TestEmployeeProject.BLL
{
    public class EmployeeBLL
    {
       //DAL.EmployeeDAL dal = new DAL.EmployeeDAL();
        //public string SetName(string nm)
        //{
        //    dal.SetName(nm);
        //    return dal.SetName(nm)+"BLL";
        //}
        public object GetData()
        {
            DAL.EmployeeDAL dl = new DAL.EmployeeDAL();
            return dl.GetData();
        }
        
        }
}
