﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoUniversityApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new ContosoUniversityEntities();
            
            foreach(var item in db.Course)
            {
                Console.WriteLine(item.Title+"\t"+item.Department.Name);
            }
        }
    }
}
