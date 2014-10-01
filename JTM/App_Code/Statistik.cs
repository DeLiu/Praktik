using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

/// <summary>
/// A class handling all statistic actions of the website.
/// </summary>

public class Statistik
{
    SQLDatabase DB = new SQLDatabase("JTM.mdf", "LocalDB", "", "");

	public Statistik()
	{
		
	}

    /// <summary>
    /// Adds an SHA256 encrypted IP and browser information to the database.
    /// </summary>
    /// <param name="ip">The IP which you want added to the database.</param>
    /// <param name="browserVersion">The version of the users browser.</param>
    /// <param name="browserPlatform">The users platform. e.g. WinNT.</param>
    
    public void Add(string ip, string browserName, string browserVersion, string browserPlatform)
    {
        try
        {
            int uniqueIp = 0; //If the IP already exists in the DB, we will not add it again. We only want unique ips.
            DB.Open();

            string[][] getIp = DB.Query("SELECT * FROM ips");

            for (int i = 0; i < getIp.Length; i++)
            {
                if (getIp[i][1] == Sha256(ip))
                {
                    uniqueIp++;
                }
            }

                if (uniqueIp == 0)
                {
                    DB.Exec("INSERT INTO ips VALUES('" + Sha256(ip) + "', '" + browserName + "', '" + browserVersion + "', '" + browserPlatform + "')");
                }
        }
        catch (Exception ex)
        {

        }
        finally
        {
            DB.Close();
        }
    }

    /// <summary>
    /// Gets and returns the number of IP addresses from the database.
    /// </summary>

    public int GetIpCount()
    {
        int ips = 0;
        try
        {
            DB.Open();
            string[][] getIps = DB.Query("SELECT * FROM ips");

            ips = getIps.Length;
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

    /// <summary>
    /// A method that hashes a string in the SHA256 format.
    /// </summary>
    /// <param name="value">The string you wish hashed.</param>

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