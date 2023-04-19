namespace Windows_Cleanup.Views
{
    public partial class NetToolsView : Form, IDisposable
    {
        public static NetToolsView? netToolsViewInstance { get; set; }
        public Button buttonDisableNet, buttonFlushDNS, buttonResetIP, buttonEnableNet, buttonPacketLossTest;
        public NetToolsView()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            netToolsViewInstance = this;
            buttonDisableNet = btnDisableNet;
            buttonFlushDNS = btnFlushDNS;
            buttonResetIP = btnResetIP;
            buttonEnableNet = btnEnableNet;
            buttonPacketLossTest = btnPacketLossTest;
        }

        private void NetToolsView_Load(object sender, EventArgs e)
        {
            MainPage.mainPageInstance?.themeChecker();
        }

        private void btnDisableNet_Click(object sender, EventArgs e)
        {
            //
        }

        private void btnFlushDNS_Click(object sender, EventArgs e)
        {
            //
        }

        private void btnResetIP_Click(object sender, EventArgs e)
        {
            //
        }

        private void btnEnableNet_Click(object sender, EventArgs e)
        {
            //
        }

        private void btnPacketLossTest_Click(object sender, EventArgs e)
        {
            //
        }
    }
}
