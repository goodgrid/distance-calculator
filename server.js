import axios from 'axios'
import express from 'express'

const app = express();

app.use(express.json())
app.listen(8080, () => console.log("Server gestart"));

app.get("/api/:coordinates/:postalCode", async (req, res) => {
    //52.035988,5.137436 

    const [ lat1, lon1 ] = req.params.coordinates.split(",")
    const postalCode = req.params.postalCode

    const { data } = await axios.get(`https://nominatim.openstreetmap.org/search?format=json&q=${postalCode},The Netherlands`)
    
    const lat2 = data[0].lat
    const lon2 = data[0].lon
    
    res.json({
        description: data[0].display_name,
        distance: {
            kilometers: Math.round(haversineDistance(lat1, lon1, lat2, lon2))
        }
    })
})

const haversineDistance = (lat1, lon1, lat2, lon2) => {
    const R = 6371; // Aarde straal in kilometers
    const toRad = (deg) => deg * (Math.PI / 180);

    const dLat = toRad(lat2 - lat1);
    const dLon = toRad(lon2 - lon1);

    const a = Math.sin(dLat / 2) * Math.sin(dLat / 2) +
              Math.cos(toRad(lat1)) * Math.cos(toRad(lat2)) *
              Math.sin(dLon / 2) * Math.sin(dLon / 2);

    const c = 2 * Math.atan2(Math.sqrt(a), Math.sqrt(1 - a));

    return R * c; // Afstand in kilometers
}