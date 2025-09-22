namespace login
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }// fecha MainPage

        private void OnCounterClicked(object? sender, EventArgs e)
        {
           new Window(new Login());

        }// fecha OnCounterClicked

       
       
      
    

    }// feicha classe

}// fecha namespace
