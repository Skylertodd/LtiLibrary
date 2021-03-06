﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace LtiLibrary.NetCore.Lti.v1
{
    
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlRoot("resultScore", Namespace = "http://www.imsglobal.org/services/ltiv1p1/xsd/imsoms_v1p0", IsNullable = false)]
    public partial class LtiReponseType
    {

        private string ltiLaunchUrlField;

        /// <remarks/>
        public string ltiLaunchUrl
        {
            get
            {
                return this.ltiLaunchUrlField;
            }
            set
            {
                this.ltiLaunchUrlField = value;
            }
        }
    }

    
    public partial class ResultType
    {
        private LtiReponseType resultDataField;        

        /// <remarks/>
        public LtiReponseType resultData
        {
            get
            {
                return this.resultDataField;
            }
            set
            {
                this.resultDataField = value;
            }
        }
    }
}
