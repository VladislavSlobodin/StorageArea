using Microsoft.EntityFrameworkCore;
using StorageArea.Models;

namespace StorageArea.Forms;

public partial class ItemsForm : Form
{
    private static readonly int MIN_LENGTH = 5;
    private static readonly string INVALID_DATA = "Введены некорректные данные";
    private static readonly string ITEM_ALREADY_EXISTS = "Предмет уже существует";

    public ItemsForm()
    {
        InitializeComponent();
    }

    public ItemsForm(bool isAdmin)
    {
        InitializeComponent();
        InitializeComboBoxes();
        if (!isAdmin)
        {
            Hide<Button>();
            ViewButton.Show();
        }
    }

    private static List<string> GetProperties<T>() where T : class =>
        typeof(T)
        .GetProperties()
        .Where(p => p.PropertyType.IsPrimitive || p.PropertyType == typeof(string))
        .Where(p => p.Name != "Id")
        .Select(p => p.Name)
        .Select(x => x.EndsWith("Id") ? x[..(x.Length - 2)] : x)
        .ToList();

    private void InitializeComboBoxes()
    {
        ContainerComboBox.ValueMember = nameof(Models.Container.Id);
        ContainerComboBox.DisplayMember = nameof(Models.Container.Name);
        TypeComboBox.ValueMember = nameof(ItemType.Id);
        TypeComboBox.DisplayMember = nameof(ItemType.Name);
    }

    private void Hide<T>() where T : Control
    {
        foreach (Control control in panel1.Controls)
        {
            if (control is T t)
            {
                t.Hide();
            }
        }

        dataGridView1.Hide();
    }

    private void ShowPanel(Panel panel)
    {
        Hide<Panel>();
        panel.Show();
    }

    private void AddButton_Click(object sender, EventArgs e)
    {
        using StorageAreaContext context = new();
        ContainerComboBox.Items.Clear();
        ContainerComboBox.Items.AddRange(context.Containers.Where(c => c.MaxVolume - c.Items.Sum(i => i.Volume * i.Count) > 0).ToArray());
        TypeComboBox.Items.Clear();
        TypeComboBox.Items.AddRange(context.ItemTypes.ToArray());
        ShowPanel(AddPanel);
    }

    private void DeleteButton_Click(object sender, EventArgs e)
    {
        using StorageAreaContext context = new();
        DeleteComboBox.Items.Clear();
        DeleteComboBox.Items.AddRange(context.Items.Select(i => i.Name).ToArray());
        ShowPanel(DeletePanel);
    }

    private void ViewButton_Click(object sender, EventArgs e)
    {
        dataGridView1.Columns.Clear();
        GetProperties<Item>().ForEach(x => dataGridView1.Columns.Add(x, x));
        using StorageAreaContext context = new();
        ShowPanel(ViewPanel);
        dataGridView1.Show();
        context
            .Items
            .Include(nameof(Item.Container))
            .Include(nameof(Item.Type))
            .ToList()
            .ForEach(i => dataGridView1.Rows.Add(i.Name, i.Count, i.Container.Name, i.Type.Name, i.Volume, i.Weight));
    }

    private void EditButton_Click(object sender, EventArgs e)
    {
        using StorageAreaContext context = new();
        EditComboBox.Items.Clear();
        EditComboBox.Items.AddRange(context.Items.Select(i => i.Name).ToArray());
        ShowPanel(EditPanel);
    }

    private void AddContainerButton_Click(object sender, EventArgs e)
    {
        if (!TryParseInput(out var item))
        {
            ErrorBox.Show(INVALID_DATA);
            return;
        }

        using StorageAreaContext context = new();
        if (context.Items.Any(i => i.Name == item.Name))
        {
            ErrorBox.Show(ITEM_ALREADY_EXISTS);
            return;
        }

        context.Items.Add(item);
        context.SaveChanges();
        Hide<Panel>();
    }

    private bool TryParseInput(out Item item)
    {
        var name = NameTextBox.Text.Trim();
        if (name.Length < MIN_LENGTH ||
            !int.TryParse(CountTextBox.Text.Trim(), out var count) ||
            !double.TryParse(VolumeTextBox.Text.Trim(), out var volume) ||
            !double.TryParse(WeightTextBox.Text.Trim(), out var weight) ||
            ContainerComboBox.SelectedIndex == -1 ||
            TypeComboBox.SelectedIndex == -1)
        {
            item = default!;
            return false;
        }

        item = new()
        {
            Name = name,
            Count = count,
            ContainerId = (ContainerComboBox.SelectedItem as Container)!.Id,
            TypeId = (TypeComboBox.SelectedItem as ItemType)!.Id,
            Volume = volume,
            Weight = weight
        };

        return true;
    }

    private void DeleteItemButton_Click(object sender, EventArgs e)
    {
        if (DeleteComboBox.SelectedIndex == -1)
        {
            return;
        }

        var name = DeleteComboBox.SelectedItem as string;
        using StorageAreaContext context = new();
        var item = context.Items.FirstOrDefault(i => i.Name == name);
        if (item is null)
        {
            return;
        }

        context.Items.Remove(item);
        context.SaveChanges();
        Hide<Panel>();
    }

    private void CloseViewButton_Click(object sender, EventArgs e)
    {
        dataGridView1.Hide();
        Hide<Panel>();
    }

    private void EditItemTypeButton_Click(object sender, EventArgs e)
    {
        if (EditComboBox.SelectedIndex == -1)
        {
            return;
        }

        var name = EditComboBox.SelectedItem as string;
        var newName = NewNameTextBox.Text.Trim();
        using StorageAreaContext context = new();
        var item = context.Items.FirstOrDefault(i => i.Name == name);
        var newNameItem = context.Items.FirstOrDefault(i => i.Name == newName);
        if (item is null || newNameItem is not null)
        {
            return;
        }

        item.Name = newName;
        context.SaveChanges();
        Hide<Panel>();
    }
}
