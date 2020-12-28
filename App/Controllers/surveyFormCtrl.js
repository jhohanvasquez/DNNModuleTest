﻿angular
	.module('surveyControllers', [])
	.controller('surveyFormCtrl', ['$scope', '$http', 'questionsFactory', 'answersFactory', '$location',
		function ($scope, $http, questionsFactory, answersFactory, $location, $sce) {

		questionsFactory.callQuestionsData()
			.then(function (data) {
				$scope.questions = angular.fromJson(data);
			}, function (data) {
				console.log(data);
			});

		 answersFactory.callAnswersData()
		 	.then(function (data) {
		 		$scope.answers = angular.fromJson(data);
		 	}, function (data) {
		 		console.log(data);
			  });

		// $scope.answers = 'Survey Questions go here.';

		// Wrap in function to be able to load 
		// after new question has been asked
		$scope.loadAnswers = function () {
			answersFactory.callAnswersData()
				.then(function (data) {
					$scope.Answers = angular.fromJson(data);
				}, function (data) {
					console.log(data);
				});
		};
		$scope.loadAnswers();

		$scope.addNewAnswer = function (newAnswer) {
			function addAnswer(newAnswerName) {
				answersFactory.setAnswers(newAnswerName)
					.success(function () {
						$scope.status = 'Inserted Answer! Refreshing Answer list.';
						// Reload Answers - pulls list from API to load Answers that
						// could be added or removed by other users since page has been loaded
						$scope.loadAnswers();
					}).
					error(function (error) {
						$scope.status = 'Unable to insert Answer: ' + error.message;
					});
			}

			// Answer object constructor
			// Properties are the same as what the AnswerController is expecting
			function Answer(name) {
				// Name from input
				this.Name = name;
				// Static for now, can add variations later
				this.Description = 'Text';
			}

			// Create new object that will be passed to API
			var NewAnswer = new Answer(newAnswer);
			// Pass new Answer object to API
			addAnswer(NewAnswer);
			// Clear out new Answer input
			$scope.newAnswerName = '';
		};
	}]);
