using Microsoft.Win32;
using System.Runtime.InteropServices;
using Windows_Cleanup.Helper;

namespace Windows_Cleanup
{
    public partial class MainPage : Form
    {
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
                await Task.Delay(1000);
                themeChecker();
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
            }
            while (taskRunning);

        }
        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            themeChecker();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }

        private void MainPage_Activated(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                // Do some stuff
                taskRunning = false;
            }
            if (WindowState == FormWindowState.Normal)
            {
                taskRunning = false;
            }
            taskRunning = false;
        }

        private void MainPage_Deactivate(object sender, EventArgs e)
        {
            //taskRunning = true;
            updateTheme();
            if (WindowState == FormWindowState.Minimized)
            {
                // Do some stuff
                taskRunning = false;
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }

        private void MainPage_Resize(object sender, EventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }
    }
}