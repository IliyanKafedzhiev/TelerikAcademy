 <?php
mb_internal_encoding('UTF-8');
session_start();
include './inc/functions.php';
$tiltle = "Registration Form";
if (isLoggedIn())
{
    header('Location: .' . DIRECTORY_SEPARATOR . 'index.php');
    exit;
}
if (isset($_POST['name']))
{
    $name = trim($_POST['name']);
    $name = str_replace('!', '', $name);
    $name = mysqli_real_escape_string($db, str_replace(DIRECTORY_SEPARATOR, '', $name));
    $pass = trim($_POST['pass']);
    $pass = mysqli_real_escape_string($db, str_replace('!', '', $pass));

    $validation = true;

    if (mb_strlen($name) < 5 || mb_strlen($name) > 30 || mb_strlen($pass) < 5 || mb_strlen($pass) > 30)
    {
        $validation = false;
        echo 'Името или паролата са твърде къси/дълги';
    }
    $checkIsUserExist = isUserOrPassExist($db, $name, $pass);
    if ($validation && !$checkIsUserExist)
    {
        $query = "INSERT INTO `users`(`user_name`, `user_pass`) VALUES ('" . $name . "','" . $pass . "')";

        if (mysqli_query($db, $query))
        {
            header('Location: .' . DIRECTORY_SEPARATOR . 'login.php');
            exit;
            echo '<br>Записа е успешен!</br>';
        } else
        {
            echo '<br>Записа е неуспешен!Oпитай Пак</br>';
        }
    } else
    {
        echo "<br>" . $checkIsUserExist . "</br>";
        echo '<br>Записа е неуспешен!Oпитай Пак</br>';
    }
}
include 'inc/header.php';
?>
<a href="index.php">Вход</a>
<form method="POST">
    <div>Име:<input type="text" name="name" /></div>
    <div>Парола:<input type="password" name="pass" /></div>   
    <div><input type="submit" value="Добави Регистрация" /></div>
</form>
<?php
include 'inc/footer.php';
?>