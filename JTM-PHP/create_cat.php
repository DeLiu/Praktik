<?php
include 'connect.php';
include 'header.php';
 
if($_SERVER['REQUEST_METHOD'] != 'POST')
{
    //the form hasn't been posted yet, display it
    echo "<form method='post' action=''>
        Subforum-navn: <input type='text' name='cat_name' />
        Subforum-beskrivelse: <input type='text' name='cat_description' />
        <input type='submit' value='Tilføj subforum' />
     </form>";
}
else
{
    //the form has been posted, so save it
    $sql = 'INSERT INTO categories(cat_name, cat_description)
       VALUES(' . mysql_real_escape_string($_POST['cat_name']) . ',
             ' . mysql_real_escape_string($_POST['cat_description']) . ')';
    $result = mysql_query($sql);
    if(!$result)
    {
        //something went wrong, display the error
        echo 'Fejl:' . mysql_error();
    }
    else
    {
        echo 'Det nye subforum er nu oprettet.';
    }
}
include 'footer.php';
?>