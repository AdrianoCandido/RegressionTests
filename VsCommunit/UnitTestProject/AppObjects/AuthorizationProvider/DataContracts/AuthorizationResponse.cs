using System;
using System.Runtime.Serialization;

namespace Dlp.Buy4.AuthorizationProvider.Core.Operations
{
    /// <summary>
    /// Contains response information for an authorization request.
    /// </summary>
    [DataContract]
    public class AuthorizationResponse : BaseResponse
    {
        #region Constructors

        /// <summary>
        /// Base constructor.
        /// </summary>
        public AuthorizationResponse() { }

        #endregion Constructors

        #region Public properties

        /// <summary>
        /// Date and time of the transaction for the acquirer.
        /// </summary>
        [DataMember]
        public DateTime AcquirerDateTime { get; set; }

        /// <summary>
        /// Transaction identification returned by the acquirer for the request.
        /// </summary>
        [DataMember]
        public string AquirerTransactionKey { get; set; }

        /// <summary>
        /// Authorized amount, in cents.
        /// </summary>
        [DataMember]
        public Int64 AmountAuthorized { get; set; }

        /// <summary>
        /// Original amount when the authorization was only partial.
        /// </summary>
        [DataMember]
        public Nullable<Int64> AmountOriginal { get; set; }

        /// <summary>
        /// Authorization identification key code returned by the issuer for the request.
        /// </summary>
        [DataMember]
        public string AuthorizationId { get; set; }

        /// <summary>
        /// Integrated circuit card data returned from issuer for EMV transactions.
        /// </summary>
        [DataMember]
        public string IccRelatedData { get; set; }

        /// <summary>
        /// Whether the amount authorized was only partial.
        /// </summary>
        [DataMember]
        public bool IsPartial { get; set; }

        /// <summary>
        /// Raw response code returned by the issuer.
        /// </summary>
        [DataMember]
        public string ActionCode { get; set; }

        /// <summary>
        /// Balance of the account, related to the payment.
        /// </summary>
        [DataMember]
        public Nullable<long> BalanceAmount { get; set; }

        /// <summary>
        /// Payment scheme number, id on database.
        /// </summary>
        [DataMember]
        public Nullable<int> PaymentSchemeId { get; set; }

        #endregion Public properties
    }
}