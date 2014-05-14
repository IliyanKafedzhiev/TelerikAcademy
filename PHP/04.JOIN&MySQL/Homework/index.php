<?php
include './includes/header.php';
?>
<a href="includes/new_book.php">Нова Книга</a>
<a href="includes/new_author.php">Нов Aвтор</a>
<table border ="3px">
    <tr>
        <th>Книга</th>
        <th>Aвтори</th>
    </tr>
    <?php
    $query = "SELECT * 
        FROM  `books` 
        WHERE 1";
    $q = mysqli_query($connection, $query);
    if ($q->num_rows > 0)
    {
        while ($row = $q->fetch_assoc())
        {
            echo "<tr>";
            echo "<td>";
            echo $row['book_title'];
            echo "</td>";
            $queryForAuthorsName = "SELECT * 
                FROM books_authors
                LEFT JOIN authors ON books_authors.author_id = authors.author_id
                WHERE books_authors.book_id =".$row["book_id"]."
                LIMIT 0 , 30";
            echo "<td>";
                $qSecond = mysqli_query($connection, $queryForAuthorsName);
                if ($qSecond->num_rows > 0)
                {
                    while ($authors = $qSecond->fetch_assoc())
                    {
                        echo "<a href=\"includes/books_from_author.php?author_id=".$authors["author_id"]."\">\"".$authors['author_name']."\" </a>";
                    }
                }

            echo "</td>";
            echo "</tr>";
        }
    }
    ?>
</table>
<?php
include './includes/footer.php';
?>