/*
 * Crée par SharpDevelop.
 * Utilisateur: C357555
 * Date: 05/08/2011
 * Heure: 18:27
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Threading.Tasks;

namespace Tools.Utilities.UI
{
    /// <summary>
    /// Description of Manager.
    /// </summary>
    public delegate void InterfaceEventHandler(object o);
    public abstract class GPInterfaceUI
	{
        #region Attributes
        public event InterfaceEventHandler SheetDisplayRequested;
        //public event InterfaceEventHandler SheetDisplayRequested;

        protected List<string> listvisiblecomponents = null;	
		protected string pathFile;
		protected string extention;
        protected bool openned;
        protected PanelScrollableCustom _sheet;
        protected TSM _tsm;
        #endregion

        #region Properties
        [XmlIgnore]
        public PanelScrollableCustom Sheet
        {
            get { return _sheet; }
            set { _sheet = value; }
        }
        [XmlIgnore]
        public string PathFile
        {
            get { return pathFile; }
            set { pathFile = value; }
        }
        [XmlIgnore]
        public string Extention
		{
			get { return extention; }
			set { extention = value; }
        }
        [XmlIgnore]
        public virtual bool Openned
		{
			get { return openned; }
			set { openned = value; }
        }
        [XmlIgnore]
        public virtual List<string> Listvisiblecomponents
		{
			get { return listvisiblecomponents; }
		}
		#endregion
		
		#region Constructor / Destructor
		public GPInterfaceUI()
		{
			openned = false;
		}
		~GPInterfaceUI()
		{
			
		}
		#endregion
		
		#region Methods public
        public virtual bool Open(object obj)
        {
            return false;
        }
        public virtual void Print()
		{
			
		}
		public virtual bool Save()
		{
			return false;
		}
		public virtual bool Save(object s)
		{
			return false;
		}
		public virtual void Close()
		{
			
		}
		public virtual void ZoomIn()
		{
			
		}
		public virtual void ZoomOut()
		{
			
		}
		public virtual void Copy()
		{
			
		}
		public virtual void Cut()
		{			
			
		}
		public virtual void Paste()
		{
			
		}
        /// <summary>
        /// Refresh position of all contol named "CurrentView"
        /// </summary>
		public void Resize()
        {
            if (_sheet != null)
            {
                foreach (Control ctrl in _sheet.Controls)
                {
                    if (ctrl.Name.Equals("CurrentView"))
                    {
                        ctrl.Left = (_sheet.Width / 2) - (ctrl.Width / 2);
                    }
                }
            }
        }
        public void Refresh()
        {
            if (_tsm != null) { _tsm.RefreshData(this); }
        }
        public void RefreshData()
        {
            if (_sheet != null)
            {
                foreach (Control ctrl in _sheet.Controls)
                {
                    if (ctrl.Name.Equals("CurrentView"))
                    {
                        ((UserControlCustom)ctrl).RefreshData();
                    }
                }
            }
        }
        public async void RefreshDataAsync()
        {
            await Task.Run(() => RefreshData());
        }
        public void InvokeRefreshData()
        {
            if (_sheet != null)
            {
                foreach (Control ctrl in _sheet.Controls)
                {
                    if (ctrl.Name.Equals("CurrentView"))
                    {
                        ((UserControlCustom)ctrl).InvokeRefreshData();
                    }
                }
            }
        }
        public void GlobalAction(object sender, EventArgs e)
        {
            ToolBarEventArgs tbea = e as ToolBarEventArgs;
            string action = tbea.EventText;
            GoAction(action);
        }
        #endregion

        #region Methods protected
        public abstract void GoAction(string action);
        protected void LaunchSheet(UserControlCustom control, bool fullSize = false, int offset = 150)
        {
            if (_sheet != null)
            {
                _sheet.Controls.Clear();
                if (control != null)
                { 
                    control.Top = offset;
                    if (fullSize)
                    {
                        control.Top -= 20;
                        control.Left = 4;
                        control.Height = _sheet.Height - offset + 16;
                        control.Width = _sheet.Width - 8;
                        control.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right) | System.Windows.Forms.AnchorStyles.Bottom)));
                        control.Name = "CurrentViewFull";
                        _sheet.BackColor = System.Drawing.Color.Black;
                        _sheet.BackgroundImage = null;
                    }
                    else
                    {
                        control.Left = (_sheet.Width / 2) - (control.Width / 2);
                        control.Name = "CurrentView";
                        _sheet.BackColor = System.Drawing.Color.Black;
                        _sheet.BackgroundImage = Properties.Resources.ShieldTileBg;
                        _sheet.BackgroundImageLayout = ImageLayout.Tile;
                    }
                    control.ChangeLanguage();
                    control.RefreshData();
                    control.Refresh();

                    _sheet.Controls.Add(control);
                }
                SheetDisplayRequested?.Invoke(null);
            }
        }
        #endregion
    }
}
