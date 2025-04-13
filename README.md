# Distance Calculator

>
> 🚧 Ontwikkeling verplaatst
> Deze functionaliteit was een proof-of-concept om om een efficiente manier afstanden tussen twee punten, waarvan een een postcode, te berekenen en op te slaan bij een Contact
> in het CRM-systeem. De proof-of-concept is geslaagd. De functionaliteit is nu verplaatst naar het CRM-systeem zelf om onderhoud centraal te houden en zoveel mogelijk 
> low-code principes toe te passen. 
>

## Inleding
Deze service berekent de hemelsbrede afstand tussen twee punten op de kaart. Het eerste punt wordt gespecificeerd met decimale coordinator. Het tweede punt wordt gespecificeerd met een postcode. De service haal voor de postcode de decimale coordinaten op bij OpenStreetMap. Vervolgens wordt de afstand berekend met de Haversine formule.

## Toepassing
De service wordt gebruikt door Land van Ons, waarbij voor leden/contacten de afstand tot de verschillende perselen wordt berekend. Dit met als doel om de juiste contacten/leden uit te nodigen voor activiteiten rond hun woonplaats of ze te voorzien van informatie over de percelen rond hun woonplaats. Percelen worden beheerd met hun decimale coordinator. Van contacten/leden zijn postcodes beschikbaar.

## Status en veiigheid
Dit is een proof-of-concept. De service verwerkt geen persoonsgegevens. Er is nog geen invoercontrole en foutafhandeling geimplementeerd.