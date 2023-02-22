namespace Windows_Cleanup.Helper
{
    public class ThemeHelper
    {
        public static void DarkTheme()
        {
            foreach (Form form in Application.OpenForms)
            {
                form.BackColor = Color.FromArgb(32, 32, 32);
                form.ForeColor = SystemColors.Control;
            }
        }
        public static void LightTheme()
        {
            foreach (Form form in Application.OpenForms)
            {
                form.BackColor = SystemColors.Control;
                form.ForeColor = SystemColors.ControlText;
            }
        }
    }
}
