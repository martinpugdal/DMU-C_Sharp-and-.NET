namespace L11___MAUI_introduktion
{
    public partial class OnePage : ContentPage
    {
        public OnePage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Text = "Hello MAUI!";
        }

        private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            SHOWBUTTON.IsVisible = checkBox.IsChecked;
        }

        // just an example to something with checkbox
        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Tjek.CheckedChanged -= CheckBox_CheckedChanged;
            Tjek.IsChecked = !Tjek.IsChecked;
            Tjek.CheckedChanged += CheckBox_CheckedChanged;
        }
    }

}
