myapp.controller('VideoGameController', ['GameStoreService',
    function (GameStoreService) {
        var vm = this;
        //vm.videoGames = {};
        vm.name = "Hello from Video Game Controller!";

        //First load time from the API seems to take 3+ seconds
        //I beleive this is beacuse IIS is still loading the app pool?
        GameStoreService.getVideoGames().then(function (data) {
            console.log(data);
            vm.videoGames = data;
        });
    }
]);