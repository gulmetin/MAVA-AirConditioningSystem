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
        //Sql fonksiyonlar�n� kullanmak i�in o fonksiyonun bulundu�u s�n�f�n nesnesini olu�turuyoruz.
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

            //sql i�in ba�lant� stringi al�yoruz
            getSqlString();
            //thread tan�mlama
            Thread thread = new Thread(new ThreadStart(StatuCheck));
            thread.Start();
            //ilk formun �al��t�r�lmas�
            Application.Run(new Giris());

        }

        private static void getSqlString()
        {
            //app.configden de�erleri al�yoruz
            string serverName = ConfigurationManager.AppSettings["servername"];
            string database = ConfigurationManager.AppSettings["database"];
            string username = ConfigurationManager.AppSettings["username"];
            string password = ConfigurationManager.AppSettings["password"];
            //global olarak olu�turdu�umuz stringe, ba�lant� stringini at�yoruz
            SqlConnectionString = "Data Source=" + serverName + ";Initial Catalog=" + database + 
                ";User Id=" + username + ";Password=" + password + ";MultipleActiveResultSets = True";
        }
        private static void StatuCheck()
        {
            while (true)
            {
                //klima sat��lar�n�n tarihlerini kontrol ediyoruz
                sqlQrys.StatuKontrol();
                //ba�lant� sa�lanan portlar� kontrol ediyoruz
                sqlQuery1.OpenPortKontrol();
                //kapanan ama sat��� aktif olan klimalar� a��yoruz
                sqlQrys.OpenCloseCheck();
                //1 dakika bekletiyoruz
                Thread.Sleep(60000);
            }
        }
    }
}
