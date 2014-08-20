<!DOCTYPE html>>
<html xmlns="http://www.w3.org/1999/xhtml" xml:lang="nl" lang="nl">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
    <meta name="description" content="Et forum omkring økologi og landbrug" />
    <meta name="keywords" content="agriculture, økologi, landbrug" />
    <title>JTM-Landbrug forum</title>
    <link rel="stylesheet" href="./css/style.css" type="text/css">
</head>
<body>
<h1>JTM-Landbrug - Forum</h1>
    <div id="wrapper">
    <div id="menu">
        <a class="item" href="index.php">Hjem</a> -
        <a class="item" href="create_topic.php">Opret en tråd</a> -
        <a class="item" href="create_cat.php">Opret en kategori</a>
         
        <div id="userbar">
        <?php
			echo '<div id="userbar">';
				if(isset($_SESSION['signed_in']))
				{
					echo 'Velkommen' . $_SESSION['user_name'] . '. Ikke dig? <a href="signout.php">Log ud</a>';
				}
				else
				{
					echo '<a href="signin.php">Log ind</a> or <a href="signup.php">Opret en bruger</a>.';
				}
			echo '</div>';
?>
    </div>
        <div id="content">