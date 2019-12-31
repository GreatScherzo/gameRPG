using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine.ViewModels;

namespace GameScreen_FormApp
{
    public partial class MainWindow : Form
    {
        private GameSession _gameSession;




        public MainWindow()
        {
            InitializeComponent();

            //goldValueLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", gameSessionBindingSource, "Gold", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _gameSession = new GameSession();
            currentPlayerBindingSource.DataSource = _gameSession.CurrentPlayer;

            nameValueLabel.DataBindings.Add(new Binding("Text", currentPlayerBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            levelValueLabel.DataBindings.Add(new Binding("Text", currentPlayerBindingSource, "Level", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            expValueLabel.DataBindings.Add(new Binding("Text", currentPlayerBindingSource, "Exp", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            goldValueLabel.DataBindings.Add(new Binding("Text", currentPlayerBindingSource, "Gold", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            
            dexterityValueLabel.DataBindings.Add(new Binding("Text", currentPlayerBindingSource, "Dexterity", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            intelligenceValueLabel.DataBindings.Add(new Binding("Text", currentPlayerBindingSource, "Intelligence", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            staminaValueLabel.DataBindings.Add(new Binding("Text", currentPlayerBindingSource, "Stamina", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            strengthValueLabel.DataBindings.Add(new Binding("Text", _gameSession.CurrentPlayer, "Strength", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));

            
            //Listing all values on control on load

            //Player Stats

            //nameValueLabel.Text = _gameSession.CurrentPlayer.Name;
            //levelValueLabel.Text = _gameSession.CurrentPlayer.Level.ToString();
            //expValueLabel.Text = _gameSession.CurrentPlayer.Exp.ToString();

            //dexterityValueLabel.Text = _gameSession.CurrentPlayer.Dexterity.ToString();

            //intelligenceValueLabel.Text = _gameSession.CurrentPlayer.Intelligence.ToString();
            //staminaValueLabel.Text = _gameSession.CurrentPlayer.Stamina.ToString();
            //strengthValueLabel.Text = _gameSession.CurrentPlayer.Strength.ToString();


            ////display current location

            //currentLocationPictureBox.Image = Image.FromFile(_gameSession.CurrentLocation.ImageName);
            currentLocationBindingSource.DataSource = _gameSession.CurrentLocation;

            LoadImageCurrentLocation();
            //currentLocationPictureBox.DataBindings.Add("ImageLocation", currentLocationBindingSource, "ImageName");
            //currentLocationPictureBox.DataBindings.Add(new Binding("ImageLocation", currentLocationBindingSource, "ImageName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
        }

        //load the current location picture
        private void LoadImageCurrentLocation()
        {
            currentLocationPictureBox.Load(_gameSession.CurrentLocation.ImageName);
        }


        private void Label1_Click(object sender, EventArgs e)
        {

        }


        //hadcode testing
        private void UpdateInfobutton_Click(object sender, EventArgs e)
        {
            //TODO: buat loop yg pergi ke semua control label dan update value masing2

            _gameSession.CurrentPlayer.Gold += 10;
            //expValueLabel.Text = _gameSession.CurrentPlayer.Exp.ToString();

        }



        //movement control
        //TODO: add guard clauses to movement

        private void ButtonNorth_Click(object sender, EventArgs e)
        {
            _gameSession.MoveNorth();
            LoadImageCurrentLocation();
            MovementButtonVisibilityUpdate();

            //currentLocationPictureBox.Load();
            //_gameSession.CurrentLocation.ImageName = _gameSession.CurrentLocation.ImageName;
            //_gameSession.CurrentLocation.ImageName = @"C:\Users\Barzarin\Documents\GitHub\gameRPG\RpgGame\Engine\Images\Location\Istana.jpg";
            //_gameSession.CurrentLocation = _gameSession.CurrentWorld.LocationAt(0, 0);
        }
        private void ButtonSouth_Click(object sender, EventArgs e)
        {
            _gameSession.MoveSouth();
            LoadImageCurrentLocation();
            MovementButtonVisibilityUpdate();
        }


        private void ButtonWest_Click(object sender, EventArgs e)
        {
            _gameSession.MoveWest();
            LoadImageCurrentLocation();
            MovementButtonVisibilityUpdate();
        }
        private void ButtonEast_Click(object sender, EventArgs e)
        {
            _gameSession.MoveEast();
            LoadImageCurrentLocation();
            MovementButtonVisibilityUpdate();
        }

        //update button control visibility

        private void MovementButtonVisibilityUpdate()
        {
            var availableDirection = _gameSession.UpdateLocation();

            buttonNorth.Visible = availableDirection[0];
            buttonSouth.Visible = availableDirection[1];
            buttonEast.Visible = availableDirection[2];
            buttonWest.Visible = availableDirection[3];
                
        }





        //Timer stuff

        private void MainWindowTimer_Tick(object sender, EventArgs e)
        {
           // currentLocationPictureBox.Update();


        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer
            {
                Interval = (1000) // 1 secs
            };

            timer.Tick += new EventHandler(MainWindowTimer_Tick);
            timer.Start();
        }
    }
}
