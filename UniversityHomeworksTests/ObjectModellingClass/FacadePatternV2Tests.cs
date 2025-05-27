using UniversityHomeworks.ObjectModellingClass.Patterns.FacadeV2;

namespace UniversityHomeworksTests.ObjectModellingClass
{
    [TestClass]
    public class FacadePatternV2Tests
    {
        [TestMethod]
        public void Client_Test()
        {
            string tableName = "Employee";

            //generating MySql HTML report and Oracle PDF report without using Facade
            Connection con = MySqlHelper.GetMySqlDBConnection();
            MySqlHelper mySqlHelper = new MySqlHelper();
            mySqlHelper.GenerateMySqlHTMLReport(tableName, con);

            Connection con1 = OracleHelper.GetOracleDBConnection();
            OracleHelper oracleHelper = new OracleHelper();
            oracleHelper.GenerateOraclePDFReport(tableName, con1);

            //generating MySql HTML report and Oracle PDF report using Facade
            HelperFacade.GenerateReport(DBTypes.MYSQL, ReportTypes.HTML, tableName);
            HelperFacade.GenerateReport(DBTypes.ORACLE, ReportTypes.PDF, tableName);
        }
    }
}
