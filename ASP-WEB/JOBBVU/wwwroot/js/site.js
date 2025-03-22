
document.addEventListener("DOMContentLoaded", function () {
    const togglePassword = document.querySelector(".toggle-password");
    const toggleConfirmPassword = document.querySelector(".toggle-confirm-password");

    const passwordInput = document.getElementById("passwordInput");
    const confirmPasswordInput = document.getElementById("confirmPasswordInput");

    togglePassword.addEventListener("click", function () {
        if (passwordInput.type === "password") {
            passwordInput.type = "text";
            this.innerHTML = '<i class="fas fa-eye-slash"></i>';
        } else {
            passwordInput.type = "password";
            this.innerHTML = '<i class="fas fa-eye"></i>';
        }
    });

    toggleConfirmPassword.addEventListener("click", function () {
        if (confirmPasswordInput.type === "password") {
            confirmPasswordInput.type = "text";
            this.innerHTML = '<i class="fas fa-eye-slash"></i>';
        } else {
            confirmPasswordInput.type = "password";
            this.innerHTML = '<i class="fas fa-eye"></i>';
        }
    });
});

