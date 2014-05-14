<?php

include './inc/functions.php';
$page = '';
if (isset($_GET['p'])) {
    switch ($_GET['p']) {
        case 'index':
            $page = 'index';
            break;
        case 'users':
            $page = 'users/user_edit';
            break;
        case 'account':
            $page = 'account';
            break;
        default:
            $page = 'index';
            break;
    }
} else {
    $page = 'index';
}


include '../../' . $page . '.php';
exit;
$connection = mysqli_connect('localhost', 'gatakka', 'qwerty', 'books');
mysqli_set_charset($connection, 'utf8');
$q = mysqli_query($connection, 'SELECT * FROM books');
$data = array();

while ($row = mysqli_fetch_assoc($q)) {
    $data['books'][] = $row;
}

$data['title'] = 'Книги';
$data['content'] = 'templates/index_public.php';
$data['header'] = 'templates/header_public.php';
render($data, 'templates/layouts/left_layout.php');





