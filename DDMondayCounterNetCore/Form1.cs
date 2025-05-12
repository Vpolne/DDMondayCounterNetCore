using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;
using System.ComponentModel.Design;
using static DDMondaysWinnerCount.Form1;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Runtime.Intrinsics.Arm;
using static System.Net.WebRequestMethods;

namespace DDMondaysWinnerCount
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LogText("^ Open json file with race results\n\r", LogTextBox);
        }
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class CarClass
        {
            public int car_class_id { get; set; }
            public string short_name { get; set; }
            public string name { get; set; }
            public int strength_of_field { get; set; }
            public int num_entries { get; set; }
            public List<CarsInClass> cars_in_class { get; set; }
        }

        public class CarsInClass
        {
            public int car_id { get; set; }
        }

        public class Data
        {
            public int subsession_id { get; set; }
            public List<int> associated_subsession_ids { get; set; }
            public bool can_protest { get; set; }
            public List<CarClass> car_classes { get; set; }
            public int caution_type { get; set; }
            public int cooldown_minutes { get; set; }
            public int corners_per_lap { get; set; }
            public int damage_model { get; set; }
            public int driver_change_param1 { get; set; }
            public int driver_change_param2 { get; set; }
            public int driver_change_rule { get; set; }
            public bool driver_changes { get; set; }
            public DriverLicenses driver_licenses { get; set; }
            public DateTime end_time { get; set; }
            public int event_average_lap { get; set; }
            public int event_best_lap_time { get; set; }
            public int event_laps_complete { get; set; }
            public int event_strength_of_field { get; set; }
            public int event_type { get; set; }
            public string event_type_name { get; set; }
            public int heat_info_id { get; set; }
            public int host_id { get; set; }
            public int league_id { get; set; }
            public int league_season_id { get; set; }
            public string license_category { get; set; }
            public int license_category_id { get; set; }
            public int limit_minutes { get; set; }
            public int max_team_drivers { get; set; }
            public int max_weeks { get; set; }
            public int min_team_drivers { get; set; }
            public int num_caution_laps { get; set; }
            public int num_cautions { get; set; }
            public int num_drivers { get; set; }
            public int num_laps_for_qual_average { get; set; }
            public int num_laps_for_solo_average { get; set; }
            public int num_lead_changes { get; set; }
            public bool official_session { get; set; }
            public string points_type { get; set; }
            public int private_session_id { get; set; }
            public RaceSummary race_summary { get; set; }
            public int race_week_num { get; set; }
            public bool restrict_results { get; set; }
            public bool results_restricted { get; set; }
            public int season_id { get; set; }
            public string season_name { get; set; }
            public int season_quarter { get; set; }
            public string season_short_name { get; set; }
            public int season_year { get; set; }
            public int series_id { get; set; }
            public string series_name { get; set; }
            public string series_short_name { get; set; }
            public int session_id { get; set; }
            public string session_name { get; set; }
            public List<SessionResult> session_results { get; set; }
            public List<SessionSplit> session_splits { get; set; }
            public int special_event_type { get; set; }
            public DateTime start_time { get; set; }
            public Track track { get; set; }
            public TrackState track_state { get; set; }
            public Weather weather { get; set; }
        }

        public class DriverLicenses
        {
            public string name { get; set; }
        }

        public class Helmet
        {
            public int pattern { get; set; }
            public string color1 { get; set; }
            public string color2 { get; set; }
            public string color3 { get; set; }
            public int face_type { get; set; }
            public int helmet_type { get; set; }
        }

        public class Livery
        {
            public int car_id { get; set; }
            public int pattern { get; set; }
            public string color1 { get; set; }
            public string color2 { get; set; }
            public string color3 { get; set; }
            public int number_font { get; set; }
            public string number_color1 { get; set; }
            public string number_color2 { get; set; }
            public string number_color3 { get; set; }
            public int number_slant { get; set; }
            public int sponsor1 { get; set; }
            public int sponsor2 { get; set; }
            public string car_number { get; set; }
            public string wheel_color { get; set; }
            public int rim_type { get; set; }
        }

        public class RaceSummary
        {
            public int subsession_id { get; set; }
            public int average_lap { get; set; }
            public int laps_complete { get; set; }
            public int num_cautions { get; set; }
            public int num_caution_laps { get; set; }
            public int num_lead_changes { get; set; }
            public int field_strength { get; set; }
            public int heat_info_id { get; set; }
            public int num_opt_laps { get; set; }
            public bool has_opt_path { get; set; }
            public int special_event_type { get; set; }
            public string special_event_type_text { get; set; }
        }

        public class Result
        {
            public int cust_id { get; set; }
            public string display_name { get; set; }
            public int aggregate_champ_points { get; set; }
            public bool ai { get; set; }
            public int average_lap { get; set; }
            public int best_lap_num { get; set; }
            public int best_lap_time { get; set; }
            public int best_nlaps_num { get; set; }
            public int best_nlaps_time { get; set; }
            public DateTime best_qual_lap_at { get; set; }
            public int best_qual_lap_num { get; set; }
            public int best_qual_lap_time { get; set; }
            public int car_class_id { get; set; }
            public string car_class_name { get; set; }
            public string car_class_short_name { get; set; }
            public int car_id { get; set; }
            public string car_name { get; set; }
            public int champ_points { get; set; }
            public int class_interval { get; set; }
            public int club_id { get; set; }
            public string club_name { get; set; }
            public int club_points { get; set; }
            public string club_shortname { get; set; }
            public string country_code { get; set; }
            public int division { get; set; }
            public bool drop_race { get; set; }
            public int finish_position { get; set; }
            public int finish_position_in_class { get; set; }
            public bool friend { get; set; }
            public Helmet helmet { get; set; }
            public int incidents { get; set; }
            public int interval { get; set; }
            public int laps_complete { get; set; }
            public int laps_lead { get; set; }
            public int league_agg_points { get; set; }
            public int league_points { get; set; }
            public int license_change_oval { get; set; }
            public int license_change_road { get; set; }
            public Livery livery { get; set; }
            public int max_pct_fuel_fill { get; set; }
            public int multiplier { get; set; }
            public double new_cpi { get; set; }
            public int new_license_level { get; set; }
            public int new_sub_level { get; set; }
            public int new_ttrating { get; set; }
            public int newi_rating { get; set; }
            public double old_cpi { get; set; }
            public int old_license_level { get; set; }
            public int old_sub_level { get; set; }
            public int old_ttrating { get; set; }
            public int oldi_rating { get; set; }
            public int opt_laps_complete { get; set; }
            public int position { get; set; }
            public int qual_lap_time { get; set; }
            public string reason_out { get; set; }
            public int reason_out_id { get; set; }
            public int starting_position { get; set; }
            public int starting_position_in_class { get; set; }
            public Suit suit { get; set; }
            public bool watched { get; set; }
            public int weight_penalty_kg { get; set; }
        }

        public class Root
        {
            public string type { get; set; }
            public Data data { get; set; }
        }
        public class RootOldJson
        {
            public int subsession_id { get; set; }
            public List<int> associated_subsession_ids { get; set; }
            public bool can_protest { get; set; }
            public List<CarClass> car_classes { get; set; }
            public int caution_type { get; set; }
            public int cooldown_minutes { get; set; }
            public int corners_per_lap { get; set; }
            public int damage_model { get; set; }
            public int driver_change_param1 { get; set; }
            public int driver_change_param2 { get; set; }
            public int driver_change_rule { get; set; }
            public bool driver_changes { get; set; }
            public DateTime end_time { get; set; }
            public int event_average_lap { get; set; }
            public int event_best_lap_time { get; set; }
            public int event_laps_complete { get; set; }
            public int event_strength_of_field { get; set; }
            public int event_type { get; set; }
            public string event_type_name { get; set; }
            public int heat_info_id { get; set; }
            public int host_id { get; set; }
            public int league_id { get; set; }
            public int league_season_id { get; set; }
            public string license_category { get; set; }
            public int license_category_id { get; set; }
            public int limit_minutes { get; set; }
            public int max_team_drivers { get; set; }
            public int max_weeks { get; set; }
            public int min_team_drivers { get; set; }
            public int num_caution_laps { get; set; }
            public int num_cautions { get; set; }
            public int num_drivers { get; set; }
            public int num_laps_for_qual_average { get; set; }
            public int num_laps_for_solo_average { get; set; }
            public int num_lead_changes { get; set; }
            public bool official_session { get; set; }
            public string points_type { get; set; }
            public int private_session_id { get; set; }
            public RaceSummary race_summary { get; set; }
            public int race_week_num { get; set; }
            public bool restrict_results { get; set; }
            public bool results_restricted { get; set; }
            public int season_id { get; set; }
            public string season_name { get; set; }
            public int season_quarter { get; set; }
            public string season_short_name { get; set; }
            public int season_year { get; set; }
            public int series_id { get; set; }
            public string series_name { get; set; }
            public string series_short_name { get; set; }
            public int session_id { get; set; }
            public string session_name { get; set; }
            public List<SessionResult> session_results { get; set; }
            public List<SessionSplit> session_splits { get; set; }
            public int special_event_type { get; set; }
            public DateTime start_time { get; set; }
            public Track track { get; set; }
            public TrackState track_state { get; set; }
            public Weather weather { get; set; }
        }

        public class SessionResult
        {
            public int simsession_number { get; set; }
            public string simsession_name { get; set; }
            public int simsession_type { get; set; }
            public string simsession_type_name { get; set; }
            public int simsession_subtype { get; set; }
            public List<Result> results { get; set; }
        }

        public class SessionSplit
        {
            public int subsession_id { get; set; }
            public int event_strength_of_field { get; set; }
        }

        public class Suit
        {
            public int pattern { get; set; }
            public string color1 { get; set; }
            public string color2 { get; set; }
            public string color3 { get; set; }
        }

        public class Track
        {
            public string category { get; set; }
            public int category_id { get; set; }
            public string config_name { get; set; }
            public int track_id { get; set; }
            public string track_name { get; set; }
        }

        public class TrackState
        {
            public bool leave_marbles { get; set; }
            public int practice_grip_compound { get; set; }
            public int practice_rubber { get; set; }
            public int qualify_grip_compound { get; set; }
            public int qualify_rubber { get; set; }
            public int race_grip_compound { get; set; }
            public int race_rubber { get; set; }
            public int warmup_grip_compound { get; set; }
            public int warmup_rubber { get; set; }
        }

        public class Weather
        {
            public bool allow_fog { get; set; }
            public int fog { get; set; }
            public int precip_mm2hr_before_final_session { get; set; }
            public int precip_mm_final_session { get; set; }
            public int precip_option { get; set; }
            public float precip_time_pct { get; set; }
            public float rel_humidity { get; set; }
            public DateTime simulated_start_time { get; set; }
            public int skies { get; set; }
            public int temp_units { get; set; }
            public int temp_value { get; set; }
            public int time_of_day { get; set; }
            public int track_water { get; set; }
            public int type { get; set; }
            public int version { get; set; }
            public int weather_var_initial { get; set; }
            public int weather_var_ongoing { get; set; }
            public int wind_dir { get; set; }
            public int wind_units { get; set; }
            public int wind_value { get; set; }
        }



        public class PilotResults
        {
            public string Name { get; set; }
            public string SessionTypeName { get; set; }
            public int IncCount { get; set; }
            public int Position { get; set; }

            public override string ToString()
            {
                return SessionTypeName + ":" + Name + " " + IncCount + "x " + "pos: " + Position;
            }
        }
        public class PilotSummary
        {
            public string Name { get; set; }
            public int TotalIncidents { get; set; }
            public double AveragePosition { get; set; }

            public override string ToString()
            {
                return $"{Name} - {TotalIncidents}x, AvgPos: {AveragePosition:F2}";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string FilePath = "";
            string jsonString = "";
            List<Result> result = new List<Result>();
            List<PilotResults> pilotResults = new List<PilotResults>();
            List<PilotResults> pilotResultsQualy = new List<PilotResults>();

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Select file with race results";
            openFileDialog1.InitialDirectory = @"D:\Downloads\";
            openFileDialog1.Filter = "All files (*.*)|*.*|Text File (*.txt)|*.txt|Json (*.json)|*.json";
            openFileDialog1.FilterIndex = 1;

            //for testing
            //FilePath = @"D:\Downloads\Rudskogen.json";
            if (FilePath == "")
            {
                openFileDialog1.ShowDialog(this);
                FilePath = openFileDialog1.FileName;
            }

            if (openFileDialog1.FileName != "")
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("FilePath:").Append(FilePath);
                LogText(sb.ToString(), LogTextBox);
            }
            else
            {
                LogText("Didn't open file \n", LogTextBox);
            }

            if (FilePath != "")
            {
                jsonString = System.IO.File.ReadAllText(FilePath);
            }

            if (jsonString != "")
            {
                ParseResultsNewJson (jsonString);
            }
        }
        public void LogText(string text, TextBox LogTextBox)
        {
            LogTextBox.AppendText(text);
            LogTextBox.AppendText(Environment.NewLine);
        }
        private Root DeserialiseJson(string json)
        {
            var root = JsonSerializer.Deserialize<Root>(json);
            return root;
        }
        private RootOldJson DeserialiseOldJson(string json)
        {
            var root = JsonSerializer.Deserialize<RootOldJson>(json);
            return root;
        }

        private void ClearLogButton_Click(object sender, EventArgs e)
        {
            LogTextBox.Clear();
        }

        private void CopyLogButton_Click(object sender, EventArgs e)
        {
            string logText="";
            if (!String.IsNullOrEmpty(LogTextBox.Text)) {
                logText = LogTextBox.Text;
            } else {
                logText = "\n";
            }
            Clipboard.SetText(logText);
        }

        private void LogTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private async void GetResultButton_click(object sender, EventArgs e)
        {
            string SubsessionId = SubsessionIdTextBox.Text;
            string SubsessionResultString = "https://members-ng.iracing.com/data/results/get?subsession_id=" + SubsessionId;


            string username = "";
            string password = "";


            using var sha256 = System.Security.Cryptography.SHA256.Create();

            var passwordAndEmail = password + (username?.ToLowerInvariant());
            var hashedPasswordAndEmailBytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(passwordAndEmail));
            var encodedHash = Convert.ToBase64String(hashedPasswordAndEmailBytes);

            var client =  new WebClientEx(username, encodedHash);

            string data = client.DownloadString(SubsessionResultString);
            using JsonDocument doc = JsonDocument.Parse(data);
            string resultDownloadLink = doc.RootElement.GetProperty("link").GetString();

            using HttpClient httpClient = new HttpClient();
            string json = await httpClient.GetStringAsync(resultDownloadLink);
            ParseResultsOLDJson(json);

        }

        private void ParseResultsNewJson (string jsonString)
        {
            List<Result> result = new List<Result>();
            List<PilotResults> pilotResults = new List<PilotResults>();
            List<PilotResults> pilotResultsQualy = new List<PilotResults>();

            var root = DeserialiseJson(jsonString);
            var sessionName = root.data.session_name;
            if (sessionName != null)
            {
                LogText(root.data.session_name, LogTextBox);
            }
            LogText(root.data.track.track_name, LogTextBox);
            LogText(root.data.track.config_name, LogTextBox);
            LogText(root.data.session_results.First().results.First().car_name, LogTextBox);
            LogText("SessionID: " + root.data.race_summary.subsession_id.ToString(), LogTextBox);
            LogText("", LogTextBox);
            List<SessionResult> sessionResult = root.data.session_results;
            foreach (var item in sessionResult)
            {
                if (item.simsession_name != "HEAT 1" && item.simsession_name != "HEAT 2" && item.simsession_name != "FEATURE"
                    && item.simsession_name != "QUALIFY" && item.simsession_name != "RACE" 
                    && item.simsession_name != "CONSOLATION") { continue; }
                var name = item.simsession_name;
                LogText(item.simsession_name, LogTextBox);
                result = item.results;
                foreach (var pilot in result)
                {
                    PilotResults pilotIterated = new PilotResults();

                    StringBuilder sb = new StringBuilder();
                    sb.Append(pilot.display_name + " ");
                    sb.Append(pilot.incidents.ToString());
                    sb.Append("x");
                    sb.Append(", Pos:");
                    sb.Append(pilot.finish_position + 1);
                    LogText(sb.ToString(), LogTextBox);

                    pilotIterated.Name = pilot.display_name;
                    pilotIterated.IncCount = pilot.incidents;
                    pilotIterated.Position = pilot.finish_position + 1;
                    pilotIterated.SessionTypeName = item.simsession_name;
                    if (item.simsession_name == "QUALIFY")
                    {
                        pilotResultsQualy.Add(pilotIterated);
                    }
                    else
                    {
                        pilotResults.Add(pilotIterated);
                    }

                }
            }

            var pilotResultsSorted = pilotResults
                .GroupBy(x => x.Name)
                .Select(g => new PilotSummary
                {
                    Name = g.Key,
                    TotalIncidents = g.Sum(x => x.IncCount),
                    AveragePosition = g.Average(x => x.Position)
                })
                .ToList();

            pilotResultsSorted = pilotResultsSorted.OrderBy(g => g.AveragePosition).ToList();
            LogText("", LogTextBox);
            LogText("+++ЛУЧШИЙ ГОНЩИК+++", LogTextBox);
            foreach (var item in pilotResultsSorted)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(item.ToString());
                sb.Append(" (Qual: " + pilotResultsQualy.Where(x => x.Name == item.Name && x.SessionTypeName == "QUALIFY")
                    .Select(x => x.Position).FirstOrDefault().ToString());
                sb.Append(",Heat 1: " + pilotResults.Where(x => x.Name == item.Name && x.SessionTypeName == "HEAT 1")
                    .Select(x => x.Position).FirstOrDefault().ToString());
                sb.Append(",Heat 2: " + pilotResults.Where(x => x.Name == item.Name && x.SessionTypeName == "HEAT 2")
                    .Select(x => x.Position).FirstOrDefault().ToString());
                sb.Append(",Consolation: " + pilotResults.Where(x => x.Name == item.Name && x.SessionTypeName == "CONSOLATION")
                    .Select(x => x.Position).FirstOrDefault().ToString());
                sb.Append(",Feature: " + pilotResults.Where(x => x.Name == item.Name && x.SessionTypeName == "FEATURE")
                    .Select(x => x.Position).FirstOrDefault().ToString());
                sb.Append(",Race: " + pilotResults.Where(x => x.Name == item.Name && x.SessionTypeName == "RACE")
                    .Select(x => x.Position).FirstOrDefault().ToString() + ")");
                LogText(sb.ToString(), LogTextBox);
            }

            pilotResultsSorted = pilotResultsSorted.OrderBy(g => g.TotalIncidents).ThenBy(p => p.AveragePosition).ToList();
            LogText("", LogTextBox);
            LogText("+++ЧИСТЫЙ ГОНЩИК+++", LogTextBox);
            foreach (var item in pilotResultsSorted)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(item.ToString());
                sb.Append(" (Heat 1: " + pilotResults.Where(x => x.Name == item.Name && x.SessionTypeName == "HEAT 1")
                    .Select(x => x.Position).FirstOrDefault().ToString());
                sb.Append(",Heat 2: " + pilotResults.Where(x => x.Name == item.Name && x.SessionTypeName == "HEAT 2")
                    .Select(x => x.Position).FirstOrDefault().ToString());      
                sb.Append(",Consolation: " + pilotResults.Where(x => x.Name == item.Name && x.SessionTypeName == "CONSOLATION")
                    .Select(x => x.Position).FirstOrDefault().ToString());
                sb.Append(",Feature: " + pilotResults.Where(x => x.Name == item.Name && x.SessionTypeName == "FEATURE")
                    .Select(x => x.Position).FirstOrDefault().ToString());
                sb.Append(",Race: " + pilotResults.Where(x => x.Name == item.Name && x.SessionTypeName == "RACE")
                    .Select(x => x.Position).FirstOrDefault().ToString() + ")");
                LogText(sb.ToString(), LogTextBox);
            }

        }
        private void ParseResultsOLDJson(string jsonString)
        {
            List<Result> result = new List<Result>();
            List<PilotResults> pilotResults = new List<PilotResults>();
            List<PilotResults> pilotResultsQualy = new List<PilotResults>();

            var root = DeserialiseOldJson(jsonString);
            var sessionName = root.session_name;
            if (sessionName != null)
            {
                LogText(root.session_name, LogTextBox);
            }
            LogText("|"+root.track.track_name +" \\ " + root.track.config_name, LogTextBox);
            LogText("|" + root.session_results.First().results.First().car_name, LogTextBox);
            LogText("SessionID: " + root.race_summary.subsession_id.ToString(), LogTextBox);
            LogText("", LogTextBox);
            List<SessionResult> sessionResult = root.session_results;
            foreach (var item in sessionResult)
            {
                if (item.simsession_name != "HEAT 1" && item.simsession_name != "HEAT 2" 
                    && item.simsession_name != "FEATURE"
                    && item.simsession_name != "QUALIFY" && item.simsession_name != "RACE"
                    && item.simsession_name != "CONSOLATION") { continue; }
                var name = item.simsession_name;
                LogText(item.simsession_name, LogTextBox);
                result = item.results;
                foreach (var pilot in result)
                {
                    PilotResults pilotIterated = new PilotResults();

                    StringBuilder sb = new StringBuilder();
                    sb.Append(pilot.display_name + " ");
                    sb.Append(pilot.incidents.ToString());
                    sb.Append("x");
                    sb.Append(", Pos:");
                    sb.Append(pilot.finish_position + 1);
                    LogText(sb.ToString(), LogTextBox);

                    pilotIterated.Name = pilot.display_name;
                    pilotIterated.IncCount = pilot.incidents;
                    pilotIterated.Position = pilot.finish_position + 1;
                    pilotIterated.SessionTypeName = item.simsession_name;
                    if (item.simsession_name == "QUALIFY")
                    {
                        pilotResultsQualy.Add(pilotIterated);
                    }
                    else
                    {
                        pilotResults.Add(pilotIterated);
                    }

                }
            }

            var pilotResultsSorted = pilotResults
                .GroupBy(x => x.Name)
                .Select(g => new PilotSummary
                {
                    Name = g.Key,
                    TotalIncidents = g.Sum(x => x.IncCount),
                    AveragePosition = g.Average(x => x.Position)
                })
                .ToList();

            pilotResultsSorted = pilotResultsSorted.OrderBy(g => g.AveragePosition).ToList();
            LogText("", LogTextBox);
            LogText("+++ЛУЧШИЙ ГОНЩИК+++", LogTextBox);
            foreach (var item in pilotResultsSorted)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(item.ToString());
                sb.Append(" (Qual: " + pilotResultsQualy.Where(x => x.Name == item.Name && x.SessionTypeName == "QUALIFY")
                    .Select(x => x.Position).FirstOrDefault().ToString());
                sb.Append(",Heat 1: " + pilotResults.Where(x => x.Name == item.Name && x.SessionTypeName == "HEAT 1")
                    .Select(x => x.Position).FirstOrDefault().ToString());
                sb.Append(",Heat 2: " + pilotResults.Where(x => x.Name == item.Name && x.SessionTypeName == "HEAT 2")
                    .Select(x => x.Position).FirstOrDefault().ToString());
                sb.Append(",Consolation: " + pilotResults.Where(x => x.Name == item.Name && x.SessionTypeName == "CONSOLATION")
                    .Select(x => x.Position).FirstOrDefault().ToString());
                sb.Append(",Feature: " + pilotResults.Where(x => x.Name == item.Name && x.SessionTypeName == "FEATURE")
                    .Select(x => x.Position).FirstOrDefault().ToString());
                sb.Append(",Race: " + pilotResults.Where(x => x.Name == item.Name && x.SessionTypeName == "RACE")
                    .Select(x => x.Position).FirstOrDefault().ToString() + ")");
                LogText(sb.ToString(), LogTextBox);
            }

            pilotResultsSorted = pilotResultsSorted.OrderBy(g => g.TotalIncidents).ThenBy(p => p.AveragePosition).ToList();
            LogText("", LogTextBox);
            LogText("+++ЧИСТЫЙ ГОНЩИК+++", LogTextBox);
            foreach (var item in pilotResultsSorted)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(item.ToString());
                sb.Append(" (Heat 1: " + pilotResults.Where(x => x.Name == item.Name && x.SessionTypeName == "HEAT 1")
                    .Select(x => x.Position).FirstOrDefault().ToString());
                sb.Append(",Heat 2: " + pilotResults.Where(x => x.Name == item.Name && x.SessionTypeName == "HEAT 2")
                    .Select(x => x.Position).FirstOrDefault().ToString());
                sb.Append(",Consolation: " + pilotResults.Where(x => x.Name == item.Name && x.SessionTypeName == "CONSOLATION")
                    .Select(x => x.Position).FirstOrDefault().ToString());
                sb.Append(",Feature: " + pilotResults.Where(x => x.Name == item.Name && x.SessionTypeName == "FEATURE")
                    .Select(x => x.Position).FirstOrDefault().ToString());
                sb.Append(",Race: " + pilotResults.Where(x => x.Name == item.Name && x.SessionTypeName == "RACE")
                    .Select(x => x.Position).FirstOrDefault().ToString() + ")");
                LogText(sb.ToString(), LogTextBox);
            }

        }
    }
}
