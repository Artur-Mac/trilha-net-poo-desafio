using DesafioPOO.Models;


// (string numero, string modelo, string imei, int memoria)
Iphone iphone1 = new Iphone("402394023", "modelo lorem", "imei: 423432423", 256);

Nokia nokia1 = new Nokia("312312312", "modelo ipsum", "423423423423", 4);

nokia1.InstalarAplicativo("Wahtasapp");

Console.WriteLine(nokia1.Modelo);

nokia1.ReceberLigacao();


iphone1.InstalarAplicativo("Whatsapp");

Console.WriteLine(iphone1.Modelo);

iphone1.ReceberLigacao();

