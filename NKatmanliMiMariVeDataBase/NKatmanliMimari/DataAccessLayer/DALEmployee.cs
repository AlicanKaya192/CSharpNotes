using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class DALEmployee
    {
        public static List<EntityEmployee> EmployeeList()
        {
            List<EntityEmployee> employeeList = new List<EntityEmployee>();
            SqlCommand command1 = new SqlCommand("SELECT * FROM TblInfo", Connection.connect);

            if(command1.Connection.State != ConnectionState.Open)
            {
                command1.Connection.Open();
            }

            SqlDataReader reader = command1.ExecuteReader();
            while (reader.Read())
            {
                EntityEmployee ent = new EntityEmployee();
                ent.Id = int.Parse(reader["ID"].ToString());
                ent.Name = reader["NAME"].ToString();
                ent.Surname = reader["SURNAME"].ToString();
                ent.City = reader["CITY"].ToString();
                ent.Duty = reader["DUTY"].ToString();
                ent.Salary = short.Parse(reader["SALARY"].ToString());
                employeeList.Add(ent);
            }

            reader.Close();
            return employeeList;
        }

        public static int EmployeeAdd(EntityEmployee e)
        {
            SqlCommand command2 = new SqlCommand("INSERT INTO TblInfo (NAME,SURNAME,CITY,DUTY,SALARY) VALUES (@p1,@p2,@p3,@p4,@p5)", Connection.connect);

            if (command2.Connection.State != ConnectionState.Open)
            {
                command2.Connection.Open();
            }

            command2.Parameters.AddWithValue("@p1", e.Name);
            command2.Parameters.AddWithValue("@p2", e.Surname);
            command2.Parameters.AddWithValue("@p3", e.City);
            command2.Parameters.AddWithValue("@p4", e.Duty);
            command2.Parameters.AddWithValue("@p5", e.Salary);

            return command2.ExecuteNonQuery();
        }

        public static bool EmployeeDelete(int p)
        {
            SqlCommand command3 = new SqlCommand("DELETE FROM TblInfo WHERE ID=@p1", Connection.connect);
            if (command3.Connection.State != ConnectionState.Open)
            {
                command3.Connection.Open();
            }
            command3.Parameters.AddWithValue("@p1", p);
            return command3.ExecuteNonQuery() > 0;
        }

        public static bool EmployeeUpdate(EntityEmployee e)
        {
            SqlCommand command4 = new SqlCommand("UPDATE TblInfo SET NAME=@p1, SURNAME=@p2, CITY=@p3, DUTY=@p4, SALARY=@p5 WHERE ID=@p6", Connection.connect);
            if (command4.Connection.State != ConnectionState.Open)
            {
                command4.Connection.Open();
            }
            command4.Parameters.AddWithValue("@p1", e.Name);
            command4.Parameters.AddWithValue("@p2", e.Surname);
            command4.Parameters.AddWithValue("@p3", e.City);
            command4.Parameters.AddWithValue("@p4", e.Duty);
            command4.Parameters.AddWithValue("@p5", e.Salary);
            command4.Parameters.AddWithValue("@p6", e.Id);
            return command4.ExecuteNonQuery() > 0;
        }
    }
}
