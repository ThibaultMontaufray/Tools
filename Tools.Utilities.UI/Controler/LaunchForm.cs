using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tools.Utilities.UI
{
    public static class LaunchForm
    {
        private static IntPtr secondThreadFormHandle;

        const int WM_CLOSE = 0x0010;
        [DllImport("User32.dll")]
        extern static IntPtr PostMessage(IntPtr hWnd, int message, IntPtr wParam, IntPtr lParam);
        
        public static void CreateForm(Form form)
        {
            if (form != null && secondThreadFormHandle == IntPtr.Zero)
            {
                form.HandleCreated += SecondFormHandleCreated;
                form.HandleDestroyed += SecondFormHandleDestroyed;
                form.TopMost = true;
                form.RunInNewThread(false);
                form.TopMost = false;
            }
        }

        private static void SecondFormHandleCreated(object sender, EventArgs e)
        {
            Control second = sender as Control;
            secondThreadFormHandle = second.Handle;
            second.HandleCreated -= SecondFormHandleCreated;
        }

        private static void SecondFormHandleDestroyed(object sender, EventArgs e)
        {
            Control second = sender as Control;
            secondThreadFormHandle = IntPtr.Zero;
            second.HandleDestroyed -= SecondFormHandleDestroyed;
        }
    }

    internal static class FormExtensions
    {
        private static void ApplicationRunProc(object state)
        {
            Application.Run(state as Form);
        }

        public static void RunInNewThread(this Form form, bool isBackground)
        {
            if (form == null)
            {
                Console.WriteLine("Launch form : the form is null");
            }
            else if (form.IsHandleCreated)
            {
                Console.WriteLine("Launch form : the form " + form.Text + " is already running");
                form.TopMost = true;
                form.Visible = true;
                form.TopMost = false;
            }
            else
            {
                Thread thread = new Thread(ApplicationRunProc);
                thread.SetApartmentState(ApartmentState.STA);
                thread.IsBackground = isBackground;
                thread.Start(form);
            }
        }
    }

}
