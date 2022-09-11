﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program\n");
            EmpWageObjects empWageObjects = new EmpWageObjects();
            empWageObjects.AddCompanyEmpWage("TCS", 25, 18, 80);
            empWageObjects.AddCompanyEmpWage("Wipro", 20, 25, 90);
            empWageObjects.CalculateEmpWage();
            Console.WriteLine("Total wage for TCS Company is : " + empWageObjects.GetTotalWage("TCS"));
            Console.ReadLine();
        }
    }
}
