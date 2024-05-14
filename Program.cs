using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
string Celular = Console.ReadLine();

if(Celular == "Nokia")
{
// Nokia
Nokia n1 = new Nokia("(91) 9 6677-6677", "SXXS", "IMEI NOKIA", 99);
n1.Ligar();
n1.ReceberLigacao();
n1.InstalarAplicativo("Thor");
}

else if(Celular == "Iphone")
{
//Iphone
Iphone i1 = new Iphone("(24) 9 7766-7766", "PRO-MAX-RICH-666", "IMEI IPHONE", 2);
i1.Ligar();
i1.ReceberLigacao();
i1.InstalarAplicativo("Chicken");
}

else
{
    throw new Exception("Não TEM");
}