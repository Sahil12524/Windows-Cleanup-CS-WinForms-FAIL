namespace Windows_Cleanup.Views
{
    public partial class BasicToolsView : Form, IDisposable
    {
        public static BasicToolsView? basicToolsViewInstance { get; set; }
        public Button buttonTempFilesRemove, buttonWindowsUpdateCacheClean, buttonCHKDSK, buttonSSDTrim;
        public BasicToolsView()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            basicToolsViewInstance = this;
            buttonTempFilesRemove = btnTempFilesRemove;
            buttonWindowsUpdateCacheClean = btnWindowsUpdateCacheClean;
            buttonCHKDSK = btnCHKDSK;
            buttonSSDTrim = btnSSDTrim;
        }

        private void BasicToolsView_Load(object sender, EventArgs e)
        {
            MainPage.mainPageInstance?.themeChecker();
        }

        private void btnTempFilesRemove_Click(object sender, EventArgs e)
        {
            //
        }

        private void btnWindowsUpdateCacheClean_Click(object sender, EventArgs e)
        {
            //
        }

        private void btnCHKDSK_Click(object sender, EventArgs e)
        {
            //
        }

        private void btnSSDTrim_Click(object sender, EventArgs e)
        {
            //
        }
    }
}
