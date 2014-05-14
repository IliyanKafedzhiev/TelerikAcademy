<?php

/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 * Description of ListOfAuctionsModel
 *
 * @author Iliyan
 */
include '../system/BaseModel.php';

class ListOfAuctionsModel extends BaseModel
{
    public function getCurrentAuctions()
    {
        $dateTimeNow = time();
        $data[];
        $this->db_connection->query("SELECT * 
                            FROM  `auctions` 
                            WHERE 
                            LIMIT 0 , 30");
        return array('succsess'=>false , 'auctions'=>$data);
    }
}
