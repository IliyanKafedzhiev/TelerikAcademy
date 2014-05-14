<?php
function render($data,$name){  
    include '../templates/header.php';
    include $name;       
    include '../templates/footer.php';
}