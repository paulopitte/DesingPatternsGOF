Console.WriteLine("Builder Sample 2");


public sealed partial class OrgChartMember
{
    public OrgChartMember(string id, string name) => (Id, Name) = (id, name);

    public string Name { get; private set; }
    public string Id { get; private set; }
    Lazy<List<OrgChartMember>> _team = new();
    public IReadOnlyList<OrgChartMember> Team => _team.Value;
    public static OrgChartMember Create(string id, string name) 
        => new(id, name);
}

sealed partial class OrgChartMember
{
    public OrgChartMember AddTeamMember(string id, string name)
    {
        var member = new OrgChartMember(id, name);
        _team.Value.Add(member);
        return member;
    }
}
