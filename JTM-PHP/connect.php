<?php
$server = 'mysql18.unoeuro.com';
$username   = 'jonodense_dk';
$password   = 'Overload12';
$database   = 'jonodense_dk_db';
 
if(!mysql_connect($server, $username, $password, $database))
{
    exit('Error: could not establish database connection');
}
if(!mysql_select_db($database))
{
    exit('Error: could not select the database');
}
?>