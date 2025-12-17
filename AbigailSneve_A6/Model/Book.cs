namespace AbigailSneve_A6.Model;

public class Book
{
    /// <summary>
    /// Title of the book property gets or sets the title of the book.
    /// </summary>
    public string? Title { get; set; }
    /// <summary>
    /// Author of the book property gets or sets the author of the book.
    /// </summary>
    public string? Author { get; set; }
    /// <summary>
    /// Number of Pages of the book property gets or sets the number of pages in the book.
    /// </summary>
    public int Pages { get; set; }
    /// <summary>
    /// Genre of the book property gets or sets the genre of the book.
    /// </summary>
    public string? Genre { get; set; }

    /// <summary>
    /// Year Published of the book property Gets or sets the year the book was published.
    /// </summary>
    public int YearPublished { get; set; }
    /// <summary>
    /// Gets or sets the manufacturer's suggested retail price (MSRP) of the product.
    /// </summary>
    public double Msrp { get; set; }

    /// <summary>
    ///
    /// default constructor for the Book class.
    /// </summary>
    public Book() { }

    /// <summary>
    /// constructor for the Book class that initializes all properties.
    /// </summary>
    /// <param name="title"></param>
    /// <param name="author"></param>
    /// <param name="pages"></param>
    /// <param name="genre"></param>
    /// <param name="yearPublished"></param>
    /// <param name="msrp"></param>
    /// <exception cref="ArgumentException"></exception>
    public Book(string title, string author, int pages, string genre, int yearPublished, double msrp)
    {
        if (string.IsNullOrWhiteSpace(title))
            throw new ArgumentException(@"Title cannot be null or empty.", nameof(title));
        if (string.IsNullOrWhiteSpace(author))
            throw new ArgumentException(@"Author cannot be null or empty.", nameof(author));

        Title = title;
        Author = author;
        Pages = pages;
        Genre = genre;
        YearPublished = yearPublished;
        Msrp = msrp;
    }


}