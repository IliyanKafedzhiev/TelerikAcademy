<?php

$connection = mysqli_connect('localhost', 'user', 'qwerty', 'telerik');
if (mysqli_connect_errno())
{
    printf("Connect failed: %s\n", mysqli_connect_error());
    exit();
}
mysqli_query($connection, "SET NAMES utf8");
?>
