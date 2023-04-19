using Windows_Cleanup.Views;

namespace Windows_Cleanup.Helper
{
    public class ThemeHelper
    {
        //static MainPage mainPage = new MainPage();
        //static HomeView homeView = new HomeView();
        public static void buttonBorderClear()
        {
            MainPage.mainPageInstance.buttonHome.FlatAppearance.BorderSize = 0;
            MainPage.mainPageInstance.buttonSettings.FlatAppearance.BorderSize = 0;
            MainPage.mainPageInstance.buttonBasicTools.FlatAppearance.BorderSize = 0;
            return;
        }
        public static void DarkTheme()
        {
            //foreach (Form form in Application.OpenForms.OfType<Form>())
            //{
            //    form.BackColor = Color.FromArgb(32, 32, 32);
            //    form.ForeColor = SystemColors.Control;
            //}
            foreach (Form form in Application.OpenForms.OfType<Form>())
            {
                form.BackColor = Color.FromArgb(39, 39, 39);
                form.ForeColor = SystemColors.Control;
                if (form.Name == "MainPage")
                {
                    form.BackColor = Color.FromArgb(32, 32, 32);
                    form.ForeColor = SystemColors.Control;
                }
            }

            MainPage.mainPageInstance.buttonHome.FlatStyle = FlatStyle.Flat;
            //MainPage.mainPageInstance.buttonHome.FlatAppearance.BorderSize = 0;
            MainPage.mainPageInstance.buttonHome.Image = Properties.Resources.home32x32Dark;
            MainPage.mainPageInstance.buttonHome.ImageAlign = ContentAlignment.MiddleLeft;
            MainPage.mainPageInstance.buttonHome.TextAlign = ContentAlignment.MiddleCenter;

            MainPage.mainPageInstance.buttonSettings.FlatStyle = FlatStyle.Flat;
            //MainPage.mainPageInstance.buttonSettings.FlatAppearance.BorderSize = 0;
            MainPage.mainPageInstance.buttonSettings.Image = Properties.Resources.setting32x32Dark;
            MainPage.mainPageInstance.buttonSettings.ImageAlign = ContentAlignment.MiddleLeft;
            MainPage.mainPageInstance.buttonSettings.TextAlign = ContentAlignment.MiddleCenter;

            MainPage.mainPageInstance.buttonBasicTools.FlatStyle = FlatStyle.Flat;
            //MainPage.mainPageInstance.buttonBasicTools.FlatAppearance.BorderSize = 0;
            MainPage.mainPageInstance.buttonBasicTools.Image = Properties.Resources.setting32x32Dark;
            MainPage.mainPageInstance.buttonBasicTools.ImageAlign = ContentAlignment.MiddleLeft;
            MainPage.mainPageInstance.buttonBasicTools.TextAlign = ContentAlignment.MiddleCenter;

            BasicToolsView.basicToolsViewInstance.buttonTempFilesRemove.FlatStyle = FlatStyle.Flat;
            BasicToolsView.basicToolsViewInstance.buttonTempFilesRemove.FlatAppearance.BorderSize = 0;
            BasicToolsView.basicToolsViewInstance.buttonTempFilesRemove.BackColor = Color.Gray;
            BasicToolsView.basicToolsViewInstance.buttonTempFilesRemove.TextAlign = ContentAlignment.MiddleCenter;

            BasicToolsView.basicToolsViewInstance.buttonWindowsUpdateCacheClean.FlatStyle = FlatStyle.Flat;
            BasicToolsView.basicToolsViewInstance.buttonWindowsUpdateCacheClean.FlatAppearance.BorderSize = 0;
            BasicToolsView.basicToolsViewInstance.buttonWindowsUpdateCacheClean.BackColor = Color.Gray;
            BasicToolsView.basicToolsViewInstance.buttonWindowsUpdateCacheClean.TextAlign = ContentAlignment.MiddleCenter;

            BasicToolsView.basicToolsViewInstance.buttonCHKDSK.FlatStyle = FlatStyle.Flat;
            BasicToolsView.basicToolsViewInstance.buttonCHKDSK.FlatAppearance.BorderSize = 0;
            BasicToolsView.basicToolsViewInstance.buttonCHKDSK.BackColor = Color.Gray;
            BasicToolsView.basicToolsViewInstance.buttonCHKDSK.TextAlign = ContentAlignment.MiddleCenter;

            BasicToolsView.basicToolsViewInstance.buttonSSDTrim.FlatStyle = FlatStyle.Flat;
            BasicToolsView.basicToolsViewInstance.buttonSSDTrim.FlatAppearance.BorderSize = 0;
            BasicToolsView.basicToolsViewInstance.buttonSSDTrim.BackColor = Color.Gray;
            BasicToolsView.basicToolsViewInstance.buttonSSDTrim.TextAlign = ContentAlignment.MiddleCenter;

            return;
        }

