myapp.controller('VideoGameController', ['GameStoreService',
    function (GameStoreService) {
        var vm = this;
        vm.videoGames = {};
        vm.name = "Testing out VideoGame Controller as";
        vm.things = ["A", "Set", "Of", "Things"];

        GameStoreService.getVideoGames().then(function (data) {
            console.log(data);
            vm.videoGames = data;
        });
    }

   
]);