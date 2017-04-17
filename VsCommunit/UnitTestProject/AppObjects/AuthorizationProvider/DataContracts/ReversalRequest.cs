using System;
using System.Runtime.Serialization;

namespace Dlp.Buy4.AuthorizationProvider.Core.Operations
{
    /// <summary>
    /// Contains information for a reversal request.
    /// </summary>
    [DataContract]
    public class ReversalRequest : BaseRequest
    {
        #region Constructors

        /// <summary>
        /// Base constructor.
        /// </summary>
        public ReversalRequest()
        {
            this.Merchant = new MerchantData();
            this.Terminal = new TerminalData();
            this.Transaction = new TransactionData();
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Merchant information
        /// </summary>
        [DataMember]
        public MerchantData Merchant { get; set; }

        /// <summary>
        /// Terminal information
        /// </summary>
        [DataMember]
        public TerminalData Terminal { get; set; }

        /// <summary>
        /// Information of  transaction.
        /// </summary>
        [DataMember]
        public TransactionData Transaction { get; set; }

        public override void Validate()
        {
            throw new NotImplementedException();
        }

        #endregion Properties

        #region Nested types

        [DataContract]
        public class MerchantData
        {
            /// <summary>
            /// Merchant identification.
            /// </summary>
            [DataMember]
            public string MerchantId { get; set; }

            /// <summary>
            /// Merchant type, AKA MCC.
            /// </summary>
            [DataMember]
            public Nullable<int> MerchantCategory { get; set; }

            /// <summary>
            /// CPF or CNPJ of the merchant.
            /// </summary>
            [DataMember]
            public string MerchantTaxId { get; set; }

            /// <summary>
            /// Name of  merchant.
            /// </summary>
            [DataMember]
            public string MerchantName { get; set; }

            /// <summary>
            /// Name of  merchant.
            /// </summary>
            [DataMember]
            public string MerchantCity { get; set; }

            /// <summary>
            /// abreviação do pais usado na mastercard
            /// </summary>
            [DataMember]
            public string MerchantCountryCharCode { get; set; }

            /// <summary>
            /// abreviação do pais usado na visa
            /// </summary>
            [DataMember]
            public string MerchantCountryIsoCode { get; set; }
        }

        [DataContract]
        public class TerminalData
        {
            /// <summary>
            /// Terminal identification.
            /// </summary>
            [DataMember]
            public string TerminalId { get; set; }
        }

        [DataContract]
        public class TransactionData
        {
            public TransactionData()
            {
                this.OriginalTransaction = new OriginalTransactionData();
            }

            #region Properties

            /// <summary>
            /// Information related of Original Transaction.
            /// </summary>
            [DataMember]
            public OriginalTransactionData OriginalTransaction { get; set; }

            /// <summary>
            /// Identification of reversal message.
            /// </summary>
            [DataMember]
            public string InitiatorTransactionKey { get; set; }

            /// <summary>
            /// Reason code for cancellation operation.
            /// </summary>
            [DataMember]
            public string Reason { get; set; }

            #endregion Properties

            #region Nested types

            [DataContract]
            public class OriginalTransactionData
            {
                #region Constructor

                public OriginalTransactionData()
                {
                }

                #endregion Constructor

                #region Properties

                /// <summary>
                /// Transaction amount to revert.
                /// </summary>
                [DataMember]
                public Int64 Amount { get; set; }

                /// <summary>
                /// Identification of original transaction to revert.
                /// </summary>
                [DataMember]
                public string OriginalAquirerTransactionKey { get; set; }

                /// <summary>
                /// Identificador da transação original
                /// </summary>
                [DataMember]
                public string InitiatorTransactionKey { get; set; }

                /// <summary>
                /// Moeda da transação original
                /// </summary>
                [DataMember]
                public int Currency { get; set; }

                #endregion Properties
            }

            #endregion Nested types
        }

        #endregion Nested types
    }
}