using ClaimTheSquareFullStack.Model;
using ClaimTheSquareFullStackWithDI.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
var connStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MyTextObjects;Integrated Security=True";
builder.Services.AddSingleton(new SqlConnectionFactory(connStr));
builder.Services.AddScoped<ITextObjectRespository, InMemoryTextObjectRepository>();

var app = builder.Build();
app.UseHttpsRedirection();

app.MapGet("/textobject", async (ITextObjectRespository repo) =>
{
    return await repo.ReadAll();
});
app.MapPost("/textobject", async (ITextObjectRespository repo, TextObject textobject) =>
{
    return await repo.Create(textobject);
});
app.UseStaticFiles();
app.Run();
