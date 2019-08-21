myapp.controller('VideoGameDetailController', ['$stateParams',
    function ($stateParams) {
        var vm = this;
        vm.name = "Testing out VideoGameDetailController as is";
        
        vm.id = $stateParams.id;
        
        console.log($stateParams.id);
        vm.things = ["A", "Set", "Of", "Things"];
    }
]);

