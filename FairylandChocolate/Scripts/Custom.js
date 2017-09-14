$(document).ready(function(){
$('div[id^=product-]').on('click',function(){
var dataAction = $(this).attr('data-url');
window.location.href = dataAction;
});
});
