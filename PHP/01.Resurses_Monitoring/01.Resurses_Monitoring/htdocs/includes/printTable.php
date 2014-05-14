
<table border="1">
    <tr>
        <th>Дата</th>
        <th>Име</th>
        <th>Сума</th>
        <th>Вид</th>
    </tr>
    <?php
    if (file_exists('resources/data.txt'))
    {
        $sum = 0.00;
        $result = file('resources/data.txt');
        foreach ($result as $value)
        {
            $columns = explode('!', $value);
            if (($selectionOption === (int) trim($columns[3]) || ( $selectionOption === -1)))
            {
                if (($date == $columns[0]) || ($date == -1))
                {
                    echo '<tr>
                        <td>' . $columns[0] . '</td>
                        <td>' . $columns[1] . '</td>
                        <td>' . $columns[2] . '</td>
                        <td>' . $kind[trim($columns[3])] . '</td>
                        </tr>';
                    $sum += (float) trim($columns[2]);
                }
            }
        }
        echo '<tr>
                <td>----</td>
                <td>----</td>
                <td>' . $sum . '</td>
                <td>----</td>
                </tr>';
    }
    ?>
</table>
