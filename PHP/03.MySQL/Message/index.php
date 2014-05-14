<?php

session_start();

if (array_key_exists('IsLogged', $_SESSION) && $_SESSION['IsLogged'] == true)
{
    header('Location: .' . DIRECTORY_SEPARATOR . 'includes' . DIRECTORY_SEPARATOR . 'message_page.php');
    exit;
} else if ($_POST)
{
    include './includes/mySQLConnection.php';
    $username = mysqli_real_escape_string($connection, trim($_POST["clientName"]));
    $password = mysqli_real_escape_string($connection, trim($_POST["clientPassword"]));
    $username = str_replace(DIRECTORY_SEPARATOR, '', $username);
    $query = "SELECT * FROM users WHERE username=\"" . $username . "\" AND password =\"" . $password . "\"";
    $q = mysqli_query($connection, $query);
    if ($q->num_rows > 0)
    {
        $row = $q->fetch_assoc();

        if (!empty($row) && $username == $row['username'] && $password == $row['password'])
        {
            $_SESSION['IsLogged'] = true;
            $_SESSION['username'] = $username;
            header('Location: .' . DIRECTORY_SEPARATOR . 'includes' . DIRECTORY_SEPARATOR . 'message_page.php');
            exit;
        }
    }
    include './includes/header.php';
    echo '<br>Невалидни потребителски данни опитай отново!</br>';
    include './includes/form.php';
} else
{
    include './includes/header.php';
    include './includes/form.php';
}
include './includes/footer.php';
?>