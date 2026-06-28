namespace DigitalPet
{
    public partial class MainPage : ContentPage
    {
        int hunger = 0;
        bool dead = false;

        public MainPage()
        {
            InitializeComponent();

            StartHungerTimer();
        }
        public void UpdateUI()
        {
            Hunger.Text = $"Hunger: {hunger}";
            if (hunger < 20)
            {
                Emojis.Text = "Your pet is full and happy!";
            }
            else if (hunger < 50)
            {
                Emojis.Text = "Your pet is getting hungry";
            }
            else if (hunger < 70)
            {
                Emojis.Text = "Your pet is getting super hungry";
            }
            else if (hunger < 100)
            {
                Emojis.Text = "Your pet is starving!";
            }
            else
            {
                Emojis.Text = "Your pet is dead!";
                Hunger.Text = "";
                dead = true;
            }
        }

        private async void StartHungerTimer()
        {
            using PeriodicTimer timer = new(TimeSpan.FromSeconds(0.2));

            while (await timer.WaitForNextTickAsync())
            {
                if (dead == false)
                {
                    hunger += 1;
                    UpdateUI();
                }
            }

                MainThread.BeginInvokeOnMainThread(() =>
                {
                    Hunger.Text = $"Hunger: {hunger}";
                });
        }

        private void FeedButton_Clicked(object? sender, EventArgs e)
        {
            if (hunger >= 5)
            {
                if (dead == false)
                {
                    hunger -= 5;
                    UpdateUI();
                }
            }  
        }
    }
}