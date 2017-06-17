﻿var user = {
    innit: function () {
        user.registerEvents();
    },

    registerEvents: function () {
        $('.btn-active').off('click').on('click', function (e) {
            e.preventDefault();
            var btn = $(this);
            var id = btn.data('id');
            $.ajax({
                url: "/Admin/User/ChangeStatus",
                data: { id: id },
                datatype: "json",
                type: 'POST',
                success: function (response) {
                    console.log(response);
                    if (response.status == true) {
                       btn.text('Active');

                    }
                    else {
                        btn.text('Lock');
                    }
                }
            });
        });
    }
}

user.innit();