// using System.Collections.Generic;

// /*class Inventory {
//     public List<Objet> objets; //Propriété + ne peut être appelé qu'ici (private) + peut être appelé partout (public)
//     private void Trier(){ } //Méthode
// }*/

// class Objet{
//     public string nom;
//     public int quantite;

//     public Objet(int quantiteInitiale, string nomInitial){ //constructeur
//         quantite = quantiteInitiale;
//         nom = nomInitial;
//     }

//     private void IncrementerQuantite(int increment){
//         quantite = quantite + increment;
//     }

//     private void ModifierNom(string nouveauNom){
//         nom = nouveauNom
//     }
// }

// class Arme : Objet {    //héritage
//     private int pointsDegat;
//     public Arme(int quantiteInitiale, string nomInitial, int pointsDegatInitial) : base(quantiteInitiale, nomInitial) {
//         pointsDegat = pointsDegatInitial;
//     }
// }

// class Main {
//     void main() {
//         //Inventaire inventaire = new Inventaire(); on stock le new inv dans un élément de classe inv
//         //inventaire.objets = new List<Objet>()

//         Objet objet1 = new Objet(6, "Potion");
//         //objet1.nom = "Potion";    autre méthode
//         //objet1.quantite = 6;

//         Objet objet2 = new Objet(1, "Bouclier");
//         //objet2.nom = "Bouclier";
//         //objet2.quantite = 1;

//         Arme arme1 = new Arme(1, "Epee", 25);

//         /*inventaire.objets.Add(objet1);
//         inventaire.objets.Add(objet2);*/
//     }
// }