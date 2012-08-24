'use strict';

angular.module('netpontoApp.filters', [])
    .filter('truncate', function () {
        return function (text, length, end) {
            if (text == undefined)
                return;
            if (isNaN(length))
                length = 10;

            if (end === undefined)
                end = "...";

            if (text.length <= length || text.length - end.length <= length) {
                return text;
            }
            else {
                return String(text).substring(0, length - end.length) + end;
            }

        }
    })
    .filter('newline', function () {
        return function (text) {
            if (text != undefined)
                return text.replace(/\n/g, '<br/>');
            return text;
        }
    });
