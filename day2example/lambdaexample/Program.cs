using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambdaexample
{
    class Program
    {
        static void Main(string[] args)
        {
            //lambda with arrys
            int[] arr = { 0, -1, 4, 5, 7, 9, -2, 3, 2, 10 };
            foreach (var a in arr.Where(n => n > 5))
                Console.WriteLine(a);

            string[] cities = { "mumbai", "chennai", "pune", "hyderabad", "kolkatta", "new delhi", "ponddicherry" };
            foreach(var c in cities.Where(g=>g.StartsWith("p")||g.StartsWith("P")))
            {
                Console.WriteLine(c);
            }
            foreach (var c in cities.Where(x => x.Contains("e")))
                Console.WriteLine(c);

            var result = cities.Where(x => x.Contains("e"));
            Console.WriteLine(result.Count());

            List<employee> emp = new List<employee>
            {
                new employee
                {empid=100, Name="martin", Dept="IT", Salary=35000 },

                new employee
                {empid=200,Name="clark",Dept="accounts",Salary=1000 },

                new employee
                {
                    empid=300,Name="MAK",Dept="COMMERCE",Salary=1500
                },


                new employee {empid=400,Name="HELLO",Dept="SCIENCE",Salary=1400 }

            };

            //display all values

            foreach (var r in emp)
                Console.WriteLine(r.empid + " " + r.Name + " " + r.Dept + " " + r.Salary);
            Console.WriteLine("**********");

            var data = emp.Where(x => x.empid == 100).SingleOrDefault();
            if (data == null)
                Console.WriteLine("invalid empID");
            else
                Console.WriteLine(data.empid + " " + data.Name + " " + data.Dept + " " + " " +data.Salary);
            Console.WriteLine("****");

            var jan = emp.Where(k => k.Dept == "IT");
            if (jan.Count() == 0)
            {
                Console.WriteLine("invalid department");
            }
            else

            {
                foreach(var d in jan)
                {
                    Console.WriteLine(d.empid + " " + d.Name + " " + d.Dept + " " + " " + d.Salary);
                }
            }
            Console.WriteLine("****");

            var data3 = emp.Where(x => x.Dept == "IT" && x.Salary > 50000);
            foreach(var d in data3)
            {
                Console.WriteLine(d.empid + " " + d.Name + " " + d.Dept + " " + " " + d.Salary);
            }
            Console.WriteLine("****");

            // select the name and sort it in the asc/desc oorder

            var data4 = emp.OrderBy(x => x.Name).Select(y => y.Name);
            foreach (var d in data4)
                Console.WriteLine(d);
            Console.WriteLine("****");

            //select -1 property or it will select all property
            // select name, salary - anonymous types from #3.5

            //new {EmpName=e.name, empsalary=e.salary}

            var data5 = emp.Select(x => new { Empname = x.Name, Empsalary = x.Salary });
            foreach (var d in data5)
                Console.WriteLine(d.Empname + " " + d.Empname);
            Console.WriteLine("****");

            //summary - count of emp dept wise, sum of salary paid dept wise
            //key- column on which group by is done

            var grp = emp.GroupBy(x => x.Dept).Select(x => new { DeptName = x.Key, empCount = x.Count(), sumsalary = x.Sum(y => y.Salary) });
            foreach (var g in grp)
                Console.WriteLine(g.DeptName + " " + g.empCount + " " +g.sumsalary);
            Console.WriteLine("****");

            Console.WriteLine("max salary;" + emp.Max(x => x.Salary));
            Console.WriteLine("min salary;" + emp.Min(x => x.Salary));

            var maxsal = emp.Where(x => x.Salary == emp.Max(y => y.Salary));
            foreach (var d in maxsal)
                Console.WriteLine(d.empid + " " + d.Name + " " + d.Dept + " " + " " + d.Salary);




        }




    }
}
