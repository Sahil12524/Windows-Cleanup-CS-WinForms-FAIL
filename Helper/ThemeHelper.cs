namespace Windows_Cleanup.Helper
{
    public class ThemeHelper
    {
        //static MainPage mainPage = new MainPage();
        //static HomeView homeView = new HomeView();
        public static void DarkTheme()
        {
            foreach (Form form in Application.OpenForms.OfType<Form>())
            {
                form.BackColor = Color.FromArgb(32, 32, 32);
                form.ForeColor = SystemColors.Control;
            }
            MainPage.mainPageInstance.buttonHome.FlatStyle = FlatStyle.Flat;
            MainPage.mainPageInstance.buttonHome.Image = Properties.Resources.home32x32Dark;
            MainPage.mainPageInstance.buttonHome.ImageAlign = ContentAlignment.MiddleLeft;
            MainPage.mainPageInstance.buttonHome.TextAlign = ContentAlignment.MiddleCenter;
        }

        public static void LightTheme()
        {
            foreach (Form form in Application.OpenForms)
            {
                form.BackColor = SystemColors.Control;
                form.ForeColor = SystemColors.ControlText;
            }
            MainPage.mainPageInstance.buttonHome.FlatStyle = FlatStyle.Flat;
            MainPage.mainPageInstance.buttonHome.Image = Properties.Resources.home32x32;
            MainPage.mainPageInstance.buttonHome.ImageAlign = ContentAlignment.MiddleLeft;
            MainPage.mainPageInstance.buttonHome.TextAlign = ContentAlignment.MiddleCenter;
        }
    }
}
