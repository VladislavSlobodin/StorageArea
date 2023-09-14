using StorageArea.Models;

namespace StorageArea;

public enum AccessLevel
{
    User,
    Admin
}

public partial class RegistrationForm : Form
{
    private static readonly int MIN_LENGTH = 5;
    private LoginForm _loginForm = null!;
    public RegistrationForm()
    {
        InitializeComponent();
    }

    public RegistrationForm(LoginForm loginForm)
    {
        InitializeComponent();
        _loginForm = loginForm;
    }

    private void RegistrationForm_FormClosed(object sender, FormClosedEventArgs e) => _loginForm?.Show();

    private void SignUpButton_Click(object sender, EventArgs e)
    {
        if (!TryParse(out var login, out var password))
        {
            return;
        }

        if (!TryRegister(login, password))
        {
            return;
        }

        MessageBox.Show("Аккаунт успешно зарегистрирован!", "Успех");
        Close();
    }

    private bool TryParse(out string login, out string password)
    {
        login = LoginTextBox.Text.Trim();
        password = PasswordTextBox.Text.Trim();
        var confirm = ConfirmTextBox.Text.Trim();
        if (login.Length < MIN_LENGTH || password.Length < MIN_LENGTH)
        {
            ShowError($"Логин и пароль должны иметь длину не менее {MIN_LENGTH} символов");
            return false;
        }

        if (password != confirm)
        {
            ShowError("Пароли не совпадают");
            return false;
        }

        return true;
    }

    private bool TryRegister(string login, string password)
    {
        using StorageAreaContext context = new();
        if (context.Users.Any(u => u.Login == login))
        {
            ShowError("User with this login already exists.");
            return false;
        }

        var role = context.UserRoles.First(r => r.AccessLevel == (int)AccessLevel.User)!;
        User user = new() { Login = login, HashedPassword = password.Hash(), Role = role };
        context.Users.Add(user);
        context.SaveChanges();
        return true;
    }

    private void ShowError(string message) => MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
}
