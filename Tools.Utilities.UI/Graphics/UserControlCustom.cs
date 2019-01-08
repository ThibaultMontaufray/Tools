using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tools.Utilities.UI
{
    public delegate void UserControlCustomEventHandler(object o);
    public class UserControlCustom : UserControl
    {
        #region Attributes
        protected bool _isActive = false;
        protected delegate void RefreshDataDelegate();
        public event UserControlCustomEventHandler ControlClick;
        public event UserControlCustomEventHandler HeightChanged;
        #endregion

        #region Properties
        public bool IsActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }
        #endregion

        #region Constructor
        public UserControlCustom()
        {

        }
        #endregion

        #region Methods public
        public virtual void RefreshData()
        {

        }
        public async void RefreshDataAsync()
        {
            await Task.Run(() => RefreshData());
        }
        public void InvokeRefreshData()
        {
            try
            {
                this.Invoke(new RefreshDataDelegate(RefreshData));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public virtual void ChangeLanguage()
        {

        }
        #endregion

        #region Methods protected
        protected void InitClick()
        {
            this.Click += ActivityPreviewPro_Click;
            foreach (Control item in this.Controls)
            {
                item.Click += ActivityPreviewPro_Click;
                foreach (Control subItem in item.Controls)
                {
                    subItem.Click += ActivityPreviewPro_Click;
                }
            }
        }
        #endregion

        #region Event
        protected void ActivityPreviewPro_Click(object sender, EventArgs e)
        {
            ControlClick?.Invoke(this);
        }
        #endregion
    }
}
