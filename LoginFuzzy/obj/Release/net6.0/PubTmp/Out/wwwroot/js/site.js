// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

showInPopup = (url, title) => {
    $.ajax({
        type: "GET",
        url: url,
        success: function (res) {
            $("#form-modal .modal-body").html(res);
            $("#form-modal .modal-title").html(title);
            $("#form-modal").modal('show');
        }
    })
}

showInLogRe = (url) => {
    $.ajax({
        type: "GET",
        url: url,
        success: function (res) {
            $("#resultadologinregistro").html(res);
        }
    })
}

$(function () {
    var placeholderElement = $('#placeholdermax');
    $('a[data-toggle="ajax-modal"]').click(function (event) {
        var url = $(this).data('url');
        $.get(url).done(function (data) {
            placeholderElement.html(data);
            placeholderElement.find('.modal').modal('show');
        });
    });

    placeholderElement.on('click', '[data-transport="ajax-register"]', function (event) {
        placeholderElement.find('.modal').modal('hide');
        $('#registromodal').trigger("click");
    });

    placeholderElement.on('click', '[data-login="modal"]', function (event) {
        const target = document.getElementById("loading")
        if (target.style.display = "none") {
            target.style.display = "block";
        }
        $('#butonlogin').attr("disabled", true);

        var form = $(this).parents('.modal').find('form');
        var actionUrl = form.attr('action');
        var dataToSend = form.serialize();

        $.post(actionUrl, dataToSend).done(function (data) {
            var newBody = $('.modal-body', data);
            placeholderElement.find('.modal-body').replaceWith(newBody);

            var isValid = newBody.find('[name="IsValid"]').val() == 'True';
            if (isValid) {
                placeholderElement.find('.modal').modal('hide');
                window.location.href = "/Index";
            }
            else {
                target.style.display = "none";
                $('#butonlogin').attr("disabled", false);
                event.preventDefault();
            }
        })
    });
});

$(function () {
    var placeholderElementP2 = $('#placeholdermaxP2');
    $('a[data-toggle="ajax-modalP2"]').click(function (event) {
        var url = $(this).data('url');
        $.get(url).done(function (data) {
            placeholderElementP2.html(data);
            placeholderElementP2.find('.modal').modal('show');
        });
    });

    placeholderElementP2.on('click', '[data-teleport="ajax-login"]', function (event) {
        placeholderElementP2.find('.modal').modal('hide');
        $('#loginmodal').trigger("click");
    });

    placeholderElementP2.on('click', '[data-registro="modalP2"]', function (event) {
        const target = document.getElementById("loading")
        if (target.style.display = "none") {
            target.style.display = "block";
        }
        $('#butonregistro').attr("disabled", true);

        var form = $(this).parents('.modal').find('form');
        var actionUrl = form.attr('action');
        var dataToSend = form.serialize();

        $.post(actionUrl, dataToSend).done(function (data) {
            var newBody = $('.modal-body', data);
            placeholderElementP2.find('.modal-body').replaceWith(newBody);

            var isValid = newBody.find('[name="IsValidP2"]').val() == 'True';
            if (isValid) {
                placeholderElementP2.find('.modal').modal('hide');
                window.location.href = "/Index";
            }
            else {
                $('#butonregistro').attr("disabled", false);
                target.style.display = "none";
                event.preventDefault();
            }
        })
    });
});

$(function () {
    var placeholderElementP3 = $('#placeholdermaxP3');
    $('a[data-toggle="ajax-modal"]').click(function (event) {
        var url = $(this).data('url');
        $.get(url).done(function (data) {
            placeholderElementP3.html(data);
            placeholderElementP3.find('.modal').modal('show');
        });
    });

    placeholderElementP3.on('click', '[data-transport="ajax-register"]', function (event) {
        placeholderElementP3.find('.modal').modal('hide');
        $('#registromodal').trigger("click");
    });

    placeholderElementP3.on('click', '[data-login="modal"]', function (event) {
        const target = document.getElementById("loading")
        if (target.style.display = "none") {
            target.style.display = "block";
        }
        $('#butonlogin').attr("disabled", true);

        var form = $(this).parents('.modal').find('form');
        var actionUrl = form.attr('action');
        var dataToSend = form.serialize();

        $.post(actionUrl, dataToSend).done(function (data) {
            var newBody = $('.modal-body', data);
            placeholderElementP3.find('.modal-body').replaceWith(newBody);

            var isValid = newBody.find('[name="IsValid"]').val() == 'True';
            if (isValid) {
                placeholderElementP3.find('.modal').modal('hide');
                window.location.href = "/Index";
            }
            else {
                target.style.display = "none";
                $('#butonlogin').attr("disabled", false);
                event.preventDefault();
            }
        })
    });
});

$(function () {
    var placeholderElementP4 = $('#placeholdermaxP4');
    $('a[data-toggle="ajax-modalP2"]').click(function (event) {
        var url = $(this).data('url');
        $.get(url).done(function (data) {
            placeholderElementP4.html(data);
            placeholderElementP4.find('.modal').modal('show');
        });
    });

    placeholderElementP4.on('click', '[data-teleport="ajax-login"]', function (event) {
        placeholderElementP4.find('.modal').modal('hide');
        $('#loginmodal').trigger("click");
    });

    placeholderElementP4.on('click', '[data-registro="modalP2"]', function (event) {
        const target = document.getElementById("loading")
        if (target.style.display = "none") {
            target.style.display = "block";
        }
        $('#butonregistro').attr("disabled", true);

        var form = $(this).parents('.modal').find('form');
        var actionUrl = form.attr('action');
        var dataToSend = form.serialize();

        $.post(actionUrl, dataToSend).done(function (data) {
            var newBody = $('.modal-body', data);
            placeholderElementP4.find('.modal-body').replaceWith(newBody);

            var isValid = newBody.find('[name="IsValidP2"]').val() == 'True';
            if (isValid) {
                placeholderElementP4.find('.modal').modal('hide');
                window.location.href = "/Index";
            }
            else {
                $('#butonregistro').attr("disabled", false);
                target.style.display = "none";
                event.preventDefault();
            }
        })
    });
});

showInPopupAtributes = (title, bodytext) => {
    $.ajax({
        type: "GET",
        success: function (res) {
            $("#form-modal .modal-body").html(bodytext);
            $("#form-modal .modal-title").html(title);
            $("#form-modal").modal('show');
        }
    })
}

function closePopup() {
    $.ajax({
        success: function (res) {
            $("#form-modal").modal('hide');
        }
    })
}

$('.input-range').on('input', function () {
    $(this).next('.range-value').html(this.value);
})

$(function () {
    const target = document.getElementById("loading")
    $(".loadingclase").click(function () {
        if (target.style.display = "none") {
            target.style.display = "block";
        }
    })
})