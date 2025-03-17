# Distance Calculator

## Inleding
Deze service berekent de hemelsbrede afstand tussen twee punten op de kaart. Het eerste punt wordt gespecificeerd met decimale coordinator. Het tweede punt wordt gespecificeerd met een postcode. De service haal voor de postcode de decimale coordinaten op bij OpenStreetMap. Vervolgens wordt de afstand berekend met de Haversine formule.

## Toepassing
De service wordt gebruikt door Land van Ons, waarbij voor leden/contacten de afstand tot de verschillende perselen wordt berekend. Dit met als doel om de juiste contacten/leden uit te nodigen voor activiteiten rond hun woonplaats of ze te voorzien van informatie over de percelen rond hun woonplaats. Percelen worden beheerd met hun decimale coordinator. Van contacten/leden zijn postcodes beschikbaar.

## Status en veiigheid
Dit is een proof-of-concept. De service verwerkt geen persoonsgegevens. Er is nog geen invoercontrole en foutafhandeling geimplementeerd.