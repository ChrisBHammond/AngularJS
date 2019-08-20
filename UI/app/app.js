
    var myapp = angular.module('myApp', ["ui.router"]);

    myapp.config(function ($stateProvider, $urlRouterProvider) {

        // For any unmatched url, send to /route1
        $urlRouterProvider.otherwise("/Home")
      

        var Home = {
            name: 'Home',
            url: '/Home',
            templateUrl: 'app/videoGames/VideoGames.html'
        }

        var VideoGames = {
            name: 'VideoGames',
            url: '/VideoGames',
            templateUrl: 'app/videoGames/VideoGames.html'
        }

        var VideoGamesDetail = {
            name: 'VideoGameDetail',
            url: '/VideoGames',
            templateUrl: 'app/videoGames/VideoGames.html'
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

        //$stateProvider
        //    .state('route1', {
        //        url: "/route1",
        //        templateUrl: '<h3>hello world!</h3>'
        //    });
            //.state('route1.list', {
            //    url: "/list",
            //    templateUrl: "route1.list.html",
            //    contr oller: "route1ctrl"
            //})

            //.state('route2', {
            //    url: "/route2",
            //    templateUrl: "route2.html"
            //})
            //.state('route2.list', {
            //    url: "/list",
            //    templateUrl: "route2.list.html",
            //    controller: "route2ctrl"
            //})
    });

