using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using MAVA.SqlQuerys;
using System.Threading;

namespace MAVA
{
    static class Program
    {
        public static string SqlConnectionString;
        //Sql fonksiyonlarýný kullanmak için o fonksiyonun bulunduðu sýnýfýn nesnesini oluþturuyoruz.
        static KlimaSatisKontrolSql sqlQrys = new KlimaSatisKontrolSql();
        static GetPostKontrol sqlQuery1 = new GetPostKontrol();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //sql için baðlantý stringi alýyoruz
            getSqlString();
            //thread tanýmlama
            Thread thread = new Thread(new ThreadStart(StatuCheck));
            thread.Start();
            //ilk formun çalýþtýrýlmasý
            Application.Run(new Giris());

        }

        private static void getSqlString()
        {
            //app.configden deðerleri alýyoruz
            string serverName = ConfigurationManager.AppSettings["servername"];
            string database = ConfigurationManager.AppSettings["database"];
            string username = ConfigurationManager.AppSettings["username"];
            string password = ConfigurationManager.AppSettings["password"];
            //global olarak oluþturduðumuz stringe, baðlantý stringini atýyoruz
            SqlConnectionString = "Data Source=" + serverName + ";Initial Catalog=" + database + 
                ";User Id=" + username + ";Password=" + password + ";MultipleActiveResultSets = True";
        }
        private static void StatuCheck()
        {
            while (true)
            {
                //klima satýþlarýnýn tarihlerini kontrol ediyoruz
                sqlQrys.StatuKontrol();
                //baðlantý saðlanan portlarý kontrol ediyoruz
                sqlQuery1.OpenPortKontrol();
                //kapanan ama satýþý aktif olan klimalarý açýyoruz
                sqlQrys.OpenCloseCheck();
                //1 dakika bekletiyoruz
                Thread.Sleep(60000);
            }
        }
    }
}
