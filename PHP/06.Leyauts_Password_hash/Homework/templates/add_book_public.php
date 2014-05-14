<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title><?= $data['title']; ?></title>     
    </head>
    <body>
        <a href="index.php">Списък</a>
        <form method="post" action="add_book.php">
            <div>
                Име: <input type="text" name="book_name" />
            </div> 
            <div>
                Автори:<select name="authors[]" multiple style="width: 200px">
                    <?php
                    if (isset($data['authors']))
                    {
                        foreach ($data['authors'] as $row)
                        {
                            if (isset($row['author_id']) && isset($row['author_name']))
                            {
                                echo '<option value="' . $row['author_id'] . '">
                                          ' . $row['author_name'] . '</option>';
                            }
                        }
                    }
                    ?>
                </select>
            </div>
            <input type="submit" value="Добави" />    
        </form>
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
