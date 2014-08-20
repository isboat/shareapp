'use strict';

uiApp.factory('userService', function () {

    var Keys = {
        DISPLAYNAME: 'SESSION_DISPLAYNAME',
        USERID: 'SESSION_USERID',
        ISLOGGEDIN: 'SESSION_ISLOGGEDIN'
    };

    var service = {
        SetLogin: function (data) {
            window.sessionStorage.setItem(Keys.USERID, data.UserId);
            window.sessionStorage.setItem(Keys.DISPLAYNAME, data.DisplayName);
            window.sessionStorage.setItem(Keys.ISLOGGEDIN, data.Success);
        },
        
        ClearLogin: function () {
            window.sessionStorage.removeItem(Keys.USERID);
            window.sessionStorage.removeItem(Keys.DISPLAYNAME);
            window.sessionStorage.removeItem(Keys.ISLOGGEDIN);
        },
        
        IsLoggedIn: function () {
            var value = window.sessionStorage.getItem(Keys.ISLOGGEDIN);
            return value === 'true';
        },
        
        GetUserId: function () {
            return window.sessionStorage.getItem(Keys.USERID);
        },
        
        GetDisplayName: function () {
            return window.sessionStorage.getItem(Keys.DISPLAYNAME);
        }
    };

    return service;
});