'use strict';

angular.module('netpontoApp.API', ['ngResource'])
  .factory('API', function ($resource) {

      var API = $resource(
          '/api/:controller/:id',
          [],
          {
              GetProcesses:     { method: 'GET',    params: { controller: 'processes' }, isArray: true },
              GetProcess:       { method: 'GET',    params: { controller: 'processes' }},
              AddProcess:       { method: 'POST',   params: { controller: 'processes' }},
              UpdateProcess:    { method: 'PUT',    params: { controller: 'processes' }},
              DeleteProcess:    { method: 'DELETE', params: { controller: 'processes' }},
          }
          );
      return API;
  });