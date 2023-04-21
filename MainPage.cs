using Microsoft.Win32;
using System.Runtime.InteropServices;
using Windows_Cleanup.Helper;
using Windows_Cleanup.Views;

namespace Windows_Cleanup
{
    public partial class MainPage : Form, IDisposable
    {
        public Button buttonHome, buttonSettings, buttonBasicTools, buttonNetTools;
        public static MainPage? mainPageInstance { get; set; }
        HomeView homeView = new HomeView();
        SettingsView settingsView = new SettingsView();
        BasicToolsView basicToolsView = new BasicToolsView();
        NetToolsView netToolsView = new NetToolsView();
        [DllImport("DwmApi")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue, int attrSize);
        public MainPage()
        {
            InitializeComponent();
            OptimizedDoubleBuffer();
            SystemEvents.UserPreferenceChanged += SystemEvents_UserPreferenceChanged;
            mainPageInstance = this;
            buttonHome = btnHome;
            buttonSettings = btnSettings;
            buttonBasicTools = btnBasicTools;
            buttonNetTools = btnNetTools;
            this.Disposed += new EventHandler(Form_Disposed);
        }

        private void Form_Disposed(object? sender, EventArgs e)
        {
            SystemEvents.UserPreferenceChanged -= SystemEvents_UserPreferenceChanged;
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            panel3.Tag = "HomeView";
            switchPanel(homeView);
            ThemeHelper.buttonBorderClear();
            btnHome.FlatAppearance.BorderSize = 1;
        }

        public void memoryFreeUp()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            return;
        }

        private void SystemEvents_UserPreferenceChanged(object sender, UserPreferenceChangedEventArgs e)
        {
            if (e.Category == UserPreferenceCategory.VisualStyle || e.Category == UserPreferenceCategory.General)
            {
                // Windows theme has changed, so update the application theme
                themeChecker();
            }
        }

        public void themeChecker()
        {
            int lightmode = (int)Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Themes\Personalize", "AppsUseLightTheme", "1")!;
            if (lightmode != 1) // Dark Mode
            {
                if (DwmSetWindowAttribute(Handle, 19, new[] { 1 }, 4) != 0)
                {
                    DwmSetWindowAttribute(Handle, 20, new[] { 1 }, 4);
                    return;
                }
                ThemeHelper.DarkTheme();
                return;
            }
            else // Light Mode
            {
                DwmSetWindowAttribute(Handle, 19, new[] { 0 }, 4);
                ThemeHelper.LightTheme();
            }
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
            return;
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
                return;
            }
        }

        private void btnNetTools_Click(object sender, EventArgs e)
        {
            if (panel3.Tag?.ToString() == "NetToolsView")
            {
                return;
            }
            else
            {
                panel3.Tag = "NetToolsView";
                ThemeHelper.buttonBorderClear();
                btnNetTools.FlatAppearance.BorderSize = 1;
                switchPanel(netToolsView);
                return;
            }
        }
    }
}