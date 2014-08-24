<?php
//create_cat.php
include 'connect.php';
include 'header.php';
 
//first select the category based on $_GET['cat_id']
$sql = "SELECT
    topic_id,
    topic_subject
	FROM
		topics
	WHERE
		topics.topic_id = " . mysql_real_escape_string(isset($_GET['id']));
 
$result = mysql_query($sql);
 
if(!$result)
{
    echo 'Denne tråd kunne ikke vises. Prøv igen senere.' . mysql_error();
}
else
{
    if(mysql_num_rows($result) == 0)
    {
        echo 'Denne tråd eksisterer ikke.';
    }
    else
    {
        //display category data
        while($row = mysql_fetch_assoc($result))
        {
            echo '<h2>Indlæg i ′' . $row['topic_subject'] . '′</h2>';
        }
     
        //do a query for the topics
        $sql = "SELECT
				posts.post_topic,
				posts.post_content,
				posts.post_date,
				posts.post_by,
				users.user_id,
				users.user_name
				FROM
					posts
				LEFT JOIN
					users
				ON
					posts.post_by = users.user_id
				WHERE
					posts.post_topic = " . mysql_real_escape_string(isset($_GET['id']));
         
        $result = mysql_query($sql);
         
        if(!$result)
        {
            echo 'Indlæggene kunne ikke vises. Prøv igen.';
        }
        else
        {
            if(mysql_num_rows($result) == 0)
            {
                echo 'Der er endnu ingen indlæg i dette emne.';
            }
            else
            {
                //prepare the table
                echo '<table border="1">
                      <tr>
                        <th>' .$row['post_by'] . ' ' .$row['post_date'] . '</th>
                      </tr>'; 
                     
                while($row = mysql_fetch_assoc($result))
                {               
                echo '<tr>';
                        echo '<td class="leftpart">
							' . $row['post_content'] . '
							  </td>';
                echo '</tr>';
                }
				echo '</table>';
				echo '<form method="post" action="reply.php?id=' . mysql_real_escape_string(isset($_GET['id'])) . '">';
				echo '<textarea name="reply-content"></textarea>';
				echo '<input type="submit" value="Indsend indlæg" />';
                echo '</form>';
            }
        }
    }
}
 
include 'footer.php';
?>