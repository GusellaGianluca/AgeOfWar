// See https://aka.ms/new-console-template for more information
using AgeOfWar.Personaggi;

Cavaliere cav1 = new Cavaliere(200);

Cavaliere[] SquadraRossa = new Cavaliere[100];
for (int i = 1; i <= 100; i++)
{
    SquadraRossa[i] = new Cavaliere(200);
    SquadraRossa[i].Squadra = "Rossi";
}
