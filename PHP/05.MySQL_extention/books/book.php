<?php
$tiltle = "Book";
mb_internal_encoding('UTF-8');
session_start();
include './inc/functions.php';
include './inc/header.php';
if (isLoggedIn())
{
    echo "<a href=\"." . DIRECTORY_SEPARATOR . "inc" . DIRECTORY_SEPARATOR . "session_destroy.php\">Изход</a>";
    if (isset($_POST['comment']) && isset($_GET['book_id']))
    {
        $comment = mysqli_real_escape_string($db,trim($_POST['comment']));
        $user_id = mysqli_real_escape_string($db,trim($_SESSION['user_id']));
        $book_id = mysqli_real_escape_string($db,trim($_GET['book_id']));
        if (strlen($comment) > 2)
        {
            $query = "INSERT INTO  `books`.`comments` (
                    `book_id` ,
                    `user_id` ,
                    `comment` ,
                    `date`
                    )
                    VALUES (
                    '" . $book_id . "',
                    '" . $user_id . "',
                    '" . $comment . "', 
                    CURRENT_TIMESTAMP
                    );";
            if (mysqli_query($db, $query))
            {
                header('Location: .' . DIRECTORY_SEPARATOR . 'book.php'.'?book_id='.$book_id);
                exit;
                echo '<br>Записа е успешен!</br>';
            } else
            {
                echo '<br>Записа е неуспешен!Oпитай Пак</br>';
            }
        }
        
    }
} else
{
    echo "<a href=\"login.php\">Вход</a>";
}
echo "<a href=\"login.php\">Всички Книги</a>";
if (isset($_GET['book_id']))
{
    $q = mysqli_query($db, 'SELECT * FROM books as b 
        INNER JOIN books_authors as ba ON b.book_id=ba.book_id 
        INNER JOIN authors as a ON a.author_id=ba.author_id 
        LEFT JOIN comments as c ON ba.book_id=c.book_id 
        LEFT JOIN users as u ON u.user_id=c.user_id 
	WHERE b.book_id='.$_GET['book_id'].'
        ORDER BY c.date DESC');
    $result = [];
    while ($row = mysqli_fetch_assoc($q))
    {
        //echo '<pre>'.print_r($row, true).'</pre>';
        $result[$row['book_id']]['book_title'] = $row['book_title'];
        $result[$row['book_id']]['book_id'] = $row['book_id'];
        $result[$row['book_id']]['authors'][$row['author_id']] = $row['author_name'];
        $result[$row['book_id']]['comments'][$row['date']]['comment'] = $row['comment'];
        $result[$row['book_id']]['comments'][$row['date']]['user'] = $row['user_name'];
        $result[$row['book_id']]['comments'][$row['date']]['user_id'] = $row['user_id'];
    }
    echo '<table border="1"><tr><td>Книга</td><td>Автори</td></tr>';
    foreach ($result as $row)
    {
        echo '<tr><td>' . '<a href="book.php?book_id=' . $row['book_id'] . '">' . $row['book_title'] . '</a>' . '</td>
        <td>';
        $ar = array();
        foreach ($row['authors'] as $k => $va)
        {
            $ar[] = '<a href="index.php?author_id=' . $k . '">' . $va . '</a>';
        }
        echo implode(' , ', $ar) . '</td></tr>';
        echo '</table>';
        foreach ($row['comments']as $k => $va)
        {
            echo "<br>".$k."  : ".
                    '<a href="user_comments.php?user_id=' . $va['user_id'] . '">' . $va['user'] . '</a>'.
                    " says : ".$va['comment']."</br>";
        }
    }
    
}
if (isLoggedIn())
{
    include './inc/formForComments.php';
}
include './inc/footer.php';
?>
