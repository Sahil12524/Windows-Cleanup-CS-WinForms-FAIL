using Windows_Cleanup.Views;

namespace Windows_Cleanup.Helper
{
    public class ThemeHelper
    {
        public static void buttonBorderClear()
        {
            if (MainPage.mainPageInstance != null)
            {
                MainPage.mainPageInstance.buttonHome.FlatAppearance.BorderSize = 0;
                MainPage.mainPageInstance.buttonSettings.FlatAppearance.BorderSize = 0;
                MainPage.mainPageInstance.buttonBasicTools.FlatAppearance.BorderSize = 0;
                MainPage.mainPageInstance.buttonNetTools.FlatAppearance.BorderSize = 0;
            }
            else
            {
                return;
            }
            return;
        }
        public static void DarkTheme()
        {
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

            if (MainPage.mainPageInstance != null)
            {
                MainPage.mainPageInstance.buttonHome.FlatStyle = FlatStyle.Flat;
                MainPage.mainPageInstance.buttonHome.Image = Properties.Resources.home32x32Dark;
                MainPage.mainPageInstance.buttonHome.ImageAlign = ContentAlignment.MiddleLeft;
                MainPage.mainPageInstance.buttonHome.TextAlign = ContentAlignment.MiddleCenter;

                MainPage.mainPageInstance.buttonSettings.FlatStyle = FlatStyle.Flat;
                MainPage.mainPageInstance.buttonSettings.Image = Properties.Resources.setting32x32Dark;
                MainPage.mainPageInstance.buttonSettings.ImageAlign = ContentAlignment.MiddleLeft;
                MainPage.mainPageInstance.buttonSettings.TextAlign = ContentAlignment.MiddleCenter;

                MainPage.mainPageInstance.buttonBasicTools.FlatStyle = FlatStyle.Flat;
                MainPage.mainPageInstance.buttonBasicTools.Image = Properties.Resources.smile32x32Dark;
                MainPage.mainPageInstance.buttonBasicTools.ImageAlign = ContentAlignment.MiddleLeft;
                MainPage.mainPageInstance.buttonBasicTools.TextAlign = ContentAlignment.MiddleCenter;

                MainPage.mainPageInstance.buttonNetTools.FlatStyle = FlatStyle.Flat;
                MainPage.mainPageInstance.buttonNetTools.Image = Properties.Resources.internet32x32Dark;
                MainPage.mainPageInstance.buttonNetTools.ImageAlign = ContentAlignment.MiddleLeft;
                MainPage.mainPageInstance.buttonNetTools.TextAlign = ContentAlignment.MiddleCenter;

            }
            else
            {
                return;
            }

            if (BasicToolsView.basicToolsViewInstance != null)
            {
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

            }
            else
            {
                return;
            }

            if (NetToolsView.netToolsViewInstance != null)
            {
                NetToolsView.netToolsViewInstance.buttonDisableNet.FlatStyle = FlatStyle.Flat;
                NetToolsView.netToolsViewInstance.buttonDisableNet.FlatAppearance.BorderSize = 0;
                NetToolsView.netToolsViewInstance.buttonDisableNet.BackColor = Color.Gray;
                NetToolsView.netToolsViewInstance.buttonDisableNet.TextAlign = ContentAlignment.MiddleCenter;

                NetToolsView.netToolsViewInstance.buttonFlushDNS.FlatStyle = FlatStyle.Flat;
                NetToolsView.netToolsViewInstance.buttonFlushDNS.FlatAppearance.BorderSize = 0;
                NetToolsView.netToolsViewInstance.buttonFlushDNS.BackColor = Color.Gray;
                NetToolsView.netToolsViewInstance.buttonFlushDNS.TextAlign = ContentAlignment.MiddleCenter;

                NetToolsView.netToolsViewInstance.buttonResetIP.FlatStyle = FlatStyle.Flat;
                NetToolsView.netToolsViewInstance.buttonResetIP.FlatAppearance.BorderSize = 0;
                NetToolsView.netToolsViewInstance.buttonResetIP.BackColor = Color.Gray;
                NetToolsView.netToolsViewInstance.buttonResetIP.TextAlign = ContentAlignment.MiddleCenter;

                NetToolsView.netToolsViewInstance.buttonEnableNet.FlatStyle = FlatStyle.Flat;
                NetToolsView.netToolsViewInstance.buttonEnableNet.FlatAppearance.BorderSize = 0;
                NetToolsView.netToolsViewInstance.buttonEnableNet.BackColor = Color.Gray;
                NetToolsView.netToolsViewInstance.buttonEnableNet.TextAlign = ContentAlignment.MiddleCenter;

                NetToolsView.netToolsViewInstance.buttonPacketLossTest.FlatStyle = FlatStyle.Flat;
                NetToolsView.netToolsViewInstance.buttonPacketLossTest.FlatAppearance.BorderSize = 0;
                NetToolsView.netToolsViewInstance.buttonPacketLossTest.BackColor = Color.Gray;
                NetToolsView.netToolsViewInstance.buttonPacketLossTest.TextAlign = ContentAlignment.MiddleCenter;

            }
            else
            {
                return;
            }

            return;
        }

