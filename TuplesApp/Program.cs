using System.Text.Json;
using TuplesApp;

Console.WriteLine("Tuple of values");
var tuple = (1, 100.00m, "test");
Console.WriteLine(tuple.Item1);
Console.WriteLine(tuple.Item2);
Console.WriteLine(tuple.Item3);

Console.WriteLine("Tuple of object values");
var car = new Car { Company = "Ford", Model = "Explorer", Year = 2020 };
var carTuple = (car.Company, car.Model, car.Year);
Console.WriteLine(carTuple.Company);
Console.WriteLine(carTuple.Model);
Console.WriteLine(carTuple.Year);


var carTupleAsJson = JsonSerializer.Serialize(carTuple, options: new JsonSerializerOptions { IncludeFields = true });
Console.WriteLine("Tuple as json: {0}", carTupleAsJson);

