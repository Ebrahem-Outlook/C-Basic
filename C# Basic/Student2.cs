namespace C__Basic;

public partial class Student2
{
    // fileds
    private int Id;
    private String FirstName;
    private String LastName;
    private int Age;

    public Student2()
    {
        
    }
    public Student2(int Id, string FirstName, string LastName, int Age)
    {
        this.Id = Id;
        this.FirstName = FirstName;
        this.LastName = LastName;
        this.Age = Age;
    }

    // propertys get And set
    public int StudentId
    {
        get { return Id; }
        set { if (value > 0) Id = value; }
    }
    public String StudentFirstName
    {
        get { return FirstName; }
        set { FirstName = value; }
    }
    public String StudentLastName
    {
        get { return LastName; }
        set { LastName = value; }
    }
    public int StudentAge
    {
        get { return Age; }
        set { Age = value; }
    }

    // Addtion mathod
    public int Sum(int num1, int num2)
    {
        return num1 + num2;
    }
    public String FullName()
    {
        return this.FirstName + " " + this.LastName;
    }
}
