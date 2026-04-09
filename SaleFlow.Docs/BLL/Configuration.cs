namespace BLL.Services
{
    public class Configuration
    {
        public required Jwt Jwt { get; set; }
        public required DataBase DataBase { get; set; }
    }

    public class DataBase()
    {
        public required string ConnectionString { get; set; }
        public bool MockDB { get; set; }
    }
    public class Jwt()
    {
        public required string SecretKey { get; set; }
        public required string Issuer { get; set; }
        public required string Audience { get; set; }
    }
}