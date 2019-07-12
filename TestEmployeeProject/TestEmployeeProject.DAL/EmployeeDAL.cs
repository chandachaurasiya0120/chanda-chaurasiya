using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TestEmployeeProject.DAL
{
    public class EmployeeDAL
    {
      TestEmployeeProject.DTO.EmployeeDTO dto= new TestEmployeeProject.DTO.EmployeeDTO ();
        SqlConnection con = new SqlConnection(@"Data Source=CS51-PC\SQLEXPRESS;Initial Catalog=TestDb;Integrated Security=True");
        public List<DTO.EmployeeDTO> GetData()
        {
           // DataTable dt = new DataTable();
            con.Open();
            //SqlCommand cmd = new SqlCommand("Insert into EmployeeDetails(EmployeeName,EmployeeAddress,EmployeeSalary) values('Nilesh','surat',10000)", con);
            SqlCommand cmd = new SqlCommand("Select EmployeeName,EmployeeAddress,EmployeeSalary from EmployeeDetails ", con);
            //SqlDataAdapter sda = new SqlDataAdapter(cmd);
            SqlDataReader dr = cmd.ExecuteReader();
            List<DTO.EmployeeDTO> employee = new List<DTO.EmployeeDTO>();
            if (dr.HasRows)
            {
                while(dr.Read())
                {
                    DTO.EmployeeDTO obj = new DTO.EmployeeDTO();
                    obj.Name = dr.GetString(0);
                    obj.Address = dr.GetString(1);
                    employee.Add(obj);
                }
            }
            con.Close();
            return employee;
        }
        //public string SetName(string nm)
        //{

        //    DTO.Name = nm + "chanda";
       // object.name
        //    return DTO.Name + "DAL";
        //}

    }
    
}
