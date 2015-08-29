function initialize() {

    var defaultBounds = new google.maps.LatLngBounds(
    new google.maps.LatLng(36.891868, 174.83616),
    new google.maps.LatLng(30.891868, 176.83616));

    var options = {
        bounds: defaultBounds,
        type: ['(cities)'],
        componentRestrictions: {country: 'nz'}
    };

    var input = document.getElementById('pac-input');

    var autocomplete = new google.maps.places.Autocomplete(input, options);
}
function previewFile() {

       var preview = document.querySelector('img'); //selects the query named img
       var file    = document.querySelector('input[type=file]').files[0]; //sames as here
       var reader  = new FileReader();

       reader.onloadend = function () {
           preview.src = reader.result;
       }

       if (file) {
           reader.readAsDataURL(file); //reads the data as a URL
       } else {
           preview.src = "";
       }
}

function loadImageFileAsURL() {

    var filesSelected = document.getElementById("DisplayPicture").files;
    if (filesSelected.length > 0) {
        var fileToLoad = filesSelected[0];

        if (fileToLoad.type.match("image.*")) {
            var fileReader = new FileReader();
            fileReader.onload = function (fileLoadedEvent) {
                
                document.getElementById("drift").src = fileLoadedEvent.target.result;
            };
            fileReader.readAsDataURL(fileToLoad);
        }
    }
}

google.maps.event.addDomListener(window, 'load', initialize);