using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfazInteresesMensualHouston.Modelos
{
    public class NotifyiConData
    {
        public long cbSize { get; set; }
        public long Hwnd { get; set; }
        public long uId { get; set; }
        public long uFlags { get; set; }
        public long uCallBackMessage { get; set; }
        public long hIcon { get; set; }
        public long szTip { get; set; }
        public long dwState { get; set; }
        public long dwStateMask { get; set; }
        public long szInfo { get; set; }
        public long uTimeout { get; set; }
        public long szInfoTitle { get; set; }
        public long dwInfoFlags { get; set; }
    }
}
