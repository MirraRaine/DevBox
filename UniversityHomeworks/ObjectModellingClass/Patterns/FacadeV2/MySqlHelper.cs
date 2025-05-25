namespace UniversityHomeworks.ObjectModellingClass.Patterns.FacadeV2
{
    public class MySqlHelper
    {
        public static Connection GetMySqlDBConnection()
        {
            //get MySql DB connection using connection parameters
            return null;
        }

        public void GenerateMySqlPDFReport(String tableName, Connection con)
        {
            //get data from table and generate pdf report
        }

        public void GenerateMySqlHTMLReport(String tableName, Connection con)
        {
            //get data from table and generate pdf report
        }
    }
}
