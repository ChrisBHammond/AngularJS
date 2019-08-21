myapp.factory('GameStoreService', function ($http) {
    return {
        getVideoGames: function () {
            return $http.get("http://localhost:57707/api/VideoGames").then(function (response) {
                return response.data;
            });
        }
    }

});

