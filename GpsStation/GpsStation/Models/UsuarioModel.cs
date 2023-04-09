namespace GpsStation.Models
{
    public class UsuarioModel
    {
        public UsuarioModel()
        {
            //Administrador = true;
            //Nome = "teste";//string.Empty;
            //Senha = "123"; //string.Empty;
            //Id_usuario = new Guid();
        }

        public bool Administrador { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public Guid Id_usuario { get; set; }
    }
}
