<?php
include 'header.php';
	unset($_SESSION['user_id']);
	unset($_SESSION['user_name']);
	unset($_SESSION['user_level']);
	
	echo 'Du er nu logget ud, gå til forsiden <a href="index.php">her</a>.';
	
include 'footer.php';
?>