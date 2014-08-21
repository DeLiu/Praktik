<?php
$server = 'mysql18.unoeuro.com';
$username   = 'jonodense_dk';
$password   = 'Overload12';
$database   = 'jonodense_dk_db';
 
if(!mysql_connect($server, $username, $password, $database))
{
    exit('Fejl: Kunne ikke oprette forbindelse til databasen.');
}
if(!mysql_select_db($database))
{
    exit('Fejl: Kunne ikke hente ud fra databasen.');
}
mysql_query("SET NAMES utf8");
?>