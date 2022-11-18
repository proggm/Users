using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>
            {
                new User("Viktor",16,177),
                new User("Raziyat",17,175),
                new User("Magomed",17,184),
                new User("Abdulhakim",20,186),
                new User("Ruslan",17,172),

            };
            var first = users.Where(item => item.age>18).ToList();
            int n = 0;
            foreach(var item in first)
            {

                n++;
            }
            Console.WriteLine($"Пользователей старше 18-ти лет: {n}");
            Console.ReadKey();

        }
    }
}
