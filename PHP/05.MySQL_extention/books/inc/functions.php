<?php

mb_internal_encoding('UTF-8');
$db = mysqli_connect('localhost', 'user', 'qwerty', 'books');
if (!$db)
{
    echo 'No database';
}
mysqli_set_charset($db, 'utf8');

function setTable($q)
{
    $result = [];
    echo '<table border="1"><tr><td>Книга</td><td>Автори</td></tr>';
    while ($row = mysqli_fetch_assoc($q))
    {
        //echo '<pre>'.print_r($row, true).'</pre>';
        if ($row['author_id']==NULL)
        {
            //echo '<tr><td>' . '<a href="book.php?book_id=' . $row['book_id'] . '">' . $row['book_title'] . '</a>' . '</td>
            //<td>';
        }
        else
        {
            $result[$row['book_id']]['book_title'] = $row['book_title'];
            $result[$row['book_id']]['book_id'] = $row['book_id'];
            $result[$row['book_id']]['authors'][$row['author_id']] = $row['author_name'];
        }
    }
    
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
    }
    echo '</table>';
}

function isLoggedIn()
{
    if (array_key_exists('IsLogged', $_SESSION) && $_SESSION['IsLogged'] == true)
    {
        return true;
    }
    return false;
}

function getAuthors($db)
{
    $q = mysqli_query($db, 'SELECT * FROM authors');
    if (mysqli_error($db))
    {
        return false;
    }
    $ret = [];
    while ($row = mysqli_fetch_assoc($q))
    {
        $ret[] = $row;
    }
    return $ret;
}

function isAuthorIdExists($db, $ids)
{
    if (!is_array($ids))
    {
        return false;
    }
    $q = mysqli_query($db, 'SELECT * FROM authors WHERE 
        author_id IN(' . implode(',', $ids) . ')');
    if (mysqli_error($db))
    {
        return false;
    }

    if (mysqli_num_rows($q) == count($ids))
    {
        return true;
    }
    return false;
}

function isUserExist($db, $username, $password)
{
    $query = "SELECT * FROM users WHERE user_name=\"" . $username . "\" AND user_pass =\"" . $password . "\"";
    $q = mysqli_query($db, $query);
    if ($q)
    {
        $row = $q->fetch_assoc();
        if ($password == $row['user_pass'] && $username == $row['user_name'])
        {
            return $row['user_id'];
        }
        return false;
    }
    return false;
}

function isUserOrPassExist($db, $username, $password)
{
    $query = "SELECT * FROM users WHERE user_name=\"" . $username . "\" OR user_pass =\"" . $password . "\"";
    $q = mysqli_query($db, $query);
    if ($q->num_rows > 0)
    {
        $row = $q->fetch_assoc();
        if ($password === $row['user_pass'])
        {
            return '<br>password is already taken</br>';
        }
        if ($username === $row['user_name'])
        {
            return '<br>Username is already taken</br>';
        }
        return false;
    }
    return false;
}