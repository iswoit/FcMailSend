using System;
using System.Collections.Generic;
using System.Text;

namespace FcMailSend
{
    public class UserState
    {
        private bool _hasError;         // 是否有异常
        private string _errMsg;     // 异常信息

        public UserState(bool hasError, string errMsg)
        {
            _hasError = hasError;
            _errMsg = errMsg;
        }

        public bool HasError
        {
            get { return _hasError; }
        }

        public string ErrorMsg
        {
            get
            {
                if (_hasError == false)
                    return string.Empty;
                else
                    return _errMsg;
            }
        }
    }
}
