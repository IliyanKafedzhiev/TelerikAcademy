<?php

function isValidatePrice($str)
{
    $error = '';
    if (preg_match("|[^0-9\.]|", $str))
    {
        $error .= "Value is not numeric.";
    } else
    {
        $sArray = explode('.', $str);
        $i = 0;
        # Explode by . , check to see if there is more than 2 parts
        foreach ($sArray as $c)
        {
            $i++;
        }
        // echo $i;

        if ($i > 2)
        {
            $error .= "Value formatted incorrectly, to many decimals (.).";
        } else if ($i == 2)
        {
            if (strlen($sArray[1]) > 2 || strlen($sArray[1]) < 2)
            {
                // echo strlen($str[1]);
                $error .= "Value formatted incorrectly, to many numbers in your cents.";
            }
        }
    }
    if (!empty($error) || empty($str))
    {
        echo 'Price:' . $error;
        return false;
    }
    return true;
}

?>
