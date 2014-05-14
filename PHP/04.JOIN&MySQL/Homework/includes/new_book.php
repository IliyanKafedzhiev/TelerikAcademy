<?php
include './header.php';
if ($_POST)
{
    $book_name = mysqli_real_escape_string($connection, trim($_POST['book_name']));

    $validation = true;
    if (strlen($book_name) < 4 || strlen($book_name) > 50)
    {
        $validation = false;
        echo "<br>Името на автора е твърде късо , дълго</br>";
    }
    $query = "SELECT * 
    FROM  `books` 
    WHERE book_title =  \"" . $book_name . "\"";
    $q = mysqli_query($connection, $query);
    if ($q && $q->num_rows > 0)
    {
        echo "Книгата която въведохте вече съществува !";
        $validation = false;
    }
    if ($validation)
    {
        $query = "INSERT INTO  `books` (  `book_title` ) 
            VALUES (\"" . $book_name . "\")";
        $q = mysqli_query($connection, $query);
        if ($q)
        {   
            echo '<br>Записа е успешен!</br>';
            $query = "SELECT * 
                FROM  `books` 
                WHERE book_title =  \"" . $book_name . "\"";
            $q = mysqli_query($connection, $query);
            $inf = $q->fetch_assoc();
            $book_id = $inf['book_id'];
            foreach ($_POST["authors_id"] as $value)
            {
                $query = "INSERT INTO `books_authors`(`book_id`, `author_id`) VALUES (\"".$book_id."\",\"".$value."\")";
                $q = mysqli_query($connection, $query);
            }
        } else
        {
            echo mysqli_error($connection);
        }
    } else
    {
        echo '<br>Записа е неуспешен!Oпитай Пак</br>';
    }
}
?>
<dir>
    <a href="../index.php">Книги</a>
</dir>
<form method="POST" action="new_book.php">

    <div>Име на книгата<input type ="text"  name ="book_name" />
        <div>
            <select multiple name="authors_id[ ]">
                <?php
                $query = "SELECT * 
                FROM  
                authors 
                WHERE 1";
                $q = mysqli_query($connection, $query);
                if ($q->num_rows > 0)
                {

                    while ($row = $q->fetch_assoc())
                    {
                        echo "<option  value=\"" . $row["author_id"] . "\">" . $row['author_name'] . "</option>";
                    }
                }
                ?>
            </select>
            <input type ="submit" value="Добави" /></div>

</form>

<?php
include './footer.php';
?>