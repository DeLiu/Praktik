using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for SQLDatabase
/// </summary>
public class SQLDatabase
{
    private string dbNavn = "";
    private string dbServer = "";
    private string dbUsername = "";
    private string dbPassword = "";
    private SqlConnection dbConn;
    public SQLDatabase(string dbNavn, string dbServer, string dbUsername, string dbPassword)
    {
        this.dbNavn = dbNavn;
        this.dbServer = dbServer;
        this.dbUsername = dbUsername;
        this.dbPassword = dbPassword;
    }

    public bool Open()
    {
        try
        {
            this.dbConn = new SqlConnection(@"Data Source=(" + this.dbServer + ")\v11.0; AttachDbFilename=|DataDirectory|\"" + this.dbNavn + "; Integrated Security=SSPI");
            this.dbConn.Open();

            return true;
        }
        catch (Exception)
        {
            //MessageBox.Show("Der kunne ikke oprettes forbindelse til databasen.");

            return false;
        }
    }

    public int Exec(string SQLQuery)
    {
        SqlCommand dbCMD = new SqlCommand(SQLQuery, this.dbConn);   //Forbered en ny SQL statement

        try
        {
            int Result = dbCMD.ExecuteNonQuery();   //Eksekvere SQL sætningen og få nummeret på påvirkede rækker

            if (Result > 0)         //Hvis nogle rækker blev påvirket
            {
                return Result;
            }
            else    //Hvis ingen rækker blev påvirket
            {
                return 0;
            }
        }
        catch
        {
            return -1;      //En fejl opstod
        }
    }

    public string[][] Query(string SQLQuery)
    {
        SqlCommand dbCMD = new SqlCommand(SQLQuery, this.dbConn);
        DataSet dataSet = new DataSet();

        try
        {
            SqlDataAdapter DataAdapter = new SqlDataAdapter(dbCMD);
            DataAdapter.Fill(dataSet);
        }
        catch
        {
            return new string[0][];         //retunerer tom array
        }

        DataRowCollection dbRecords = dataSet.Tables[0].Rows;
        int ColumnCount = dataSet.Tables[0].Columns.Count;

        string[][] Result = new string[dbRecords.Count][];  //Opretter hoved-array

        for (int i = 0; i < dbRecords.Count; i++)   //for hver tupel
        {
            Result[i] = new string[ColumnCount];

            for (int i2 = 0; i2 < ColumnCount; i2++)        //for hver tupel i hver kolonne
            {
                Result[i][i2] = Convert.ToString(dbRecords[i][i2]); //konverterer hver kolonne til en string
            }
        }

        return Result;
    }

    public void Close()
    {
        this.dbConn.Close();
    }
}