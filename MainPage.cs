using Microsoft.Win32;
using System.Runtime.InteropServices;
using Windows_Cleanup.Helper;
using Windows_Cleanup.Views;

namespace Windows_Cleanup
{
    public partial class MainPage : Form, IDisposable
    {
        public Button buttonHome, buttonSettings, buttonBasicTools;
        public static MainPage mainPageInstance;
        HomeView homeView = new HomeView();
        SettingsView settingsView = new SettingsView();
        BasicToolsView basicToolsView = new BasicToolsView();
        bool updateThemeTaskRunning;
        bool isLightMode;
        [DllImport("DwmApi")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue, int attrSize);
        public MainPage()
        {
            InitializeComponent();
            OptimizedDoubleBuffer();
            mainPageInstance = this;
            buttonHome = btnHome;
            buttonSettings = btnSettings;
            buttonBasicTools = btnBasicTools;
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            panel3.Tag = "HomeView";
            switchPanel(homeView);
            ThemeHelper.buttonBorderClear();
            btnHome.FlatAppearance.BorderSize = 1;
            //memoryFreeUp();
            //themeChecker();
        }

        public void memoryFreeUp()
        {
            Invalidate();
            Refresh();
            Update();
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
                Invalidate();
                Refresh();
                Update();
                isLightMode = false;
                //memoryFreeUp();
                return;
            }
            else // Light Mode
            {
                DwmSetWindowAttribute(Handle, 19, new[] { 0 }, 4);
                ThemeHelper.LightTheme();
                isLightMode = true;
                Invalidate();
                Refresh();
                Update();
            }
            //memoryFreeUp();
            return;
        }

        public async Task updateTheme()
        {
            updateThemeTaskRunning = true;
            do
            {
                await Task.Delay(500);
                themeChecker();
                memoryFreeUp();
            }
            while (updateThemeTaskRunning);
            return;
        }

        public void switchPanel(Form panel)
        {
            panel3.Controls.Clear();
            panel.TopLevel = false;
            panel.FormBorderStyle = FormBorderStyle.None;
            panel.Dock = DockStyle.Fill;
            //panel.AutoSize = true;
            panel.AutoSizeMode = AutoSizeMode.GrowOnly;
            //panel.AutoScroll = true;
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
            Invalidate();
            Refresh();
            Update();
            //memoryFreeUp(); <- causes minimize freeze
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
            }
        }

        private void MainPage_ResizeEnd(object sender, EventArgs e)
        {
            memoryFreeUp();
        }

        public void OptimizedDoubleBuffer()
        {
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
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
                ThemeHelper.buttonBorderClear();
                btnHome.FlatAppearance.BorderSize = 1;
                switchPanel(homeView);
                //memoryFreeUp();
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
                ThemeHelper.buttonBorderClear();
                btnSettings.FlatAppearance.BorderSize = 1;
                switchPanel(settingsView);
                //memoryFreeUp();
                return;
            }
        }

        private void btnBasicTools_Click(object sender, EventArgs e)
        {
            if (panel3.Tag?.ToString() == "BasicToolsView")
            {
                return;
            }
            else
            {
                panel3.Tag = "BasicToolsView";
                ThemeHelper.buttonBorderClear();
                btnBasicTools.FlatAppearance.BorderSize = 1;
                switchPanel(basicToolsView);
                //memoryFreeUp();
                return;
            }
        }
    }
}