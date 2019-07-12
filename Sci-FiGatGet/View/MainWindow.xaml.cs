using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Sci_FiGadGet
{   
    public partial class MainWindow : Window,IDisposable
    {
        #region Private Fields
        private Storyboard _sbSettingsMenuIn, _sbSettingsMenuOut;
        private bool _settingsBtnInOrOut=false;
        #endregion

        #region Ctor
        public MainWindow()
        {
            InitializeComponent();
            InitAllObjects();
            HelperClass.SetWindowPosition(this);
           
        } 
        #endregion

        #region Public Fields
        
        #endregion

        #region Private event CallBack
        void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        #region Button Click Events
        private void settingsbtn_Click(object sender, RoutedEventArgs e)
        {
            if (_settingsBtnInOrOut)
            {
                _sbSettingsMenuOut.Begin();
                _settingsBtnInOrOut = false;
            }
            else
            {
                _sbSettingsMenuIn.Begin();
                _settingsBtnInOrOut =true ;
            }
        }
        private void btnInSettingsOne_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnInSettingsTwo_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnInSettingsThree_Click(object sender, RoutedEventArgs e)
        {

        }
        private void btnInSettingsFour_Click(object sender, RoutedEventArgs e)
        {

        }
        private void btnInSettingsFive_Click(object sender, RoutedEventArgs e)
        {

        }
        private void btnInSettingsSix_Click(object sender, RoutedEventArgs e)
        {

        }
        private void closebtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void minimizebtn_Click(object sender, RoutedEventArgs e)
        {

        }
        #endregion

        #region MouseEnter Leave Events
        private void settingsbtn_MouseEnter(object sender, MouseEventArgs e)
        {
            try
            {
                SettingEllipseBtn.Fill.Opacity = 0.7;
            }
            catch (Exception ex)
            {

            }
        }
        private void settingsbtn_MouseLeave(object sender, MouseEventArgs e)
        {
            try
            {
                SettingEllipseBtn.Fill.Opacity = 0;
            }
            catch (Exception ex)
            {

            }
        }

        private void btnInSettingsOne_MouseLeave(object sender, MouseEventArgs e)
        {
            try
            {
                //var rect = btnInSettingsOne.Template.FindName("btnSettOneRec", btnInSettingsOne) as Rectangle;
                btnSettOneRec.Fill.Opacity = 0.01;

            }
            catch (Exception ex)
            {

            }
        }

        private void btnInSettingsOne_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            try
            {
                //var rect = btnInSettingsOne.Template.FindName("btnSettOneRec", btnInSettingsOne) as Rectangle;
                btnSettOneRec.Fill.Opacity = 0.4;

            }
            catch (Exception ex)
            {

            }
        }

        private void btnInSettingsTwo_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            try
            {
                //var rect = btnInSettingsOne.Template.FindName("btnSettOneRec", btnInSettingsOne) as Rectangle;
                btnSettTwoRec.Fill.Opacity = 0.01;

            }
            catch (Exception ex)
            {

            }
        }

        private void btnInSettingsTwo_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            try
            {
                btnSettTwoRec.Fill.Opacity = 0.4;
            }
            catch (Exception ex)
            {

            }
        }

        private void btnInSettingsThree_MouseEnter(object sender, MouseEventArgs e)
        {
            try
            {
                btnSettThreeRec.Fill.Opacity = 0.4;
            }
            catch (Exception ex)
            {

            }
        }

        private void btnInSettingsThree_MouseLeave(object sender, MouseEventArgs e)
        {
            try
            {
                //var rect = btnInSettingsOne.Template.FindName("btnSettOneRec", btnInSettingsOne) as Rectangle;
                btnSettThreeRec.Fill.Opacity = 0.01;

            }
            catch (Exception ex)
            {

            }
        }

        private void btnInSettingsFour_MouseEnter(object sender, MouseEventArgs e)
        {
            try
            {
                btnSettFourRec.Fill.Opacity = 0.4;
            }
            catch (Exception ex)
            {

            }
        }

        private void btnInSettingsFour_MouseLeave(object sender, MouseEventArgs e)
        {
            try
            {
                //var rect = btnInSettingsOne.Template.FindName("btnSettOneRec", btnInSettingsOne) as Rectangle;
                btnSettFourRec.Fill.Opacity = 0.01;

            }
            catch (Exception ex)
            {

            }
        }



        private void btnInSettingsFive_MouseEnter(object sender, MouseEventArgs e)
        {
            try
            {
                btnSettFiveRec.Fill.Opacity = 0.4;
            }
            catch (Exception ex)
            {

            }
        }

        private void btnInSettingsFive_MouseLeave(object sender, MouseEventArgs e)
        {
            try
            {
                //var rect = btnInSettingsOne.Template.FindName("btnSettOneRec", btnInSettingsOne) as Rectangle;
                btnSettFiveRec.Fill.Opacity = 0.01;

            }
            catch (Exception ex)
            {

            }
        }



        private void btnInSettingsSix_MouseEnter(object sender, MouseEventArgs e)
        {
            try
            {
                btnSettSixRec.Fill.Opacity = 0.4;
            }
            catch (Exception ex)
            {

            }
        }

        private void btnInSettingsSix_MouseLeave(object sender, MouseEventArgs e)
        {
            try
            {
                //var rect = btnInSettingsOne.Template.FindName("btnSettOneRec", btnInSettingsOne) as Rectangle;
                btnSettSixRec.Fill.Opacity = 0.01;

            }
            catch (Exception ex)
            {

            }
        } 
        #endregion

        #endregion

        #region Private Method
        private void InitAllObjects()
        {
            _sbSettingsMenuIn = this.FindResource("SettingsMenuIn") as Storyboard;
            _sbSettingsMenuOut = this.FindResource("SettingsMenuOut") as Storyboard;
        }
        #endregion

        #region Public Methods
        public void Dispose()
        {
           
        }
        #endregion

        private void closebtn_MouseEnter(object sender, MouseEventArgs e)
        {
            try
            {
                closeBKRect.Fill.Opacity = 0.7;
            }
            catch (Exception ex)
            {

            }
        }

        private void closebtn_MouseLeave(object sender, MouseEventArgs e)
        {
            try
            {
                closeBKRect.Fill.Opacity = 0.01;
            }
            catch (Exception ex)
            {

            }
        }

        
       
    }
}
