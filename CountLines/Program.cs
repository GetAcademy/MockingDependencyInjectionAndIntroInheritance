using CountLines;
using CountLines.Source;


//var source = new FileLineSource("file.txt");
//var source = new KeyboardLineSource();
//var source = new WebLineSource("https://www.vg.no");
var source = new MockLineSource();

var lineCountService = new LineCountService(source);
var stats = lineCountService.GetCounts("e");
stats.Show();

