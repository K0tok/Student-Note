using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Note.Menu
{
    public class User
    {
        public string id { get; set; }
        public string last_name { get; set; }
        public string first_name { get; set; }
        public string second_name { get; set; }
        public string sex { get; set; }
        public string birthdate { get; set; }
        public string reg_date { get; set; }
        public string email { get; set; }
        public string phone_number { get; set; }
        public string member_type { get; set; }
        public User(string id, string last_name, string first_name, string second_name, string sex, string birthdate, string reg_date, string email, string phone_number, string member_type) 
        { 
            this.id = id;
            this.last_name = last_name;
            this.first_name = first_name;   
            this.second_name = second_name;
            this.sex = sex;
            this.birthdate = birthdate;
            this.reg_date = reg_date;
            this.email = email;
            this.phone_number = phone_number;
            this.member_type = member_type;
        }
    }
}
