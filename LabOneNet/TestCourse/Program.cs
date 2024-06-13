var names = new List<string>()
{

    "Estevan","Melany","Santiago","Ana","Gloria"

};


//n es un alias
var namesResult = from n in  names
                  where n.Length <= 3
                  orderby n
                  select n;

foreach (var name in namesResult)
{
    Console.WriteLine(name);

}


//Esta es la manera por decirlo asi de las personas que vienen de 
//SQL  lo puedan entender
//var namesResult = from n in names
//                  where n.Length <= 3 && n.Length < 5
//                  orderby n descending
//                  select n;

//Esta es la manera de como c# lo entiende ya que trabaja con funciones
//Tambien lo llamamos funciones R o funciones lambda

//var namesResult2 = names.Where(n => n.Length > 3 && n.Length <5)
//                        .OrderByDescending(nameof => n)
//                        .Select(d => d);