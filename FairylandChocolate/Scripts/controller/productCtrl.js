var ctrl = angular.module("productCtrl", []);
ctrl.controller("productCtrl", ["$scope", "productService", "$location", "$window", "$rootScope", function ($scope, productService,
    $location, $window, $rootScope) {
    $scope.productList = [];
    $scope.editProductItem = [];
    $scope.Loading = true;
    $scope.recordSize = "5";
    $scope.Page = 1;

    $scope.showProductList = true;

    $scope.Init = function () {
        productService.GetAllProduct()
        .then(function (res) {
            var prdList = JSON.parse(res.data);
            $scope.productList = prdList;
            $scope.totalProduct = prdList.length;
            $scope.changePage($scope.Page)
            $scope.Loading = false;
            $scope.showProductList = true;
            $scope.showEditProduct = false;
            $scope.showAddProduct = false;
        }, function (err) {
            $scope.Loading = false;
            $scope.showProductList = true;
            $scope.showEditProduct = false;
            $scope.showAddProduct = false;
            Materialize.toast('Some Error occured! Please try after sometime', 4000);
        });
    }

    $scope.Init();
    
    $scope.ShowEditProductPage = function (productId) {
        $('.preloader-background').fadeIn();
        productService.GetProductById(productId)
        .then(function (success) {
            $scope.editProductItem = JSON.parse(success.data);
            $scope.showProductList = false;
            $scope.showEditProduct = true;
            $scope.showAddProduct = false;
            $('.preloader-background').fadeOut();
            //Materialize.toast('Awesome, we got the data', 4000);
        },function (status) {
            Materialize.toast('Bad stuff happened', 4000);
        });
    }
    
    $scope.record = {
        choices: ["1","3","5","10"]
    };

    $scope.changePage = function (page) {
        $scope.Page = page;
        _page = parseInt($scope.Page);
        _records = parseInt($scope.recordSize);
        $scope.productListFilter = $scope.productList.slice((_page - 1) * _records, ((_page - 1) * _records) + _records);
    };

    $scope.ChangeRecord = function (recordSize) {
        $scope.recordSize = recordSize;
        $scope.changePage(1);
    };

    $scope.DeleteProduct = function (productId) {
        productService.DeleteProduct(productId)
        .then(function (success) {
            success.data === true ?
            Materialize.toast('Product successfully deleted', 4000) :
            Materialize.toast('Some Error occured! Please try after sometime', 4000);
            $scope.Init();
        }, function (status) {
            Materialize.toast('Some Error occured! Please try after sometime', 4000);
        });
    }

    $scope.ShowAddProductPage = function (productId) {
        $('.preloader-background').fadeIn();

        $scope.addproductItem = {
            productName: "",
            keywords: "",
            shortDescription: "",
            longDescription: "",
            isActive: "",
            unitPrice: "",
            unitCost: ""
        }
        $scope.showProductList = false;
        $scope.showEditProduct = false;
        $scope.showAddProduct = true;
        $('.preloader-background').fadeOut();        
    }

    $scope.ProductAddition = function () {
        productService.AddProduct($scope.addproductItem)
        .then(function (res) {
            res.data === true ?
            Materialize.toast('Product added successfully', 4000) :
            Materialize.toast('Product addition failed', 4000);
            $scope.Init();
        }, function (err) {
            Materialize.toast('Product addition failed', 4000);
        });
    }

    $scope.ProductUpdation = function () {        
        productService.UpdateProduct($scope.editProductItem)
        .then(function (res) {
            res.data === true ?
            Materialize.toast('Product updated successfully', 4000) :
            Materialize.toast('Product updation failed', 4000);
            $scope.Init();
        }, function (err) {
            Materialize.toast('Product updation failed', 4000);
        });
    }
}]);


