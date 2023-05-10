 struct Employee
{
    public int id;

    public Employee(int id)
    {
        this.id=id;
        Console.WriteLine("Constructor in structure ");
    }
    // public void Set(int empid){
    //     this.id = empid;
    // }
    public void Get(){
        Console.WriteLine(this.id);
    }

    
}