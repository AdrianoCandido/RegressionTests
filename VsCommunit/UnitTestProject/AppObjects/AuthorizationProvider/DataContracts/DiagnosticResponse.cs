using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Dlp.Buy4.AuthorizationProvider.Core.Models
{
    [DataContract]
    public class DiagnosticResponse
    {
        public DiagnosticResponse()
        {
            this.ChannelReportList = new List<ChannelReportData>();
        }

        /// <summary>
        /// Name of Machine
        /// </summary>
        [DataMember]
        public string MachineName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [DataMember]
        public string AppVersion { get; set; }

        /// <summary>
        /// List of Report of Channels
        /// </summary>
        [DataMember]
        public List<ChannelReportData> ChannelReportList { get; set; }

        [DataContract]
        public class ChannelReportData
        {
            public ChannelReportData()
            {
            }

            /// <summary>
            /// Name of Channel
            /// </summary>
            [DataMember]
            public string ChannelName { get; set; }

            /// <summary>
            /// Description of Channel State
            /// </summary>
            [DataMember]
            public string ChannelState { get; set; }

            /// <summary>
            /// DateTime of channel is Created
            /// </summary>
            [DataMember]
            public DateTime CreatedDateTime { get; set; }

            /// <summary>
            /// Date Of Last Channel Conection
            /// </summary>
            [DataMember]
            public Nullable<DateTime> LastConnectionDateTime { get; set; }

            /// <summary>
            /// Number of Reconnections
            /// </summary>
            [DataMember]
            public int ConnectionCount { get; set; }

            /// <summary>
            /// Adress of to connect
            /// </summary>
            [DataMember]
            public string RemoteIpAdress { get; set; }

            /// <summary>
            /// Remote PortTo connect
            /// </summary>
            [DataMember]
            public int Port { get; set; }
        }
    }
}