function displayMessage(id) {     
    var today = new Date();
    let date = today.getFullYear() + '-' + (today.getMonth() + 1) + '-' + today.getDate(); 
    document.getElementById(id).innerHTML = date;
}

$(document).ready(function () {
    $('#multas').DataTable(); 
});
 