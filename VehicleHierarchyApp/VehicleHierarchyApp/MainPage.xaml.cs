namespace VehicleHierarchyApp
{
    public partial class MainPage : ContentPage
    {
        Vehicle currentvehicle;
        public MainPage()
        {
            InitializeComponent();
            SizeChanged += VerticalStackLayout_SizeChanged;
            Vehicle currentvehicle = new Car();
            UpdateUI("Welcome to the vehicle simulation");
            SetVehicle(new Car());
        }

        private void VerticalStackLayout_SizeChanged(object sender, EventArgs e)
        {
            if(Width < 400 || Height < 600)
            {
                Title.FontSize = 100;
            }
            else
            {
                Title.FontSize = 40;
            }
        }
        public void SelectCar(object sender, EventArgs e)
        {
            Symbol.Source = "car.png";
            SetVehicle(new Car());
        }
        public void SelectMotorcycle(object sender, EventArgs e)
        {
            Symbol.Source = "motorcycle.png";
            SetVehicle(new Motorcycle());
        }
        public void SelectHelicopter(object sender, EventArgs e)
        {
            Symbol.Source = "helicopter.png";
            SetVehicle(new Helicopter());
        }
        public void SelectTruck(object sender, EventArgs e)
        {
            Symbol.Source = "truck.png";
            SetVehicle(new Truck());
        }
        private void SetVehicle(Vehicle v)
        {
            currentvehicle = v;
            UpdateUI($"Switched to {v.Name}");
        }
        private void StartButton_Clicked(object sender, EventArgs e)
        {
            UpdateUI(currentvehicle.Start());
        }

        private void SpecialButton_Clicked(object sender, EventArgs e)
        {
            string actionResult = "";

            if (currentvehicle is Car c) actionResult = c.Honk();
            else if (currentvehicle is Motorcycle m) actionResult = m.Rev();
            else if (currentvehicle is Helicopter h) actionResult = h.Fly();
            else if (currentvehicle is Truck t) actionResult = t.Deliver();
            UpdateUI(actionResult);
        }

        private void StopButton_Clicked(object sender, EventArgs e)
        {
            UpdateUI(currentvehicle.Stop());
        }

        private void UpdateUI(string message)
        {
            Textbox.Text = message;
        }
    }
}
