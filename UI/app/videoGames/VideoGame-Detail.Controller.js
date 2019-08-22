myapp.controller('VideoGameDetailController', ['$stateParams', 'GameStoreService',
    function ($stateParams, GameStoreService) {
        var vm = this;
        vm.name = "Updating";
        vm.videoGame = {};
        
        vm.id = $stateParams.id;
        
        console.log($stateParams.id);

        GameStoreService.getVideoGameById(vm.id).then(function (data) {
            console.log(data);
            vm.videoGame = data;

            //convert string into date object wonder if this can be down better in html file?
            vm.videoGame.ReleaseDate = new Date(data.ReleaseDate);
            
        });

        
        
    }
]);

