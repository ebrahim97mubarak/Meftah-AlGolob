using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace FinalProject
{
    public class Class_LinkOfServer
    {
        public enum NameOfStoredProcedure
        {
            DeleteOfDuteies,
            DeleteOfDuteiesOfTypes,
            DeleteOfDuteiesOfUsers,
            DeleteOfPeaces,
            DeleteOfPeacesUnitsOfProjectes,
            DeleteOfProjects,
            DeleteOfTypese,
            DeleteOfUnits,
            DeleteOfUsers,
            InsertOfDuteies,
            InsertOfDuteiesOfTypes,
            InsertOfDuteiesOfUsers,
            InsertOfPeaces,
            InsertOfPeacesUnitsOfProjectes,
            InsertOfProjects,
            InsertOfTypese,
            InsertOfUnits,
            InsertOfUsers,
            PrivetSelectOneOfDataOfUsers,
            PrivetSelectOneOfDataOfUsersByIDType,
            SelectAllDataOfDuteies,
            SelectAllDataOfPeaces,
            SelectAllDataOfProjects,
            SelectAllDataOfTypese,
            SelectAllDataOfUnits,
            SelectAllDataOfUsers,
            SelectMaxOfIDNoDataOfDuteies,
            SelectMaxOfIDNoDataOfPeaces,
            SelectMaxOfIDNoDataOfProjects,
            SelectMaxOfIDNoDataOfTypese,
            SelectMaxOfIDNoDataOfUnits,
            SelectMaxOfIDNoDataOfUsers,
            SelectOneOfDataOfDuteies,
            SelectOneOfDataOfDuteiesOfTypes,
            SelectOneOfDataOfDuteiesOfUsers,
            SelectOneOfDataOfPeaces,
            SelectOneOfDataOfPeacesUnitsOfProjectes,
            SelectOneOfDataOfProjects,
            SelectOneOfDataOfTypese,
            SelectOneOfDataOfUnits,
            SelectOneOfDataOfUsers,
            UpdateOfDuteies,
            UpdateOfPeaces,
            UpdateOfProjects,
            UpdateOfTypese,
            UpdateOfUnits,
            UpdateOfUsers
        }
        public enum NameOfFildes
        {
            IDNo,
            Number,
            FirstName,
            IDDuty,
            IDType,
            IDUser,
            Pecture,
            IDProjects,
            IDPeaces,
            HorezantalDirection,
            VerticalDirection,
            NoRow,
            NoClouman,
            Quantity,
            IDUnit,
            MUX,
            Passwords,
            Telephon,
            Title
        }
        public SqlConnection sqlConnection = new SqlConnection("Server = DESKTOP-FPR4KDQ; Database = MeftahAlGolob; User Id = sa; Password = 0123456789;"/*"Data Source=(LocalDB)\\MSSQLLocalDB;" +
            "AttachDbFilename=C:\\Users\\Ibrahim\\Desktop\\Hammed\\FinalProject\\FinalProject\\" +
            "FinalProject.mdf;Integrated Security=True"*/);
        SqlCommand sqlCommand;
        SqlParameter[] sqlParameters;
        SqlParameter sqlParameter;
        DataTable dataTable;
        SqlDataAdapter sqlDataAdapter;
        public DataTable ReadData(NameOfStoredProcedure nameOfStoredProcedure)
        {
            sqlCommand = new SqlCommand(nameOfStoredProcedure.ToString(), sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
            }
            sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            if (sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }
            return dataTable;
        }
        public DataTable ReadData(NameOfStoredProcedure nameOfStoredProcedure, NameOfFildes[] nameOfFildes, SqlDbType[] TypeOfDatas, string[] Datas)
        {
            sqlCommand = new SqlCommand(nameOfStoredProcedure.ToString(), sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlParameters = new SqlParameter[2];
            for (int i = 0; i < nameOfFildes.Length; i++)
            {
                if (TypeOfDatas[i] == SqlDbType.Binary || TypeOfDatas[i] == SqlDbType.NVarChar)
                {
                    sqlParameters[i] = new SqlParameter("@" + nameOfFildes[i].ToString(), TypeOfDatas[i], 50);
                }
                else
                {
                    sqlParameters[i] = new SqlParameter("@" + nameOfFildes[i].ToString(), TypeOfDatas[i]);
                }
                sqlParameters[i].Value = Datas[i];
            }
            sqlCommand.Parameters.AddRange(sqlParameters);
            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
            }
            sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            if (sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }
            return dataTable;
        }
        public DataTable ReadData(NameOfStoredProcedure nameOfStoredProcedure, NameOfFildes nameOfFildes, SqlDbType TypeOfDatas, string Data)
        {
            sqlCommand = new SqlCommand(nameOfStoredProcedure.ToString(), sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            if (TypeOfDatas == SqlDbType.Binary || TypeOfDatas == SqlDbType.NVarChar)
            {
                sqlParameter = new SqlParameter("@" + nameOfFildes.ToString(), TypeOfDatas, 50);
            }
            else
            {
                sqlParameter = new SqlParameter("@" + nameOfFildes.ToString(), TypeOfDatas);
            }
            sqlParameter.Value = Data;
            sqlCommand.Parameters.Add(sqlParameter);
            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
            }
            sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            if (sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }
            return dataTable;
        }
        public void WriteData(NameOfStoredProcedure nameOfStoredProcedure, NameOfFildes[] nameOfFildes, SqlDbType[] TypeOfDatas, string[] Datas)
        {
            sqlCommand = new SqlCommand(nameOfStoredProcedure.ToString(), sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlParameters = new SqlParameter[nameOfFildes.Length];
            for (int i = 0; i < nameOfFildes.Length; i++)
            {
                if (TypeOfDatas[i] == SqlDbType.Binary || TypeOfDatas[i] == SqlDbType.NVarChar)
                {
                    sqlParameters[i] = new SqlParameter("@" + nameOfFildes[i].ToString(), TypeOfDatas[i], 50);
                }
                else
                {
                    sqlParameters[i] = new SqlParameter("@" + nameOfFildes[i].ToString(), TypeOfDatas[i]);
                }
                sqlParameters[i].Value = Datas[i];
            }
            sqlCommand.Parameters.AddRange(sqlParameters);
            if (sqlConnection.State!=ConnectionState.Open)
            {
                sqlConnection.Open();
            }
            sqlCommand.ExecuteNonQuery();
            if (sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }
    }
}
