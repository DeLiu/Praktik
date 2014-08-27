<?php
include 'connect.php';
include 'header.php';
 
$sql = "SELECT * FROM categories";

$result = mysql_query($sql);
 
if(!$result)
{
    die("Kategorierne kunne ikke findes: " . mysql_error());
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
                <th>Subforum</th>
              </tr>'; 
             
        while($row = mysql_fetch_assoc($result))
        {               
            echo '<tr>';
                echo '<td class="leftpart">';
                    echo '<h3><a href="category.php?id=' . $row['cat_id'] . '">' . $row['cat_name'] . '</a></h3>' . $row['cat_description'];
                echo '</td>';
            echo '</tr>';
        }
    }
}
include 'footer.php';
?>