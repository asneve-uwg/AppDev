using System.Text;
using AbigailSneve_A6.Model;
using Newtonsoft.Json;
using static System.IO.Path;


namespace AbigailSneve_A6.View;

public partial class MainForm : Form
{
    /// <summary>
    /// store a list of books on the main form
    /// </summary>
    private List<Book>? _books = [];

    public MainForm()
    {
        InitializeComponent();
        UpdateBookCount();
    }

    private void UpdateBookCount()
    {
        bookCountLbl.Text = $@"Total Books: {_books?.Count ?? 0}";
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ChooseFileBtn_Click(object sender, EventArgs e)
    {
        var openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = @"JSON files (*.json)|*.json|CSV files (*.csv)|*.csv|All files (*.*)|*.*";

        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {

            var filePath = openFileDialog.FileName;
            var fileContent = File.ReadAllText(filePath);

            if (GetExtension(filePath).ToLower() == ".json")

            {
                _books = JsonConvert.DeserializeObject<List<Book>>(fileContent);



            }
            else if (GetExtension(filePath).ToLower() == ".csv")
            {
                _books = [];
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    var parts = line.Split(',');
                    if (parts.Length == 6)
                    {
                        _books.Add(new Book(
                            parts[0],
                            parts[1],
                            int.Parse(parts[2]),
                            parts[3],
                            int.Parse(parts[4]),
                            double.Parse(parts[5])
                        ));
                    }
                }
            }

            MessageBox.Show(@"File loaded successfully");

        }

        UpdateBookCount();
    }

    private void exportCsvBtn_Click(object sender, EventArgs e)
    {
        var saveFileDialog = new SaveFileDialog();
        saveFileDialog.Filter = @"CSV files (*csv)|*.csv";
        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            if (_books != null)
            {
                var lines = _books.Select(book => $"{book.Title}, {book.Author},{book.Pages}, {book.Genre}, {book.YearPublished}, {book.Msrp}").ToList();

                File.WriteAllLines(saveFileDialog.FileName, lines, Encoding.UTF8);
            }

            MessageBox.Show(@"CSV file exported successfully");
        }

        UpdateBookCount();
    }

    private void exportJsonBtn_Click(object sender, EventArgs e)
    {
        if (_books is { Count: 0 })
        {
            MessageBox.Show(@"No data to export.");
            return;
        }


        var saveFileDialog = new SaveFileDialog();
        saveFileDialog.Filter = @"JSON files (*.json)|*.json";
        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            var json = JsonConvert.SerializeObject(_books, Formatting.Indented);
            File.WriteAllText(saveFileDialog.FileName, json);
            MessageBox.Show(@"JSON file exported successfully");
        }

        UpdateBookCount();

    }
}