using Microsoft.EntityFrameworkCore;

namespace Angelix_Vazques_P2_AP1.DAL;

public class Contexto : DbContext
{
    public Contexto(DbContextOptions<Contexto> options) : base(options) { }

}
