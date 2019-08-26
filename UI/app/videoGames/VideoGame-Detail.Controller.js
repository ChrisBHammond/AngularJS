myapp.controller('VideoGameDetailController', ['$stateParams','$state', 'GameStoreService',
    function ($stateParams, $state, GameStoreService) {
        var vm = this;
        vm.videoGame = {};

        vm.id = $stateParams.id;

        GameStoreService.getVideoGameById(vm.id).then(function (data) {
            vm.videoGame = data;

            //convert string into date object wonder if this can be down better in html file?
            vm.videoGame.ReleaseDate = new Date(data.ReleaseDate);
        });

        vm.updateVideoGame = function (videoGame) {

            GameStoreService.updateVideoGame(videoGame).then(function (data) {

                //TODO check if video game failed to update
                $state.go("VideoGames");
            });

        };

    }
]);

