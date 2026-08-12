using Newtonsoft.Json;
using Serilog;

namespace subtask_3;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();

        string logDir = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "Subtask 3", "logs");

        Log.Logger = new LoggerConfiguration()
            .WriteTo.File(Path.Combine(logDir, "app.log"), rollingInterval: RollingInterval.Day)
            .CreateLogger();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        var data = new { Name = "Task 1.3", Version = "1.0" };
        string json = JsonConvert.SerializeObject(data, Formatting.Indented);
        MessageBox.Show(json, "meow");

        Log.Information("Button clicked at {Time}", DateTime.Now);

    }
}