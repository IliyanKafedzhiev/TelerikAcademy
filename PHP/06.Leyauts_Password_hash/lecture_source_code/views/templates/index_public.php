<h1>Welcome</h1>
<?php

foreach ($data['books'] as $v){
    echo '<p>'.$v['book_title'].'</p>';
}
?>