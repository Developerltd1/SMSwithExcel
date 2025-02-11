using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BusinessLogic.Model.StaticModel;
using System.Windows.Forms.DataVisualization.Charting;
using Series = System.Windows.Forms.DataVisualization.Charting.Series;

namespace WifiPocketProject.UI
{
    public partial class Dashboard : Form//BaseForm//Form//BasetForm
    {
        private Series series;


        private const int CELL1 = 0;
        private const int CELL2 = 1;
        private const int CELL3 = 2;
        private const int CELL4 = 3;
        private const int CELL5 = 4;
        private const int CELL6 = 5;
        private const int CELL7 = 6;
        private const int CELL8 = 7;
        private const int CELL9 = 8;
        private const int CELL10 = 9;
        private const int CELL11 = 10;
        private const int CELL12 = 11;
        private const int CELL13 = 12;
        private const int CELL14 = 13;
        private const int CELL15 = 14;
        private const int TEMP = 32;
        private const int VOLTAGE = 40;
        private const int CURRENT = 41;
        private const int SOC = 42;
        private const int AH = 48;
        private const int POWER = 57;


        public Dashboard()
        {
            InitializeComponent();
        }

        //private void chart()
        //{
        //    // Create the CartesianChart control
        //    var cartesianChart = new LiveCharts.WinForms.CartesianChart();
        //    cartesianChart.Dock = DockStyle.Fill;
        //    this.Controls.Add(cartesianChart);

        //    // Set up data series for cell voltages
        //    SeriesCollection seriesCollection = new SeriesCollection();

        //    // Example data: integer X values and decimal Y values
        //    double[] yValues = { 2.1, 3.1, 4.1, 5.0, 4.8, 3.9 }; // Replace with your actual data
        //    ChartValues<ObservablePoint> chartValues = new ChartValues<ObservablePoint>();

        //    for (int i = 0; i < yValues.Length; i++)
        //    {
        //        chartValues.Add(new ObservablePoint(i + 1, yValues[i]));
        //    }

        //    // Add series to the collection
        //    seriesCollection.Add(new LineSeries
        //    {
        //        Title = "Cell Voltages (V)",
        //        Values = chartValues,
        //        PointGeometrySize = 15
        //    });

        //    // Configure X axis
        //    cartesianChart.AxisX.Add(new LiveCharts.Wpf.Axis
        //    {
        //        Title = "Cell",
        //        Labels = new[] { "1", "2", "3", "4", "5", "6" } // X axis labels
        //    });

        //    // Configure Y axis
        //    cartesianChart.AxisY.Add(new LiveCharts.Wpf.Axis
        //    {
        //        Title = "Voltages (V)",
        //        LabelFormatter = value => value.ToString("N1") // Format Y axis labels as decimal with one decimal place
        //    });

        //    // Add legends
        //    cartesianChart.LegendLocation = LiveCharts.LegendLocation.Right;
        //    cartesianChart.Name = "Legend";

        //    // Assign series collection to chart
        //    cartesianChart.Series = seriesCollection;

        //}

