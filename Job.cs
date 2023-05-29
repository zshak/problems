using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    
//№5
//შექმენით ჩამონათვალი(enum). რომელიც შეიცავს თანამშრომლების თანამდებობებს, როგორც კონსტანტებს.
//მიანიჭეთ ყოველ თანამდებობას მნიშვნელობა, რომელიც განსაზღვრავს რამდენი საათი უნდა იმუშავოს ყოველმა თვეში.
//შექმენით კლასი ccauntant bool AskForBonus(Post worker, int hours) მეთოდით, რომელიც ამოწმებს,
//იმსახურებს თუ არა თანამშრომელი ბონუსს.თუ თანამშრომელმა თავის თანამდებობისთვის განკუთვნილ საათებზე
//მეტი იმუშავა, მაშინ მას ეკუთვნის ბონუსი
    public enum Jobs
    {
        Job1 = 160,
        job2 = 170,
        job3 = 180,
    }
    internal static class Job
    {
        static bool askForBonus(Jobs job, int hours)
        {
            int HoursWorked = (int)job;
            return HoursWorked > hours;
        }
    }
}
