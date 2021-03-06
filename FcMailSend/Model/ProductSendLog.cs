﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FcMailSend
{
    public class ProductSendLog
    {
        private int _id;
        private int _productID;
        private string _productName;
        private DateTime _productDate;
        private bool _isSendOK;
        private string _note;
        private DateTime _opTime;


        public int ID
        {
            get { return _id; }
        }
        public int ProductID
        {
            get { return _productID; }
        }
        public string ProductName
        {
            get { return _productName; }
        }
        public DateTime ProductDate
        {
            get { return _productDate; }
        }
        public bool IsSendOK
        {
            get { return _isSendOK; }
        }
        public string Note
        {
            get { return _note; }
        }
        public DateTime OpTime
        {
            get { return _opTime; }
        }


        public ProductSendLog(int id, int productID,string productName, DateTime productDate, bool isSendOK, string note, DateTime opTime)
        {
            _id = id;
            _productID = productID;
            _productName = productName;
            _productDate = productDate;
            _isSendOK = isSendOK;
            _note = note;
            _opTime = opTime;
        }
    }
}
