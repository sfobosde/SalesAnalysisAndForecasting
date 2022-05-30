/// Login user.

/// Get login button.
var loginButton = document.getElementById("LoginButton");

/// Get user domain and make login read only.
( function() {
    document.getElementById("login").value = getUserDomain();;
    document.getElementById("login").readOnly = true;
}());

loginButton.onclick = function() {

}

/// Get User domain with api.
function getUserDomain() {
    var xmlHttp = new XMLHttpRequest();
    var userDomainApiUrl = 'https://localhost:44331/home/getuserdomain';

    xmlHttp.open( "GET", userDomainApiUrl, false );

    xmlHttp.send( null );

    return xmlHttp.responseText;
}