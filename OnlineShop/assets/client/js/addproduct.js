﻿function addProduct() {
    //this is just a product placeholder
    var productAdded = $('<li class="product"> < div class="rating-left" ><a href= "#0" > <img src="img/product-preview.png" alt="placeholder"></a></div ><div class="simpleCart_shelfItem products-right-grid1-add-cart"><h3><a href="#0">Product Name</a></h3><span class="item_price">$25.99</span><div class="actions"><a href="#0" class="delete-item">Delete</a><div class="quantity"><label for="cd-product-' + productId + '">Qty</label><span class="select"><select id="cd-product-' + productId + '" name="quantity"> <option value="1">1</option>                           <option value="2">2</option>                            <option value="3">3</option>                            <option value="4">4</option><option value="5">5</option><option value="6">6</option><option value="7">7</option><option value="8">8</option><option value="9">9</option></select>  </span></div>  </div></div></li > ');
       
    cartList.prepend(productAdded);
}