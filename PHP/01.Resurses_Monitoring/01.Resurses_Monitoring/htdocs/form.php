<?php
mb_internal_encoding('UTF-8');
$pageTitle = 'Форма';
include 'includes/header.php';
include 'includes/validatePrice.php';
if ($_POST)
{
    $name = trim($_POST['name']);
    $name = str_replace('!', '', $name);

    $price = trim($_POST['price']);
    $price = str_replace('!', '', $price);
    $validation = isValidatePrice($price);

    $date = trim($_POST['date']);
    $date = split('\.', $date);
    if (count($date) == 3)
    {
        if (!checkdate($date[1], $date[0], $date[2]))
        {
            $validation = false;
            echo 'Невалидна дата';
        }
    } else
    {
        $validation = false;
    }

    $selectedKind = (int) $_POST['kind'];
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
        $result = $date[0] . '.' . $date[1] . '.' . $date[2] . '!' . $name . '!' . $price . '!' . $selectedKind . "\n";
        if (file_put_contents('resources/data.txt', $result, FILE_APPEND))
        {
            echo 'Записа е успешен!';
        }
    } else
    {
        echo 'Записа е неуспешен!';
    }
}
?>
<a href="index.php">Списък</a>
<form method="POST">
    <div>Име:<input type="text" name="name" /></div>
    <div>Сума:<input type="text" name="price" /></div>
    <div>Дата:<input type="text" name="date" />дд.мм.гггг</div>
    <div>
        <small>Вид:</small>
        <select name="kind">
            <?php
            foreach ($kind as $key => $value)
            {
                echo '<option value="' . $key . '">' . $value .
                '</option>';
            }
            ?>
        </select>           
    </div>        
    <div><input type="submit" value="Добави" /></div>
</form>
<?php
include 'includes/footer.php';
?>