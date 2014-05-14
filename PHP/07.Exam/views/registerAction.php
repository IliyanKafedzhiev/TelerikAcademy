<?php
include '../views/header.php';
?>
<div><a href="?">Начало</a> 
<form action="?p=regAction" method="POST">
    <p><label for="name">Action Name</label> <input type="text" name="name" id="name" />
        <?php
        if ($errors['name_lenght']) {
            echo 'Name lenght < 4';
        }
        if ($errors['name_taken']) {
            echo 'Action name already exist';
        }
        ?>
    </p>
    <p><label for="description">Description:</label> <textarea type="textarea" name="description" id="description" >Type here</textarea>
        <?php
        if ($errors['description_lenght']) {
            echo 'Description lenght < 10';
        }
        ?>
    </p>
    <p><label for="Start price">Price</label> <input type="text" name="price" id="price" />
        <?php
        if ($errors['price']) {
            echo 'Price must be a digit!';
        }
        ?>
    </p>
    <p><label for="date">Until</label> <input type="text" name="date" id="date" value ="02-02-2014"/>
        <?php
        if ($errors['date']) {
            echo 'Invalid Date!';
        }
        ?>
    </p>
    <p class="submit"><input type="submit" value="Go!" /></p>
</form> 

<?php
include '../views/footer.php';
