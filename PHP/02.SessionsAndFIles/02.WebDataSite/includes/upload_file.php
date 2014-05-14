<?php
session_start();
include './header.php';
if (count($_FILES) > 0)
{
    if ($_FILES["file"]["error"] > 0)
    {
        echo "Error: " . $_FILES["file"]["error"] . "<br>";
        echo 'Грешка !Файла се не е качен!';
    } else
    {
        $files = scandir('..' . DIRECTORY_SEPARATOR . $_SESSION['username'] . DIRECTORY_SEPARATOR);
        $_FILES['file']['name'] = str_replace(DIRECTORY_SEPARATOR, "", $_FILES['file']['name']);
        $exist=false;
        foreach ($files as $value)
        {
            if ($_FILES['file']['name'] == $value)
            {
                $exist = true;
                echo '<br>Файла вече е качен , Моля изберете друг Файл</br>';
            }
        }
        if (!$exist && move_uploaded_file($_FILES['file']['tmp_name'], '..' . DIRECTORY_SEPARATOR . $_SESSION['username'] . DIRECTORY_SEPARATOR . $_FILES['file']['name']))
        {
            echo "Upload: " . $_FILES["file"]["name"] . "<br>";
            echo "Type: " . $_FILES["file"]["type"] . "<br>";
            echo "Size: " . ($_FILES["file"]["size"] / 1024) . " kB<br>";
            echo "Stored in: " . $_FILES["file"]["tmp_name"];
            echo '<br>Фаила е качен успешно!</br>';
        } else
        {
            echo 'Файла се не е качен!';
        }
    }
}
?>
<form  method="POST" enctype="multipart/form-data">
    <label for="file">Filename:</label>
    <input type="file" name="file" id="file"><br>
    <input type="submit" name="submit" value="Submit">
</form>
<dir>
    <a href="session_destroy.php" >Изход</a>
    <a href="dataManage.php" >Назад</a>
</dir>
<?php
include './footer.php';
?>