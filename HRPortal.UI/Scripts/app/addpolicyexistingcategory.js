$(document).ready(function () {
    $('#addpolicyexistform').validate({
        rules: {
            Title: {
                required: true
            },
            CategoryId: {
                required: true
            },
            ContentText: {
                required: true
            }
        },

        messages: {
            Title: "Please enter a policy title",
            CategoryId: "Please choose a Category",
            ContextText: "ContextText"
        }
    });
});