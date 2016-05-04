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
});
