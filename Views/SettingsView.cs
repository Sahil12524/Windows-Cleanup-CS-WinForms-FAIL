namespace Windows_Cleanup.Views
{
    public partial class SettingsView : Form, IDisposable
    {
        public SettingsView()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }

        private void SettingsView_Load(object sender, EventArgs e)
        {
            MainPage.mainPageInstance.themeChecker();
        }
    }
}
