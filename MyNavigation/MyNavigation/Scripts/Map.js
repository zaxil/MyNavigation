var directionsDisplay;
var directionsService = new google.maps.DirectionsService();
var map;

function displayMap(mapDivId)
{
    var torun = new
        google.maps.LatLng(53.0137902, 18.5984437);
    var options = 
        {
            zoom: 11,
            mapTypeId:
                google.maps.MapTypeId.ROADMAP,
            center: torun  
        }

    directionsDisplay = new google.maps.DirectionsRenderer();

    map = new google.maps.Map(document.getElementById(mapDivId), options);
    directionsDisplay.setMap(map);
}

function draftRoute(startTextId, endTextId)
{
    var start = document.getElementById(startTextId).value;
    var end = document.getElementById(endTextId).value;

    if(start !="" && end !="")
    {
        var request = {
            origin: start,
            destination: end,
            travelMode: google.maps.DirectionsTravelMode.DRIVING
        };

        directionsService.route(request, function (response, status) {
            if (status == 'OK') {
                directionsDisplay.setDirections(response);
            }
        });
    }
}

