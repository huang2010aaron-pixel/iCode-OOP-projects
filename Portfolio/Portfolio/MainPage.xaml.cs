namespace Portfolio
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void ColorButton_Clicked(object sender, EventArgs e)
        {
            Random random = new Random();
            int red = random.Next(0, 255);
            int green = random.Next(0, 255);
            int blue = random.Next(0, 255);

            int fontsize = random.Next(0, 20);



            Background.BackgroundColor = Color.FromRgb(red, green, blue);
            Title.FontSize = 30 + fontsize;
            Description.FontSize = 15 + fontsize;
        }
    }
}
