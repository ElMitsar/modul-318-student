using SwissTransport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FahrplanAPP
{
    public partial class Form1 : Form
    {
        private Transport transport = new Transport();
        public Form1()
        {
            InitializeComponent();
        }

        private void EingabeAbfahrtsstation_KeyUp(object sender, KeyEventArgs e)
        {
            EingabeVollständigkeitsPrüfung(e);
            {
                Stations Abfahrtsstation = transport.GetStations(EingabeAbfahrtsstation.Text);
                foreach (Station x in Abfahrtsstation.StationList)
                {
                    EingabeAbfahrtsstation.Items.Add(x.Name);
                }
            }
        }

        private void EingabeZielstation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EingabeZielstation_KeyUp(object sender, KeyEventArgs e)
        {
            EingabeVollständigkeitsPrüfung(e);
            {
                Stations Zielstation = transport.GetStations(EingabeZielstation.Text);
                foreach (Station x in Zielstation.StationList)
                {
                    EingabeZielstation.Items.Add(x.Name);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RoutenAnzeige_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RoutenAnzeige_KeyUp(object sender, KeyEventArgs e)
        {
            EingabeVollständigkeitsPrüfung(e);
        }

        public void EingabeVollständigkeitsPrüfung(KeyEventArgs e)  //Prüft bei Betätigung der Enter Taste ob alle erforderlichen Felder ausgefüllt wurden, wenn nicht erscheint eine Fehlermeldung, ansonsten werden die Informationen verarbeitet
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(EingabeAbfahrtsstation.Text) || string.IsNullOrEmpty(EingabeZielstation.Text))
                {
                    MessageBox.Show("Eingabe unvollständig");
                }

                else
                {
                    RoutenSuchen();
                }
            };
        }

        public void RoutenSuchen()
        {
            RoutenAnzeige.Items.Clear(); //Löscht vorgängige Eingaben
            Connections Route = transport.GetConnections(EingabeAbfahrtsstation.Text, EingabeZielstation.Text);
            foreach (Connection x in Route.ConnectionList)
            {

                RoutenAnzeige.Items.Add(x.From.Station.Name);
                RoutenAnzeige.Items.Add(x.To.Station.Name);
            }

        }

        private void EingabeAbfahrtsstation_SelectedIndexChanged(object sender, EventArgs e)
        {
            Stations Abfahrtsstation = transport.GetStations(EingabeAbfahrtsstation.Text);
        }

        private void EingabeZielstation_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Stations Zielstation = transport.GetStations(EingabeZielstation.Text);
        }

        private void ButtonAbfahrtsPlan_Click(object sender, EventArgs e)
        {
            RoutenAnzeige.Items.Clear(); //Löscht vorgängige Eingaben
            var AbfahrtsstationID = transport.GetStations(EingabeAbfahrtsstation.Text).StationList[0].Id;
            StationBoardRoot Abfahrtsplan = transport.GetStationBoard(EingabeAbfahrtsstation.Text, AbfahrtsstationID);
            foreach (StationBoard x in Abfahrtsplan.Entries)
            {
                RoutenAnzeige.Items.Add(x.Stop.Departure + "\t" + x.To);
            }
        }
    }
}
