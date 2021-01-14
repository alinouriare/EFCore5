using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace NetFive
{
   

  

    class Program
    {
        //public static void GetParentAdnChild(int id)
        //{
        //    Stopwatch sw = new Stopwatch();
        //    Console.WriteLine($" start Query");
        //    using var ctx = new NewsContext();
        //                sw.Start();

        //    var parentQuery = ctx.Parents.AsSplitQuery().Include(c => c.Child01s).Include(c => c.Child02s).Include(c => c.Child03s)
        //        .ToQueryString();
        //    var parent = ctx.Parents.AsSplitQuery().Include(c => c.Child01s).Include(c => c.Child02s).Include(c => c.Child03s)
        //     .FirstOrDefault(c=>c.ParentId==id);
        //    var m = sw.ElapsedMilliseconds;
        //    Console.WriteLine($"total record{parent.Child01s.Count + parent.Child02s.Count+ parent.Child01s.Count}");
        //    Console.WriteLine($"Total time{m}");

        //}

        public static void AddCategory(string name ,string description)
        {
            using var ctx = new PropertyBag();
            var category = new Dictionary<string, object>
            {
                ["Name"] = name,
                ["Description"] = description
            };
            ctx.Categories.Add(category);
            ctx.SaveChanges();
        }

        public static Dictionary<string,object> GetCateogory(string name)
        {
            using var ctx = new PropertyBag();
            var cat = ctx.Categories.FirstOrDefault(c=>c["Name"]==name);
            return cat;
        }
        //public static int AddParent(int childCount)
        //{
        //    Console.WriteLine($"Add{childCount}item start");
        //    Stopwatch sw = new Stopwatch();
        //    sw.Start();
        //    var parent = new Parent
        //    {
        //        Title = "Titel",
        //        Child01s = new System.Collections.Generic.List<Child01>(),
        //        Child02s = new System.Collections.Generic.List<Child02>(),
        //        Child03s = new System.Collections.Generic.List<Child03>()
        //    };
        //    for (int i = 0; i < childCount; i++)
        //    {
        //        parent.Child01s.Add(new Child01() { Title = $"title{i}" });
        //        parent.Child02s.Add(new Child02() { Title = $"title{i}" });
        //        parent.Child03s.Add(new Child03() { Title = $"title{i}" });

        //    };
        //    using var ctx = new NewsContext();
        //    ctx.Parents.Add(parent);
        //    int a = ctx.SaveChanges();
        //    sw.Stop();
        //    Console.WriteLine($"Add {childCount} item add");
        //    var m = sw.ElapsedMilliseconds;
        //    Console.WriteLine($"Total time{m}");
        //    return parent.ParentId;
        //}
        static void Main(string[] args)
        {




            //do
            //{
            //    Console.WriteLine("Child Count");
            //    var count = int.Parse(Console.ReadLine());
            //    var id = AddParent(count);
            //    GetParentAdnChild(id);
            //    Console.WriteLine("Contu");

            //} while (Console.ReadLine().ToLower()=="y");
            //Console.ReadKey();
        }
    }
}
