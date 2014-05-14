<?php
session_start();
$_SESSION['IsLogged'] = false;
session_destroy();
header('Location: ../index.php');
exit;
?>
