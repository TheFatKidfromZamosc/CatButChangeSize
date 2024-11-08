namespace CatSlider
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
           
        }
        void OnSliderValueChanged(object sender, ValueChangedEventArgs args)
        {
            double value = args.NewValue;
            Cat.HeightRequest = value;
            displayLabel.Text = String.Format("The Slider value is {0}", value);
        }
    }

}
