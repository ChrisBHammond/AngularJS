var myapp = angular.module('myApp', ["ui.router"]);

myapp.config(function ($stateProvider, $urlRouterProvider) {

    // For any unmatched url, send to /home
    $urlRouterProvider.otherwise("/Home")
      
    var Home = {
        name: 'Home',
        url: '/Home',
        templateUrl: 'app/home/home.html'
    }

    var VideoGames = {
        name: 'VideoGames',
        url: '/VideoGames',
        templateUrl: 'app/videoGames/VideoGames.html'
    }

    var VideoGamesDetail = {
        name: 'VideoGameDetails',
        url: '/VideoGamesDetails/:id',
        templateUrl: 'app/videoGames/VideoGame-Detail.html'
    }

    var about = {
        name: 'About',
        url: '/about',
        templateUrl: 'app/about/about.html'
    }

    $stateProvider.state(Home);
    $stateProvider.state(VideoGames);
    $stateProvider.state(VideoGamesDetail);
    $stateProvider.state(about);

});

