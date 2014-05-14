<?php
$cells = array(1,2,4,8,16,32,64,128,256);
$played = (int)$_GET['played'];

do {
    $index = array_rand($cells);
} while( ($cells[$index] & $played) != 0 );

$data = <<<EOD
{
  "cell": $cells[$index]
}
EOD;

echo $data;
