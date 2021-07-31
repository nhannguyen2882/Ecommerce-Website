// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
const onLoginButtonClick = event => {
    event.preventDefault();
    userManager.signinRedirect();
};

const onLogoutButtonClick = event => {
    event.preventDefault();
    userManager.signoutRedirect({ id_token_hint: user.id_token });
    userManager.removeUser();
};

