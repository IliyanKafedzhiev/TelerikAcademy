<?php

$pageTitle = 'Списък';
include 'includes/header.php';
include 'includes/indexForm.php';
if ($_POST)
{
    if ($_POST["selectionOption"])
    {
        $selectionOption = (int) trim($_POST["selectionOption"]);
    } else
    {
        $selectionOption = -1;
    }
    if ($_POST["date"])
    {
        $date = $_POST["date"];
    } else
    {
        $date = -1;
    }
} else
{
    $selectionOption = -1;
    $date = -1;
}
include 'includes/printTable.php';
include 'includes/footer.php';
?>
