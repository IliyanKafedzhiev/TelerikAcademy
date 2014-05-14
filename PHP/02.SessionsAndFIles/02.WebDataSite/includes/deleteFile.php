<?php
session_start();

if ($_SESSION['IsLogged'] === true)
{
    unlink($_GET['path']);
}
header('Location: dataManage.php');
exit();
?>
