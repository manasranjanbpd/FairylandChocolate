var productsvc = angular.module("productService", []);

productsvc.factory('productService', function ($http) {
    var factory = {};

    factory.GetAllProduct = function () {
        return $http.post('GetAllProduct');
    }

    factory.GetProductById = function (productId) {
        return $http.post('GetProductById', { productId: productId });
    }

    factory.AddProduct = function (product) {
        return $http.post('SaveProduct', { productData: product });
    }

    factory.DeleteProduct = function (productId) {
        return $http.delete('DeleteProduct', { params: { productId: productId } });
    }

    factory.UpdateProduct = function (product) {
        return $http.post('UpdateProduct', { productData: product });
    }

    return factory;
});