using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

/// <summary>
/// Summary description for Statistik
/// </summary>
public class Statistik
{
    SQLDatabase DB = new SQLDatabase("JTM.mdf", "LocalDB", "", "");

	public Statistik()
	{
		
	}

    public void Add(string ip) //TODO: Land.
    {
        try
        {
            DB.Open();
            DB.Exec("INSERT INTO ips VALUES('" + Sha256(ip) + "')");
        }
        catch (Exception ex)
        {

        }
        finally
        {
            DB.Close();
        }
    }

    public int GetIpCount()
    {
        int ips = 0;
        try
        {
            DB.Open();
            string[][] getIps = DB.Query("SELECT * FROM ips");

            for (int i = 0; i < getIps.Count; i++)
            {
                ips++;
            }
        }
        catch (Exception ex)
        {

        }
        finally
        {
            DB.Close();
        }

        return ips;
    }

    public string Sha256(string value)
    {
        StringBuilder Sb = new StringBuilder();

        using (SHA256 hash = SHA256Managed.Create())
        {
            Encoding enc = Encoding.UTF8;
            byte[] result = hash.ComputeHash(enc.GetBytes(value));

            foreach (byte b in result)
                Sb.Append(b.ToString("x2"));
        }

        return Sb.ToString();
    }
}