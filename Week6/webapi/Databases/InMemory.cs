using System.Collections.Generic;
using webapi.Models;

namespace webapi.Databases
{
    public class InMemory
    {
        public static List<Student> GetStudents()
        {
            return new List<Student> {
                new Student {
                    Id = 918244474,
                    Email = "jordan.clark@oit.edu"
                },
                new Student {
                    Id = 918123456,
                    Email = "test.student@oit.edu"
                },
                new Student {
                    Id = 918555555,
                    Email = "second.test@oit.edu"
                },
            };
        }
        
        public static List<Instructor> GetInstructors()
        {
            return new List<Instructor> {
                new Instructor {
                    First = "Gerald",
                    Middle = "N/A",
                    Last = "Aden",
                },
                new Instructor {
                    First = "Peter",
                    Middle = "N/A",
                    Last = "Meyers",
                },
                new Instructor {
                    First = "Paula",
                    Middle = "N/A",
                    Last = "Hannan",
                },
            };
        }
    }
}