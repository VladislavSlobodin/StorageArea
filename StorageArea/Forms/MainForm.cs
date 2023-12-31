using StorageArea.Forms;
using StorageArea.Models;

namespace StorageArea;

public partial class MainForm : Form
{
    private Form _activeForm = null!;
    private LoginForm _loginForm = null!;
    private User _user = null!;

    public MainForm()
    {
        InitializeComponent();
    }

    public MainForm(LoginForm loginForm, User user)
    {
        InitializeComponent();
        _loginForm = loginForm;
        _user = user;
    }

    private void MainForm_FormClosed(object sender, FormClosedEventArgs e) => _loginForm.Show();

    private void ItemsButton_Click(object sender, EventArgs e) => OpenForm(new ItemsForm(_user.Role.AccessLevel == (int)AccessLevel.Admin));

    private void ContainersButton_Click(object sender, EventArgs e) => OpenForm(new ContainersForm(_user.Role.AccessLevel == (int)AccessLevel.Admin));

    private void ItemTypesButton_Click(object sender, EventArgs e) => OpenForm(new ItemTypesForm(_user.Role.AccessLevel == (int)AccessLevel.Admin));

    private void OpenForm(Form form)
    {
        CloseActiveForm();
        _activeForm = form;
        LogoLabel.Text = form.Text;
        form.TopLevel = false;
        form.FormBorderStyle = FormBorderStyle.None;
        form.Dock = DockStyle.Fill;
        FormPanel.Controls.Add(form);
        form.BringToFront();
        form.Show();
    }

    private void CloseActiveForm()
    {
        _activeForm?.Close();
        LogoLabel.Text = string.Empty;
    }

    private void panel4_DoubleClick(object sender, EventArgs e) => CloseActiveForm();

    private void MainForm_Load(object sender, EventArgs e) => GreetingsLabel.Text = $"Здравствуй, {_user.Login}!";
}