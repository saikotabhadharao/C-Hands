using System;
/*public class Account
{
    private int id;
    private string accountType;
    private double balance;
    public int Id
    {
        get
        {
            return this.id;
        }
        set
        {
            this.id = value;
        }
    }
    public string AccountType
    {
        get
        {
            return this.accountType;
        }
        set
        {
            this.accountType = value;
        }
    }
    public double Balance
    {
        get
        {
            return balance;
        }
        set
        {
            this.balance = value;
        }
    }

    /* private int id { get; set; }
     private string accountType { get; set; }
     private double balance { get; set; }*/

  /*  public Account() { }

    public Account(int id, string accountType, double balance)
    {
        this.id = id;
        this.accountType = accountType;
        this.balance = balance;
    }

    public bool Withdraw(double amount)
    {
        if (balance > amount)
        {
            balance -= amount;
            return true;
        }
        else
        {
            return false;
        }

    }
    public string GetDetails()
    {
        return ($"Account Id: {id}\nAccount Type: {accountType}\nBalance: {balance}");

    }

}*/
public class Program
{
    public static void Main(string[] args)
    {
        /*  Console.WriteLine("Enter account id");
          int id = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Enter account type");
          string type = Console.ReadLine();
          Console.WriteLine("Enter account balance");
          double balance = Convert.ToDouble(Console.ReadLine());
          Console.WriteLine("Enter amount to withdraw");
          double withdraw = Convert.ToDouble(Console.ReadLine());
          Account acc = new Account(id, type, balance);

          // acc.Withdraw(withdraw);
          Console.WriteLine(acc.GetDetails());
          if (acc.Withdraw(withdraw))
          {
              Console.WriteLine("New Balance :{0}", acc.Balance);
          }*/
        DateTime date = Convert.ToDateTime(Console.ReadLine());
         Console.WriteLine(date);
        Console.WriteLine(date.Month);
        Console.WriteLine(date.Date);
        Console.WriteLine(date.Day);
        Console.WriteLine("{0}.{1}",date.Day,date.Month);
        Console.WriteLine("Enter mobile number");
        long ph = Convert.T(Console.ReadLine());
    }
}