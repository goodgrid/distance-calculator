using System;

class Program
{
    static void Main(string[] args)
    {
        //var ContactCoordinaten = Get<string>("ContactCoordinaten");
        //var PerceelCoordinaten = Get<string>("PerceelCoordinaten");

        string[] ContactCoordinaten = args[0];
        string[] PerceelCoordinaten = args[1];

        if (string.IsNullOrEmpty(ContactCoordinaten) || string.IsNullOrEmpty(PerceelCoordinaten)) {
            throw new Exception("Er zijn geen ContactCoordinaten en/of PerceelCoordinaten doorgegeven aan de script task.");
        } else {
            const double R = 6371; // Aarde straal in kilometers
            
            string[] ContactCoordinatenArray = ContactCoordinaten.Split(',');
            string[] PerceelCoordinatenArray = PerceelCoordinaten.Split(',');
            
            if (ContactCoordinatenArray.Length == 2 && PerceelCoordinatenArray.Length == 2)
            {
                // Zet de variabelen voor de coordinaten van het contact en het perceel
                double ContactLatt = double.Parse(ContactCoordinatenArray[0].Trim()); 
                double ContactLong = double.Parse(ContactCoordinatenArray[1].Trim()); 
                double PerceelLatt = double.Parse(PerceelCoordinatenArray[0].Trim()); 
                double PerceelLong = double.Parse(PerceelCoordinatenArray[1].Trim()); 

                // Defintiie van een functie. 
                // Converteer graden naar radialen
                //double ToRad(double deg) => deg * (Math.PI / 180);

                double dLat = ToRad(ContactLatt - PerceelLatt);
                double dLon = ToRad(ContactLong - PerceelLong);
            
                double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                    Math.Cos(ToRad(ContactLatt)) * Math.Cos(ToRad(PerceelLatt)) * 
                    Math.Sin(dLon / 2) * 
                    Math.Sin(dLon / 2);
            
                double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

                int distance = (int)Math.Round(c * R);

                Console.WriteLine(distance);
                //Set("ContactPerceelAfstand", distance);
            }
            else
            {
                throw new Exception("Er zijn ongeldige ContactCoordinaten en/of PerceelCoordinaten doorgegeven aan de script task.");
            }	
        }
    }
    static double ToRad(double deg)
    {
        return deg * (Math.PI / 180);
    }

}

//return true;