<?php

include './inc/functions.php';
$data = [];
$authors = getAuthors($db);
if ($authors === false)
{
    $data['errors'] = 'грешка';
    ///TODO        
} else
{
    $data['authors'] = $authors;
}


if ($_POST)
{
    $book_name = trim($_POST['book_name']);
    if (!isset($_POST['authors']))
    {
        $_POST['authors'] = '';
    }
    $authors = $_POST['authors'];
    $er = [];
    if (mb_strlen($book_name) < 2)
    {
        $er[] = 'Невалидно име';
    }
    if (!is_array($authors) || count($authors) == 0)
    {
        $er[] = 'Грешка';
    }
    if (!isAuthorIdExists($db, $authors))
    {
        $er[] = 'невалиден автор';
    }

    if (count($er) > 0)
    {
        foreach ($er as $v)
        {
            $data['errors'] = $v;
        }
    } else
    {
        mysqli_query($db, 'INSERT INTO books (book_title) VALUES("' .
                mysqli_real_escape_string($db, $book_name) . '")');
        if (mysqli_error($db))
        {
            $data['errors'] = 'Error';
            exit;
        }
        $id = mysqli_insert_id($db);
        foreach ($authors as $authorId)
        {
            mysqli_query($db, 'INSERT INTO books_authors (book_id,author_id)
                VALUES (' . $id . ',' . $authorId . ')');
            if (mysqli_error($db))
            {
                $data['errors'] = 'Error';
                $data['errors'] = mysqli_error($db);
                exit;
            }
        }
        $data['errors'] = 'Книгата е добавена';
    }
}
$data['title'] = 'Нова книга';
render($data, "./templates/add_book_public.php");
?>