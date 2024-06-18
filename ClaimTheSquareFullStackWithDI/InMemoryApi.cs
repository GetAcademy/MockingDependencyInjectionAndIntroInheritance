/*
 
   using System.Text.Json;
   using ClaimTheSquareFullStack.Model;
   
   var builder = WebApplication.CreateBuilder(args);
   var app = builder.Build();
   app.UseHttpsRedirection();
   var textobjects = new List<TextObject>()
   {
   new TextObject{ Index = 5, Text ="A", BackColor = "blue", ForeColor = "white"},
   new TextObject{ Index = 6, Text ="B", BackColor = "white", ForeColor = "blue"},
   };
   
   app.MapGet("/textobject", () =>
   {
   return textobjects;
   });
   app.MapPost("/textobject", (TextObject textobject) =>
   {
   textobjects.Add(textobject);
   });
   app.UseStaticFiles();
   app.Run();
 */ 
 