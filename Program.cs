using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
    class Program
    {
        static void Main(string[] args)
        {
            IList<Employee> employees = new List<Employee>()
            {
            new Employee() { EmpId = 1, FirstName = "Jhon", LastName = "Abraham",JoiningDate="01-JAN-13 12.00.00 AM", Salary = 1000000, Dept = "Banking" },
            new Employee() { EmpId = 2, FirstName = "Michael", LastName = "Clarke",JoiningDate="01-JAN-13 12.00.00 AM", Salary = 800000, Dept = "Insurance" },
            new Employee() { EmpId = 3, FirstName = "Roy", LastName = "Thomas",JoiningDate="01-FEB-13 12.00.00 AM", Salary = 700000, Dept = "Banking" },
            new Employee() { EmpId = 4, FirstName = "Tom", LastName = "Jose",JoiningDate="01-FEB-13 12.00.00 AM", Salary = 600000, Dept = "Insurance" },
            new Employee() { EmpId = 5, FirstName = "Jerry", LastName = "Pinto",JoiningDate="01-FEB-13 12.00.00 AM", Salary = 650000, Dept = "Insurance" },
            new Employee() { EmpId = 6, FirstName = "Philip", LastName = "Mathew",JoiningDate="01-JAN-13 12.00.00 AM", Salary = 750000, Dept = "Services" },
            new Employee() { EmpId = 7, FirstName = "TestName1", LastName = "123",JoiningDate="01-JAN-13 12.00.00 AM", Salary = 650000, Dept = "Services" },
            new Employee() { EmpId = 8, FirstName = "TestName2", LastName = "Lname%",JoiningDate="01-FEB-13 12.00.00 AM", Salary =600000, Dept = "Insurance" }
            };

            IList<Incentive> incentives = new List<Incentive>()
            {
                new Incentive(){ EmpRefId=1,IncentiveDate="01-02-13",IncentiveAmount=5000},
                new Incentive(){ EmpRefId=2,IncentiveDate="01-02-13",IncentiveAmount=3000},
                new Incentive(){ EmpRefId=3,IncentiveDate="01-02-13",IncentiveAmount=4000},
                new Incentive(){ EmpRefId=1,IncentiveDate="01-01-13",IncentiveAmount=4500},
                new Incentive(){ EmpRefId=2,IncentiveDate="01-01-13",IncentiveAmount=3500}
            };

            IEnumerable<Employee> q1 = from e in employees
                      select e;
            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp.EmpId + ' ' + emp.FirstName+' '+emp.LastName+' '+emp.Salary+' '+emp.Dept);
            }

            var q2 = from e in employees
                     select e.FirstName + e.LastName;
            foreach (var emp in q2)
            {
                Console.WriteLine(emp);
            }

            var q3=from e in employees
                   select new { EmployeeName = e.FirstName };
            foreach(var emp in q3)
            {
                Console.WriteLine(emp);
            }

            var q4 = from e in employees
                     select e.FirstName; 
            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp.FirstName.ToUpper());
            }

            var q5 = from e in employees
                     select e.FirstName;
            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp.FirstName.ToLower());
            }

            var q6 = employees.Select(e => e.Dept).Distinct();
            foreach (var emp in q6)
            {
                Console.WriteLine(emp);
            }

            var q7 = from e in employees
                     select new { FirstName = e.FirstName.Substring(0, 3) };
            foreach (var emp in q7)
            {
                Console.WriteLine(emp);
            }

            var q8 = employees.Where(st => st.FirstName.ToLower().Contains("o"));
            foreach (var std in q8)
            {
                Console.WriteLine(std.FirstName);
                Console.WriteLine(std.FirstName.ToLower().IndexOf("o"));
            }

            //q9
            foreach (var std in q8)
            {
                Console.WriteLine(std.FirstName.TrimEnd());
            }

            //q10
            foreach (var std in q8)
            {
                Console.WriteLine(std.FirstName.TrimStart());
            }

            //q11
            foreach (Employee emp in q1)
            {
                Console.WriteLine(emp.FirstName);
                Console.WriteLine(emp.FirstName.Length);
            }

            //q12
            foreach (Employee emp in q1)
            {
                Console.WriteLine(emp.FirstName.ToLower().Replace("o", "$"));
            }

            //q13
            foreach (Employee emp in q1)
            {
                var e = string.Join("_", emp.FirstName, emp.LastName);
                Console.WriteLine(e);
            }

            //q14
            IEnumerable<Employee> q14 = from e in employees
                                        orderby e.FirstName ascending
                                        select e;
            foreach (Employee emp in q14)
            { 
                Console.WriteLine(emp.FirstName);
            }

            //q15
            IEnumerable<Employee> q15 = from e in employees
                                        orderby e.FirstName descending
                                        select e;
            foreach (Employee emp in q15)
            {
                Console.WriteLine(emp.FirstName);
            }

            //q16
            IEnumerable<Employee> q16 = from e in employees
                                        orderby e.Salary descending
                                        select e;
            foreach (Employee emp in q16)
            {
                Console.WriteLine(emp.FirstName);
                Console.WriteLine(emp.Salary);
            }

            //q17
            var q17 = from e in employees
                      where e.FirstName == "John"
                      select e;
            foreach (var emp in q17)
            {
                Console.WriteLine(emp.FirstName);
            }

            //q18
            var q18 = from e in employees
                       where e.FirstName == "John" || e.FirstName == "Roy"
                       select e;
            foreach (var emp in q18)
            {
                Console.WriteLine(emp.FirstName);
            }

            //q19
            var q19 = from e in employees
                       where e.FirstName != "John" && e.FirstName != "Roy"
                       select e;
            foreach (var emp in q19)
            {
                Console.WriteLine(emp.FirstName);
            }

            //q20
            var q20 = from e in employees
                       where e.FirstName.StartsWith("J")
                       select e;
            foreach (var emp in q20)
            {
                Console.WriteLine(emp.FirstName);
            }

            //q21
            foreach (var emp in q8)
            {
                Console.WriteLine(emp.FirstName);
            }

            //q22
            var q22 = from e in employees
                       where e.FirstName.EndsWith("n")
                       select e;
            foreach (var emp in q22)
            {
                Console.WriteLine(emp.FirstName);
            }

            //q23
            var q23 = from e in employees
                       where e.FirstName.EndsWith("n") && e.FirstName.Length == 4
                       select e;
            foreach (var emp in q23)
            {
                Console.WriteLine(emp.FirstName);
            }

            //q24
            var q24 = from e in employees
                       where e.Salary > 600000
                       select e;
            foreach (var emp in q24)
            {
                Console.WriteLine(emp.FirstName);
                Console.WriteLine(emp.Salary);
            }

            //q25
            var q25 = from e in employees
                       where e.Salary < 800000
                       select e;
            foreach (var emp in q25)
            {
                Console.WriteLine(emp.FirstName);
                Console.WriteLine(emp.Salary);
            }

            //q29
            var q29 = from e in employees
                       where e.Salary > 500000 && e.Salary < 800000
                       select e;
            foreach (var emp in q29)
            {
                Console.WriteLine(emp.FirstName);
                Console.WriteLine(emp.Salary);
            }

            //q30
            var q30 = from e in employees
                       where e.FirstName == "John" || e.FirstName == "Michael "
                       select e;
            foreach (var emp in q30)
            {
                Console.WriteLine(emp.FirstName + "-" + emp.LastName + "-" + emp.Salary + "-" + emp.JoiningDate + "-" + emp.Dept);
            }

            //q31
            Console.WriteLine("q31");
            var q31 = from e in employees
                      where e.JoiningDate.Contains("13")
                      select e;
            foreach(var emp in q31)
            {
                Console.WriteLine(emp.FirstName);
            }

            //q32
            var q32 = from e in employees
                      where e.JoiningDate.Contains("JAN")
                      select e;
            foreach (var emp in q32)
            {
                Console.WriteLine(emp.FirstName);
            }

            //q33
            //var q33=from e in employees
            //   where e.

            //q34

            //q35

            //q36

            //q37

            //q38

            //q39
            Console.WriteLine("q39");
            var q39 = from e in employees
                      where e.LastName.Contains("%")
                      select e;
            foreach(var emp in q39)
            {
                Console.WriteLine(emp.LastName);
            }

            //q40
            Console.WriteLine("q40");
            var q40 = from e in employees
                      where e.LastName.Contains("%")
                      select e;
            foreach(var emp in q40)
            {
                Console.WriteLine(emp.LastName.ToLower().Replace("%", " "));
            }

            //q41
            var q41 = employees.GroupBy(e => e.Dept).Select(e => new
            {
                dept = e.Key,
                sal = e.Sum(t => t.Salary)
            });
            foreach(var emp in q41)
            {
                Console.WriteLine(emp.dept+ ' ' + emp.sal);
            }

            //q42
            var q42 = employees.GroupBy(e => e.Dept).Select(e => new
            {
                dept = e.Key,
                sal = e.Sum(t => t.Salary)
            }).OrderByDescending(s=>s.sal);
            foreach (var emp in q42)
            {
                Console.WriteLine(emp.dept + ' ' + emp.sal);
            }

            //q43
            var q43 = employees.GroupBy(e => e.Dept).Select(e => new
            {
                dept = e.Key,
                sal = e.Sum(t => t.Salary),
                emp = e.Count()
            }).OrderByDescending(s => s.sal);
            foreach (var emp in q43)
            {
                Console.WriteLine(emp.dept + ' ' + emp.sal + ' ' + emp.emp);
            }

            //q44
            var q44 = employees.GroupBy(e => e.Dept).Select(e => new
            {
                dept = e.Key,
                sal = e.Average(t => t.Salary),
            }).OrderByDescending(s => s.sal);
            foreach (var emp in q44)
            {
                Console.WriteLine(emp.dept + ' ' + emp.sal );
            }

            //q45
            var q45 = employees.GroupBy(e => e.Dept).Select(e => new
            {
                dept = e.Key,
                sal = e.Max(t => t.Salary),
            }).OrderBy(s => s.sal);
            foreach (var emp in q45)
            {
                Console.WriteLine(emp.dept + ' ' + emp.sal);
            }

            //q46
            var q46 = employees.GroupBy(e => e.Dept).Select(e => new
            {
                dept = e.Key,
                sal = e.Min(t => t.Salary),
            }).OrderBy(s => s.sal);
            foreach (var emp in q46)
            {
                Console.WriteLine(emp.dept + ' ' + emp.sal);
            }

            //q47

            //q48
            var q48 = employees.GroupBy(e => e.Dept).Select(e => new
            {
                dept = e.Key,
                sal = e.Sum(t => t.Salary),
            }).OrderBy(s => s.sal).Where(t => t.sal > 800000);
            foreach (var emp in q48)
            {
                Console.WriteLine(emp.dept + ' ' + emp.sal);
            }

            //q49
            var q49 = employees.Join(incentives, 
                      emp => emp.EmpId,
                      incentive => incentive.EmpRefId,
                      (emp, incentive) => new 
                      {
                         FirstName=emp.FirstName,
                         IncentiveAmount=incentive.IncentiveAmount
                      });
            foreach(var e in q49)
            {
                Console.WriteLine(e.FirstName + ' ' + e.IncentiveAmount);
            }

            //q50
            var q50 = employees.Join(incentives,
                      emp => emp.EmpId,
                      incentive => incentive.EmpRefId,
                      (emp, incentive) => new
                      {
                          FirstName = emp.FirstName,
                          IncentiveAmount = incentive.IncentiveAmount
                      }).Where(i=>i.IncentiveAmount>3000);
            foreach (var e in q50)
            {
                Console.WriteLine(e.FirstName + ' ' + e.IncentiveAmount);
            }
            Console.ReadLine();
        }
    }

    public class Employee
    {
        public int EmpId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }
        public string JoiningDate { get; set; }
        public string Dept { get; set; }
    }
    
    public class Incentive
    {
        public int EmpRefId { get; set; }
        public string IncentiveDate { get; set; }
        public int IncentiveAmount { get; set; }
    }
}
