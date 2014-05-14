<?php
mb_internal_encoding('UTF-8');
session_start();
if (array_key_exists('IsLogged', $_SESSION) && $_SESSION['IsLogged'] == true)
{
    header('Location: .' . DIRECTORY_SEPARATOR . 'includes' . DIRECTORY_SEPARATOR . 'message_page.php');
    exit;
}


if ($_POST)
{
    include './includes/mySQLConnection.php';
    $name = trim($_POST['name']);
    $name = str_replace('!', '', $name);
    $name = mysqli_real_escape_string($connection, str_replace(DIRECTORY_SEPARATOR, '', $name));

    $pass = trim($_POST['pass']);
    $pass = mysqli_real_escape_string($connection, str_replace('!', '', $pass));

    $validation = true;

    if (mb_strlen($name) < 5 || mb_strlen($name) > 30 || mb_strlen($pass) < 5 || mb_strlen($pass) > 30)
    {
        $validation = false;
        echo 'Името или паролата са твърде къси/дълги';
    }

    $query = "SELECT * FROM users WHERE username=\"" . $name . "\" OR password =\"" . $pass . "\"";
    $q = mysqli_query($connection, $query);
    if ($q)
    {
        $row = $q->fetch_assoc();
        if ($pass == $row['password'])
        {
            $validation = false;
            echo '<br>password is already taken</br>';
        }
        if ($name == $row['username'])
        {
            $validation = false;
            echo '<br>Username is already taken</br>';
        }
    }
    if ($validation)
    {
        $query = "INSERT INTO `users`(`username`, `password`) VALUES ('" . $name . "','" . $pass . "')";

        if (mysqli_query($connection, $query))
        {
            header('Location: .' . DIRECTORY_SEPARATOR . 'index.php');
            exit;
            echo '<br>Записа е успешен!</br>';
        }
    } else
    {
        echo '<br>Записа е неуспешен!Oпитай Пак</br>';
    }
}
include 'includes/header.php';
?>
<a href="index.php">Вход</a>
<form method="POST">
    <div>Име:<input type="text" name="name" /></div>
    <div>Парола:<input type="password" name="pass" /></div>   
    <div><input type="submit" value="Добави Регистрация" /></div>
</form>
<?php
include 'includes/footer.php';
?>