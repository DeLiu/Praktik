<?php
include 'connect.php';
include 'header.php';
 
$sql = "SELECT
            cat_id,
            cat_name,
            cat_description
        FROM
            categories";
 
$result = mysql_query($sql);
 
if(!$result)
{
    echo 'Kategorierne kunne ikke vises, prøv igen senere.';
}
else
{
    if(mysql_num_rows($result) == 0)
    {
        echo 'Der er ingen kategorier.';
    }
    else
    {
        //prepare the table
        echo '<table border="1">
              <tr>
                <th>Kategori</th>
                <th>Sidste tråd</th>
              </tr>'; 
             
        while($row = mysql_fetch_assoc($result))
        {               
            echo '<tr>';
                echo '<td class="leftpart">';
                    echo '<h3><a href="category.php?id">' . $row['cat_name'] . '</a></h3>' . $row['cat_description'];
                echo '</td>';
                echo '<td class="rightpart">';
                            echo '<a href="topic.php?id=">Topic subject</a> at 10-10';
                echo '</td>';
            echo '</tr>';
        }
    }
}
?>

<?php
include 'connect.php';
 
//first select the category based on $_GET['cat_id']
$sql = "SELECT
            cat_id,
            cat_name,
            cat_description
        FROM
            categories
        WHERE
            cat_id = " . mysql_real_escape_string($_GET['id']);
 
$result = mysql_query($sql);
 
if(!$result)
{
    echo 'Subforummet kunne ikke vises, prøv igen senere.' . mysql_error();
}
else
{
    if(mysql_num_rows($result) == 0)
    {
        echo 'Dette subforum eksisterer ikke.';
    }
    else
    {
        //display category data
        while($row = mysql_fetch_assoc($result))
        {
            echo '<h2>Tråde i ' . $row['cat_name'] . '-subforummet</h2>';
        }
     
        //do a query for the topics
        $sql = "SELECT  
                    topic_id,
                    topic_subject,
                    topic_date,
                    topic_cat
                FROM
                    topics
                WHERE
                    topic_cat = " . mysql_real_escape_string($_GET['id']);
         
        $result = mysql_query($sql);
         
        if(!$result)
        {
            echo 'Trådene kunne ikke vises, prøv igen senere.';
        }
        else
        {
            if(mysql_num_rows($result) == 0)
            {
                echo 'Der er endnu ingen tråde i dette subforum.';
            }
            else
            {
                //prepare the table
                echo '<table border="1">
                      <tr>
                        <th>Tråd</th>
                        <th>Skabt d.</th>
                      </tr>'; 
                     
                while($row = mysql_fetch_assoc($result))
                {               
                    echo '<tr>';
                        echo '<td class="leftpart">';
                            echo '<h3><a href="topic.php?id=' . $row['topic_id'] . '">' . $row['topic_subject'] . '</a><h3>';
                        echo '</td>';
                        echo '<td class="rightpart">';
                            echo date('d-m-Y', strtotime($row['topic_date']));
                        echo '</td>';
                    echo '</tr>';
                }
            }
        }
    }
}
?>

<?php
include 'connect.php';
 
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