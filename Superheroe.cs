class Superheroe
{
    public string Nombre { get; set; } 
    public string Ciudad { get; set; }
    public double Peso { get; set; }  
    public double Fuerza { get; set; } 
    public double Velocidad { get; set; } 

    public Superheroe() { }

    public Superheroe(string nombre, string ciudad, double peso, double fuerza, double velocidad)
    {
        Nombre = nombre;
        Ciudad = ciudad;
        Peso = peso;
        Fuerza = fuerza;
        Velocidad = velocidad; 
    }
   
    public double ObtenerSkill()
    {
        double skill;
        Random rnd = new Random();
        int azar = rnd.Next(1,11);
        skill = (Velocidad*0.6) + (Fuerza*0.8) + (azar);
        return skill;
    }
}