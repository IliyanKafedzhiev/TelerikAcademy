<?php

/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 * Description of FrontControler
 *
 * @author Iliyan
 */

namespace GF;

class FrontControler
{

    private static $_instance = null;
    private $ns = null;
    private $controller = null;
    private $method = null;

    private function __construct()
    {
        
    }

    /**
     * 
     * @return \GF\FrontControler
     */
    public function dispatch()
    {
        $a = new \GF\Routers\DefaultRouter();
        $_uri = $a->getURI();
        $routes = \GF\App::getInstance()->getConfig()->routes;
        $_rc;
        if (is_array($routes) && count($routes) > 0)
        {
            foreach ($routes as $key => $value)
            {
                if (strpos($_uri, $key) === 0 && ( $_uri == $key || strpos($_uri, $key . '/') === 0 ) && $value['namespace'])
                {
                    $this->ns = $value['namespace'];
                    $_uri = substr($_uri, strlen($key) + 1);
                    $_rc = $value;
                    break;
                }
            }
        } else
        {
            throw new \Exception('Default route missing', 500);
        }
        if ($this->ns == null && $routes['*']['namespace'])
        {
            $this->ns = $routes['*']['namespace'];
            $_rc = $routes['*'];
        } else if ($this->ns == null && !$routes['*']['namespace'])
        {
            throw new \Exception('Default route missing', 500);
        }

        $_params = explode('/', $_uri);
        if ($_params[0])
        {
            $this->controller = $_params[0];
            if ($_params[1])
            {
                $this->method = $_params[1];
            } else
            {
                $this->method = $this->getDefaultMethod();
            }
        } else
        {
            $this->controller = $this->getDefaultController();
            $this->method = $this->getDefaultMethod();
        }
        if (is_array($_rc) && $_rc['controllers'] && $_rc['controllers'][$this->controller]['to'])
        {
            if ($_rc['controllers'][$this->controller]['methods'][$this->method])
            {
                $this->method = $_rc['controllers'][$this->controller]['methods'][$this->method];
            }
            $this->controller = $_rc['controllers'][$this->controller]['to'];
        }
        $obj = $this->ns.'\\'.$this->controller;
        $newController = new $obj();
        $newController->{$this->method}();
        
    }

    public function getDefaultController()
    {
        $controller = \GF\App::getInstance()->getConfig()->app['default_controller'];
        if ($controller)
        {
            return $controller;
        }
        return 'index';
    }

    public function getDefaultMethod()
    {
        $method = \GF\App::getInstance()->getConfig()->app['defalt_method'];
        if ($method)
        {
            return $method;
        }
        return 'index';
    }

    public static function getInstance()
    {
        if (self::$_instance == null)
        {
            self::$_instance = new \GF\FrontControler();
        }
        return self::$_instance;
    }

}
