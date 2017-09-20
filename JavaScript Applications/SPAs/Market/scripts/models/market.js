let market = (() => {
    async function getShopItems() {
        let allItems = await requester.get('appdata', 'shop');
        let shopItems = [];

        for (let item in allItems) {
            if (!allItems[item].inCart) {
                allItems[item].price = allItems[item].price.toFixed(2);
                shopItems.push(allItems[item]);
            }
        }
        return shopItems;
    }

    async function getCartItems() {
        let userId = sessionStorage.getItem('userId');
        let currentUser = await requester.get('user', userId);

        return currentUser.cart;
    }

    async function moveToCart(productId) {
        let userId = sessionStorage.getItem('userId');
        let currentUser = await requester.get('user', userId);
        let currentProduct = await requester.get('appdata', 'shop/' + productId);

        let cart;
        if (!currentUser['cart']) {
            cart = {};
        } else {
            cart = currentUser['cart'];
        }

        //IF HAS ALREADY PURCHASED
        if (cart.hasOwnProperty(productId)) {
            cart[productId].quantity++;
            cart[productId].product.totalPrice = (+currentProduct.price * +cart[productId].quantity).toFixed(2);
        } else {
            cart[productId] = {};
            cart[productId]._id = currentProduct._id;
            cart[productId].quantity = 1;
            cart[productId].product = {
                title: currentProduct.title,
                description: currentProduct.description,
                totalPrice: (+currentProduct.price * +cart[productId].quantity).toFixed(2)
            }
        }

        currentUser.cart = cart;
        requester.update('user', userId, '', currentUser);
    }

    async function deleteCartItem(productId) {
        let userId = sessionStorage.getItem('userId');
        let currentUser = await requester.get('user', userId);
        let currentProduct = await requester.get('appdata', 'shop/' + productId);

        delete currentUser.cart[productId];
        requester.update('user', userId, '', currentUser);
    }

    return {
        getShopItems,
        getCartItems,
        moveToCart,
        deleteCartItem
    }
})();