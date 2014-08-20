'use strict';

var UiHelper = function() {
    
    this.ShowMessage = function(data) {
        var $el = $('#alertMessage');
        $el.addClass(data.Type); // error=red, success=green, info=blue
        $el.html("<span>" + data.Message + "</span>");
    };
    
    this.ClearMessage = function(data) {
        var $el = $('#alertMessage');
        $el.removeClass();
        $el.empty();
    };
};

var uiHelper = new UiHelper();