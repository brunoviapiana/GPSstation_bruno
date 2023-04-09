using System.Data.SqlClient;

namespace GpsStation.Models
{
	public class UsuarioModel
	{
		public UsuarioModel() { }
		public UsuarioModel(Boolean administrador, string nome, string senha, Guid id_usuario)
		{
			Administrador = administrador;
			Nome = nome;
			Senha = senha;
			Id_usuario = id_usuario;
		}
		public Boolean Administrador { get; set; }
		public string Nome { get; set; }
		public string Senha { get; set; }
		public Guid Id_usuario { get; set; }






		private readonly static string conexao = @"Data Source=ACER_B\TEW_SQLEXPRESS;
Initial Catalog=gpsstation;
User ID=user;
Password=********;
Connect Timeout=30;
Encrypt=False;
Trust Server Certificate=False;
Application Intent=ReadWrite;
Multi Subnet Failover=False";


		public static List<UsuarioModel> GetUsuarios()
		{

			var listaUsuarios = new List<UsuarioModel>();

			var sql = "select * from usuario";


			try
			{





				using (var con = new SqlConnection(conexao))
				{
					con.Open();
					using (var cmd = new SqlCommand(sql, con))
					{

						using (var dr = cmd.ExecuteReader())
						{
							if (dr.HasRows)
							{
								while (dr.Read())
								{
									listaUsuarios.Add(new UsuarioModel(
										Convert.ToBoolean(dr["administrador"]),
										dr["nome"].ToString(),
										dr["senha"].ToString(),
										Guid.Parse((string)dr["Id_usuario"])
										));
								}

							}

						}
					}

				}

			}
			catch (Exception ex)
			{
				Console.Write("Erro leitura de usuarios no banco de dados " + ex.Message);
			}
			return listaUsuarios;
		}


	}
}

