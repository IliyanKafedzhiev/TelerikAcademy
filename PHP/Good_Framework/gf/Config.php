<?php

/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 * Description of Config
 *
 * @author Iliyan
 */

namespace GF;

class Config
{

    private static $_instance = null;
    private $_configFolder = null;
    private $_configArray = array();

    private function __construct()
    {
        
    }

    /**
     * 
     * @return \GF\Config
     */
    public static function getInstance()
    {
        if (self::$_instance == NULL)
        {
            self::$_instance = new \GF\Config();
        }
        return self::$_instance;
    }

    public function setConfigFolder($configFolder)
    {
        if (!$configFolder)
        {
            throw new \Exception("Empty configFolder path");
        }
        $_configFolder = realpath($configFolder);
        if ($_configFolder != FALSE && is_dir($_configFolder) && is_readable($_configFolder))
        {
            $this->_configArray = array();
            $this->_configFolder = $_configFolder . DIRECTORY_SEPARATOR;
            $ns = $this->app['namespaces'];
            if (is_array($ns))
            {
                \GF\Loader::registerNamespaces($ns);
            }
        } else
        {
            throw new \Exception('Config directory read error' . $configFolder);
        }
    }

    public function __get($name)
    {
        if (!$this->_configArray[$name])
        {
            $this->includeConfigFile($this->_configFolder . $name . '.php');
        }
        if (array_key_exists($name, $this->_configArray))
        {
            return $this->_configArray[$name];
        }
        return null;
    }

    public function includeConfigFile($path)
    {
        if (!$path)
        {
            throw new Exception;
        }
        $_file = realpath($path);
        if ($_file != FALSE && is_file($_file) && is_readable($_file))
        {
            $_basename = explode('.php', basename($_file))[0];
            $this->_configArray[$_basename] = include $_file;
        } else
        {
            throw new \Exception('Config file read error:' . $path);
        }
    }

    public function getConfigFolder()
    {
        return $this->_configFolder;
    }

}
