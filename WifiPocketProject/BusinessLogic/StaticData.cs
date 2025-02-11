

using BusinessLogic.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BusinessLogic.Model.StaticModel;
using static BusinessLogic.Model.StaticModel.SettingsModel;
namespace BusinessLogic
{
    public class StaticData
    {

        public StaticModel.MainParamatersForm_Parameters MainParamatersForm_ParametersFn()
        {
            StaticModel.MainParamatersForm_Parameters _Parameters = new StaticModel.MainParamatersForm_Parameters();
            _Parameters.Volt = 1.1;
            _Parameters.Current = 2.1;
            _Parameters.Power = 3.1;
            _Parameters.Ah = 4.1;
            _Parameters.Temp = 5.1;
            return _Parameters;
        }

        public DataTable DataGridView()
        {

            List<string> list = new List<string>()
            {
                "Voltage (V)","Current (Amps)","Power (kW)","SOC","Total Remaining Capacity(Ah)","Temperature (C)","Cell-1 (V)",
                "Cell-2 (V)","Cell-3 (V)","Cell-4 (V)","Cell-5 (V)","Cell-6 (V)","Cell-7 (V)","Cell-8 (V)","Cell-9 (V)","Cell-10 (V)",
                "Cell-11 (V)","Cell-12 (V)","Cell-13 (V)","Cell-14 (V)","Cell-15 (V)"
            };
           
            DataTable dt = new Utility().ListToDataTable(list);
            return dt;
        }

        #region StaticData_SettingsData

        #endregion
        public SettingsRequest SettingsData()
        {
            //Dictionary<int, string> items = new Dictionary<int, string>()
            //{
            //    { 1,"Value1"  },
            //    { 2,"Value2"  },
            //    { 3,"Value3"  }
            //};

            List<StaticModel.SettingsModel.ComboBoxModel> Comboitems1 = new List<StaticModel.SettingsModel.ComboBoxModel>()
            {
                new StaticModel.SettingsModel.ComboBoxModel("Please Select", "0"),
                new StaticModel.SettingsModel.ComboBoxModel("Online Monitoring", "1"),
                new StaticModel.SettingsModel.ComboBoxModel("Offline Monitoring", "2")
            };

            SettingsRequest settingsModel = new SettingsRequest()
            {
                tbCurrent = 24.1,
                tbLowCellVolt = 2.4,
                tbHighCellVolt = 2.44,
                tbHighCurrCharge = 2.5,
                tbHighCurrDischarge = 2.55,
                tbHighTempCharge = 2.96,
                tbHighTempDischarge = 2.66,
                tbHighSumVolt = 2.7,
                tbLowSumVolt = 2.77,
                tbSocHighAlarm = 2.9,
                tbSocLowAlarm = 2.99,
                tbSetChargeEnergy = 2.10,
                tbSetDishargeEnergy = 2.100,
                tbSleepTimeout = 2.11,
                tbSoc = 2.12,
                tbUtbOffset = 2.13,
                tbSerial = 2.14,
                datePickerMS = DateTime.Now,
                cbMode1 = Comboitems1,
                //cbMode = items,
            };
            return settingsModel;
        }


        public DashboardModel.Parameters DashboardData()
        {
            DashboardModel.Parameters parameters = new DashboardModel.Parameters()
            {
                labelChargeEnergy = 1.1,
                labelDiscEnergy = 2.1,
                labelPowerSystem = 3.1,
                labelRemaningEnergy = 4.1,
                labelRemaningTime = 5.1,
                labelStateOfCharge = 5.1,
                labelSystemTemp =6.1,
                labelTermilanVolt = 7.1,
                labelTerminalCurrent = 8.1
            };

            return parameters;
        }


    }
}
