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

        BindingSource BindingSource = new BindingSource();


        public MainWindow()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _gameSession = new GameSession();



            //Listing all values on control on load

            //Player Stats
            nameValueLabel.Text = _gameSession.CurrentPlayer.Name;
            levelValueLabel.Text = _gameSession.CurrentPlayer.Level.ToString();
            expValueLabel.Text = _gameSession.CurrentPlayer.Exp.ToString();
            goldValueLabel.Text = _gameSession.CurrentPlayer.Gold.ToString();

            dexterityValueLabel.Text = _gameSession.CurrentPlayer.Dexterity.ToString();
            intelligenceValueLabel.Text = _gameSession.CurrentPlayer.Intelligence.ToString();
            staminaValueLabel.Text = _gameSession.CurrentPlayer.Stamina.ToString();
            strengthValueLabel.Text = _gameSession.CurrentPlayer.Strength.ToString();


            //display current location

            currentLocationPictureBox.Image = Image.FromFile(_gameSession.CurrentLocation.ImageName);


        }





        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void UpdateInfobutton_Click(object sender, EventArgs e)
        {
            //TODO: buat loop yg pergi ke semua control label dan update value masing2

            _gameSession.CurrentPlayer.Name = "SHIT";
            //expValueLabel.Text = _gameSession.CurrentPlayer.Exp.ToString();

            gameSessionBindingSource.ResetBindings(false);
            nameValueLabel.ResetBindings();
            nameValueLabel.Refresh();
            Update();

        }


        private void Refresh_Stats()
        {
            this.Refresh();
            Application.DoEvents();
            //expValueLabel.Refresh();
            //expValueLabel.Text = _gameSession.CurrentPlayer.Exp.ToString();
        }




        //Timer stuff

        private void MainWindowTimer_Tick(object sender, EventArgs e)
        {
            Refresh_Stats();
            
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
