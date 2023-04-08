﻿namespace GpsStation.Models
{
    public class DispositivoModel
    {
        public DispositivoModel()
        {
            Id_dispositivo = new Guid();
            IdUsuario = new Guid();
            Nome = string.Empty;
            Ativo = false; 
        }

        Guid Id_dispositivo { get; set; }

        Guid IdUsuario { get; set; }
        public string Nome { get; set; }

        public bool Ativo { get; set; }
       
        /*
         {
            [pontoz: 10, pontoy: 20],
            [pontoz: 10, pontoy: 20]
         [pontoz: 10, pontoy: 20]
         [pontoz: 10, pontoy: 20]
         [pontoz: 10, pontoy: 20]
         [pontoz: 10, pontoy: 20]
        
        }
         */
    }
}
