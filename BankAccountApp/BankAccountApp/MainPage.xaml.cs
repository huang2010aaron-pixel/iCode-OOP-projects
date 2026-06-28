namespace BankAccountApp;

public partial class MainPage : ContentPage
{
    private double balance = 0;

    public void Deposit(double amount)
    {
        if (amount > 0)
            balance += amount;
    }

    public double GetBalance() => balance;

    public void Withdraw(double amount)
    {
        if (balance > 0 && amount > 0)
        {
            balance -= amount;
        }
    }
    public MainPage()
    {
        InitializeComponent();
    }

    private void DepositButton_Clicked(object sender, EventArgs e)
    {
        if(double.TryParse(Textbox.Text, out double money))
        {
            Deposit(money);
            Counter.Text = $"$ " + balance;
            Textbox.Text = "";
        }
        else
        {
            DisplayAlert("Error", "Please type in numbers only", "Okay");
        }
    }
    private void WithdrawButton_Clicked(object sender, EventArgs e)
    {
        if (double.TryParse(Textbox.Text, out double money))
        {
            Withdraw(money);
            Counter.Text = $"$ " + balance;
            Textbox.Text = "";
        }
        else
        {
            DisplayAlert("Error", "Please type in numbers only", "Okay");
        }
    }

}
