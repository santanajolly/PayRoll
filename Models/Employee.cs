using System;
using System.ComponentModel.DataAnnotations;

namespace PayRoll.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float RateOfPay { get; set; }

        public float HoursWorked { get; set; }


        [DataType(DataType.Date)]
        public DateTime PayWeek { get; set; }
    }
}
