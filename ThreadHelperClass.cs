using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceEngineersUnlocker
{
    class ThreadHelperClass
    {
        delegate void SetValueCallback(Form f, ProgressBar ctrl, int value);
        /// <summary>
        /// Set value property of ProgressBar
        /// </summary>
        /// <param name="form">The calling form</param>
        /// <param name="ctrl"></param>
        /// <param name="text"></param>
        public static void SetValue(Form form, ProgressBar ctrl, int value)
        {
            // InvokeRequired required compares the thread ID of the 
            // calling thread to the thread ID of the creating thread. 
            // If these threads are different, it returns true. 
            if (ctrl.InvokeRequired)
            {
                SetValueCallback d = new SetValueCallback(SetValue);
                form.Invoke(d, new object[] { form, ctrl, value });
            }
            else
            {
                ctrl.Value = value;
            }
        }
    }
}
