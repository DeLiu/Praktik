<?php
include 'connect.php';
include 'header.php';

//first select the category based on $_GET['cat_id']
$sql = "SELECT
            cat_id,
            cat_name,
            cat_description
        FROM
            categories
        WHERE
            cat_id = " . mysql_real_escape_string(isset($_GET['id']));
 
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
                    topic_cat = " . mysql_real_escape_string(isset($_GET['id']));
         
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
                            echo '<h3><a href="topic.php?id=' . $row['topic_id'] . '">' . $row['topic_subject'] . '</a>';
							if (isset($_SESSION['user_level']) == 1)
							{
								echo '<form method="post" action="delete_topic.php?id="' . mysql_real_escape_string($_GET['id']) . '>';
								echo '<input type="submit" value="Slet tråd" />';
								echo '</form>';
								echo '</h3>';
							}
							else
							{
								'</h3>';
							}
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
include 'footer.php';
?>