
[AttributeUsage(AttributeTargets.All)]
public class CustomAttribute : Attribute
{
   private string developerName;
   private string action;
   private string projectStatus;
   private string lastSubmissionDate;

   public CustomAttribute(string name,string act,string status,string submitDate)
   {
    developerName=name;
    action=act;
    projectStatus=status;
    lastSubmissionDate=submitDate;
   }

   public string DeveloperName{
    get{ return developerName ;}
   }
   public string Action{
    get{ return action ;}
   }
   public string ProjectStatus{
    get{ return projectStatus ;}
   }
   public string LastSubmissionDate{
    get{ return  lastSubmissionDate ;}
   }


}


class Banking
{
    private int accountNumber;
    private string accountHolderName;
    private int balance;

  [CustomAttribute("Jenifer","Working with set details method","In-Progress","5/11/2023")]
    public void SetDetails(int num,string name,int bal)
    {
        accountNumber=num;
        accountHolderName=name;
        balance=bal;
    }

 [CustomAttribute("Vivek","Get details about the account number module","Completed","5/08/2023")]
    public int getAccountNumber()
    {
        return accountNumber;
    }
    public string getAccountHolderName()
    {
        return accountHolderName;
    }
    public int getAvailableBalance()
    {
        return balance;
    }
}