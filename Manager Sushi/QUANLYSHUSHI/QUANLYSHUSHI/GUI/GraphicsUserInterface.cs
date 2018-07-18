using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using System.Drawing;
using System.Security.Cryptography;
using System.Net.Mail;
using System.Net;
using System.Threading;

namespace QUANLYSHUSHI.GUI
{
    public class GraphicsUserInterface
    {
        public Thread _th = null;

        private static volatile GraphicsUserInterface _graphicsusers;

        public string MaHoa(string _sMaHoa)
        {
            byte[] _bArray = Encoding.ASCII.GetBytes(_sMaHoa);

            _bArray = MD5.Create().ComputeHash(_bArray);

            string _s = "";

            foreach(byte _b in _bArray)
            {
                _s += _b.ToString("X2") + _b.ToString("X1") + _b.ToString("X0") + _b.ToString("X100");
            }

            int _i = 0;

            List<int> _listInt = new List<int>();

            foreach(char _c in _s)
            {
                if(int.TryParse(_c.ToString(), out _i) == true)
                {
                    _listInt.Add(_i);
                }
            }

            _listInt.Sort();

            _i = 0;

            char[] _cArray = _s.ToCharArray();

            for (int _j = 0; _j < _listInt.Count; _j++)
            {
                char _c = ' ';

                switch(_listInt[_j])
                {
                    case 1:
                        _c = '!';
                        _cArray[_i] = _c;
                        break;
                    case 2:
                        _c = '@';
                        _cArray[_i] = _c;
                        break;
                    case 3:
                        _c = '&';
                        _cArray[_i] = _c;
                        break;
                    case 4:
                        _c = '^';
                        _cArray[_i] = _c;
                        break;
                    case 5:
                        _c = '#';
                        _cArray[_i] = _c;
                        break;
                    case 6:
                        _c = '%';
                        _cArray[_i] = _c;
                        break;
                    case 7:
                        _c = '=';
                        _cArray[_i] = _c;
                        break;
                    case 8:
                        _c = '<';
                        _cArray[_i] = _c;
                        break;
                    case 9:
                        _c = '?';
                        _cArray[_i] = _c;
                        break;
                }
                _i++;
            }

            _s = new string(_cArray);

            _bArray = null;

            return _s;
        }

        public static GraphicsUserInterface GraphicsUsers
        {
            get
            {
                if (_graphicsusers == null)
                {
                    _graphicsusers = new GraphicsUserInterface();
                }

                return _graphicsusers;
            }
        }

        private GraphicsUserInterface() { }

        public bool CloseMessage()
        {
            if (XtraMessageBox.Show("Bạn có chắc chắn muốn thoát ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                return true;
            }

            return false;
        }

        public void PaintPanel(Graphics _g, string _sTitle, int _iX, int _iY, Bitmap _bm = null)
        {
            Font _f = new Font("Times New Roman", 10, FontStyle.Bold | FontStyle.Italic);

            _g.DrawString(_sTitle, _f, Brushes.White, new PointF(_iX, _iY));

            _f.Dispose();

            if(_bm != null)
            {
                _g.DrawImage(_bm, 5, 0, 28, 28);
            }

            _g.Dispose();
        }

        public void PainForm(Graphics _g, int _iX, int _iY, int _iWidth, int _iHeight, Bitmap _bm)
        {
            _g.DrawImage(_bm, _iX, _iY, _iWidth, _iHeight);

            _g.Dispose();

            _bm.Dispose();
        }

        public int NotePassWord(string _sMatKhau)
        {
            int _i = 0;

            if(_sMatKhau.Length < 8)
            {
                return 1;
            }

            string _sHoaDau = _sMatKhau[0].ToString();
            string _sThuongSau = _sMatKhau[1].ToString();

            if(Check.CheckNumber(_sHoaDau) == true)
            {
                return 2;
            }

            if(_sMatKhau[0].ToString().Equals(_sHoaDau.ToUpper()) == false)
            {
               
                return 3;
            }

            if(Check.CheckNumber(_sThuongSau) == true)
            {
                return 4;
            }

            if(_sMatKhau[1].ToString().Equals(_sThuongSau.ToLower()) == false)
            {
                return 5;
            }

            return _i;
        }

        public void SendMail(string _sSubject, string _sBody, params string[] _sArrayEmail)
        {
            try
            {
                _th = new Thread(() =>
                    {
                        MailMessage _mm = null;

                        SmtpClient _sl = null;

                        for (int _i = 0; _i < _sArrayEmail.Length; _i++)
                        {
                            _mm = new MailMessage(EmailUser.User, _sArrayEmail[_i].ToString(), _sSubject, _sBody);

                            _sl = new SmtpClient()
                            {
                                Host = "smtp.gmail.com",

                                Port = 587,

                                EnableSsl = true,

                                Credentials = new NetworkCredential(EmailUser.User, EmailUser.Pass),
                            };

                            _sl.Send(_mm);
                        }
                    }) { IsBackground = true };

                _th.Start();
            }
            catch { }
        }

        public Cursor MouseHand(Bitmap _bm)
        {
            IntPtr _intPtr = _bm.GetHicon();

            return new Cursor(_intPtr);
        }
    }
}
