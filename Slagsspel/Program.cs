// See https://aka.ms/new-console-template for more information
using System.ComponentModel;

Random rnd = new Random();
string sk1;
string sk2;
int sk2n = rnd.Next(1, 3);
int sk1hp = rnd.Next(220, 290);
int sk2hp = rnd.Next(230, 280);
int sk1s;
int sk2s;
string atk = "0";
string spd = "0";
string hp = "0";
int atki = 0;
int spdi = 0;
int hpi = 0;
int hp2;
int at2;
int sp2;
int sp2x;
int spdix;
while (1==1)
{hp2 =rnd.Next(1, 5);
at2 =rnd.Next(1, 5);
sp2 =rnd.Next(1, 5);
if (hp2+at2+sp2==10){break;}}
// System.Console.WriteLine(hp2+at2+sp2);}
sk2 = "h";
if (sk2n == 1)
{
    sk2 = "Blastois";
}
if (sk2n == 2)
{
    sk2 = "Venasaur";
}
if (sk2n == 3)
{
    sk2 = "Charizard";
}
int slag = 0;
while (1==1)
{
System.Console.WriteLine("Vad heter din pokemon?");
sk1 = Console.ReadLine();
if (sk1.Length<3){System.Console.WriteLine("namnet är för kort");}
if (sk1.Length>10){System.Console.WriteLine("namnet är för långt");}
if (sk1.Length<=10 && sk1.Length >=3){break;}   
System.Console.WriteLine("Fighten börjar!!");

}
while (1==1){
System.Console.WriteLine("Här får du välja hur din gubbe ska se ut. Du har 10 poäng och du kan sprida ut dom mellan attack \n  Hp och snabbhet du kan välja alla mellan 1 och 5 alla värden måste ha ett värde" );
 System.Console.WriteLine("Din speed är?");
 spd = Console.ReadLine();
 System.Console.WriteLine("din attack är?");
 atk = Console.ReadLine();
 System.Console.WriteLine("din hp är?");
 hp = Console.ReadLine();
 if (spd == "1"){spdi=1;} 
 if (spd == "2"){spdi=2;} 
 if (spd == "3"){spdi=3;} 
 if (spd == "4"){spdi=4;} 
 if (spd == "5"){spdi=5;} 
 if (atk == "1"){atki=1;}
 if (atk == "2"){atki=2;}
 if (atk == "3"){atki=3;}
 if (atk == "4"){atki=4;}
 if (atk == "5"){atki=5;}
 if(hp == "1"){hpi=1;}
 if(hp == "2"){hpi=2;}
 if(hp == "3"){hpi=3;}
 if(hp == "4"){hpi=4;}
 if(hp == "5"){hpi=5;}
 if (hpi==0){System.Console.WriteLine("gör om gör rätt!");
 hpi=11;}
 if (atki==0){System.Console.WriteLine("gör om gör rätt!");
 atki=11;}
 if (spdi==0){System.Console.WriteLine("gör om gör rätt!");
 spdi=11;}
if (spdi+atki+hpi<=10){break;}
}
sk1hp=+20*hpi;
sk2hp=+hp2*20;
while (1==1){
Console.ReadLine();
// correct();
slag ++;
sk1s = rnd.Next(10, 20)+atki;
sk2s = rnd.Next(10, 20)+at2;
spdix = rnd.Next(1,5)+spdi;
sp2x = rnd.Next(1,5)+sp2;
if (spdix >= sp2x){
sk1hp =-sk2s;
if (sk1hp>0){
sk2hp =- sk1s;}}
sk2s =+2*at2;
if (spdix < sp2x){
sk2hp =-sk1s;
if (sk2hp>0){
sk1hp =- sk2s;}}
System.Console.WriteLine("Efter Attack "+ slag + " har "+ sk1 +" "+ sk1hp +" liv kvar och "+sk2+ " "+sk2hp + " kvar");
if (sk1hp < 1){ break;};
if (sk2hp < 1){ break;}
}
if (sk1hp>0&sk2hp<0){
    System.Console.WriteLine("Grattis "+ sk1 + "!!!!");
}
if (sk2hp>0&sk1hp<0){
    System.Console.WriteLine("Grattis "+ sk2+"!!!!!");
}
if (sk2hp<0&sk1hp<0){System.Console.WriteLine("Oavgjort!");}
Console.ReadLine();
//correct();
// static void correct()
// {

// System.Console.WriteLine("""

 
// """);
// }