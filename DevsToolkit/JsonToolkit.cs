using System.Text.Json.Nodes;
using NUnit.Framework;

namespace DevsToolkit;

public class JsonToolkit
{
    [Test]
    public void DistinctRowsFromJsonFile()
    {
        string jsonFilePath = "C:\\Work\\adform-logs-live\\Adform.Logs.Live\\bin\\Debug\\AllLogs_NoUrlOverride.txt";
        string distinctByColumn= "Url";

        string jsonFile = File.ReadAllText(jsonFilePath);
        var jArray = JsonNode.Parse(jsonFile)?.AsArray();
        var distincts = jArray?.Select(j=>j[distinctByColumn].ToString()).Distinct().ToList();
        
        distincts?.ForEach(d=>Console.WriteLine(d));
    }
}