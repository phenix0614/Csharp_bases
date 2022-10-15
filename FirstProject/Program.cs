// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, PhenixWorld j'apprends le C#");
// methode Write -> sans saut de ligne 

// langage fortement typé les variable ne change jamais de type 
// declaré une variable TYPE NOM = Val
// on peu declaré une Var sans la typé mais en utilisant instruction var NOM = Val obligation d'assigner une valeur pour que le compilateur puisse la typé 

string name = "stephane";
int age = 38;
 
Console.WriteLine(name);
age = 39;
Console.WriteLine(age);

// sous c# une constante est fortement typé , ni sa valeur ni sont type ne sont modifiable 
const string boss = "papa";
Console.WriteLine(boss);
// boss = "mama";
// Console.WriteLine(boss);
Console.WriteLine("qui est le boss");
var saisie = Console.ReadLine();
 Console.WriteLine(saisie + " " + "est le Boss");