<?php

session_start();
$tiltle = "Login Page";
if (array_key_exists('IsLogged', $_SESSION) && $_SESSION['IsLogged'] == true)
{
    header('Location: .' . DIRECTORY_SEPARATOR . 'index.php');
    exit;
} else if ($_POST)
{
    include './inc/functions.php';
    $username = mysqli_real_escape_string($db, trim($_POST["clientName"]));
    $password = mysqli_real_escape_string($db, trim($_POST["clientPassword"]));
    $username = str_replace(DIRECTORY_SEPARATOR, '', $username);
    $checkIsUserExist = isUserExist($db, $username, $password);
    if ($checkIsUserExist)
    {
        $_SESSION['IsLogged'] = true;
        $_SESSION['username'] = $username;
        $_SESSION['user_id'] = $checkIsUserExist;
        header('Location: .' . DIRECTORY_SEPARATOR . 'index.php');
        exit;
    }
    include './inc/header.php';
    echo '<br>Невалидни потребителски данни опитай отново!</br>';
    include './inc/form.php';
} else
{
    include './inc/header.php';
    include './inc/form.php';
}
include './inc/footer.php';
?>