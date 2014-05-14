<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title><?=$data['title'];?></title>     
    </head>
    <body>
<a href="authors.php">Автори</a>
<a href="add_book.php">Нова книга</a>
<table border="1"><tr><td>Книга</td><td>Автори</td></tr>
<?php
foreach ($data as $row) {
     if (isset($row['book_title']))
     {
             echo '<tr><td>' . $row['book_title'] . '</td> <td>';
             if (isset($row['authors']))
             {
                 $ar = array();
                foreach ($row['authors'] as $k => $va) {
                    $ar[] = '<a href="index.php?author_id=' . $k . '">' . $va . '</a>';
                }
                echo implode(' , ', $ar) . '</td></tr>';
             }  
     }

    
}
?>
</table>
</body>
</html>