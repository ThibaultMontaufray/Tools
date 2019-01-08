using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tools.Utilities.UI
{
    public partial class Hexagon : UserControl
    {
        #region Enum
        public enum Color
        {
            GRAY,
            RED,
            ORANGE,
            DARKORANGE,
            YELLOW,
            DARKGREEN,
            GREEN,
            PURPLE
        }
        #endregion

        #region Attributes
        //private const int WS_EX_TRANSPARENT = 0x20;
        //private int opacity = 50;

        protected Color _currentColor;
        #endregion

        #region Properties
        //[DefaultValue(50)]
        //public int Opacity
        //{
        //    get
        //    {
        //        return this.opacity;
        //    }
        //    set
        //    {
        //        if (value < 0 || value > 100)
        //            throw new ArgumentException("value must be between 0 and 100");
        //        this.opacity = value;
        //    }
        //}
        public Color CurrentColor
        {
            get { return _currentColor; }
            set { _currentColor = value; }
        }
        #endregion

        #region Constructor
        public Hexagon()
        {
            //SetStyle(ControlStyles.Opaque, true);
            _currentColor = Color.GRAY;
            InitializeComponent();
        }
        #endregion

        #region Methods public
        #endregion

        #region Methods protected
        protected void UpdateColor()
        {
            this.SuspendLayout();
            //switch (_currentColor)
            //{
                //case Color.RED:
                //    this.BackgroundImage = Properties.Resources.hexagon_red;
                //    break;
                //case Color.ORANGE:
                //    this.BackgroundImage = Properties.Resources.hexagon_orange;
                //    break;
                //case Color.DARKORANGE:
                //    this.BackgroundImage = Properties.Resources.hexagon_darkOrange;
                //    break;
                //case Color.YELLOW:
                //    this.BackgroundImage = Properties.Resources.hexagon_yellow;
                //    break;
                //case Color.DARKGREEN:
                //    this.BackgroundImage = Properties.Resources.hexagon_darkGreen;
                //    break;
                //case Color.GREEN:
                //    this.BackgroundImage = Properties.Resources.hexagon_green;
                //    break;
                //case Color.PURPLE:
                //    this.BackgroundImage = Properties.Resources.hexagon_purple;
                //    break;
                //case Color.GRAY:
                //default:
                //    this.BackgroundImage = Properties.Resources.hexagon_gray;
                //    break;
            //}
            this.ResumeLayout();
        }
        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams cp = base.CreateParams;
        //        cp.ExStyle = cp.ExStyle | WS_EX_TRANSPARENT;
        //        return cp;
        //    }
        //}
        #endregion

        #region Event
        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    using (var brush = new SolidBrush(System.Drawing.Color.FromArgb(this.opacity * 255 / 100, this.BackColor)))
        //    {
        //        e.Graphics.FillRectangle(brush, this.ClientRectangle);
        //    }
        //    base.OnPaint(e);
        //}
        #endregion
    }
}
