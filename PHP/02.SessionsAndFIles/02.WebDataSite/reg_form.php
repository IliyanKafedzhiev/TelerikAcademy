<?php
mb_internal_encoding('UTF-8');
include 'includes/header.php';
if ($_POST)
{
    $name = trim($_POST['name']);
    $name = str_replace('!', '', $name);
    $name = str_replace(DIRECTORY_SEPARATOR, '', $name);
    
    $pass = trim($_POST['pass']);
    $pass = str_replace('!', '', $pass);
    
    $validation = true;
    
    if (mb_strlen($name) < 4 || mb_strlen($name) > 40||mb_strlen($pass) < 4 || mb_strlen($pass) > 40)
    {
        $validation = false;
        echo 'Името или паролата са твърде къси/дълги';
    }
    
    $data = file('./userList.txt');
    for($i = 0;$i < count($data);$i++)
    {
        $curLine = split('!', $data[$i]);
        if( $name === trim($curLine[0]) || $pass == trim($curLine[1]) )
        {
            $validation = false;
            echo 'Името съвпада или паролата вече са заети';
        } 
    }
    if ($validation)
    {
        $result =  $name . '!' . $pass. "\n";
        if (file_put_contents('userList.txt', $result, FILE_APPEND))
        {
            echo 'Записа е успешен!';
        }
    } else
    {
        echo 'Записа е неуспешен!';
    }
}
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