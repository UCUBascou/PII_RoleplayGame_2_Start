namespace Ucu.Poo.RolePlayGame
{
public class Dwarf
{
    // Atributos de Dwarf

    //Nombre
    private string name;
    public string Name
    {
        get {return this.name;} set {this.name=value;}
    }

    // Equipment
    // El método "set" actua como función que asigna un item en caso de no tener un item previo,
    // pero tambien actua como "cambiar item" porque sin importar lo que tenga el personaje anteriormente
    // la variable se limpia y se le asigna un nuevo valor.
    private Axe axe;
    public Axe Axe
    {
        get {return this.axe;} set {this.axe=value;}
    }
    private Shield shield;
    public Shield Shield
    {
        get {return this.shield;} set {this.shield=value;}
    }
    private Helmet helmet;
    public Helmet Helmet
    {
        get {return this.helmet;} set {this.helmet=value;}
    }

    //Stats
    private int baseHealth;
    public int BaseHealth
    {
        get {return this.baseHealth;} set {this.baseHealth=value;}
    }
    private int health;
    public int Health
    {
        get {return this.health;} set {this.health=value;}
    }
    private int attackValue;
    public int AttackValue
    {
        get {return this.attackValue;} set {this.attackValue=value;}
    }
    private int defenseValue;
    public int DefenseValue
    {
        get {return this.defenseValue;} set {this.defenseValue=value;}
    }
    //Métodos
    public void RemoveAxe()
    {
        this.Axe = null;
    }
    public void RemoveShield()
    {
        this.Shield = null;
    }
    public void RemoveHelmet()
    {
        this.Helmet = null;
    }
    public int GetTotalAttack()
    {
        int ataqueTotal = 0;
        ataqueTotal += this.AttackValue;
        if (this.Axe != null){ataqueTotal += this.Axe.AttackValue;}
        if (this.Shield != null){ataqueTotal += this.Shield.AttackValue;}
        if (this.Helmet != null){ataqueTotal += this.Helmet.AttackValue;}
        return ataqueTotal; // El ataque total es la suma del ataque del personaje y de los ataques de sus ítems
    }
    public int GetTotalDefense()
    {
        int defensaTotal = 0;
        defensaTotal += this.DefenseValue;
        if (this.Axe != null){defensaTotal += this.Axe.DefenseValue;}
        if (this.Shield != null){defensaTotal += this.Shield.DefenseValue;}
        if (this.Helmet != null){defensaTotal += this.Helmet.DefenseValue;}
        return defensaTotal; // La defensa total es la suma de la defensa del personaje y de las defensas de sus ítems
    }
    public void ReceiveAttack(int incomingDMG) // ReceiveAttack necesita que se le ingrese el ataque entrante al personaje, luego se calcula el ataque total recibido
    {
        int dmgReceived=incomingDMG-this.GetTotalDefense(); // El ataque recibido por el personaje es la resta entre el ataque entrante y la estadística de defensa total
        if (dmgReceived>0) // Si el ataque recibido es positivo (es decir que la defensa no logró bloquear el ataque entrante)
        {
            this.Health-=dmgReceived; // Se resta el daño recibido a la vida actual
        }
    }
    public void Cure()
    {
        this.Health=this.BaseHealth; // Curarse es retaurar la vida actual a la vida base (vida completa)
    }
    //Constructor
    public Dwarf(string Dname, int basehp, int AV, int DV)
    {
        this.Name=Dname;
        this.BaseHealth=basehp; //base health point (no se modifica)
        this.Health=basehp; // Health modificable para el método ReceiveAttack
        this.AttackValue=AV; // Attack points
        this.DefenseValue=DV; // Defense points
    }
}
}