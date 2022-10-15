// vehicule
class vehicule
{
    // proprieté de la classe 
    public string nom { get; set; }
    public int prix { get; set; }
    public string couleur { get; set; }
    public string roue { get; set; }

    // constructeur
    public vehicule(string nom, int prix, string couleur, string roue)
    {
        this.nom = nom;
        this.prix = prix;
        this.couleur = couleur;
        this.roue = roue;

    }


}

// voiture
class voiture
{
    public string nom { get; set; }
    public int prix { get; set; }
    public string couleur { get; set; }
    public string roue { get; set; }
    public string moteur { get; set; }


}
// moto
class moto
{
    public string nom { get; set; }
    public int prix { get; set; }
    public string couleur { get; set; }
    public string roue { get; set; }
    public string moteur { get; set; }



}