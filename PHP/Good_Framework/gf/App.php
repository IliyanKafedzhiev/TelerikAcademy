<?php

/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 * Description of App
 *
 * @author Iliyan
 */

namespace GF;

include_once 'Loader.php';

class App
{

    private static $_instance = null;
    private $_config = null;

    /**
     * @var \GF\FrontControler
     */
    private $_frontController = null;

    private function __construct()
    {
        \GF\Loader::registerNamespace('GF', dirname(__FILE__) . DIRECTORY_SEPARATOR);
        \GF\Loader::registerAutoLoad();
        $this->_config = \GF\Config::getInstance();
    }

    public function setConfigFolder($path)
    {
        $this->_config->setConfigFolder($path);
    }

    public function getConfigFolder()
    {
        return $this->_config->getConfigFolder();
    }

    /**
     * 
     * @return \GF\Config
     */
    public function getConfig()
    {
        return $this->_config;
    }

    public function run()
    {
        if ($this->getConfigFolder() == null)
        {
            $this->setConfigFolder('../config');
        }
        $this->_frontController = \GF\FrontControler::getInstance();
        $this->_frontController->dispatch();
    }

    /**
     * 
     * @return \GF\App
     */
    public static function getInstance()
    {
        if (self::$_instance == null)
        {
            self::$_instance = new \GF\App();
        }
        return self::$_instance;
    }

}
