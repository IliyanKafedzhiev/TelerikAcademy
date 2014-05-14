<?php

include '../views/header.php';
if ($_SESSION['is_logged']) {
    echo '<div>Здравей ' . $_SESSION['user_data']['email'] . ' <a href="?p=new_auction">Нова обява</a> <a href="?p=logout">Изход</a> <a href="?p=regAction">RegAction</a></div>';
} else {
    echo '<div><a href="?p=login">Вход</a> <a href="?p=register">Регистрация</a> </div>';
}
?>
<p>
<table border="1px">
    <?php 
    echo "<tr>
            <td>Ime na Targ</td>
            <td>  </td>
          </tr>";
        for($i = 0;$i < count($data);$i++)
        {
          echo "<tr>".
                  "<td>".$data['spix']."</td>".
                  "</tr>";   
        }
    ?>
</table>

</p>
<?php

include '../views/footer.php';


