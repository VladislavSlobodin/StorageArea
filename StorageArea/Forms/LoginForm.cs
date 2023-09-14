using Microsoft.EntityFrameworkCore;
using StorageArea.Models;

namespace StorageArea;

public partial class LoginForm : Form
{
    private static readonly int MIN_LENGTH = 5;
    private static readonly string INVALID_LOGIN_OR_PASSWORD_LENGTH = $"Логин и пароль должны иметь длину не меньше {MIN_LENGTH} символов";
    private static readonly string USER_DOES_NOT_EXIST = "Данного пользователя не существует";


    public LoginForm()
    {
        InitializeComponent();
    }

    private void ShowError(string message) => MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

    private void SignInButton_Click(object sender, EventArgs e)
    {
        if (!TryParseInput(out var login, out var password))
        {
            ShowError(INVALID_LOGIN_OR_PASSWORD_LENGTH);
            return;
        }

        if (!TryLogin(login, password, out var user))
        {
            ShowError(USER_DOES_NOT_EXIST);
            return;
        }

        Hide();
        new MainForm(this, user).Show();
    }

    private bool TryParseInput(out string login, out string password)
    {
        login = LoginTextBox.Text.Trim();
        password = PasswordTextBox.Text.Trim();
        return login.Length >= MIN_LENGTH && password.Length >= MIN_LENGTH;
    }

    private bool TryLogin(string login, string password, out User user)
    {
        using StorageAreaContext context = new();
        user = context.Users.Include(nameof(User.Role)).FirstOrDefault(u => u.Login == login && u.HashedPassword == password.Hash())!;
        return user is not null;
    }

    private void SignUpButton_Click(object sender, EventArgs e)
    {
        Hide();
        new RegistrationForm(this).Show();
    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {
    }

    private void PasswordTextBox_TextChanged(object sender, EventArgs e)
    {
    }

    private void LoginTextBox_TextChanged(object sender, EventArgs e)
    {
    }
}
