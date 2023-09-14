using StorageArea.Models;

namespace StorageArea.Forms;

public partial class ContainersForm : Form
{
    private static readonly int MIN_LENGTH = 5;
    private static readonly string INVALID_NAME = $"Минимально необходимая длина названия - {MIN_LENGTH} символов";
    private static readonly string INVALID_VOLUME = "Объем должен быть положительным рациональным числом";
    private static readonly string ALREADY_EXISTS = "Тип уже существует";
    private static readonly string CONTAINER_NOT_SELECTED = "Не выбран контейнер для удаления";
    public ContainersForm()
    {
        InitializeComponent();
    }

    public ContainersForm(bool isAdmin)
    {
        InitializeComponent();
        if (!isAdmin)
        {
            AddButton.Hide();
            DeleteButton.Hide();
            EditButton.Hide();
        }
    }

    private void HidePanels()
    {
        foreach (Panel panel in MainPanel.Controls)
        {
            panel.Hide();
        }
    }

    private void ShowPanel(Panel panel)
    {
        HidePanels();
        panel.Show();
    }

    private void AddButton_Click(object sender, EventArgs e) => ShowPanel(AddPanel);


    private void DeleteButton_Click(object sender, EventArgs e)
    {
        DeleteComboBox.Items.Clear();
        using StorageAreaContext context = new();
        DeleteComboBox.Items.AddRange(context.Containers.Select(c => c.Name).ToArray());
        ShowPanel(DeletePanel);
    }

    private void ViewButton_Click(object sender, EventArgs e)
    {
        ViewComboBox.Items.Clear();
        using StorageAreaContext context = new();
        ViewComboBox.Items.AddRange(context.Containers.Select(c => $"{c.Name} | {c.MaxVolume - c.Items.Sum(i => i.Volume * i.Count)} м^3 | {c.Items.Sum(i => i.Volume * i.Count)} м^3 | {c.MaxVolume} м^3").ToArray());
        ShowPanel(ViewPanel);
    }

    private void EditButton_Click(object sender, EventArgs e)
    {
        EditComboBox.Items.Clear();
        using StorageAreaContext context = new();
        EditComboBox.Items.AddRange(context.Containers.Select(c => c.Name).ToArray());
        ShowPanel(EditPanel);
    }

    private void AddContainerButton_Click(object sender, EventArgs e)
    {
        var name = NameTextBox.Text.Trim();
        if (name.Length < MIN_LENGTH)
        {
            ErrorBox.Show(INVALID_NAME);
            return;
        }

        if (!double.TryParse(VolumeTextBox.Text.Trim(), out var volume) || volume <= 0)
        {
            ErrorBox.Show(INVALID_VOLUME);
            return;
        }

        using StorageAreaContext context = new();
        if (context.Containers.Any(c => c.Name == name))
        {
            ErrorBox.Show(ALREADY_EXISTS);
            return;
        }

        context.Containers.Add(new() { Name = name, MaxVolume = volume });
        context.SaveChanges();
        HidePanels();
    }

    private void DeleteContainerButton_Click(object sender, EventArgs e)
    {
        if (DeleteComboBox.SelectedIndex == -1)
        {
            ErrorBox.Show(CONTAINER_NOT_SELECTED);
            return;
        }

        using StorageAreaContext context = new();
        var container = context.Containers.FirstOrDefault(c => c.Name == DeleteComboBox.SelectedItem as string);
        if (container is null)
        {
            return;
        }

        context.Containers.Remove(container);
        context.SaveChanges();
        HidePanels();
    }

    private void CloseViewButton_Click(object sender, EventArgs e) => HidePanels();

    private void EditItemTypeButton_Click(object sender, EventArgs e)
    {
        var name = EditComboBox.SelectedItem as string;
        var newName = NewNameTextBox.Text.Trim();
        using StorageAreaContext context = new();
        var container = context.Containers.FirstOrDefault(c => c.Name == name);
        var newContainer = context.Containers.FirstOrDefault(c => c.Name == newName);
        if (container is null || newContainer is not null)
        {
            return;
        }

        container.Name = newName;
        context.SaveChanges();
        HidePanels();
    }
}
