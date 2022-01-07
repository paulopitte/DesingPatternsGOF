namespace _03_Sample
{
    // Abstract Product
    public abstract class DbConnector
    {
        protected DbConnector(string connectionString)
        {
            ConnectionString = connectionString;
        }

        protected string ConnectionString { get; set; }
        public abstract Connection Connect();
    }
}