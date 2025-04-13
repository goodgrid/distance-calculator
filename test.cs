using System;

class Program
{
    static void Main()
    {
        // Aarde straal in kilometers
        const double R = 6371; 

        // Voorbeeld coördinaten
        double PerceelLatt = 52.913222;
        double PerceelLong = 6.541576;
        double ContactLatt = 52.096956923076924;
        double ContactLong = 5.042270603846154;

        double dLat = ToRad(ContactLatt - PerceelLatt);
        double dLon = ToRad(ContactLong - PerceelLong);
        
        double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
            Math.Cos(ToRad(ContactLatt)) * Math.Cos(ToRad(PerceelLatt)) * 
            Math.Sin(dLon / 2) * 
            Math.Sin(dLon / 2);
        
        double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

        int distance = (int)Math.Round(c * R);

        Console.WriteLine(distance);
    }

    static double ToRad(double deg)
    {
        return deg * (Math.PI / 180);
    }
}