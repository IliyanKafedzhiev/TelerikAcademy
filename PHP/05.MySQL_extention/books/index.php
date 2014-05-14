<?php
$tiltle = 'Списък';
include './inc/header.php';
include './inc/functions.php';
session_start();
if (isLoggedIn())
{
    echo "<a href=\"." . DIRECTORY_SEPARATOR . "inc" . DIRECTORY_SEPARATOR . "session_destroy.php\">Изход</a>";
} else
{
    echo "<a href=\"login.php\">Вход</a>";
}
?>
<a href="authors.php">Автори</a>
<a href="add_book.php">Нова книга</a>
<a href="index.php">Виж всички записи</a>
<?php
if (isset($_GET['author_id']))
{
    $author_id = (int) $_GET['author_id'];
    $q = mysqli_query($db, 'SELECT * 
        FROM books_authors AS ba
        INNER JOIN books AS b ON ba.book_id = b.book_id
        INNER JOIN books_authors AS bba ON bba.book_id = ba.book_id
        INNER JOIN authors AS a ON bba.author_id = a.author_id
        WHERE ba.author_id=' . $author_id);
} else
{
    $q = mysqli_query($db, 'SELECT * FROM books as b 
        LEFT JOIN books_authors as ba ON b.book_id=ba.book_id 
        LEFT JOIN authors as a ON a.author_id=ba.author_id');
}
setTable($q);
?>

<?php
include './inc/footer.php';
?>