using Microsoft.Win32;
using System.Runtime.InteropServices;
using Windows_Cleanup.Helper;
using Windows_Cleanup.Views;

namespace Windows_Cleanup
{
    public partial class MainPage : Form, IDisposable
    {
        public Button buttonHome, buttonSettings;
        public static MainPage mainPageInstance;
        HomeView homeView = new HomeView();
        SettingsView settingsView = new SettingsView();
        bool updateThemeTaskRunning;
        bool isLightMode;
        [DllImport("DwmApi")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue, int attrSize);
        public MainPage()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            mainPageInstance = this;
            buttonHome = btnHome;
            buttonSettings = btnSettings;
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            panel3.Tag = "HomeView";
            switchPanel(homeView);
            memoryFreeUp();
            //themeChecker();
        }

        public void memoryFreeUp()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            return;
        }

        public void themeChecker()
        {
            int lightmode = (int)Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Themes\Personalize", "AppsUseLightTheme", "1");
            if (lightmode != 1) // Dark Mode
            {
                if (DwmSetWindowAttribute(Handle, 19, new[] { 1 }, 4) != 0)
                {
                    DwmSetWindowAttribute(Handle, 20, new[] { 1 }, 4);
                    return;
                }
                ThemeHelper.DarkTheme();
                isLightMode = false;
                memoryFreeUp();
                return;
            }
            else // Light Mode
            {
                DwmSetWindowAttribute(Handle, 19, new[] { 0 }, 4);
                ThemeHelper.LightTheme();
                isLightMode = true;
            }
            memoryFreeUp();
            return;
        }

        public async Task updateTheme()
        {
            updateThemeTaskRunning = true;
            do
            {
                await Task.Delay(500);
                themeChecker();
            }
            while (updateThemeTaskRunning);
            memoryFreeUp();
            return;
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
            memoryFreeUp();
            return;
        }

        private void MainPage_Activated(object sender, EventArgs e)
        {
            _ = updateTheme();
            updateThemeTaskRunning = false;
            return;
        }

        private void MainPage_Deactivate(object sender, EventArgs e)
        {
            //updateThemeTaskRunning = true;
            _ = updateTheme();
            if (WindowState == FormWindowState.Minimized)
            {
                // Do some stuff
                _ = updateTheme();
                updateThemeTaskRunning = false;
                return;
            }
            return;
        }

        private void MainPage_ResizeEnd(object sender, EventArgs e)
        {
            memoryFreeUp();
            return;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (panel3.Tag?.ToString() == "HomeView")
            {
                return;
            }
            else
            {
                panel3.Tag = "HomeView";
                switchPanel(homeView);
                memoryFreeUp();
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
                panel3.Tag = "SettingsView";
                switchPanel(settingsView);
                memoryFreeUp();
                return;
            }
        }

    }
}