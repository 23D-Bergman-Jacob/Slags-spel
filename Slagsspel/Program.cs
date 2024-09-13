// See https://aka.ms/new-console-template for more information
Random rnd = new Random();
string sk1;
string sk2;
int sk1hp = rnd.Next(220, 290);
int sk2hp = rnd.Next(230, 280);
int sk1s;
int sk2s;
int slag = 0;
System.Console.WriteLine("Vad heter slagskämpe 1?");
sk1 = Console.ReadLine();
System.Console.WriteLine("Vad heter slagskämpe 2?");
sk2 = Console.ReadLine();
// Console.Clear();
while (1==1){
Console.ReadLine();
slag ++;
sk1s = rnd.Next(20, 30);
sk2s = rnd.Next(20, 30);
sk1hp = sk1hp - sk2s;
sk2hp = sk2hp - sk1s;
System.Console.WriteLine("Efter slag "+ slag + " har "+ sk1 +" "+ sk1hp +" liv kvar och "+sk2+ " "+sk2hp + " kvar");
if (sk1hp < 1){ break;}
if (sk2hp < 1){ break;}
}
if (sk1hp>0){
    System.Console.WriteLine("Grattis "+ sk1 + "!!!!");
}
if (sk2hp>0){
    System.Console.WriteLine("Grattis "+ sk2+"!!!!!");
}
if (sk2hp<0&sk1hp<0){System.Console.WriteLine("Oavgjort!");}
Console.ReadLine();
//correct();
//static void correct()
// {
// upprepande kåd
// }