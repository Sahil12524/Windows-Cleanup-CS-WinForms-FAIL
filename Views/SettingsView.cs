namespace Windows_Cleanup.Views
{
    public partial class SettingsView : Form, IDisposable
    {
        public SettingsView()
        {
            InitializeComponent();
        }

        private void SettingsView_Load(object sender, EventArgs e)
        {
            MainPage.mainPageInstance.themeChecker();
        }
    }
}
