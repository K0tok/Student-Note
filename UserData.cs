using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Student_Note
{
    public class UserData
    {
        public int id { get; set; }
        public string last_name { get; set; }
        public string first_name { get; set; }
        public string? second_name { get; set; }
        public bool gender { get; set; }
        public string birthdate { get; set; }
        public string reg_date { get; set; }
        public string email { get; set; }
        public string phone_number { get; set; }
        public bool member_type { get; set; }
        /// <summary>
        /// id, last_name, first_name, second_name, sex, birthdate, reg_date, email, phone_number, member_type
        /// Конструктор
        /// </summary>
        public UserData(
            string id, 
            string last_name, 
            string first_name, 
            string? second_name, 
            string gender, 
            string birthdate, 
            string reg_date, 
            string email, 
            string phone_number, 
            string member_type
            ) 
        {
            try
            {
                this.id             = int.Parse(id);
                this.last_name      = last_name;
                this.first_name     = first_name;
                this.second_name    = second_name;
                this.gender         = gender == "1"; 
                this.birthdate      = birthdate;
                this.reg_date       = reg_date;
                this.email          = email;
                this.phone_number   = phone_number;
                this.member_type    = member_type == "1";
            } 
            catch 
            { MessageBox.Show("Ошибка в получении данных пользователя"); }
            
        }

        public string NewToString()
        {
            return $"{id}, {last_name}, {first_name}, {second_name}, {gender}, {birthdate}, {reg_date}, {email}, {phone_number}, {member_type}";
        } 
    }
}
