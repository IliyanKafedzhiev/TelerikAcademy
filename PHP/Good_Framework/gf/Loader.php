<?php

/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 * Description of Loader
 *
 * @author Iliyan
 */

namespace GF;

class Loader
{

    private static $namespace = array();

    private function __construct()
    {
        
    }

    /**
     * 
     * @return \GF\Loader
     */
    public static function registerAutoLoad()
    {
        spl_autoload_register(array('\GF\Loader', 'autoload'));
    }

    public static function autoload($class)
    {
        //echo $class;
        self::loadClass($class);
    }

    public static function loadClass($class)
    {
        foreach (self::$namespace as $k => $v)
        {
            if (strpos($class, $k) === 0)
            {
                $f = str_replace('\\', DIRECTORY_SEPARATOR, $class);
                $f = substr_replace($f, $v, 0, strlen($k)) . '.php';
                $f = realpath($f);
                if ($f && is_readable($f))
                {
                    include $f;
                } else
                {
                    throw new \Exception("File cannnot be included:", $f);
                }
                break;
            }
        }
    }

    public static function registerNamespaces($ar)
    {
        if (is_array($ar))
        {
            foreach ($ar as $k => $v)
            {
                self::registerNamespace($k, $v);
            }
        } else
        {
            throw new \Exception('Invalid Namespaces');
        }
    }

    public static function registerNamespace($namespace, $path)
    {
        $namespace = trim($namespace);
        if (strlen($namespace) > 0)
        {
            if (!$path)
            {
                throw new \Exception('Invalid path');
            }
            $_path = realpath($path);
            if ($_path && is_dir($_path) && is_readable($_path))
            {
                self::$namespace[$namespace . '\\'] = $_path . DIRECTORY_SEPARATOR;
            } else
            {
                //TOdO
                throw new \Exception("Namespace directory read error:" . $path);
            }
        } else
        {
            throw new \Exception('Invalid namespace:' . $namespace);
        }
    }

}