        public static void LightTheme()
        {
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
            if (MainPage.mainPageInstance != null)
            {
                MainPage.mainPageInstance.buttonHome.FlatStyle = FlatStyle.Flat;
                MainPage.mainPageInstance.buttonHome.Image = Properties.Resources.home32x32;
                MainPage.mainPageInstance.buttonHome.ImageAlign = ContentAlignment.MiddleLeft;
                MainPage.mainPageInstance.buttonHome.TextAlign = ContentAlignment.MiddleCenter;

                MainPage.mainPageInstance.buttonSettings.FlatStyle = FlatStyle.Flat;
                MainPage.mainPageInstance.buttonSettings.Image = Properties.Resources.setting32x32;
                MainPage.mainPageInstance.buttonSettings.ImageAlign = ContentAlignment.MiddleLeft;
                MainPage.mainPageInstance.buttonSettings.TextAlign = ContentAlignment.MiddleCenter;

                MainPage.mainPageInstance.buttonBasicTools.FlatStyle = FlatStyle.Flat;
                MainPage.mainPageInstance.buttonBasicTools.Image = Properties.Resources.smile32x32;
                MainPage.mainPageInstance.buttonBasicTools.ImageAlign = ContentAlignment.MiddleLeft;
                MainPage.mainPageInstance.buttonBasicTools.TextAlign = ContentAlignment.MiddleCenter;

                MainPage.mainPageInstance.buttonNetTools.FlatStyle = FlatStyle.Flat;
                MainPage.mainPageInstance.buttonNetTools.Image = Properties.Resources.internet32x32;
                MainPage.mainPageInstance.buttonNetTools.ImageAlign = ContentAlignment.MiddleLeft;
                MainPage.mainPageInstance.buttonNetTools.TextAlign = ContentAlignment.MiddleCenter;

            }
            else
            {
                return;
            }


            if (BasicToolsView.basicToolsViewInstance != null)
            {
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

            }
            else
            {
                return;
            }


            if (NetToolsView.netToolsViewInstance != null)
            {
                NetToolsView.netToolsViewInstance.buttonDisableNet.FlatStyle = FlatStyle.Flat;
                NetToolsView.netToolsViewInstance.buttonDisableNet.FlatAppearance.BorderSize = 0;
                NetToolsView.netToolsViewInstance.buttonDisableNet.BackColor = Color.White;
                NetToolsView.netToolsViewInstance.buttonDisableNet.TextAlign = ContentAlignment.MiddleCenter;

                NetToolsView.netToolsViewInstance.buttonFlushDNS.FlatStyle = FlatStyle.Flat;
                NetToolsView.netToolsViewInstance.buttonFlushDNS.FlatAppearance.BorderSize = 0;
                NetToolsView.netToolsViewInstance.buttonFlushDNS.BackColor = Color.White;
                NetToolsView.netToolsViewInstance.buttonFlushDNS.TextAlign = ContentAlignment.MiddleCenter;

                NetToolsView.netToolsViewInstance.buttonResetIP.FlatStyle = FlatStyle.Flat;
                NetToolsView.netToolsViewInstance.buttonResetIP.FlatAppearance.BorderSize = 0;
                NetToolsView.netToolsViewInstance.buttonResetIP.BackColor = Color.White;
                NetToolsView.netToolsViewInstance.buttonResetIP.TextAlign = ContentAlignment.MiddleCenter;

                NetToolsView.netToolsViewInstance.buttonEnableNet.FlatStyle = FlatStyle.Flat;
                NetToolsView.netToolsViewInstance.buttonEnableNet.FlatAppearance.BorderSize = 0;
                NetToolsView.netToolsViewInstance.buttonEnableNet.BackColor = Color.White;
                NetToolsView.netToolsViewInstance.buttonEnableNet.TextAlign = ContentAlignment.MiddleCenter;

                NetToolsView.netToolsViewInstance.buttonPacketLossTest.FlatStyle = FlatStyle.Flat;
                NetToolsView.netToolsViewInstance.buttonPacketLossTest.FlatAppearance.BorderSize = 0;
                NetToolsView.netToolsViewInstance.buttonPacketLossTest.BackColor = Color.White;
                NetToolsView.netToolsViewInstance.buttonPacketLossTest.TextAlign = ContentAlignment.MiddleCenter;

            }
            else
            {
                return;
            }

            return;
        }
    }
}
