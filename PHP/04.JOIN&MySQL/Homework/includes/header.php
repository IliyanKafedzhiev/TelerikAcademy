<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>Library</title>
		<link rel="stylesheet" type="text/css" href="theme.css"></link>
    </head>
    <body>
        <?php

$connection = mysqli_connect('localhost', 'user', 'qwerty', 'books');
if (mysqli_connect_errno())
{
    printf("Connect failed: %s\n", mysqli_connect_error());
    exit();
}
mysqli_query($connection, "SET NAMES utf8");
?>