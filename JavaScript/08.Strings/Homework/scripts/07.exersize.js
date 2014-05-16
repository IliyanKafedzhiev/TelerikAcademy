//function to parse URL and return JSON object
function parseURL(url)
{
    var protocol = url.split('://')[0];

    var server = url.split('://')[1];
    server = server.split('/')[0];

    var resource = url.split('://')[1];
    resource = resource.split('/')[1];

    return {
        protocol: protocol,
        server: server,
        resource: resource,
        toString:function()
        {
            return 'protocol: ' + this.protocol + '<br/>' +
			      'server: ' + this.server + '<br/>' +
				  'resource:' + this.resource;
        }
    };
}

var url = "http://www.devbg.org/forum/index.php ";
jsConsole.writeLine(parseURL(url));