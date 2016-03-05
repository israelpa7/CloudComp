using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var res = new List<Person>();
            using (var dbContext = new qslEntities()) {
                 res = dbContext.Person.ToList();
            }

            foreach (var item in res)
            {
                Console.WriteLine(string.Format("Id: {0}, First Name: {1}, Last Name: {2}", item.Id, item.FirstName, item.LastName));
            }

        }
    }
}
