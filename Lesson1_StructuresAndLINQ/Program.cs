﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_StructuresAndLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            DBService.GetCountCommentsByUserPosts(14);

            Console.ReadKey();
        }
    }
}
