app.config(function($routeProvider){
    $routeProvider
        .when('/home', {
            controller: 'HomeController',
            templateUrl: '/templates/home.html'
        })
        .when('/login', {
            controller: 'LoginController',
            templateUrl: '/templates/login.html'
        })
        .when('/register', {
            controller: 'RegisterController',
            templateUrl: '/templates/register.html'
        })
        .otherwise({
            redirectTo: '/'
        })
});

app.config(function($httpProvider){
    $httpProvider.interceptors.push('authInterceptorService');
});

app.run(['authService', function(authService){
    authService.fillAuthData();
}]);