using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using System.Data.SqlClient;

namespace TestEmployeeProject.Controllers
{

  
    public class TestEmployeeProjectController : ApiController
    {
       
       
        //public string SetName(string nm)
        //{
        //    string str = nm;
        //    bll.SetName(str);
        //    return bll.SetName(str);
        //}
        //public string TestEmployeeProject()
        //{

        //    return dal1.BLL();
        //}
         [Route("api/test")]
        [HttpPost]
        public object GetData()
        {
            BLL.EmployeeBLL bll = new BLL.EmployeeBLL();
            return bll.GetData();
        }
    }
}
