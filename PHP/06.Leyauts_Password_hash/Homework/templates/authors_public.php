<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title><?= $data['title']; ?></title>     
    </head>
    <body>
        <a href="index.php">Списък</a>
        <a href="add_book.php">Нова книга</a>
        <form method="post" action="authors.php">
            Име: <input type="text" name="author_name" />
            <input type="submit" value="Добави" />    
        </form>
        <table border='1'>
            <tr><th>Автор</th></tr>

            <?php
            if (isset($data['authors']))
            {
                foreach ($data['authors'] as $row)
                {
                    if (isset($row['author_name']))
                    {
                        echo '<tr><td>' . $row['author_name'] . '</td></tr>';
                    }
                }
            }
            ?>
        </table>
        <div>
            <?php
            if (isset($data['errors']))
            {
                if (is_array($data['errors']))
                {
                    foreach ($data['errors'] as $v)
                    {
                        echo "<p>" . $v . "<p>";
                    }
                } else
                {
                    echo "<p>" . $data['errors'] . "<p>";
                }
            }
            ?>
        </div>
    </body>
</html>
