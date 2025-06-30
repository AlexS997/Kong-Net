using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms;
using KongN.Classi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KongN.StrutturaRete
{
    public partial class FrmMappa : Form
    {
        private List<PointLatLng> _points;
        // public double _Lat { get; set; }
        // public double _Lng { get; set; }

        // serve per vedere se la mappa è singola o multipla
        // se è multipla allora non permette di riportare i punti e nemmeno di prenderli
        public int chiChiama { get; set; }
        public DataTable _dt { get; set; }
        public int _TipoMarker { get; set; }


        public FrmMappa()
        {
            InitializeComponent();

            _points = new List<PointLatLng>();
        }

        void LoadMap(PointLatLng point) => map.Position = point;

        private void FrmMappa_Load(object sender, EventArgs e)
        {
            try
            {
                Services.Tracker.Track(this);
                GMapProviders.GoogleMap.ApiKey = AppConfiguration.Key;
                GMaps.Instance.Mode = AccessMode.ServerAndCache;
                map.CacheLocation = @"cache";
                map.DragButton = MouseButtons.Left;

                map.MapProvider = GMapProviders.GoogleMap;
                map.ShowCenter = false;
                map.MinZoom = 1;
                map.MaxZoom = 50;
                map.Zoom = 14;
                map.SetPositionByKeywords("Capalbio, Italy");
                cboTipo.SelectedIndex = 2;
                // se viene chiamato da mappa multipla non permette di riportare i punti
                if (chiChiama != 0)
                {
                    btnRiporta.Enabled = false;
                    btnPulisci.Enabled = false;
                }
                CaricaMappa();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                this.Close();
                return;
            }
        }

        private void CaricaMappa()
        {
            // controlla che _dt non sia vuoto
            if (_dt == null)
            {
                return;
            }
            if (_dt.Rows.Count > 0)
            {

                // se _dt ha una riga sola controlla che le cooordinate non siano 0
                // se sono 0 riporta la posizione di default
                if (_dt.Rows.Count == 1)
                {
                    double lat = Convert.ToDouble(_dt.Rows[0]["Latitudine"].ToString());
                    double lng = Convert.ToDouble(_dt.Rows[0]["Longitudine"].ToString());
                    if (lat == 0 && lng == 0)
                    {
                        map.SetPositionByKeywords("Capalbio, Italy");
                        return;
                    }
                }


                foreach (DataRow row in _dt.Rows)
                {
                    double lat = Convert.ToDouble(row["Latitudine"].ToString());
                    double lng = Convert.ToDouble(row["Longitudine"].ToString());
                    string title = "";
                    if (lat == 0 && lng == 0)
                    {
                        continue;
                    }
                    switch (_TipoMarker)
                    {
                        case 0:
                            title = row["Gateway"].ToString();
                            break;
                        case 1:
                            title = row["Ponte"].ToString();
                            break;
                        case 2:
                            title = row["Denom"].ToString();
                            break;

                    }


                    LoadMap(new PointLatLng(lat, lng));
                    _points.Clear();
                    // aggiunge il marker

                    AddMarker(lat, lng, title);
                }
            }


        }

        private void AddMarker(double lat, double lng, string title)
        {


            // icona di google maps


            switch (_TipoMarker)
            {


                case 0:// Gateway
                    GMapMarker marker = new GMarkerGoogle(new PointLatLng(lat, lng), GMarkerGoogleType.red_pushpin);

                    marker.ToolTipText = title;
                    GMapOverlay markersOverlay = new GMapOverlay("markers");
                    markersOverlay.Markers.Add(marker);
                    map.Overlays.Add(markersOverlay);

                    break;
                case 1: //ponte

                    GMapMarker marker1 = new GMarkerGoogle(new PointLatLng(lat, lng), GMarkerGoogleType.blue_pushpin);
                    marker1.ToolTipText = title;
                    GMapOverlay markersOverlay1 = new GMapOverlay("markers");
                    markersOverlay1.Markers.Add(marker1);
                    map.Overlays.Add(markersOverlay1);

                    break;
                //case 2:// pannello
                //    GMapMarker marker2 = new GMarkerGoogle(new PointLatLng(lat, lng), GMarkerGoogleType.green_pushpin);
                //    marker2.ToolTipText = title;
                //    GMapOverlay markersOverlay2 = new GMapOverlay("markers");
                //    markersOverlay2.Markers.Add(marker2);
                //    map.Overlays.Add(markersOverlay2);


                //    break;
                case 2:// cliente
                    GMapMarker marker3 = new GMarkerGoogle(new PointLatLng(lat, lng), GMarkerGoogleType.blue);
                    marker3.ToolTipText = title;
                    GMapOverlay markersOverlay3 = new GMapOverlay("markers");
                    markersOverlay3.Markers.Add(marker3);
                    map.Overlays.Add(markersOverlay3);


                    break;

            }

        }

        void AddMarkerPunto(PointLatLng pointToAdd, GMarkerGoogleType markerType = GMarkerGoogleType.arrow)
        {
            var markersp = new GMapOverlay("markersp");
            var markerp = new GMarkerGoogle(pointToAdd, markerType);

            var tooltip = new GMap.NET.WindowsForms.ToolTips.GMapBaloonToolTip(markerp)
            {
                Stroke = new Pen(new SolidBrush(Color.Black)),
                Font = new Font("Arial", 9, FontStyle.Bold | FontStyle.Underline),
                Fill = new SolidBrush(Color.Black),
                Foreground = new SolidBrush(Color.White)
            };
            markerp.ToolTip = tooltip;
            markerp.ToolTip.TextPadding = new Size(0, 0);
            markerp.ToolTip.Format.Alignment = StringAlignment.Far;

            markerp.ToolTipText = $"Latitude: {Math.Round(map.Position.Lat, 3)}, \nLongitude: {Math.Round(map.Position.Lng, 3)}";


            markersp.Markers.Add(markerp);
            map.Overlays.Add(markersp);
            //map.RefreshMap();
            map.UpdateMarkerLocalPosition(markerp);
        }

        enum TipoMarker
        {

            Gateway = 0,
            Ponte = 1,
            Cliente = 2

        }

        enum TipoMappa
        {
            GoogleMap = 0,
            GoogleSatelliteMap = 1,
            GoogleHybridMap = 2,
            GoogleTerrainMap = 3
        }

        private void btnEsci_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPulisci_Click(object sender, EventArgs e)
        {
            // remove all markers
            map.Overlays.Clear();
            map.Refresh();
        }

        private void btnRiporta_Click(object sender, EventArgs e)
        {
            if (txtLat.Text != "" && txtLong.Text != "")
            {
                switch (MessageBox.Show("Attenzione le Coordinate scelte prenderanno il posto di quelle vecchie .Vuoi Riportate le Coordinate nella maschera chiamante?", "Messaggio di Conferma", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {
                    case DialogResult.Yes:
                        double _Lat = Convert.ToDouble(txtLat.Text);
                        double _Lng = Convert.ToDouble(txtLong.Text);

                        MapPunto._Latitude = _Lat;
                        MapPunto._Longitude = _Lng;

                        btnEsci.PerformClick();
                        break;

                    case DialogResult.No:
                        txtLat.Text = "";
                        txtLong.Text = "";

                        break;
                }
            }
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboTipo.SelectedIndex)
            {
                case 0:
                    map.MapProvider = GMapProviders.GoogleMap;
                    break;
                case 1:
                    map.MapProvider = GMapProviders.GoogleSatelliteMap;
                    break;
                case 2:
                    map.MapProvider = GMapProviders.GoogleHybridMap;
                    break;
                case 3:
                    map.MapProvider = GMapProviders.GoogleTerrainMap;
                    break;
            }
            map.Refresh();
        }

        private void map_MouseClick(object sender, MouseEventArgs e)
        {
            if (chiChiama != 0)
            {
                return;
            }
            if (e.Button == MouseButtons.Right)
            {
                var point = map.FromLocalToLatLng(e.X, e.Y);
                double lat = point.Lat;
                double lng = point.Lng;
                txtLat.Text = lat.ToString() + "";
                txtLong.Text = lng.ToString() + "";
                //var Markers = new GMapOverlay("markers");
                //var marker = new GMarkerGoogle(point, GMarkerGoogleType.green_pushpin);
                //Markers.Markers.Add(marker);
                //map.Overlays.Add(Markers);
                AddMarkerPunto(point);
            }
        }
    }
}
