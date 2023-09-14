using StorageArea.Models;
using System.Data;

namespace StorageArea.Forms;

public partial class ItemTypesForm : Form
{
    private static readonly int MIN_LENGTH = 5;
    private static readonly string INVALID_NAME = $"Минимально необходимая длина названия - {MIN_LENGTH} символов";
    private static readonly string TYPE_NOT_SELECTED = "Не выбран тип для удаления";
    private static readonly string ALREADY_EXISTS = "Тип уже существует";

    public ItemTypesForm()
    {
        InitializeComponent();
    }

    public ItemTypesForm(bool isAdmin)
    {
        InitializeComponent();
        if (!isAdmin)
        {
            AddButton.Hide();
            DeleteButton.Hide();
            EditButton.Hide();
        }
    }

    private void AddButton_Click(object sender, EventArgs e) => ShowPanel(AddPanel);

    private void DeleteButton_Click(object sender, EventArgs e)
    {
        DeleteComboBox.Items.Clear();
        using StorageAreaContext context = new();
        DeleteComboBox.Items.AddRange(context.ItemTypes.Select(it => it.Name).ToArray());
        ShowPanel(DeletePanel);
    }

    private void ViewButton_Click(object sender, EventArgs e)
    {
        ViewComboBox.Items.Clear();
        using StorageAreaContext context = new();
        ViewComboBox.Items.AddRange(context.ItemTypes.Select(it => it.Name).ToArray());
        ShowPanel(ViewPanel);
    }

    private void EditButton_Click(object sender, EventArgs e)
    {
        EditComboBox.Items.Clear();
        using StorageAreaContext context = new();
        EditComboBox.Items.AddRange(context.ItemTypes.Select(it => it.Name).ToArray());
        ShowPanel(EditPanel);
    }

    private void HidePanels()
    {
        foreach (Panel p in MainPanel.Controls)
        {
            p.Hide();
        }
    }

    private void ShowPanel(Panel panel)
    {
        HidePanels();
        panel.Show();
    }

    private void AddItemTypeButton_Click(object sender, EventArgs e)
    {
        var name = NameTextBox.Text.Trim();
        if (name.Length < MIN_LENGTH)
        {
            ErrorBox.Show(INVALID_NAME);
            return;
        }

        using StorageAreaContext context = new();
        if (context.ItemTypes.Any(it => it.Name == name))
        {
            ErrorBox.Show(ALREADY_EXISTS);
            return;
        }

        context.ItemTypes.Add(new() { Name = name });
        context.SaveChanges();
        HidePanels();
    }

    private void DeleteItemTypeButton_Click(object sender, EventArgs e)
    {
        if (DeleteComboBox.SelectedIndex == -1)
        {
            ErrorBox.Show(TYPE_NOT_SELECTED);
            return;
        }

        using StorageAreaContext context = new();
        var itemType = context.ItemTypes.FirstOrDefault(it => it.Name == DeleteComboBox.SelectedItem as string);
        if (itemType is null)
        {
            return;
        }

        context.ItemTypes.Remove(itemType);
        context.SaveChanges();
        HidePanels();
    }

    private void CloseViewButton_Click(object sender, EventArgs e) => HidePanels();

    private void EditItemTypeButton_Click(object sender, EventArgs e)
    {
        var name = EditComboBox.SelectedItem as string;
        var newName = NewNameTextBox.Text.Trim();
        using StorageAreaContext context = new();
        var itemType = context.ItemTypes.FirstOrDefault(it => it.Name == name);
        var newItemType = context.ItemTypes.FirstOrDefault(it => it.Name == newName);
        if (itemType is null || newItemType is not null)
        {
            return;
        }

        itemType.Name = newName;
        context.SaveChanges();
        HidePanels();
    }
}
