using Microsoft.Win32;
using System.Runtime.InteropServices;
using Windows_Cleanup.Helper;
using Windows_Cleanup.Views;

namespace Windows_Cleanup
{
    public partial class MainPage : Form
    {
        public Button buttonHome;
        public static MainPage mainPageInstance;
        HomeView homeView = new HomeView();
        bool taskRunning;
        bool isLightMode;
        [DllImport("DwmApi")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue, int attrSize);
        public void themeChecker()
        {
            int lightmode = (int)Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Themes\Personalize", "AppsUseLightTheme", "1");
            if (lightmode != 1) // Dark Mode
            {
                if (DwmSetWindowAttribute(Handle, 19, new[] { 1 }, 4) != 0)
                {
                    DwmSetWindowAttribute(Handle, 20, new[] { 1 }, 4);
                }
                ThemeHelper.DarkTheme();
                isLightMode = false;
            }
            else // Light Mode
            {
                DwmSetWindowAttribute(Handle, 19, new[] { 0 }, 4);
                ThemeHelper.LightTheme();
                isLightMode = true;
            }
        }
        public async Task updateTheme()
        {
            taskRunning = true;
            do
            {
                await Task.Delay(500);
                themeChecker();
            }
            while (taskRunning);
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();

        }

        public void switchPanel(Form panel)
        {
            panel3.Controls.Clear();
            panel.TopLevel = false;
            panel.FormBorderStyle = FormBorderStyle.None;
            panel.Dock = DockStyle.Fill;
            panel.AutoSize = true;
            panel.AutoSizeMode = AutoSizeMode.GrowOnly;
            panel.AutoScroll = true;
            panel3.Controls.Add(panel);
            panel3.AutoSize = true;
            panel.TopMost = true;
            panel.Show();
        }

        public MainPage()
        {
            InitializeComponent();
            mainPageInstance = this;
            buttonHome = btnHome;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            switchPanel(homeView);
            themeChecker();
        }

        private void MainPage_Activated(object sender, EventArgs e)
        {
            _ = updateTheme();
            taskRunning = false;
        }

        private void MainPage_Deactivate(object sender, EventArgs e)
        {
            //taskRunning = true;
            _ = updateTheme();
            if (WindowState == FormWindowState.Minimized)
            {
                // Do some stuff
                _ = updateTheme();
                taskRunning = false;
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            switchPanel(homeView);
        }
    }
}