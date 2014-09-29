<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml" xml:lang="nl" lang="nl">
<head>
    <meta charset="utf-8">
    <meta name="description" content="Et forum omkring økologi og landbrug" />
    <meta name="keywords" content="agriculture, økologi, landbrug" />
    <title>JTM-Landbrug forum</title>
    <link rel="stylesheet" href="./css/style.css" type="text/css">
	<script>
        (function (i, s, o, g, r, a, m) {
            i['GoogleAnalyticsObject'] = r; i[r] = i[r] || function () {
                (i[r].q = i[r].q || []).push(arguments)
            }, i[r].l = 1 * new Date(); a = s.createElement(o),
            m = s.getElementsByTagName(o)[0]; a.async = 1; a.src = g; m.parentNode.insertBefore(a, m)
        })(window, document, 'script', '//www.google-analytics.com/analytics.js', 'ga');

        ga('create', 'UA-55244039-1', 'auto');
        ga('send', 'pageview');

</script>
</head>
<body>
<h1>JTM-Landbrug - Forum</h1>
    <div id="wrapper">
    <div id="menu">
        <a class="item" href="index.php">Hjem</a>
		<?php
		if ($_SESSION['user_level'] == 0)
		{
		echo '
			<a class="item" href="create_topic.php">Opret en tråd</a> -
			<a class="item" href="create_cat.php">Opret et subforum</a>
			';
		}
		?>
         
        <div id="userbar">
        <?php
		session_start();
			echo '<div id="userbar">';
				if(isset($_SESSION['signed_in']))
				{
					echo 'Velkommen ' . $_SESSION['user_name'] . '. Ikke dig? <a href="signout.php">log ud</a>';
				}
				else
				{
					echo '<a href="signin.php">Log ind</a> eller <a href="signup.php">opret en bruger</a>.';
				}
			echo '</div>';
?>
    </div>
        <div id="content">