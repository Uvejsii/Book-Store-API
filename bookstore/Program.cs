using bookstore.DatabaseContext;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<BooksContext>();
var app = builder.Build();


app.MapGet("/", () => "Hello World!");


app.MapGet("/books", async (BooksContext context) => { 
   return await context.Books.ToListAsync(); 
});


app.MapGet("/book/{id}", async (BooksContext context, int id) => {
   return await context.Books.FindAsync(id) is Book book ?
            Results.Ok(book) :
            Results.NotFound("Sorry, book not found.");
});

app.MapGet("/searchBook/{bookName}", async (BooksContext context, string bookName) => {
    var books = await context.Books.Where(book => book.Name == bookName).ToListAsync();
    return books.Any() ? Results.Ok(books) : Results.NotFound("Sorry, book not found.");
});


app.MapGet("/searchAuthor/{bookAuthor}", async (BooksContext context ,string bookAuthor) => {
    var book = await context.Books.Where(book => book.Author == bookAuthor).ToListAsync();
    return book.Any() ? Results.Ok(book) : Results.NotFound("Sorry, book not found");
});


app.MapGet("/searchPages/{bookPages}", async (BooksContext context, int bookPages) => {
    var book = await context.Books.Where(book => book.Pages == bookPages).ToListAsync();
    return book.Any() ? Results.Ok(book) : Results.NotFound("Sorry, book not found");
});


app.MapGet("/searchPrice/{bookPrice}", async (BooksContext context, int bookPrice) => {
    var book = await context.Books.Where(book => book.Price == bookPrice).ToListAsync();
    return book.Any() ? Results.Ok(book) : Results.NotFound("Sorry, book not found");
} );


app.MapPost("/book", async (BooksContext context, Book book) => {
    context.Books.Add(book);
    await context.SaveChangesAsync();
    return Results.Ok(await context.Books.ToListAsync());
});


app.MapPut("book/{id}", async (BooksContext context, Book updatedBook, int id) => {
    var book = await context.Books.FindAsync(id);
    if (book is null)
    {
        return Results.NotFound("Sorry, this book doesnt exist.");
    }

    book.Name = updatedBook.Name;
    book.Author = updatedBook.Author;
    book.Pages = updatedBook.Pages;
    book.Price = updatedBook.Price;
    await context.SaveChangesAsync();

    return Results.Ok(await context.Books.ToListAsync());
});


app.MapDelete("/book/{id}", async (BooksContext context, int id) => {
    var book = await context.Books.FindAsync(id);
    if (book is null)
    {
        return Results.NotFound("Sorry, this book doesnt exist");
    } 

    context.Books.Remove(book);
    await context.SaveChangesAsync();

    return Results.Ok(await context.Books.ToListAsync());
});


app.Run();