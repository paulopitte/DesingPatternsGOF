using static System.Console;
namespace _01_Sample.Concrete
{
    // ConcreteBuilder
    class Notebook_DELL_Builder : ComputerBuilder
    {
        Computer computer = null;

        public Notebook_DELL_Builder()
        {
            computer = new Computer("NoteBook DELL ");
            WriteLine(" Iniciando a construção do NoteBook Dell Inspiron.....");
        }

        /// <summary>
        /// Implementação de negocio para o determinado produto
        /// </summary>
        public override void BuilderOS()
        {
            WriteLine("Instalando Sistema Operacional no Notebook...  ");
        }

        /// <summary>
        /// Implementação de negocio para o determinado produto
        /// </summary>
        public override void DevicesBuilder()
        {
            WriteLine("Instalando Dispositivos(RAM, Placa de vídeo, HD) no Notebook...  ");
        }

        /// <summary>
        /// Representa o produto criado
        /// </summary>
        public Computer ComputerType { get { return computer; } }
    }
}
