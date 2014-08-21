<?php
include 'connect.php';
include 'header.php';
 
if($_SERVER['REQUEST_METHOD'] != 'POST')
{
    //someone is calling the file directly, which we don't want
    echo 'This file cannot be called directly.';
}
else
{
    //check for sign in status
    if(!isset($_SESSION['signed_in']))
    {
        echo 'Du skal være logget ind før du kan oprette et indlæg.';
    }
    else
    {
        //a real user posted a real reply
        $sql = "INSERT INTO 
                    posts(post_content,
                          post_date,
                          post_topic,
                          post_by) 
                VALUES ('" . $_POST['reply-content'] . "',
                        NOW(),
                        " . mysql_real_escape_string($_GET['id']) . ",
                        " . $_SESSION['user_id'] . ")";
                         
        $result = mysql_query($sql);
                         
        if(!$result)
        {
            echo 'Dit indlæg kunne ikke gemmes, prøv igen senere.';
        }
        else
        {
            echo 'Dit indlæg er gemt, se det <a href="topic.php?id=' . htmlentities($_GET['id']) . '">her</a>.';
        }
    }
}
 
include 'footer.php';
?>