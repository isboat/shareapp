'use strict';

uiApp.factory('userService', function () {

    var Keys = {
        DISPLAYNAME: 'SESSION_DISPLAYNAME',
        USERNAME: 'SESSION_USERNAME',
        ISLOGGEDIN: 'SESSION_ISLOGGEDIN',
        CMSID: 'SESSION_CMSID'
    };

    var service = {
        SetLogin: function (data) {
            window.sessionStorage.setItem(Keys.USERNAME, data.Username);
            window.sessionStorage.setItem(Keys.DISPLAYNAME, data.DisplayName);
            window.sessionStorage.setItem(Keys.ISLOGGEDIN, data.Success);
        },
        
        ClearLogin: function () {
            window.sessionStorage.removeItem(Keys.USERNAME);
            window.sessionStorage.removeItem(Keys.DISPLAYNAME);
            window.sessionStorage.removeItem(Keys.ISLOGGEDIN);
        },
        
        IsLoggedIn: function () {
            var value = window.sessionStorage.getItem(Keys.ISLOGGEDIN);
            return value === 'true';
        },
        
        GetUserId: function () {
            return window.sessionStorage.getItem(Keys.USERNAME);
        },
        
        GetDisplayName: function () {
            return window.sessionStorage.getItem(Keys.DISPLAYNAME);
        },

        SetAppSettings: function (data) {
            window.sessionStorage.setItem(Keys.CMSID, data.CmsId);
        },

        GetCmsId: function () {
            return window.sessionStorage.getItem(Keys.CMSID);
        }
    };

    return service;
});