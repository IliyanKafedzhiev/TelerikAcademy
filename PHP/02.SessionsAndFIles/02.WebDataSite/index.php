<?php
session_start();

if (array_key_exists('IsLogged', $_SESSION) && $_SESSION['IsLogged'] == true)
{
        header('Location: .'.DIRECTORY_SEPARATOR.'includes'.DIRECTORY_SEPARATOR.'dataManage.php');
        exit;
}
else if ($_POST)
{
    $username = trim($_POST["clientName"]);
    $password = trim($_POST["clientPassword"]);
    $username = str_replace(DIRECTORY_SEPARATOR , '' , $username);
    $data = file('./userList.txt');
    for($i = 0;$i < count($data);$i++)
    {
        $curLine = split('!', $data[$i]);
        
        if( $username === trim($curLine[0]) && $password == trim($curLine[1]) )
        {
            $_SESSION['IsLogged'] = true;
            $_SESSION['username'] = $username;
            header('Location: .'.DIRECTORY_SEPARATOR.'includes'.DIRECTORY_SEPARATOR.'dataManage.php');
            exit;
        } 
    }
    include './includes/header.php';
    echo '<br>Невалидни потребителски данни опитай отново!</br>';
    include './includes/form.php';
    
}
else
{
    include './includes/header.php';
    include './includes/form.php';
}
include './includes/footer.php';
?>