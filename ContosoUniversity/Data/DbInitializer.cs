using TheStore.Models;
using System;
using System.Linq;

namespace TheStore.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            context.Database.EnsureCreated();

            // Look for any Items.
            if (context.Items.Any())
            {
                return;   // DB has been seeded. Adding items that are in inventory and for sale.
            }

            var Items = new Item[]
            {
            new Item{ItemDescription="Red Folding Chair",ItemDept="Furniture",ItemPrice=Decimal.Parse("14.99")},
            new Item{ItemDescription="Chocolate Ice Cream",ItemDept="Perishables",ItemPrice=Decimal.Parse("2.99")},
            new Item{ItemDescription="Grass Seed",ItemDept="Lawn and Garden",ItemPrice=Decimal.Parse("15.00")},
            new Item{ItemDescription="Chocolate Chip Waffles",ItemDept="Perishables",ItemPrice=Decimal.Parse("5.00")},
            new Item{ItemDescription="Blue Fountain Pen",ItemDept="Office Supplies",ItemPrice=Decimal.Parse("1.99")},
            new Item{ItemDescription="Paper Clips(Pack of 50)",ItemDept="Office Supplies",ItemPrice=Decimal.Parse("0.99")},
            new Item{ItemDescription="Roofing Hammer",ItemDept="Home Imporvement",ItemPrice=Decimal.Parse("8.99")},
            new Item{ItemDescription="Computer Desk",ItemDept="Furniture",ItemPrice=Decimal.Parse("145.99")}
            };
            foreach (Item s in Items)
            {
                context.Items.Add(s);
            }
            context.SaveChanges();

            var courses = new Course[]
            {
            new Course{CourseID=1050,Title="Chemistry",Credits=3},
            new Course{CourseID=4022,Title="Microeconomics",Credits=3},
            new Course{CourseID=4041,Title="Macroeconomics",Credits=3},
            new Course{CourseID=1045,Title="Calculus",Credits=4},
            new Course{CourseID=3141,Title="Trigonometry",Credits=4},
            new Course{CourseID=2021,Title="Composition",Credits=3},
            new Course{CourseID=2042,Title="Literature",Credits=4}
            };
            foreach (Course c in courses)
            {
                context.Courses.Add(c);
            }
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
            new Enrollment{ItemID=1,CourseID=1050,Grade=Grade.A},
            new Enrollment{ItemID=1,CourseID=4022,Grade=Grade.C},
            new Enrollment{ItemID=1,CourseID=4041,Grade=Grade.B},
            new Enrollment{ItemID=2,CourseID=1045,Grade=Grade.B},
            new Enrollment{ItemID=2,CourseID=3141,Grade=Grade.F},
            new Enrollment{ItemID=2,CourseID=2021,Grade=Grade.F},
            new Enrollment{ItemID=3,CourseID=1050},
            new Enrollment{ItemID=4,CourseID=1050},
            new Enrollment{ItemID=4,CourseID=4022,Grade=Grade.F},
            new Enrollment{ItemID=5,CourseID=4041,Grade=Grade.C},
            new Enrollment{ItemID=6,CourseID=1045},
            new Enrollment{ItemID=7,CourseID=3141,Grade=Grade.A},
            };
            foreach (Enrollment e in enrollments)
            {
                context.Enrollments.Add(e);
            }
            context.SaveChanges();
        }
    }
}