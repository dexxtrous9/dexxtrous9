$(function () {
    // Handle Account Info Form
    $('#accountForm').on('submit', function (e) {
      e.preventDefault();
      const accountData = {
        username: $('#username').val(),
        email: $('#email').val()
      };
  
      $.post('/api/update-account', accountData, function (res) {
        alert("Account updated successfully!");
      }).fail(() => alert("Failed to update account."));
    });
  
    // Handle Password Form
    $('#passwordForm').on('submit', function (e) {
      e.preventDefault();
      const passwordData = {
        currentPassword: $('#currentPassword').val(),
        newPassword: $('#newPassword').val(),
        confirmPassword: $('#confirmPassword').val()
      };
  
      $.post('/api/update-password', passwordData, function (res) {
        alert("Password updated successfully!");
      }).fail(() => alert("Failed to update password."));
    });
  
    // Handle Preferences Form
    $('#preferencesForm').on('submit', function (e) {
      e.preventDefault();
      const preferencesData = {
        emailNotif: $('#emailNotif').is(':checked'),
        darkMode: $('#darkMode').is(':checked')
      };
  
      $.post('/api/update-preferences', preferencesData, function (res) {
        alert("Preferences saved!");
      }).fail(() => alert("Failed to save preferences."));
    });
  });
  