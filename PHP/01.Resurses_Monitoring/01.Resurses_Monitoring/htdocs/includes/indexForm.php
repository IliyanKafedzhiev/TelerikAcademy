<form method="POST">
    <a href="form.php">Добави разход</a>
    <a href="del.php">Изтриване на разход</a>
    <a href="editor.php">Редактиране на разход</a>
    <select name="selectionOption">
        <option value="-1">Всички</option>
        <?php
        foreach ($kind as $key => $value)
        {
            echo '<option value="' . $key . '">' . $value .
            '</option>';
        }
        ?>
    </select>
    <small>Oт дата:</small><input type="text" name="date" /><small>дд.мм.гггг</small>
    <input type="submit" value="Филтрирай" />
</form>