        private void SetupDataGridView()
        {
            DataTable dt = new StaticData().DataGridView();

            dgvCellLevel.Rows.Clear();
            foreach (DataRow r in dt.Rows)
            {
                dgvCellLevel.Rows.Add(
                    r["Parameter"].ToString(), r["Battery-1"].ToString(), r["Battery-2"].ToString(), r["Battery-3"].ToString(), r["Battery-4"].ToString(), r["Battery-5"].ToString());
            }
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        //Funcations
        private void Paremeters()
        {
            DashboardModel.Parameters _Parameters = new StaticData().DashboardData();
            labelChargeEnergy.Text = _Parameters.labelChargeEnergy.ToString();
            labelDiscEnergy.Text = _Parameters.labelDiscEnergy.ToString();
            labelPowerSystem.Text = _Parameters.labelPowerSystem.ToString();
            labelRemaningEnergy.Text = _Parameters.labelRemaningEnergy.ToString();
            labelRemaningTime.Text = _Parameters.labelRemaningTime.ToString();
            labelStateOfCharge.Text = _Parameters.labelStateOfCharge.ToString();
            labelSystemTemp.Text = _Parameters.labelSystemTemp.ToString();
            labelTermilanVolt.Text = _Parameters.labelTermilanVolt.ToString();
            labelTerminalCurrent.Text = _Parameters.labelTerminalCurrent.ToString();
        }
        private void InitializeChart()
        {
            // Example data
            int[] xValues = { 1, 2, 3, 4, 5 };
            double[] yValues = { 10.2, 15.1, 7.5, 22.3, 18.6 };

            // Clear existing series
            chart1.Series.Clear();

            // Initialize the series object
            series = new Series("Sample Series");
            series.ChartType = SeriesChartType.Line;

            for (int i = 0; i < xValues.Length; i++)
            {
                series.Points.AddXY(xValues[i], yValues[i]);
            }

            // Add series to the chart
            chart1.Series.Add(series);

            // Customize chart appearance
            chart1.ChartAreas[0].AxisX.Title = "X Axis";
            chart1.ChartAreas[0].AxisY.Title = "Y Axis";
            chart1.Titles.Add("Sample Line Chart");
        }

        #region GridRealTimeData

        private bool isPollingEnabled = false;
        private Timer pollingTimer;

        #region btnToggle
        private void btnToggle()
        {
            isPollingEnabled = !isPollingEnabled;

            if (isPollingEnabled)
            {
                //btnTogglePolling1.BackColor = Color.Gray;
                InitializePollingTimer();
                StartPolling();
            }
            else
            {
               // btnTogglePolling1.BackColor = Color.White;
                StopPolling();

            }
        }
        #endregion

        #region SupportFunctions
        private void InitializePollingTimer()
        {
            pollingTimer = new Timer();
            pollingTimer.Interval = 500;// Convert.ToInt32(pollingTimeout.Value); // Polling interval in milliseconds (1 second here)
            pollingTimer.Tick += PollingTimer_Tick;
        }
        private void StartPolling()
        {
            pollingTimer.Start();
        }

        private void StopPolling()
        {
            pollingTimer.Stop();
          
        }

        private void PollingTimer_Tick(object sender, EventArgs e)
        {
            int functionCode = 3;// Convert.ToInt32(comboBoxFunctionCode.SelectedIndex) + 1;
        }

     
        #endregion
        #endregion
        private void Dashboard_Load(object sender, EventArgs e)
        {
            isPollingEnabled = !isPollingEnabled;

            if (isPollingEnabled)
            {
                //btnTogglePolling1.BackColor = Color.Gray;
                InitializePollingTimer();
                StartPolling();
            }
            else
            {
                //btnTogglePolling1.BackColor = Color.White;
                StopPolling(); 
            }

            Paremeters();
            SetupDataGridView();

            //chart();
            InitializeChart();
            #region DataGrid


            #endregion


            //chart();
            //cartesianChart.AxisX.Add(new LiveCharts.Wpf.Axis
            //{
            //    Title = "Month",
            //    Labels = new[] { "Jan", "Feb", "Mar", "April", "May", "June", "Juny", "Aug", "Sep", "Oct", "Nov", "Dec", }
            //});
            //cartesianChart.AxisX.Add(new LiveCharts.Wpf.Axis
            //{
            //    Title = "Revenue",
            //    LabelFormatter = value => value.ToString("C")
            //});
            //cartesianChart.LegendLocation = LiveCharts.LegendLocation.Right;


            // Create the CartesianChart control
            //var cartesianChart = new LiveCharts.WinForms.CartesianChart();
            //cartesianChart.Dock = DockStyle.Fill;
            //this.Controls.Add(cartesianChart);

            //// Set up data series for the chart
            //SeriesCollection seriesCollection = new SeriesCollection();

            //// Example data series: replace with your actual data
            //double[] xValues = { 1, 2, 3, 4, 5, 6 }; // X axis values (integers)
            //double[] yValues1 = { 2.1, 3.1, 4.1, 5.0, 4.8, 3.9 }; // Y axis values for series 1 (decimal)
            //double[] yValues2 = { 3.2, 4.2, 5.2, 6.1, 5.9, 4.8 }; // Y axis values for series 2 (decimal)

            //// Add series 1: Cell Voltages (V)
            //ChartValues<ObservablePoint> series1Values = new ChartValues<ObservablePoint>();
            //for (int i = 0; i < xValues.Length; i++)
            //{
            //    series1Values.Add(new ObservablePoint(xValues[i], yValues1[i]));
            //}
            //seriesCollection.Add(new LineSeries
            //{
            //    Title = "Cell Voltages (V)",
            //    Values = series1Values,
            //    PointGeometrySize = 15
            //});

            //// Add series 2: Example additional series
            //ChartValues<ObservablePoint> series2Values = new ChartValues<ObservablePoint>();
            //for (int i = 0; i < xValues.Length; i++)
            //{
            //    series2Values.Add(new ObservablePoint(xValues[i], yValues2[i]));
            //}
            //seriesCollection.Add(new LineSeries
            //{
            //    Title = "Additional Series",
            //    Values = series2Values,
            //    PointGeometrySize = 15
            //});

            //// Configure X axis
            //cartesianChart.AxisX.Add(new LiveCharts.Wpf.Axis
            //{
            //    Title = "Cell",
            //    Labels = new[] { "1", "2", "3", "4", "5", "6" } // X axis labels
            //});

            //// Configure Y axis
            //cartesianChart.AxisY.Add(new LiveCharts.Wpf.Axis
            //{
            //    Title = "Voltages (V)",
            //    LabelFormatter = value => value.ToString("N1") // Format Y axis labels as decimal with one decimal place
            //});

            //// Add legends
            //cartesianChart.LegendLocation = LiveCharts.LegendLocation.Right;


            //// Assign series collection to chart
            //cartesianChart.Series = seriesCollection;


        }
    }
}
