using DebugInformation;

FormatVariableFirst("Spuha", "");

static void FormatVariableFirst(string input, string name)
{

    var re = DebugInf.FormatVariables(input, name);

    Console.WriteLine(re);
}