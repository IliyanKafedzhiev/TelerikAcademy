<?php
$tiltle = "UsersComment";
mb_internal_encoding('UTF-8');
session_start();
include './inc/functions.php';
include './inc/header.php';
if (isLoggedIn())
{
    echo "<a href=\"." . DIRECTORY_SEPARATOR . "inc" . DIRECTORY_SEPARATOR . "session_destroy.php\">Изход</a>";
} else
{
    echo "<a href=\"login.php\">Вход</a>";
}
echo "<a href=\"login.php\">Всички Книги</a>";
if (isset($_GET['user_id']))
{
    $q = mysqli_query($db, 'SELECT * FROM comments as c 
        INNER JOIN books as b ON b.book_id = c.book_id
	WHERE c.user_id='.$_GET['user_id'].'
        ORDER BY c.date DESC
        LIMIT 0 , 30');
    $result = [];
    while ($row = mysqli_fetch_assoc($q))
    {
        echo "<br>Коментар към Книга:".'<a href="book.php?book_id=' . $row['book_id'] . '">' . $row['book_title'] . '</a>'."
                <div>
                    Коментар:".$row['comment']."
                </div>
            </br>";
    }
    
}
include './inc/footer.php';
?>
