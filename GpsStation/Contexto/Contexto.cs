
using GpsStation.Models;
using Microsoft.EntityFrameworkCore;

namespace GpsStation.Data
{
    public class Contexto :DbContext //herança para utiliar o entity framework
    {
        //o construtor recebe um tipo DbContextOptions, setado como sendo da própria classe 
        //demos o nome de options
        // chama base:options para mandar a variável options para o construtor de DbContext (classe mae)
        public Contexto(DbContextOptions<Contexto> options):base(options)
        {
        }

        //criação de uma nova tabela
        //pega parâmetros da Model DispositivoModel e cria a tabela Dispositivos no banco
        public DbSet<DispositivoModel> Dispositivos { get; set; }
    }
}
