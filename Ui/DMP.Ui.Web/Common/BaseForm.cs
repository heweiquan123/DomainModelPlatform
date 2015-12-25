﻿using DMP.Infrastructure.Common.Model;
using System.Web.UI;
using System;

namespace DMP.Ui.Web.Common
{
    /// <summary>窗体基类</summary>
    public abstract class BaseForm : Page
    {
        public int SourceTag;
        public int DocumentType;

        public abstract ModelBase ModelInfo { get; }



        protected void Page_Load(object sender, EventArgs e)
        {

        }

    }

    /// <summary>报表窗体</summary>
    public class ReportForm : BaseForm
    { 

        public override ModelBase ModelInfo
        {
            get
            {
                return new ReportModel();
            }
        }
    }
}