
namespace _01_Sample
{
    // esse builder passa a ser um whapper
    public class EmailBuilder
    {
        private readonly Email _email;
        public EmailBuilder()
            => _email = new Email();

        public EmailBuilder To(string destino)
        {
            _email.To = destino;
            return this;
        }
        public EmailBuilder From(string origem)
        {
            _email.From = origem;
            return this;
        }
        public EmailBuilder Subject(string titulo)
        {
            _email.Subject = titulo;
            return this;
        }
        public EmailBuilder Body(string conteudo)
        {
            _email.Body = conteudo;
            return this;
        }
        public Email CriaEmail()
            => _email;

    }
}
