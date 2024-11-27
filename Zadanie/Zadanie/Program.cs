using Zadanie;
/*
List<Wektor> listaWektorow = new List<Wektor>();

using (StreamReader stream = File.OpenText("punkty.txt"))
{
    while (!stream.EndOfStream)
    {
        string line = stream.ReadLine();
        string[] punkty = line.Split(' ');
        double[] argumenty = new double[punkty.Length];
        
        for (int i = 0; i < punkty.Length; i++)
        {
            double result = 0;
            if(double.TryParse(punkty[i],out result)){
                argumenty[i] = result;
            }
        }
        if (punkty.Length == 4)
        {
            listaWektorow.Add(new Wektor(new Punkt(argumenty[0], argumenty[1]),new Punkt(argumenty[2], argumenty[3])));
        }
    }
}

for (int i = 0;i < listaWektorow.Count; i++)
{
    Console.WriteLine(listaWektorow[i].Dlugosc());
}
*/

List<WektorWieloWymiarowy> wektory = new List<WektorWieloWymiarowy>();

using (StreamReader stream = File.OpenText("punktywielowymiarowe.txt"))
{
    while (!stream.EndOfStream)
    {
        string line = stream.ReadLine() ?? "";
        string[] punkty = line.Split(' ');
        List<double> argumenty = new List<double>();
        
            for (int i = 0; i < punkty.Length; i++)
            {
                double result = 0;
                if (double.TryParse(punkty[i], out result))
                {
                    argumenty.Add(result);
                }
            }
        if (argumenty.Count() % 2 == 0 && argumenty.Count() >= 2)
        {
            wektory.Add(new WektorWieloWymiarowy(new PunktWieloWymiarowy(argumenty.GetRange(0, argumenty.Count / 2)), new PunktWieloWymiarowy(argumenty.GetRange(argumenty.Count / 2, argumenty.Count / 2))));
        }
    }
}

for (int i = 0; i < wektory.Count; i++)
{
    Console.WriteLine(wektory[i].Dlugosc());
}


