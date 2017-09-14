$(document).ready(function(){
//ProductDetails/Index?id=24567890
$('div[id^=product-]').on('click',function(){
var id = $(this).attr('id');
//var productId=id.split('-')[1];
var dataAction = $(this).attr('data-action');
//dataAction = dataAction + "?id="+productId;
window.location.href = dataAction;
});
});
