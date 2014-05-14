<?php
session_start();
include './header.php';
if (!file_exists('..' . DIRECTORY_SEPARATOR . $_SESSION['username'] . DIRECTORY_SEPARATOR))
{
    if (mkdir('..' . DIRECTORY_SEPARATOR . $_SESSION['username'] . DIRECTORY_SEPARATOR))
    {
        echo "Добре дошли";
    }
}
$files = scandir('..' . DIRECTORY_SEPARATOR . $_SESSION['username'] . DIRECTORY_SEPARATOR);
?>

<table border="1">
    <tr>
        <th>Cвали файл:</th>
        <th>Големина</th>
        <th></th>
    </tr>
    <?php
    foreach ($files as $key => $value)
    {

        if ($key != 0 && $key != 1 && $value)
        {

            echo'<tr>
<td><a href=
"' . './downloadFile.php' . '?path=' . '..' . DIRECTORY_SEPARATOR . $_SESSION['username'] . DIRECTORY_SEPARATOR . $value . '">' . $value . '</td>
<td>' . filesize('..' . DIRECTORY_SEPARATOR . $_SESSION['username'] . DIRECTORY_SEPARATOR . $value)/1024/1024 . 'MB' . '</td>
<td>' . '<a href=
"' . './deleteFile.php' . '?path=' . '..' . DIRECTORY_SEPARATOR . $_SESSION['username'] . DIRECTORY_SEPARATOR . $value . '">' .'Изтрии'. '</td>
</tr>';
        }
    }
    ?>
</table>

<dir>
    <a href="session_destroy.php" >Изход</a>
    <a href="upload_file.php" >Добави файл</a>
</dir>
<?php
include './footer.php';
?>