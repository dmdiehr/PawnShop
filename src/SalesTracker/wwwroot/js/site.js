// Write your Javascript code.
$(document).ready(function () {
    $('.create-item').click(function () {
        $.ajax({
            type: 'GET',
            dataType: 'html',
            url: '~/../../Item/CreateItem',
            success: function (result) {
                $('#item-form').html(result);
            }
        });
    });

    $('.show-items').click(function () {
        $.ajax({
            type: 'GET',
            dataType: 'html',
            url: '~/../../Item/Inventory',
            success: function (result) {
                $('#item-grid').html(result);
            }
        });
    });

    $('.hide-inventory').click(function () {
        $.ajax({
            type: 'GET',
            dataType: 'html',
            url: '~/../../Home/Associates',
            success: function (result) {
                $('#associates').html(result);
            }
        });
    });
});
