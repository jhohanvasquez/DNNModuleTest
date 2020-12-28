angular
    .module('surveyControllers')
    .controller('surveyResultsCtrl', ['$scope', '$http', 'answersFactory', '$location',
        function ($scope, $http, answersFactory, $location, $sce) {

            answersFactory.callAnswersData()
                .then(function (data) {
                    $scope.answers = angular.fromJson(data);
                }, function (data) {
                    console.log(data);
                });
        }]);
