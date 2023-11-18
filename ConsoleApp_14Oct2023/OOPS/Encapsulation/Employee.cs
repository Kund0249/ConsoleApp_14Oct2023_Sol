using System;

namespace ConsoleApp_14Oct2023.OOPS.Encapsulation
{
    class Employee
    {
        private int _EmpId;
        private string _EmpName;
        private int _Salary;

        public int EmpId
        {
            get { return _EmpId; }

            set
            {
                if (value > 0)
                    _EmpId = value;
                else
                    throw new Exception("Invalid Value for Id Property");
            }
        }
        public string EmpName
        {
            get { return _EmpName; }
            set
            {
                if (!(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)))
                    _EmpName = value;
                else
                    throw new Exception("Invalid Value for Name Property");
            }
        }
        public int EmpSalary
        {
            get { return _Salary; }

            set
            {
                if (value > 0)
                    _Salary = value;
                else
                    throw new Exception("Invalid Value for Salary Property");
            }
        }

        //public void EmpId(int id)
        //{
        //    if (id > 0)
        //        _EmpId = id;
        //    else
        //        throw new Exception("Invalid Value for Id Property");
        //}
        //public void EmpName(string Name)
        //{
        //    if (!(string.IsNullOrEmpty(Name) || string.IsNullOrWhiteSpace(Name)))
        //        _EmpName = Name;
        //    else
        //        throw new Exception("Invalid Value for Name Property");

        //}

        //public void EmpSalary(int Salary)
        //{
        //    if (Salary > 0)
        //        _Salary = Salary;
        //    else
        //        throw new Exception("Invalid Value for Salary Property");
        //}

        //public int GetId()
        //{
        //    return _EmpId;
        //}
    }
}
