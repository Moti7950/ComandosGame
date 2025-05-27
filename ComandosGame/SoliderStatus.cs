public class SoliderStatus
{
    public string name;
    public string nameCode;
    public string[] Tolls = { "Hammer", "chisel", "rope", "bag", "water" };
    public string status;
    
    public StartGame(string name, string nameCode, string[] Tolls, string status)
    {
        this.name = name;
        this.nameCode = nameCode;
        this.Tolls = Tolls;
        this.status = status;
    }
    public void Walk()
    {
        this.status = "Walk";
        System.Console.WriteLine("The solider walking now");
    }
    public void Hide()
    {
        this.status = "Hide";
        System.Console.WriteLine("The solider hideing now");
    }
    public void Attack(string Attack_enimil)
    {
        this.status = "Attack";
        System.Console.WriteLine($"The solider attacted {Attack_enimil}");
    }
}

