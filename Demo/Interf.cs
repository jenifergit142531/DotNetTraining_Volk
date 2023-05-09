

interface Employee
{
    void salary();
}

interface Person
{
    void details();
}

class HR : Employee,Person
{
    public void salary()
    {
  Console.WriteLine("Salary is negotiable");
    }
    public void details()
    {
Console.WriteLine("Personal details verified");
    }
    }
