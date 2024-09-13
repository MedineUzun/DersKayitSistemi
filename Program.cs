using Npgsql;

namespace YazLab_1
{
    internal static class Program
    {


        private static string Host = "localhost";
        private static string User = "postgres";
        private static string DBname = "Yazlab1";
        private static string Password = "b123";
        private static string Port = "5432";

        static void Main()
        {

            string connString =
               String.Format(
                   "Server={0}; User Id={1}; Database={2}; Port={3}; Password={4};SSLMode=prefer",
                   Host,
                   User,
                   DBname,
                   Port,
                   Password);

            using (var conn = new NpgsqlConnection(connString))
            {

                Console.Out.WriteLine("Opening connection");
                conn.Open();

            }

            Console.WriteLine("Press RETURN to exit");
            Console.ReadLine();

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}