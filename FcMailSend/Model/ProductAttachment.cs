using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace FcMailSend
{
    public enum AttachmentType
    {
        磁盘路径 = 0,
        FTP = 1
    }

    public class ProductAttachment
    {
        private int _productID;
        private AttachmentType _type;
        private string _path;
        private int? _ftpID;


        public int ProductID
        {
            get { return _productID; }
        }

        public AttachmentType Type
        {
            get { return _type; }
        }

        public string Path
        {
            get { return _path; }
        }

        public int? FtpID
        {
            get { return _ftpID; }
        }


        public ProductAttachment(int productID, AttachmentType type, string path, int? ftpID)
        {
            _productID = productID;
            _type = type;
            _path = path;
            _ftpID = ftpID;
        }

    }
}
