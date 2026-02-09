namespace quiltekvisten.Service
{
    public class DatabaseService
    {
        private readonly string _connectionString;

        public DatabaseService(IConfiguration configuration) 
        {
            _connectionString = configuration.GetConnectionString("quiltekvistenConnectionString");
        }
    }
}
