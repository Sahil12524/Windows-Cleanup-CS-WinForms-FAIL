namespace Windows_Cleanup.Views
{
    public partial class HomeView : Form, IDisposable
    {
        public HomeView()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }

        private void HomeView_Load(object sender, EventArgs e)
        {
            MainPage.mainPageInstance?.themeChecker();
        }
    }
}
