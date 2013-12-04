using System;
using System.Data;
using System.Data.OleDb;

namespace Table_Model.DAL
{
	public abstract class BaseGateway
	{
		public BaseGateway()
		{
		}
        //alteradas as connectionStrings

        //private const string _CONNSTR = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=gandalf.dei.isep.ipp.pt\sqlexpress; Initial Catalog=ARQSI056;UserID=ARQSI056;Password=ARQSI056";
        private const string _CONNSTR = @"Provider=SQLOLEDB;Data Source=gandalf.dei.isep.ipp.pt\sqlexpress;Initial Catalog=ARQSI056;Persist Security Info=True;User ID=ARQSI056;Password=ARQSI056";
        
		private string CONNSTR
		{
			get 
			{
				//return System.Configuration.ConfigurationSettings.AppSettings["ConnStr"];
               return _CONNSTR;
            }
		}

        

		protected OleDbConnection GetConnection(bool open)
		{
			OleDbConnection cnx = new OleDbConnection(CONNSTR);
			if (open)
				cnx.Open();
			return cnx;
		}

        protected DataSet GetDataSet(string Sql)
        {
            OleDbConnection conn = new OleDbConnection(_CONNSTR);
            OleDbDataAdapter adp = new OleDbDataAdapter(Sql, conn);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            conn.Close();
            return ds;
        }


	}
}
