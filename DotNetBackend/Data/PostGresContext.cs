using Microsoft.EntityFrameworkCore;

namespace quiltekvisten.Data
{
    public class PostGresContext(DbContextOptions<PostGresContext> options) : DbContext(options)
    {   
    }
}
