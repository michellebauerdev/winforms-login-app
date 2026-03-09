namespace WinFormsApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            frmLogin login = new frmLogin();
            login.Show();
            Application.Run();
        }
    }
}