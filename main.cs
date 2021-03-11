using System;
//calculate parking fee, then return total fee to the customer

class MainClass {
  
  //fee calculation
  public static double CalculateCharges(double hours)
  {
      double totalFee = 2 + (hours - 3) * 0.50;

    if (hours < 3)
    {
      totalFee = 2.0;
    }
    if (totalFee > 10.0)
    {
      totalFee = 10.0;
    }

    return totalFee;
  }
  
  
  
  
  public static void Main (string[] args) {
  
    bool customersLeft = true;

    while(customersLeft)
    {
      Console.WriteLine("How many hours?");
      double hours = Convert.ToDouble(Console.ReadLine());

      double totalFee = CalculateCharges(hours);

      Console.WriteLine("The fee is " + totalFee + "dollars");

      Console.WriteLine("Are there any customers left?");
      string noCheck = Console.ReadLine();
      if (noCheck == "no"){
        customersLeft = false;
      }
    }
  }
}
