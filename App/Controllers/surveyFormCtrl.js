angular
    .module('surveyControllers', ['ngAnimate'])
    .controller('surveyFormCtrl', ['$scope', '$http', 'questionsFactory', 'answersFactory', '$location',
        function ($scope, $http, questionsFactory, answersFactory, $location, $sce) {

            questionsFactory.callQuestionsData()
                .then(function (data) {
                    $scope.questions = angular.fromJson(data);
                }, function (data) {
                    console.log(data);
                });

            $scope.addNewAnswer = function (newAnswer, newQuestion) {
                function addAnswer(newAnswerName, newQuestionId) {
                    answersFactory.setAnswers(newAnswerName, newQuestionId)
                        .success(function () {
                            $scope.status = 'Inserted Answer! Refreshing Answer list.';
                        }).
                        error(function (error) {
                            $scope.status = 'Unable to insert Answer: ' + error.message;
                        });
                }

                // Answer object constructor
                // Properties are the same as what the AnswerController is expecting
                function Answer(name, questionId) {
                    // Name from input
                    this.Value = name;
                    this.QuestionId = questionId;
                }

                // Create new object that will be passed to API
                var NewAnswer = new Answer(newAnswer, newQuestion);
                // Pass new Answer object to API
                addAnswer(NewAnswer);
                // Clear out new Answer input
                $scope.newAnswerName = '';
            };
        }]);
