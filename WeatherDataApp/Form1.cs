using System.Windows.Forms;
using System.Xml.Linq;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace WeatherDataApp
{
    struct WeatherData
    {
        public DateTime date;
        public double precipitation, highTemp, lowTemp;
    };
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<WeatherData> weatherDataList = new List<WeatherData>();
 

        private void ReadFile()
        {
            try
            {
                StreamReader inputFile; // To read the file
                string line;            // To hold a line from the file

                // Create an instance of the WeatherData structure.
                WeatherData data = new WeatherData();

                // Create a delimiter array.
                char[] delim = { ',' };

                // Open the PhoneList file.
                inputFile = File.OpenText("WeatherData.txt");

                // Read the lines from the file.
                while (!inputFile.EndOfStream)
                {
                    // Read a line from the file.
                    line = inputFile.ReadLine();

                    

                    // Tokenize the line
                    string[] tokens = line.Split(delim);

                    ConvertAndStoreData(tokens);
                }
                inputFile.Close();
            }
            catch (Exception ex)
            {
                // Display an error message.
                MessageBox.Show(ex.Message);
            }
        }

        private bool ConvertAndStoreData(string[] tokens)
        {
            // Ensure we have exactly 4 tokens.
            if (tokens.Length != 4)
                return false;

            // Create a WeatherData instance.
            var wdata = new WeatherData();

            // Validate and assign the tokens.
            if (!DateTime.TryParse(tokens[0], out wdata.date) ||
                !double.TryParse(tokens[1], out wdata.precipitation) ||
                !double.TryParse(tokens[2], out wdata.highTemp) ||
                !double.TryParse(tokens[3], out wdata.lowTemp))
            {
                MessageBox.Show("Incorrect Data in weather list");
                return false;
            }

            // Store the valid data.
            weatherDataList.Add(wdata);

            return true;
        }

        private void dateInput_ValueChanged(object sender, EventArgs e)
        {
            int index = 0;        // Index to step through the list
            bool found = false;   // Flag to signal a found date

            //Get the date selected by the user.
            DateTime selected = dateInput.Value;


            // Search for the date.
            while (index < weatherDataList.Count && !found)
            {
                if (weatherDataList[index].date == selected.Date)
                    found = true;
                else
                    index++;
            }

            // If the date was found, display the data.
            if (found)
            {
                dateBox.Text = weatherDataList[index].date.ToShortDateString();
                precipitationBox.Text = weatherDataList[index].precipitation.ToString();
                highTempBox.Text = weatherDataList[index].highTemp.ToString();
                lowTempBox.Text = weatherDataList[index].lowTemp.ToString();
            }
            else
            {
                MessageBox.Show("No data found for the selected date.");
                dateBox.Text = "";
                precipitationBox.Text = "";
                highTempBox.Text = "";
                lowTempBox.Text = "";
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            ReadFile();
        }
    }
}