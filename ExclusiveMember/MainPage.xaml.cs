namespace ExclusiveMember
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        /*private void BuyBtnClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                BuyBtn.Text = $"Clicked {count} time";
            else
                BuyBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(BuyBtn.Text);
        }*/
    }

}
