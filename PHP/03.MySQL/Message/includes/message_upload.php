<?php
session_start();
if (!array_key_exists('IsLogged', $_SESSION) || $_SESSION['IsLogged'] != true)
{
    header('Location: .' . DIRECTORY_SEPARATOR . 'index.php');
    exit;
}
if ($_POST)
{
    include 'mySQLConnection.php';
    $header = mysqli_real_escape_string($connection, trim($_POST['header']));
    $text = mysqli_real_escape_string($connection, trim($_POST['text']));
    $validation = true;
    if (strlen($header) < 4 || strlen($header) > 50)
    {
        $validation = false;
        echo "<br>Заглавието е твърде късо , дълго</br>";
    }
    if (strlen($text) < 1 || strlen($text) > 250)
    {
        $validation = false;
        echo "<br>Съобщението е твърде късо , дълго</br>";
    }
    if ($validation)
    {
        $query = "INSERT INTO `messages`(`username`, `header`,`message`) VALUES ('" . $_SESSION['username'] . "','" . $header . "','" . $text . "')";
        $q = mysqli_query($connection, $query);
        if ($q)
        {
            header('Location: .' . DIRECTORY_SEPARATOR . 'message_page.php');
            echo '<br>Записа е успешен!</br>';
            exit;
        } else
        {
            echo mysqli_error($connection);
        }
    } else
    {
        echo '<br>Записа е неуспешен!Oпитай Пак</br>';
    }
}
include './header.php';
?>
<form method="POST">
    <div>Заглавие на съобщението:<input type ="text"  name ="header" /></div>
    <dir>Съобщение:<textarea rows="4" cols="50" name="text" > </textarea></dir>
    <div><input type ="submit" value="Публикувай" /></div>

</form>

<dir>
    <a href="session_destroy.php" >Изход</a>
    <a href="message_page.php" >Обратно към съобщенията</a>
</dir>
<?php
include './footer.php';
?>