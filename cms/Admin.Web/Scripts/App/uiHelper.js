'use strict';

var UiHelper = function() {
    
    this.IsLoading = false;

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

    this.ShowLoading = function (container) {
        container = container || '.fullscreen';
        var $loading = $('<div class="loading"><span>Loading...</span></div>');
        var $container = $('body').find(container);

        if ($container.length) {
            //Set up
            $loading.css({
                'width': $container.css('width'),
                'height': $container.css('height')
            });

            // Display
            $container.prepend($loading);
            this.IsLoading = true;
        }
    };

    this.HideLoading = function () {
        var loading = $('.fullscreen').find('.loading');
        if (this.IsLoading && loading.length) {
            loading.remove();
        }
    }
};

var uiHelper = new UiHelper();