using XIIRPL2_19_Tiket.MasterForm;

namespace XIIRPL2_19_Tiket
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

            // Login login = new Login();
            //login.Show();

           //Kodepromo kodepromo = new Kodepromo();
           //kodepromo.Show();

             //maskapai maskapai = new maskapai();
             //maskapai.Show();

            Masterbandara masterbandara = new Masterbandara();
            masterbandara.Show();

            //Jadwalpenerbangan jadwalpenerbangan = new Jadwalpenerbangan();
           // jadwalpenerbangan.Show();

            Application.Run();
        }
    }
}