// See https://aka.ms/new-console-template for more information
Console.WriteLine("LISTA DE SERIES");
Console.WriteLine();

List<string> serie = new List<string>();

//Agregar elementos a la lista

serie.Add("QUOTIENTS");
serie.Add("Coficiente Intelectual");
serie.Add("Coeficiente Emocional");
serie.Add("Coeficiente Social");
serie.Add("Coeficiente de Adversidad");
serie.Add("Coeficiente Cognitivo");
serie.Add("Coeficiente Cultural");



//Recorrido de la lista
foreach (string s in serie)
{
    Console.WriteLine("Serie -"+s);
}

Console.WriteLine();

serie.Insert(2, "Coeficiente de felicidad");

Console.WriteLine("Nueva lista con el elemento insertado en la posicion 2");
Console.WriteLine();

foreach (string s in serie)
{
    Console.WriteLine("Serie -"+s);
}
Console.WriteLine();

//Primera
bool respuesta = serie.Contains("Coeficiente de felicidad");
Console.WriteLine(respuesta);
if (respuesta)
{
    Console.WriteLine("Se encuentra el elemento en la escala de coeficientes.");

}
else
{
    Console.WriteLine("No se encuentra el elemento en la escala de coeficientes");
}

serie.Remove("Coeficiente Cognitivo");

foreach (string s in serie)
{
    Console.WriteLine("Serie -"+s);
}
Console.WriteLine();


// See https://aka.ms/new-console-template for more information
Console.WriteLine("LISTA DE SERIES");
Console.WriteLine();

List<string> serie = new List<string>();

//Agregar elementos a la lista

serie.Add("QUOTIENTS");
serie.Add("Coficiente Intelectual");
serie.Add("Coeficiente Emocional");
serie.Add("Coeficiente Social");
serie.Add("Coeficiente de Adversidad");
serie.Add("Coeficiente Cognitivo");
serie.Add("Coeficiente Cultural");



//Recorrido de la lista
foreach (string s in serie)
{
    Console.WriteLine("Serie -"+s);
}

Console.WriteLine();

serie.Insert(2, "Coeficiente de felicidad");

Console.WriteLine("Nueva lista con el elemento insertado en la posicion 2");
Console.WriteLine();

foreach (string s in serie)
{
    Console.WriteLine("Serie -"+s);
}
Console.WriteLine();

//Primera
bool respuesta = serie.Contains("Coeficiente de felicidad");
Console.WriteLine(respuesta);
if (respuesta)
{
    Console.WriteLine("Se encuentra el elemento en la escala de coeficientes.");

}
else
{
    Console.WriteLine("No se encuentra el elemento en la escala de coeficientes");
}

serie.RemoveAt(3);

foreach (string s in serie)
{
    Console.WriteLine("Serie -"+s);
}
Console.WriteLine();
