using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public enum Position : int
    {
        Developer = 1000,
        Hr = 1500, 
        Manager = 2000
    }

    public enum Experience
    {
        NotDeveloper = 0,
        Junior = 50, 
        Middle = 150,
        Senior = 300
    }

    public class Employee
    {
        private string _name;
        private string _second_name;
        private Position _position;
        private Experience _exp;
        private float _salary;
        private float _tax;

        public Employee(string name, string second_name, Position position, Experience experience)
        {
            _name = name;
            _second_name = second_name;
            _position = position;
            _exp = experience;
            Calculate();
        }

        private void Calculate()
        {
            _salary = (int)_position + ((int)_exp * 3f);
            _tax = _salary * 0.1f;
        }

        public Employee(string name, string second_name, Position position) : this(name, second_name, position, Experience.NotDeveloper) { }

        public override string ToString()
        {
            return $"Прізвище: {_second_name}\nІм'я: {_name}\nПосада: {_position.ToString()}\nОклад: {_salary}\nПодатковий збір: {_tax}\n";
        }
    }
}
