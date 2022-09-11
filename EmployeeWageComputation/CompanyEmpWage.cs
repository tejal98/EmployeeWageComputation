using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public interface ICalculateEmpWage
    {
        void AddCompanyEmpWage(string company, int numOfWorkingDays, int empRatePerHr, int maxHoursPerMonth);
        void CalculateEmpWage();
        int GetTotalWage(string company);
    }

    public class CompanyEmpWage
    {
        public string company;
        public int numOfWorkingDays;
        public int empRatePerHr;
        public int maxHoursPerMonth;
        public int totalEmpWage;
        public CompanyEmpWage(string company, int numOfWorkingDays, int empRatePerHr, int maxHoursPerMonth)
        {
            this.company = company;
            this.numOfWorkingDays = numOfWorkingDays;
            this.empRatePerHr = empRatePerHr;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }
        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }
        public string toString()
        {
            return ("\nTotal wage for " + this.company + " company is " + this.totalEmpWage+"\n");
        }
    }
}
