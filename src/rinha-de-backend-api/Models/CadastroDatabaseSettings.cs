namespace rinha_de_backend_api.Models
{
    public class CadastroDatabaseSettings
    {
        public string ConnectionString { get; set; } = null!;

        public string DatabaseName { get; set; } = null!;

        public string PessoasCollectionName { get; set; } = null!;
    }
}
