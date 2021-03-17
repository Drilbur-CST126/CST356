using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Logging;
using NUnit.Framework;
using FakeItEasy;
using FluentAssertions;

public class StudentServiceTests
{
    private StudentService _studentService;
    private IStudentRepository _studentRepository;
    private const string SpecialKey = "j";

    [SetUp]
    public void Setup()
    {
        var loggerFactory = A.Fake<LoggerFactory>();
        _studentRepository = A.Fake<IStudentRepository>();

        _studentService = new StudentService(_studentRepository);
    }

    [Test]
    public void ShouldNotReturnSpecialStudents()
    {
        A.CallTo(() => _studentRepository.GetAllStudents()).Returns(
            new List<Student> {
                new Student {
                    StudentId = 1,
                    EmailAddress = "test.student@oit.edu",
                },
                new Student {
                    StudentId = 2,
                    EmailAddress = "test.student2@oit.edu",
                },
                new Student {
                    StudentId = 3,
                    EmailAddress = "test.student3@oit.edu",
                },
            }
        );

        var studentViewModels = _studentService.GetAllStudents();

        Assert.That(studentViewModels.Any(student => student.Special), Is.EqualTo(false));

        studentViewModels.Any(student => student.Special).Should().BeFalse();
    }

    [Test]
    public void ShouldReturnTwoSpecialStudents()
    {
        A.CallTo(() => _studentRepository.GetAllStudents()).Returns(
            new List<Student> {
                new Student {
                    StudentId = 1,
                    EmailAddress = "test.student@oit.edu",
                },
                new Student {
                    StudentId = 2,
                    EmailAddress = SpecialKey + "test.student2@oit.edu",
                },
                new Student {
                    StudentId = 3,
                    EmailAddress = SpecialKey + "test.student3@oit.edu",
                },
            }
        );

        var studentViewModels = _studentService.GetAllStudents();

        studentViewModels.Count(student => student.Special).Should().Be(2);
        studentViewModels.Single(student => !student.Special).StudentId.Should().Be(1);
    }
}