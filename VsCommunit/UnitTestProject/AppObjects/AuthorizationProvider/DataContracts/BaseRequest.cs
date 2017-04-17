using System;
using System.Runtime.Serialization;

namespace Dlp.Buy4.AuthorizationProvider.Core.Operations
{
    /// <summary>
    /// Contains basic information for all operations.
    /// </summary>
    [DataContract]
    public abstract class BaseRequest
    {
        #region Constructors

        /// <summary>
        /// Base constructor.
        /// </summary>
        public BaseRequest()
        {
            Acquirer = new AcquirerData();
            Timeout = new TimeSpan();
        }

        #endregion Constructors

        #region Data members

        /// <summary>
        /// Timeout for the operation.
        /// </summary>
        [DataMember]
        public TimeSpan Timeout { get; set; }

        /// <summary>
        /// Unique serial number for the transaction.
        /// </summary>
        [DataMember]
        public UInt64 UniqueSerialNumber { get; set; }

        #endregion Data members

        #region Public properties

        /// <summary>
        /// Acquirer data.
        /// </summary>
        public AcquirerData Acquirer { get; set; }

        /// <summary>
        /// Request ISO 8583 message created after packaging.
        /// </summary>

        #endregion Public properties

        #region Nested types

        /// <summary>
        /// Contains acquire information for an authorization request.
        /// </summary>
        public class AcquirerData
        {
            /// <summary>
            /// Base constructor.
            /// </summary>
            public AcquirerData()
            {
                // Set default values.
                DateTime = System.DateTime.UtcNow;
            }

            /// <summary>
            /// Country code for the acquiring institution.
            /// </summary>
            public Nullable<uint> CountryCode { get; set; }

            /// <summary>
            /// Date and time at the acquire.
            /// </summary>
            public DateTime DateTime { get; set; }

            /// <summary>
            /// Acquire identification in the network.
            /// </summary>
            public string NetworkAcquirerId { get; set; }

            /// <summary>
            /// Forwarding institution identification in the network.
            /// </summary>
            public string NetworkForwardingInstitutionId { get; set; }
        }

        #endregion Nested types

        public abstract void Validate();
    }
}