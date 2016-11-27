(function () {
    var app = angular.module('store', []);

    app.controller('StoreController', function () {
        this.products = gems;
    });

    var gems = [
    {
        name: 'Dodecahedron',
        price: 2,
        description: "In geometry, a dodecahedron is any polyhedron with twelve flat faces. The most familiar dodecahedron is the regular dodecahedron, which is a Platonic solid. There are also three regular star dodecahedra, which are constructed as stellations of the convex form. All of these have icosahedral symmetry, order 120.",
        canPurchase: true,
        soldOut: false,
        images: [
            {
                full: 'images/Dodecahedron.png',
                thumb: 'images/120px-Dodecahedron.png'
            }
        ]
    },
    {
        name: 'Pentagonal Gem',
        price: 5.95,
        description: "The most familiar dodecahedron is the regular dodecahedron, which is a Platonic solid. There are also three regular star dodecahedra, which are constructed as stellations of the convex form. All of these have icosahedral symmetry, order 120.",
        canPurchase: false,
        soldOut: false
    }
    ];

})();