<?php

/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 * Description of newActionController
 *
 * @author Iliyan
 */
class newActionController
{

    public function __construct()
    {
        if (!isset($_SESSION['is_logged']) && $_SESSION['is_logged'] === false)
        {
            header('?');
            exit;
        }
        $view_data['page_title'] = 'New Action';
        if ($_SERVER['REQUEST_METHOD'] == 'POST')
        {
           
                include '../models/ActionRegModel.php';
                $action_model = new ActionRegModel();
                $result = $action_model->registerAction($_POST['name'],$_POST['description'],$_POST['price'],$_POST['date']);
                if ($result['success'])
                {
                    View::getInstance()->render('registerAction_ok', $view_data);
                    exit;
                }else
                {
                    $view_data['errors'] = $result['error'];
                }
            
              
        } else
        {
            $view_data['errors']['not_logged'] = "You are not logged in";
        }
        View::getInstance()->render('registerAction', $view_data);
    }

}
