using System;

public class BankAccount
{
	public BankAccount()
	{
	}
	private double balance;
	public void Deposit(double depositAmount)
	{
	balance+=depositAmount;
	}
	public double GetBalance()
	{
		Console.WriteLine(balance);
		return balance;
	}


}
