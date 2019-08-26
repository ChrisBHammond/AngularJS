myapp.factory('GameStoreService', function ($http) {
    return {
        getVideoGames: function () {
            return $http.get("http://localhost:57707/api/VideoGames").then(function (response) {
                return response.data;
            });
        },

        getVideoGameById: function (id) {
            return $http.get("http://localhost:57707/api/VideoGames/" + id).then(function (response) {
                return response.data;
            });
        },

        updateVideoGame: function (videoGame) {
            return $http.post("http://localhost:57707/api/UpdateVideoGame", JSON.stringify(videoGame))
                .then(
                    function (response) {
                        console.log("Video Game updated");
                    },
                    function (response) {
                        console.log("Video Game updated failed");
                    }
                );


        }
    }
});

