<?php

if (isset($_GET['author_id']))
{
    include './header.php';
    $query = "SELECT * 
        FROM  
        books_authors JOIN books ON books_authors.book_id = books.book_id
        WHERE books_authors.author_id = " . $_GET['author_id'];
    
    $q = mysqli_query($connection, $query);
    if ($q->num_rows > 0)
    {
        echo "<a href=\"../index.php\">Книги</a>";
        echo "<table border =\"3px\">
        <tr>
            <th>Книга</th>
            <th>Aвтори</th>
        </tr>";
        while ($row = $q->fetch_assoc())
        {
            echo "<tr>";
            echo "<td>";
            echo $row['book_title'];
            echo "</td>";
            $queryForAuthorsName = "SELECT * 
                FROM books_authors
                JOIN authors ON books_authors.author_id = authors.author_id
                WHERE books_authors.book_id =" . $row["book_id"] . "
                LIMIT 0 , 30";
            echo "<td>";
            $qSecond = mysqli_query($connection, $queryForAuthorsName);
            if ($qSecond->num_rows > 0)
            {
                while ($authors = $qSecond->fetch_assoc())
                {
                    echo "<a href=\"books_from_author.php?author_id=" . $authors["author_id"] . "\">\"" . $authors['author_name'] . "\" </a>";
                }
            }

            echo "</td>";
            echo "</tr>";
            echo '</table>';
        }
    } else
    {
        header('Location: ../index.php');
        exit;
    }
} else
{
    header('Location: ../index.php');
    exit;
}
include './footer.php';
?>
