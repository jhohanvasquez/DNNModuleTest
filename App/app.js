'use strict';
angular
	.module('DNNModuleTest', [
		'ngRoute',
		'surveyControllers',
		'ui.bootstrap'
	])
	.config(['$routeProvider', '$httpProvider',
		function ($routeProvider) {
			console.log('app loaded');
			$routeProvider
			.when('/results', {
				templateUrl: '/DesktopModules/DNNModuleTest/app/Views/surveyResultsView.html',
				controller: 'surveyResultsCtrl'
			})
			.when('/edit', {
				templateUrl: '/DesktopModules/DNNModuleTest/app/Views/surveyEditView.html',
				controller: 'surveyEditCtrl'
			})
			.otherwise({
				templateUrl: '/DesktopModules/DNNModuleTest/app/Views/surveyFormView.html',
				controller: 'surveyFormCtrl'
			});
		}
	]);