<?php
mb_internal_encoding('UTF-8');
$pageTitle = 'Изтриване';
include 'includes/header.php';
include 'includes/validatePrice.php';
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
                    $name = trim($_POST['newName']);
                    $name = str_replace('!', '', $name);

                    $price = trim($_POST['newPrice']);
                    $price = str_replace('!', '', $price);
                    $validation = isValidatePrice($price);

                    $selectedKind = (int) $_POST['newKind'];
                    if (mb_strlen($name) < 4 || mb_strlen($name) > 40)
                    {
                        echo '<p>Името е прекалено късо/дълго</p>';
                        $validation = false;
                    }
                    if (!array_key_exists($selectedKind, $kind))
                    {
                        echo '<p>невалиден вид на разход</p>';
                        $validation = false;
                    }
                    if ($validation)
                    {
                        $result[$i] = date("d.m.y") . '!' . $name . '!' . $price . '!' . $selectedKind . "\n";
                        file_put_contents('resources/data.txt', $result);
                        echo 'Редактирането е Успешно!';
                        break;
                    } else
                    {
                        echo 'Записа е неуспешен!';
                        break;
                    }
                }
            }
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
    <div>Ново име на разхода<input type="text" name="newName" /></div>  
    <div>Нова цена<input type="text" name="newPrice" /></div>
    <div>
        <small>Нов вид:</small>
        <select name="newKind">Вид:
            <?php
            foreach ($kind as $key => $value)
            {
                echo '<option value="' . $key . '">' . $value .
                '</option>';
            }
            ?>
        </select>           
    </div>  
    <div><input type="submit" value="Редактираи" /></div>
</form>
<?php
include 'includes/footer.php';
?>
