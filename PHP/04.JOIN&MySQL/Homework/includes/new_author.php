<?php
include './header.php';
if ($_POST)
{
    $author_name = mysqli_real_escape_string($connection, trim($_POST['author_name']));
    
    $validation = true;
    if (strlen($author_name) < 4 || strlen($author_name) > 50)
    {
        $validation = false;
        echo "<br>Името на автора е твърде късо , дълго</br>";
    }
    $query ="SELECT * 
    FROM  `authors` 
    WHERE author_name =  \"".$author_name."\"";
    $q = mysqli_query($connection, $query);
    if ($q && $q->num_rows > 0)
    {
        echo "Автора които въведохте вече съществува !";
        $validation = false;
    }
    if ($validation)
    {
        $query = "INSERT INTO  `authors` (  `author_name` ) 
            VALUES (\"".$author_name."\")";
        $q = mysqli_query($connection, $query);
        if ($q)
        {
            echo '<br>Записа е успешен!</br>';
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
<form method="POST">
    <div>Автор<input type ="text"  name ="author_name" />

        <input type ="submit" value="Добави" /></div>

</form>
<table border="1px">
    <tr>
        <th>Автори</th>
    </tr>
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
            echo "<tr>";
            echo "<td>";
            echo "<a href=\"books_from_author.php?author_id=" . $row["author_id"] . "\">\"" . $row['author_name'] . "\" </a>";;
            echo "</td>";
            echo "</tr>";
        }
    }
    ?>
</table>
<?php
include './footer.php';
?>