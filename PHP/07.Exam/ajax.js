var ajax = {
    url: null,
    data: null,    
    method: null,
    success: null,
    responseType: null,
    xhr: null,
    
    request: function(opts) {
        this.url = opts.url;
        this.method = this[opts.method.toLowerCase()];
	this.success = opts.success;
	this.responseType = opts.responseType;
        this.data = opts.data;
        this.createInstance();
	var self = this;
        this.xhr.onreadystatechange = (function() {
		self.callback(self);
	});
	this.method();
    },
    getProgId: function() {
        var axi = ['MSXML2.XMLHTTP.6.0', 'MSXML2.XMLHTTP.3.0',
                   'MSXML2.XMLHTTP', 'Microsoft.XMLHTTP'];
        for (var i = 0; i < axi.length; i++) {
          var candidate = axi[i];
          try {
            new ActiveXObject(candidate);
            return candidate;
          } catch (e) {
            // do nothing; try next choice
          }
        }  
    },
    createInstance: function() {
      var progId = this.getProgId();
      if (progId) {
        this.xhr = new ActiveXObject(progId);
      } else {
        this.xhr = new XMLHttpRequest();
      }        
    },
    get: function() {
        this.xhr.open("GET", this.url + "?" + (new Date().getTime()));
        this.xhr.send(null);
    },
    post: function() {
        this.xhr.open("POST", this.url + "?" + (new Date().getTime()));
        this.xhr.send(this.data);
    },
    callback: function(self) {
        if (self.xhr.readyState == 4) {
            if (self.xhr.status == 200) {
                try {
                    self.success((self.responseType === "xml")?self.xhr.responseXML:self.xhr.responseText);
                } catch (e) {
                }
            } else {
                console.log("Error status: " + self.xhr.status + ", status message: " + self.xhr.statusText);
            }
        }
    }
};

