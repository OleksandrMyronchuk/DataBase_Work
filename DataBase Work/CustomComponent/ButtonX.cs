using DataBase_Work.Properties;
using DataBase_Work.Utility;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DataBase_Work.CustomComponent
{
    public class ButtonX : Button
    {
        [Browsable(false)]
        [DefaultValue("")]
        public override string Text
        {
            get { return base.Text; }
            set { base.Text = value; }
        }

        public ButtonX()
        {
            Size = new Size(20, 20);            
            Image = UtilityImage.ResizeImage(Resources.Close, 19, 19);
        }

        protected override void OnCreateControl()
        {
            Text = "";
            base.OnCreateControl();
        }
    }
}