        public static void LightTheme()
        {
            //foreach (Form form in Application.OpenForms)
            //{
            //    form.BackColor = SystemColors.Control;
            //    form.ForeColor = SystemColors.ControlText;
            //}
            foreach (Form form in Application.OpenForms.OfType<Form>())
            {
                form.BackColor = Color.FromArgb(249, 249, 249);
                form.ForeColor = SystemColors.ControlText;
                if (form.Name == "MainPage")
                {
                    form.BackColor = Color.FromArgb(243, 243, 243);
                    form.ForeColor = SystemColors.ControlText;
                }
            }
            MainPage.mainPageInstance.buttonHome.FlatStyle = FlatStyle.Flat;
            //MainPage.mainPageInstance.buttonHome.FlatAppearance.BorderSize = 0;
            MainPage.mainPageInstance.buttonHome.Image = Properties.Resources.home32x32;
            MainPage.mainPageInstance.buttonHome.ImageAlign = ContentAlignment.MiddleLeft;
            MainPage.mainPageInstance.buttonHome.TextAlign = ContentAlignment.MiddleCenter;

            MainPage.mainPageInstance.buttonSettings.FlatStyle = FlatStyle.Flat;
            //MainPage.mainPageInstance.buttonSettings.FlatAppearance.BorderSize = 0;
            MainPage.mainPageInstance.buttonSettings.Image = Properties.Resources.setting32x32;
            MainPage.mainPageInstance.buttonSettings.ImageAlign = ContentAlignment.MiddleLeft;
            MainPage.mainPageInstance.buttonSettings.TextAlign = ContentAlignment.MiddleCenter;

            MainPage.mainPageInstance.buttonBasicTools.FlatStyle = FlatStyle.Flat;
            //MainPage.mainPageInstance.buttonBasicTools.FlatAppearance.BorderSize = 0;
            MainPage.mainPageInstance.buttonBasicTools.Image = Properties.Resources.setting32x32;
            MainPage.mainPageInstance.buttonBasicTools.ImageAlign = ContentAlignment.MiddleLeft;
            MainPage.mainPageInstance.buttonBasicTools.TextAlign = ContentAlignment.MiddleCenter;

            BasicToolsView.basicToolsViewInstance.buttonTempFilesRemove.FlatStyle = FlatStyle.Flat;
            BasicToolsView.basicToolsViewInstance.buttonTempFilesRemove.FlatAppearance.BorderSize = 0;
            BasicToolsView.basicToolsViewInstance.buttonTempFilesRemove.BackColor = Color.White;
            BasicToolsView.basicToolsViewInstance.buttonTempFilesRemove.TextAlign = ContentAlignment.MiddleCenter;

            BasicToolsView.basicToolsViewInstance.buttonWindowsUpdateCacheClean.FlatStyle = FlatStyle.Flat;
            BasicToolsView.basicToolsViewInstance.buttonWindowsUpdateCacheClean.FlatAppearance.BorderSize = 0;
            BasicToolsView.basicToolsViewInstance.buttonWindowsUpdateCacheClean.BackColor = Color.White;
            BasicToolsView.basicToolsViewInstance.buttonWindowsUpdateCacheClean.TextAlign = ContentAlignment.MiddleCenter;

            BasicToolsView.basicToolsViewInstance.buttonCHKDSK.FlatStyle = FlatStyle.Flat;
            BasicToolsView.basicToolsViewInstance.buttonCHKDSK.FlatAppearance.BorderSize = 0;
            BasicToolsView.basicToolsViewInstance.buttonCHKDSK.BackColor = Color.White;
            BasicToolsView.basicToolsViewInstance.buttonCHKDSK.TextAlign = ContentAlignment.MiddleCenter;

            BasicToolsView.basicToolsViewInstance.buttonSSDTrim.FlatStyle = FlatStyle.Flat;
            BasicToolsView.basicToolsViewInstance.buttonSSDTrim.FlatAppearance.BorderSize = 0;
            BasicToolsView.basicToolsViewInstance.buttonSSDTrim.BackColor = Color.White;
            BasicToolsView.basicToolsViewInstance.buttonSSDTrim.TextAlign = ContentAlignment.MiddleCenter;

            return;
        }
    }
}
