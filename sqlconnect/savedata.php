<?php 

	$con = mysqli_connect('192.168.0.244', 'root', 'toor', 'paisa');

	if (mysqli_connect_errno())
	{
		echo "1: Conection falied";
		exit();
	}

	$username = $_POST["name"];
	$newscore = $_POST["score"];

	$namecheckquery = "SELECT username FROM players WHERE username='" . $username . "';";

	$namecheck = mysqli_query($con, $namecheckquery) or die("2: Name check query failed");
	if(mysqli_num_rows($namecheck) != 1)
	{
		echo "5: Either no user with name, or more than one";
		exit();
	}

	$updatequery = "UPDATE players SET score = " . $newscore . " WHERE username = '" . $username . "';";
	mysqli_query($con, $updatequery) or die("7: Save query failed");

	echo "0";


 ?>