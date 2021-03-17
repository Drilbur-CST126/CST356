using System.Collections.Generic;
using System.Linq;
using Databases;
using System;

public class StudentRepository : IStudentRepository
{
    private readonly SchoolContext _context;

    public StudentRepository(SchoolContext context)
    {
        _context = context;
    }

    public List<Student> GetAllStudents()
    {
        try
        {
            return _context.Student.ToList();
        }
        catch (System.Exception)
        {
            return new List<Student>();
        }
    }
}