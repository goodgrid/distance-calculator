var ContactCoordinatenLat = (double)Get<decimal>("ContactCoordinatenLat");
var ContactCoordinatenLon = (double)Get<decimal>("ContactCoordinatenLon");
var PerceelCoordinatenLat = (double)Get<decimal>("PerceelCoordinatenLat");
var PerceelCoordinatenLon = (double)Get<decimal>("PerceelCoordinatenLon");

if (double.IsNaN(ContactCoordinatenLat) || double.IsNaN(ContactCoordinatenLon) || double.IsNaN(PerceelCoordinatenLat) || double.IsNaN(PerceelCoordinatenLon)) {
    return true;
} else {
	const double R = 6371; // Aarde straal in kilometers
	
	// Defintiie van een functie: converteer graden naar radialen
	double ToRad(double deg) => deg * (Math.PI / 180);

	double dLat = ToRad(ContactCoordinatenLat - PerceelCoordinatenLat);
	double dLon = ToRad(ContactCoordinatenLon - PerceelCoordinatenLon);

	double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
		Math.Cos(ToRad(ContactCoordinatenLat)) * Math.Cos(ToRad(PerceelCoordinatenLat)) * 
		Math.Sin(dLon / 2) * 
		Math.Sin(dLon / 2);

	double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

	int distance = (int)Math.Round(c * R);

	Set("ContactPerceelAfstand", distance);
}

return true;