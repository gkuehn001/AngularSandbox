<%@ Page Language="VB" %>

<!DOCTYPE html>
<html ng-app="store">
<head>
    <link rel="stylesheet" type="text/css" href="css/bootstrap.min.css" />
</head>
<body ng-controller="StoreController as store">
    <script type="text/javascript" src="js/angular.min.js"></script>
    <script type="text/javascript" src="js/app.js"></script>


    <div ng-repeat="product in newProducts">
        <h1>{{product.name}}</h1>
        <em class="pull-right"><h2>{{product.price | currency}}</h2></em>
        <img ng-src="{{product.image.thumb}}" />
        <p>{{product.description | limitTo:50}}</p>
        <button ng-show="product.canPurchase">Add to cart</button>
    </div>
</body>
</html>

