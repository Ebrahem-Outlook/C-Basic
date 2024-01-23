using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Basic;

public class Student1
{
    private int Id;
    private string FirstName;
    private String LastName;
    private int Age;

    public Student1()
    {
        
    }
    public Student1(int Id, string FirstName, string LastName, int Age)
    {
        this.Id = Id;
        this.FirstName = FirstName;
        this.LastName = LastName;
        this.Age = Age;
    }

    public int Student1Id
    {
        get => Id;
        set => Id = value;
    }

    public String StudentName
    {
        get => FirstName;
        set => FirstName = value;
    }

    public String StudentLastName
    {
        get => LastName;
        set => LastName = value;
    }

    public int StudentAge
    {
        get => Age;
        set => Age = value;
    }
}

