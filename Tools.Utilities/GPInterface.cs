using System.Collections.Generic;
using System.Xml.Serialization;

namespace Tools.Utilities
{
    public delegate void InterfaceEventHandler(object o);
    public abstract class GPInterface
    {
        #region Attributes
        public event InterfaceEventHandler SheetDisplayRequested;
        //public event InterfaceEventHandler SheetDisplayRequested;

        protected List<string> listvisiblecomponents = null;
        protected string pathFile;
        protected string extention;
        protected bool openned;
        #endregion

        #region Properties
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
        public GPInterface()
        {
            openned = false;
        }
        ~GPInterface()
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
        #endregion

        #region Methods protected
        public abstract void GoAction(string action);
        #endregion
    }
}
