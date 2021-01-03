/**
 * Dessine la carte des sations avec l'api google map
 * @param {any} stations
 */
function drawStationsMap(stations) {
    var map = new google.maps.Map(document.getElementById('map'), {
        zoom: 12,
        center: new google.maps.LatLng(stations[0].Latitude, stations[0].Longitude),
        mapTypeId: google.maps.MapTypeId.ROADMAP
    });

    var infowindow = new google.maps.InfoWindow();

    for (const station of stations) {
        let marker = new google.maps.Marker({
            position: new google.maps.LatLng(station.Latitude, station.Longitude),
            map: map,
            icon: {
                url: "/images/marker.png",
                scaledSize: new google.maps.Size(35, 40),
                labelOrigin: new google.maps.Point(29, 6)
            },
            label: {
                text: station.count.toString(),
                color: 'black',
                fontSize: "10px"
            }
        });
        google.maps.event.addListener(marker, 'click', () => {
            let content = '<div class="text-center p-1">';
            content += '<div class="pt-2">';
            for (vehicule of station.Vehicules) {
                if (vehicule.Disponibilite === "LIBRE") {
                    content += '<p class="mapVehiculeText">' + vehicule.ModelVehicule;
                    if (vehicule.count > 1) {
                        content += ` (${vehicule.count})`;
                    }
                    content += '</p>'
                }
            }
            content += '</div>';
            content += '<div class="pt-2 px-4 border-top">';
            content += `<a class="btn btn-sm btn-outline-primary" href="${station.href}">Choisir cette station</a>`;
            content += '</div>';
            content += '</div>';
            infowindow.setContent(content);
            infowindow.open(map, marker);
        });
    }
}

document.body.onload = function () {
    for (let i = 0; i < stations.length; i++) {
        stations[i].href = stationsHref[i];
        var vehicules = {};
        stations[i].Vehicules.forEach(v => vehicules[v.IdType] = v);
        stations[i].Vehicules = Object.values(vehicules).map(v => Object.assign(v, {
            count: stations[i].Vehicules.filter(v1 => v1.IdType === v.IdType && v.Disponibilite === "LIBRE").length
        }));
        stations[i].count = stations[i].Vehicules.reduce((c, v) => c + v.count, 0);
    }
    stations = stations.filter(s => s.count > 0);
    drawStationsMap(stations);
}
