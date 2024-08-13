using ConsoleUI;
using System.Globalization;
using System.Text.Json;

string FilePath = "C:\\CTS Projects\\ConsoleUI\\RawData.txt";
List<string> Lines = File.ReadAllLines(FilePath).ToList();
List<Employee> Employees = new List<Employee>();

foreach (string line in  Lines)
{
    if (line == Lines[0]) continue;
    else
    {
        string[] input = line.Split('\t');
        Employee _employee = new Employee();
        _employee.EmpId = input[0];
        _employee.Mode = input[1];
        _employee.In0rOut = input[2];
        _employee.Antipass = (input[3]=="1");
        _employee.ProxyWork = (input[4]=="1");
        //_employee.DateTime = Convert.ToDateTime(input[5]);
        _employee.DateTime = DateTime.ParseExact(input[5], "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
        Employees.Add(_employee);
    }
}

foreach (Employee employee in Employees)
{
    Console.WriteLine($"EnNo:{employee.EmpId}   " +
        $"Mode:{employee.Mode}    " +
        $"In/Out:{employee.In0rOut}   " +
        $"Antipass:{employee.Antipass} " +
        $"ProxyWork:{employee.ProxyWork} " +
        $"DateTime:{employee.DateTime.ToString("yyyy-MM-dd HH:mm:ss")}");

    var option = new JsonSerializerOptions();
    option.WriteIndented = true;
    Console.WriteLine(JsonSerializer.Serialize(employee,option)+'\n');
}
Console.ReadKey();