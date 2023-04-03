// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

//--------------------------------------------------------------------------
let map;
function initMap() {

    //criacao do mapa
    map = new google.maps.Map(document.getElementById("map"), {
        center: { lat: 38.97492, lng: -124.4194 },
        zoom: 8,
    });

    //coordenadas dos pontos que serão ligados
    var pontos = [
        { lat: 37.9749, lng: -122.4194 },
        { lat: 37.5749, lng: -122.5294 },
        { lat: 37.3849, lng: -122.7294 },
        { lat: 37.6849, lng: -122.9194 }
    ];

    //características da linha
    var linha = new google.maps.Polyline({
        path: pontos,
        geodesic: true,
        strokeColor: '#FF0000',
        strokeOpacity: 1.0,
        strokeWeight: 2
    });

    //desenhar linha no mapa escolhido
    linha.setMap(map);

}
window.initMap = initMap;
//------------------------------------------------------------------------


