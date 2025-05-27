public class Commando
{
    public string name { get; set; }
    public string nameCode { get; set; }
    public string[] Tolls = { "Hammer", "chisel", "rope", "bag", "water" };
    public string status { get; set; }
    public Weapon x;


    public Commando(string name, string nameCode, string status , Weapon x)
    {
        this.name = name;
        this.nameCode = nameCode;
        this.status = status;
        this.x = x;
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
   
    public void Attack()
    {
        this.status = "Attack";
        System.Console.WriteLine($"The solider attacted {name}");
    }
}

