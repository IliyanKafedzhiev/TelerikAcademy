<?php
mb_internal_encoding('UTF-8');
$pageTitle = 'Изтриване';
include 'includes/header.php';
if ($_POST)
{
    $name = trim($_POST['name']);
    $name = str_replace('!', '', $name);
    $error = false;
    if (mb_strlen($name) < 4)
    {
        echo '<p>Името е прекалено късо</p>';
        $error = true;
    }

    if (!$error)
    {

        if (file_exists('resources/data.txt'))
        {
            $result = file('resources/data.txt');

            for ($i = 0; $i < count($result); $i++)
            {
                $columns = explode('!', $result[$i]);

                if (strcmp($name, $columns[1]) == 0)
                {
                    unset($result[$i]);
                }
            }
            file_put_contents('resources/data.txt', $result);
            echo 'Изтриването е Успешно!';
        } else
        {
            echo 'Файлът е празен!';
        }
    }
}
?>
<a href="index.php">Списък</a>
<a href="form.php">Добави разход</a>
<form method="POST">
    <div>Име:<input type="text" name="name" /></div>     
    <div><input type="submit" value="Изтрии" /></div>
</form>
<?php
include 'includes/footer.php';
?>