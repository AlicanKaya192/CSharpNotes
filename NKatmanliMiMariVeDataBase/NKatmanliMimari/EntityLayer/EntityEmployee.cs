using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityEmployee
    {
        // Alan seçildikden sonra ctrl + R + E ile otomatik olarak property oluşturulabilir.

        private int id;
        private string name;
        private string surname;
        private string city;
        private string duty;
        private short salary;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string City { get => city; set => city = value; }
        public string Duty { get => duty; set => duty = value; }
        public short Salary { get => salary; set => salary = value; }
    }
}
