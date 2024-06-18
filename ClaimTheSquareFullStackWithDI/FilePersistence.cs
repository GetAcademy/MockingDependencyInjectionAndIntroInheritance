/*
app.MapGet("/textobject", () =>
   {
   var json = File.ReadAllText("textobjects.json");
   var textobjects = JsonSerializer.Deserialize<List<TextObject>>(json);
   return textobjects;
   });
   app.MapPost("/textobject", (TextObject textobject) =>
   {
   var json = File.ReadAllText("textobjects.json");
   var textobjects = JsonSerializer.Deserialize<List<TextObject>>(json);
   textobjects.Add(textobject);
   json = JsonSerializer.Serialize(textobjects);
   File.WriteAllText("textobjects.json", json);
   });
*/