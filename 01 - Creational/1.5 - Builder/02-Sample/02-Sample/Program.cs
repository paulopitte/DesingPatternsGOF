Console.WriteLine("Builder Sample 2");

OrgChartMember builder = OrgChartMember.Create("1", "Paulo Pitte")
                          .AddSubordinate("2", "Esposa", b => b
                            .AddSubordinate("2-1", "Filho 1"))
                            .AddSubordinate("2-2", "Filho 2", c => c
                                    .AddSubordinate("2-2-1", "Neto 1")
                                    .AddSubordinate("2-2-2", "Neto 2"))
                          .AddSubordinate("3", "Esposa 2")
                          .AddSubordinate("4", "Esposa 3");
                          //.Build(); /// REALIZO A OPERAÇÃO DE CHAMADA DE FORMA IMPLICITA


/// Classe de Representação 
public sealed partial record class OrgChartMember
{
    private OrgChartMember(string id, string name) => (Id, Name) = (id, name);




    public string Name { get; private set; }
    public string Id { get; private set; }
    Lazy<List<OrgChartMember>> _team = new();
    public IReadOnlyList<OrgChartMember> Team => _team.Value;

    
    
    
    /// Factory Method
    public static OrgChartBuilder Create(string id, string name) => new(new OrgChartMember(id, name));



    
    
    
    ///Classe com lógica da construção(Builder)
    public class OrgChartBuilder
    {
        readonly OrgChartMember _root;
        public OrgChartBuilder(OrgChartMember root) => _root = root;


        public OrgChartBuilder AddSubordinate(string id, string name)
        {
            _root._team.Value.Add(new OrgChartMember(id, name));
            return this;
        }

        public OrgChartBuilder AddSubordinate(string id, string name, Action<OrgChartBuilder> action)
        {
            var a = new OrgChartBuilder(new OrgChartMember(id, name));
            action(a);
            _root._team.Value.Add(a.Build());
            return this;
        }

        public OrgChartMember Build() => _root;

        public static implicit operator OrgChartMember(OrgChartBuilder input) => input.Build();



    }
}





