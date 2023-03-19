using Microsoft.Win32;
using System.Runtime.InteropServices;
using Windows_Cleanup.Helper;
using Windows_Cleanup.Views;

namespace Windows_Cleanup
{
    public partial class MainPage : Form
    {
        public Button buttonHome, buttonSettings;
        public static MainPage mainPageInstance;
        HomeView homeView = new HomeView();
        SettingsView settingsView = new SettingsView();
        bool taskRunning;
        bool isLightMode;
        [DllImport("DwmApi")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue, int attrSize);
        public MainPage()
        {
            InitializeComponent();
            mainPageInstance = this;
            buttonHome = btnHome;
            buttonSettings = btnSettings;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            panel3.Tag = "HomeView";
            switchPanel(homeView);
            themeChecker();
        }

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
            panel.BringToFront();
            panel.Show();
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

        private void MainPage_ResizeEnd(object sender, EventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (panel3.Tag?.ToString() == "HomeView")
            {
                return;
            }
            else
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                panel3.Tag = "HomeView";
                switchPanel(homeView);
                return;
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            if (panel3.Tag?.ToString() == "SettingsView")
            {
                return;
            }
            else
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                panel3.Tag = "SettingsView";
                switchPanel(settingsView);
                return;
            }
        }

    }
}