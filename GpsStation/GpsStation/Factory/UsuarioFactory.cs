using GpsStation.Models;

namespace GpsStation.Factory
{
    public class UsuarioFactory
    {
        public static List<UsuarioModel> GeradorMoqUsuarios(int numeroObjetos)
        {
            List<UsuarioModel> usuarios = new List<UsuarioModel>();
            for (int i = 0; i < numeroObjetos; i++)
            {
                usuarios.Add(new UsuarioModel()
                { 
                Administrador = true,
                Nome = "teste",//string.Empty;
                Senha = "123", //string.Empty;
                Id_usuario = new Guid()
            });
            }
            return usuarios;
        }
    }
}
