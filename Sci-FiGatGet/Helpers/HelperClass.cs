using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace Sci_FiGadGet
{
    class HelperClass : Window
    {
       #region Ctor
        
        #endregion  
      
       #region Private Fields

        #endregion

       #region Public Fields

        public static readonly double SystemScreenWidth = System.Windows.SystemParameters.PrimaryScreenWidth;
        public static readonly double SystemScreenHeight = System.Windows.SystemParameters.PrimaryScreenHeight;

        #endregion

       #region Private event CallBack
      
       #endregion

       #region Private Method

       #endregion

       #region Public Methods
        public static void GetGeoLocation()
        {
            
        }
        public static void SetWindowPosition(Window window)
        {
            window.Left = HelperClass.SystemScreenWidth - window.Width;
            window.Top = 0;
        }
        #endregion
    }
}
