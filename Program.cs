namespace ApexClientV2
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new CadSplash(5000));
        }
    }
}