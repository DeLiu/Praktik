﻿using System;
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
    /// Adds an SHA256 encrypted IP to the database.
    /// </summary>
    /// <param name="ip">The IP which you want added to the database.</param>
    
    public void Add(string ip)
    {
        try
        {
            DB.Open();
            DB.Exec("INSERT INTO ips VALUES('Danmark', '" + Sha256(ip) + "')");

            /* TODO: Fix this shit, currently spamming the DB with lots of land names.
            
            foreach (CultureInfo ci in CultureInfo.GetCultures(CultureTypes.SpecificCultures))
            {
                RegionInfo ri = new RegionInfo(ci.Name);
                DB.Exec("INSERT INTO ips VALUES('" + ri.EnglishName + "', '" + Sha256(ip) + "')");
            }
             */
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

            ips = getIps.Length + 1;
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