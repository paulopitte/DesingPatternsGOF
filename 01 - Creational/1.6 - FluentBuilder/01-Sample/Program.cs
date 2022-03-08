 using static System.Console;

namespace _01_Sample
{

    /*
     * 
     * FluentBuilder nada mais é uma variação do padrao Builder,
     
     * É um estilo de codificação quue força o dev a criar o objeto em seguencia, chamando cada metodo setter, um após o outro, até que todos os atributos necessários sejam configurados.
     * este padrão fornce uma interface fluida o que torna o código mais limpo e facil de ler.
     * 
     * esse cara é semelhante a FluentAPI ou fluent interface que é orientada a objetos cuja o design se baseia no encadeamento de metodos.
     * 
     * exemplo:
     * 
     * listaAlunos.Where(x=>x.Idade > 18)
     *            .Select(s => x)
     *            .Where(n => n.Nota > 5)
     *            .Select(a => a.Nome)
     *            .FirstOnDefault();
     * 
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine(" ****** Fluent Builder Sample 01 *******");
            WriteLine("*************************************");
            WriteLine();

            var emailBuilder = new EmailBuilder();

            var email = emailBuilder
                       .To("microsoft@email.com")
                       .From("paulopitte@gmail.com")
                       .Subject("Micrsofot Build")
                       .Body("Microsoft Build 2021\n\t25 a 27 de Maio 2021" +
                                "\n\tNovidades Windows,Azure,Office e mais")
                       .CriaEmail();

            WriteLine(email.ToString());
            ReadLine();

        }
    }
}
