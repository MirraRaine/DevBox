namespace UniversityHomeworks.ObjectModellingClass.Patterns.FacadeV2
{
    public class HelperFacade
    {
        public static void GenerateReport(DBTypes dbType, ReportTypes reportType, string tableName)
        {
            Connection con = null;
            switch (dbType)
            {
                case DBTypes.MYSQL:
                    con = MySqlHelper.GetMySqlDBConnection();
                    MySqlHelper mySqlHelper = new MySqlHelper();
                    switch (reportType)
                    {
                        case ReportTypes.HTML:
                            mySqlHelper.GenerateMySqlHTMLReport(tableName, con);
                            break;
                        case ReportTypes.PDF:
                            mySqlHelper.GenerateMySqlPDFReport(tableName, con);
                            break;
                    }
                    break;
                case DBTypes.ORACLE:
                    con = OracleHelper.GetOracleDBConnection();
                    OracleHelper oracleHelper = new OracleHelper();
                    switch (reportType)
                    {
                        case ReportTypes.HTML:
                            oracleHelper.GenerateOracleHTMLReport(tableName, con);
                            break;
                        case ReportTypes.PDF:
                            oracleHelper.GenerateOraclePDFReport(tableName, con);
                            break;
                    }
                    break;
            }
        }
    }
}
