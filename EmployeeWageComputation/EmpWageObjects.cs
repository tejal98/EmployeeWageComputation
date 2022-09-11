using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmpWageObjects : ICalculateEmpWage
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private LinkedList<CompanyEmpWage> companyEmpWageList;
        private Dictionary<string, CompanyEmpWage> companyToEmpWagemap;

        public EmpWageObjects()
        {
            this.companyEmpWageList = new LinkedList<CompanyEmpWage>();
            this.companyToEmpWagemap = new Dictionary<string, CompanyEmpWage>();
        }
        public void AddCompanyEmpWage(string company, int numOfWorkingDays, int empRatePerHr, int maxHoursPerMont)
        {
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(company, numOfWorkingDays, empRatePerHr, maxHoursPerMont);
            this.companyEmpWageList.AddLast(companyEmpWage);
            this.companyToEmpWagemap.Add(company, companyEmpWage);
        }

        public void CalculateEmpWage()
        {
            foreach (CompanyEmpWage companyEmpWage in this.companyEmpWageList)
            {
                companyEmpWage.setTotalEmpWage(this.CalculateEmpWage(companyEmpWage));
                Console.WriteLine(companyEmpWage.toString());
            }
        }
        private int CalculateEmpWage(CompanyEmpWage companyEmpWage)
        {
            int empHrs = 0, totalWorkingDays = 0, totalEmpHrs = 0;
            Random random = new Random();
            while (totalWorkingDays < companyEmpWage.numOfWorkingDays && totalEmpHrs <= companyEmpWage.maxHoursPerMonth)
            {
                totalWorkingDays++;
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day number = " + totalWorkingDays + " Working hours = " + empHrs);
            }
            return totalEmpHrs * companyEmpWage.empRatePerHr;
        }

        public int GetTotalWage(string company)
        {
            return this.companyToEmpWagemap[company].totalEmpWage;
        }
        
    }
}
