using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace LogicLayer
{
    public class LogicEmployee
    {
        public static List<EntityEmployee> LLEmployeeList()
        {
            return DALEmployee.EmployeeList();
        }

        public static int LLEmployeeAdd(EntityEmployee e)
        {
            if(e.Name != "" && e.Surname != "" && e.City != "" && e.Duty != "" && e.Salary >= 10000 && e.Name.Length >= 2)
            {   
                return DALEmployee.EmployeeAdd(e);
            }
            else
            {
                return -1;
            }
        }

        public static bool LLEmployeeDelete(int p)
        {
            if (p > 0)
            {
                return DALEmployee.EmployeeDelete(p);
            }
            else
            {
                return false;
            }
        }

        public static bool LLEmployeeUpdate(EntityEmployee e)
        {
            if (e.Id > 0 && e.Name != "" && e.Surname != "" && e.City != "" && e.Duty != "" && e.Salary >= 10000 && e.Name.Length >= 2)
            {
                return DALEmployee.EmployeeUpdate(e);
            }
            else
            {
                return false;
            }
        }
    }
}
