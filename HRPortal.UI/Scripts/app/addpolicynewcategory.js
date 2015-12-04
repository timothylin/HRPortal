$(document).ready(function () {
    $('#addpolicynewform').validate({
        rules: {
            Title: {
                required: true
            },
            CategoryTitle: {
                required: true
            },
            ContentText: {
                required: true
            }
        },

        messages: {
            Title: "Please enter a policy title",
            CategoryTitle: "Please enter a Category Title",
            ContextText: "ContextText"
        }
    });
});