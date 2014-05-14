<?php 
include("libs/PHPCrawler.class.php");
// It may take a whils to crawl a site ...
set_time_limit(10000);
// Now, create a instance of your class, define the behaviour
// of the crawler (see class-reference for more options and details)
// and start the crawling-process. 
// Inculde the phpcrawl-mainclass
// Extend the class and override the handleDocumentInfo()-method 
class MyCrawler extends PHPCrawler 
{
            
        function handleDocumentInfo($DocInfo) 
  {
    // Just detect linebreak for output ("\n" in CLI-mode, otherwise "<br>").
    if ($DocInfo->received == true)
    {
        echo "Content received: ".$DocInfo->bytes_received." bytes".$lb;
    
        $ContentOfTheCurrentPage = array("url"=>"","title"=>"","content"=>"","outgoingLinks"=>"","keyWords"=>"","rank"=>0,"httpHeader"=>"");
        $ContentOfTheCurrentPage["url"] = $DocInfo->url;             //Add HTTP in Array
        $ContentOfTheCurrentPage["httpHeader"] = $DocInfo->header;   //Add HTTP in Array
        $ContentOfTheCurrentPage["content"] = $DocInfo->content;     //Add Contetn in Array

        //$html = str_get_html($DocInfo->content);
        //$el = $html->find('title', 0);
        //$ContentOfTheCurrentPage["title"] = $el->innertext;
        var_dump($ContentOfTheCurrentPage);
    }
    
    // Now you should do something with the content of the actual
    // received page or file ($DocInfo->source), we skip it in this example 
    
    echo $lb;
    
    flush();
  } 
}

$crawler = new MyCrawler();
//function setMyCrawer(&$crawler)
//{
    $crawler->setUserAgentString("GoomedBot (www.example.com/discriptionBot)");
    // URL to crawl
    $crawler->setURL("http://mashups.goomedlabs.info");

    // Only receive content of files with content-type "text/html"
    $crawler->addContentTypeReceiveRule("#text/html#");

    // Ignore links to pictures, dont even request pictures
    $crawler->addURLFilterRule("#\.(jpg|jpeg|gif|png)$# i");

    // Store and send cookie-data like a browser does
    $crawler->enableCookieHandling(true);


    // Set the traffic-limit to 1 MB (in bytes,
    // for testing we dont want to "suck" the whole site)
    $crawler->setTrafficLimit(1000 * 1024);
//}

// Thats enough, now here we go
$crawler->go();
?>