<?php
session_start();
if (!array_key_exists('IsLogged', $_SESSION) || $_SESSION['IsLogged'] != true)
{
    header('Location: .' . DIRECTORY_SEPARATOR . 'index.php');
    exit;
}
include './header.php';
include 'mySQLConnection.php';
if ($_POST)
{
    if (array_key_exists('headerDel', $_POST))
    {
        $qu = 'DELETE FROM `messages`
        WHERE header ="' . $_POST['headerDel'] . '"';
        $z = mysqli_query($connection, $qu);
        if (!$z)
        {
            echo 'Database error';
            echo mysqli_error($connection);
        } else
        {
            echo 'Изстриването е Успешно';
        }
    }
}
if ($_SESSION['username'] == 'admin')
{
    echo '
            <form method="POST">
                <dir>Изтрии съобчение със заглавие : <input type="text" name="headerDel"> </dir>
                <input type="submit" value="Изтрии" />
            </form>
            ';
}
?>
<form method="POST">
    <select name="sort">
        <option value="ASC">Възходящо</option>
        <option value="DESC">Низходящо</option>
    </select>
    <input type="submit" value="Сортирай" />
</form>
<dir>
    <a href="session_destroy.php" >Изход</a>
    <a href="message_upload.php" >Добави Съобщение</a>
</dir>

<?php
$order = 'DESC';
if ($_POST)
{
    if (array_key_exists('sort', $_POST))
    {
        $order = $_POST ['sort'];
    }
}
$query = "SELECT * 
FROM  `messages` 
ORDER BY  `messages`.`time` " . $order . "  
LIMIT 0 , 60";
$q = mysqli_query($connection, $query);
if (!$q)
{
    echo 'Database error';
    echo mysqli_error($connection);
} else
{

    while ($row = $q->fetch_assoc())
    {
        echo'<table border="1">
        <tr>
            <th>Дата</th>
            <th>Потребител</th>
            <th>Заглавие</th>
            <th>Съобщение</th>
        </tr>
        <tr>
            <td>' . $row['time'] . '</td>
            <td>' . $row['username'] . '</td>
            <td>' . $row['header'] . '</td>
                <td>' . $row['message'] . '</td>
        </tr>
    </table>
    ';
    }
}

include './footer.php';
?>