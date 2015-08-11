
namespace _02.StudentsAndWorkers
{
    using System;

    public class Worker : Human
    {
        private const decimal workDaysInWeek = 5m;

        public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay) : base(firstName,lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary { get; set; }
        public int WorkHoursPerDay { get; set; }

        public decimal MoneyPerHour()
        {
            return this.WeekSalary / (workDaysInWeek * WorkHoursPerDay);
        }

        public override string ToString()
        {
            return String.Format(" First name: {0}   Last name: {1}   Money per hour: {2:C}", this.FirstName, this.LastName, this.MoneyPerHour());
        }
    }
}
