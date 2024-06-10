
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;



namespace QUANTUMWEB.Models

{
	public class MusterilerDb
	{
		SqlConnection con = new SqlConnection("Server=DESKTOP-NVH768C\\SQLEXPRESS16;Database=QuantumProje;Trusted_Connection=true");


		public string Saverecord(Musteriler emp)
		{
			try
			{

				SqlCommand com = new SqlCommand("sp_AddDenemeMusteri", con);
				com.CommandType = CommandType.StoredProcedure;
				com.Parameters.AddWithValue("@MusteriId", emp.MusteriId);
				com.Parameters.AddWithValue("@Kodu", emp.Kodu);
				com.Parameters.AddWithValue("@Adi", emp.Adi);
				com.Parameters.AddWithValue("@TckNo", emp.TckNo);
				com.Parameters.AddWithValue("@Il", emp.Il);
				com.Parameters.AddWithValue("@Ilce", emp.Ilce);


				con.Open();
				SqlDataReader reader = com.ExecuteReader();

				reader.Close();
				con.Close();
				return ("ok");
			}
			catch (Exception ex)
			{
				if (con.State == ConnectionState.Open)

				{
					con.Close();
				}

				return (ex.Message.ToString());
			}

		}
	}
}

