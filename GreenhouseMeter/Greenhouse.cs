using GreenhouseMeter.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Point = GreenhouseMeter.Model.Point;

namespace GreenhouseMeter
{
    public partial class Greenhouse : Form
    {
        private readonly int sleepTimeMs = 5000;
        private Dictionary<int, Unit> Units = new Dictionary<int, Unit>();
        public BindingList<Unit> DisplayUnits = new BindingList<Unit>();

        private readonly double step = 0.5;

        public Greenhouse()
        {
            InitializeComponent();
            Sensors.DataSource = DisplayUnits;
            InitializeUnits();
            WorkCycle();
        }


        private void InitializeUnits()
        {
            Units = FileSystem.InitializePoints();
        }

        private async void WorkCycle()
        {
            while(true)
            {
                WorkProcess();
                await Task.Delay(sleepTimeMs);
            }
        }

        private void WorkProcess()
        {
            MakeRequest();

            var temperatureDatas = Units.Select(u => new Point
            {
                X = u.Value.Xpos,
                Y = u.Value.Ypos,
                Value = u.Value.Temp,
                Num = u.Value.Id
            });
            var temperatureMap = MathController.BuildDistribution(temperatureDatas, step);
            MapController.UpdateMap(TempMap, temperatureMap);
        }

        private void MakeRequest()
        {
            var currentUnits = LoRaController.GetActual();

            foreach (var unit in currentUnits)
            {
                if (Units.ContainsKey(unit.Id))
                {
                    var realUnit = Units[unit.Id];
                    realUnit.Temp = unit.Temp;
                    realUnit.Humidity = unit.Humidity;
                    Log("Updated unit: " + unit.Id);
                }
                else
                {
                    unit.Xpos = 0;
                    unit.Ypos = 0;
                    Units.Add(unit.Id, unit);
                    Log("Added new unit: " + unit.Id);
                    DisplayUnits.Add(unit);
                }
            }
        }

        

        private void Save_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Identificator.Text);
            double x = double.Parse(PosX.Text);
            double y = double.Parse(PosY.Text);

            Units[id].Xpos = x;
            Units[id].Ypos = y;

            FileSystem.SavePoints(Units);
        }

        private void Sensors_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listBox = (ListBox)sender;
            var unit = (Unit)listBox.SelectedItem;
            Identificator.Text = unit.Id.ToString();
            temp.Text = unit.Temp.ToString();
            humidity.Text = unit.Humidity.ToString();
            PosX.Text = unit.Xpos.ToString();
            PosY.Text = unit.Ypos.ToString();
        }

        private void Log(string message)
        {
            LogBox.Text += message + '\n';
        }
    }
}
