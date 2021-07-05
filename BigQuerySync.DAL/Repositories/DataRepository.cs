using System.Data.SqlClient;

namespace BigQuerySync.DAL.Repositories
{
    public class DataRepository
    {
        protected int CommandTimeOut = 100;
        protected int PageSize = 20;
        protected int OffSet = 20;
        private int _pageIndex;

        public int PageIndex
        {
            get { return _pageIndex; }
            set
            {
                _pageIndex = value;
                OffSet = PageSize * (value - 1);
            }
        }

        protected SqlConnection Connection { get; private set; }

        internal DataRepository(string connStr)
        {
            var conns = connStr ?? "Password=Password1!;Persist Security Info=True;User ID=admin;Initial Catalog=PortalWorkflowIntegration;Data Source=vn-db-01-uph\\externaldb";
            this.Connection = new SqlConnection(conns);
        }
    }


}
