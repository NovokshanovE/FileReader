namespace FileReader
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            formStartSelect StartWindow = new formStartSelect();
            Application.Run(StartWindow);
            
            FormFile formFile = new FormFile(StartWindow.StreamReader_Output(), StartWindow.FilePath_Output());
            Application.Run(formFile);

        }
    }
}