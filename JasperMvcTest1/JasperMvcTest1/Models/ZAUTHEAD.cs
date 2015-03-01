using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace JasperMvcTest1.Models
{
    public class ZAUTHEAD : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public String zautyp { get; set; }
        public String zrolln { get; set; }
        public String zwrkun { get; set; }
        public String zwrkti { get; set; }
        public String rgtm { get; set; }
        public String rgdt { get; set; }
        public String zcurln { get; set; }
        public String zpurcn { get; set; }
        public String zausts { get; set; }
        public String itds { get; set; }
        public String sunm { get; set; }
        public String sino { get; set; }
        public String puno { get; set; }
        public String plpn { get; set; }
        public String zprvrn { get; set; }
        public String conm { get; set; }
       

        private void RaisePropertyChanged(string propertyName)
        {
            // take a copy to prevent thread issues
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

      

    }
}
