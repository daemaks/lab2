using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User
{
    public class User
    {
        public string _login;
        private string _name;
        private string _second_name;
        private int age;
        private readonly DateTime date;

        public User(string login, string name, string second_name, int age)
        {
            _login = login;
            _name = name;
            _second_name = second_name;
            this.age = age;
            date = DateTime.UtcNow;
        }

        public override string ToString()
        {
            return $"Логін: {_login}\nІм'я: {_name}\nПрізвище: { _second_name}\nВік: {age}\nДата заповнення анкети: {date.ToString("G")}";
        }
    }
}
