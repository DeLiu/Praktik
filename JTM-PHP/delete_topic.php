<?php
include 'connect.php';
include 'header.php';
 
if($_SERVER['REQUEST_METHOD'] != 'POST')
{
    //someone is calling the file directly, which we don't want
    echo 'Denne fil er blevet kaldt direkte.';
}
else
{
    //check for sign in status
    if(!isset($_SESSION['user_level']) != 0)
    {
        echo 'Du skal være en administrator før du kan slette en tråd.';
    }
    else
    {
        //a real user posted a real reply
        $sql = "DELETE FROM topics WHERE topic_id =" . mysql_real_escape_string($_GET['id']);
                         
        $result = mysql_query($sql);
                         
        if(!$result)
        {
            echo 'Tråden kunne ikke slettes.';
        }
        else
        {
            echo 'Tråden er nu slettet, klik <a href="index.php">her for at gå tilbage til forsiden.</a>.';
        }
    }
}
 
include 'footer.php';
?>