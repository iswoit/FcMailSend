using System;
using System.Collections.Generic;
using System.Text;

namespace FcMailSend
{
    /// <summary>
    /// 发送附件时的临时对象
    /// </summary>
    public class ProductAttachmentTmp
    {
        private string _displayPath;
        private string _actualPath;
        private bool _isExist;



        public string DisplayPath
        {
            get { return _displayPath; }
        }

        public string ActualPath
        {
            get { return _actualPath; }
        }

        public bool IsExist
        {
            get { return _isExist; }
            set { _isExist = value; }
        }


        public ProductAttachmentTmp(string displayPath, string actualPath, bool isExist)
        {
            _displayPath = displayPath;
            _actualPath = actualPath;
            _isExist = isExist;
        }

    }
}
