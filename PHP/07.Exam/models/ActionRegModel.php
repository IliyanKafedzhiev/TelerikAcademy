<?php

/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 * Description of ActionRegModel
 *
 * @author Iliyan
 */
include '../system/BaseModel.php';

class ActionRegModel extends BaseModel
{

    public function registerAction($ActionName, $description, $startPrice, $date)
    {
        //$result['errors']['name_lenght']=null;
        //$result['errors']['name_mach']=null;
        //$result['errors']['description_lenght']=null;
        //$result['errors']['price']=null;
        // $result['errors']['date']=null;
        $ActionName = trim($ActionName);
        $description = trim($description);
        $startPrice = trim($startPrice);
        $date = trim($date);

        if (strlen($ActionName) < 4)
        {
            $errors['name_lenght'] = true;
        }
        $ActionName = mysqli_real_escape_string($this->db_connection, $ActionName);
        $query = $this->db_connection->query('SELECT * FROM auctions WHERE action_title="' . $ActionName . '"');
        if ($query->num_rows > 0)
        {
            $errors['name_taken'] = true;
        }
        if (strlen($description) < 10)
        {
            $errors['description_lenght'] = true;
        }
        $description = mysqli_real_escape_string($this->db_connection, $description);

        $startPrice = mysqli_real_escape_string($this->db_connection, $startPrice);

        $date = mysqli_real_escape_string($this->db_connection, $date);
        $date = strtotime($date);
        $curentDate = time();
        if ($date < $curentDate)
        {
            $errors['date'] = true;
        }

        if (count($errors) > 0)
        {
            return array('success' => false, 'errors' => $errors);
        }
        //after validation and normalization we can put data in DataBase
        $this->db_connection->query('INSERT INTO `auction`.`auctions` (`auction_id` ,`user_id` ,
                                                                    `date_created` ,
                                                                    `minimum_price` ,
                                                                    `date_end` ,
                                                                    `action_title` ,
                                                                    `auction_desc`) '
                . 'VALUES(NULL,"' . $_SESSION['user_id'] . '",' . $curentDate
                . '"' . $startPrice . '",' . $date . '",' . $ActionName . '",' . $description . ' )');

        return array('success' => true, 'user_id' => $this->db_connection->insert_id);
    }

}