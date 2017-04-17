using Dlp.Buy4.AuthorizationProvider.Operations;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Dlp.Buy4.AuthorizationProvider.Core.Operations
{
    /// <summary>
    /// Contains information for an authorization request.
    /// </summary>
    [DataContract]
    public class AuthorizationRequest : BaseRequest
    {
        /// <summary>
        /// Base constructor.
        /// </summary>
        public AuthorizationRequest()
        {
            this.Card = new CardData();
            this.Merchant = new MerchantData();
            this.Terminal = new TerminalData();
            this.Terminal.Capabilities = new TerminalData.CapabilityData();
            this.Terminal.Status = new TerminalData.StatusData();
            this.Transaction = new TransactionData();
            this.Acquirer = new AcquirerData();
            this.AditionalService = new AditionalServiceData();
        }

        [DataMember]
        public AditionalServiceData AditionalService { get; set; }

        /// <summary>
        /// Card data.
        /// </summary>
        [DataMember]
        public CardData Card { get; set; }

        [DataMember]
        public bool MastercardAgroService { get; set; }

        /// <summary>
        /// Merchant data.
        /// </summary>
        [DataMember]
        public MerchantData Merchant { get; set; }

        /// <summary>
        /// Terminal data.
        /// </summary>
        [DataMember]
        public TerminalData Terminal { get; set; }

        /// <summary>
        /// Transaction data.
        /// </summary>
        [DataMember]
        public TransactionData Transaction { get; set; }

        public override void Validate() { }

        [DataContract]
        public class AditionalServiceData
        {
            public AditionalServiceData()
            {
                this.AditionalData = new Dictionary<AditionalDataType, string>();
            }

            [DataMember]
            public Dictionary<AditionalDataType, string> AditionalData { get; set; }
        }

        /// <summary>
        /// Contains card information for an authorization request.
        /// </summary>
        [DataContract]
        public class CardData
        {
            /// <summary>
            /// Base constructor.
            /// </summary>
            public CardData() { }

            /// <summary>
            /// Personal account number (PAN).
            /// </summary>
            [DataMember]
            public string CardNumber { get; set; }

            /// <summary>
            /// Expiration date.
            /// </summary>
            [DataMember]
            public string ExpirationDate { get; set; }

            /// <summary>
            /// Cryptogram with encrypted personal identification number (PIN).
            /// </summary>
            [DataMember]
            public string PinData { get; set; }

            /// <summary>
            /// Card sequence number.
            /// </summary>
            [DataMember]
            public string SequenceNumber { get; set; }

            /// <summary>
            /// Validation code printed on the card.
            /// </summary>
            [DataMember]
            public string ValidationCode { get; set; }
        }

        /// <summary>
        /// Contains merchant information for an authorization request.
        /// </summary>
        [DataContract]
        public class MerchantData
        {
            /// <summary>
            /// Base constructor.
            /// </summary>
            public MerchantData() { }

            /// <summary>
            /// Merchant type, AKA MCC.
            /// </summary>
            [DataMember]
            public Nullable<int> MerchantCategory { get; set; }

            /// <summary>
            /// Name of  merchant.
            /// </summary>
            [DataMember]
            public string MerchantCity { get; set; }

            /// <summary>
            /// abreviação do pais usado para mastercard
            /// </summary>
            [DataMember]
            public string MerchantCountryCharCode { get; set; }

            /// <summary>
            /// abreviação do pais usado para visa
            /// </summary>
            [DataMember]
            public string MerchantCountryIsoCode { get; set; }

            /// <summary>
            /// Merchant identification.
            /// </summary>
            [DataMember]
            public string MerchantId { get; set; }

            /// <summary>
            /// Name of  merchant.
            /// </summary>
            [DataMember]
            public string MerchantName { get; set; }

            /// <summary>
            /// Cpf or Cnpj of the merchant.
            /// </summary>
            [DataMember]
            public string MerchantTaxId { get; set; }

            /// <summary>
            /// Numero do cep do lojista.
            /// </summary>
            [DataMember]
            public string ZipCode { get; set; }
        }

        /// <summary>
        /// Contains terminal data for an authorization request.
        /// </summary>
        [DataContract]
        public class TerminalData
        {
            /// <summary>
            /// Base constructor.
            /// </summary>
            public TerminalData()
            {
                Capabilities = new CapabilityData();
                Status = new StatusData();
            }

            /// <summary>
            /// Terminal capabilities.
            /// </summary>
            [DataMember]
            public CapabilityData Capabilities { get; set; }

            /// <summary>
            /// Country code for the terminal.
            /// </summary>
            [DataMember]
            public uint CountryCode { get; set; }

            /// <summary>
            /// Whether terminal features are known.
            /// </summary>
            [DataMember]
            public bool FeaturesAreKnown { get; set; }

            /// <summary>
            /// Whether a terminal is really used or not.
            /// </summary>
            [DataMember]
            public bool IsNotTerminal { get; set; }

            /// <summary>
            /// Terminal status.
            /// </summary>
            [DataMember]
            public StatusData Status { get; set; }

            /// <summary>
            /// Terminal identification.
            /// </summary>
            [DataMember]
            public string TerminalId { get; set; }

            /// <summary>
            /// Contains static characteristics of the terminal.
            /// </summary>
            [DataContract]
            public class CapabilityData
            {
                /// <summary>
                /// Base constructor.
                /// </summary>
                public CapabilityData()
                {
                    MaximumPinLength = 12;  // Default is the maximum permitted.
                }

                /// <summary>
                /// Whether barcode can be read.
                /// </summary>
                [DataMember]
                public bool CanReadBarcode { get; set; }

                /// <summary>
                /// Whether integrated circuit chip (ICC) can be read.
                /// </summary>
                [DataMember]
                public bool CanReadChip { get; set; }

                /// <summary>
                /// Whether contactless chip can be read.
                /// </summary>
                [DataMember]
                public bool CanReadContactless { get; set; }

                /// <summary>
                /// Whether magnetic stripe can be read.
                /// </summary>
                [DataMember]
                public bool CanReadMagStripe { get; set; }

                /// <summary>
                /// Whether card data can be manually entered.
                /// </summary>
                [DataMember]
                public bool CanReadManualEntry { get; set; }

                /// <summary>
                /// Whether personal identification number (PIN) can be read.
                /// </summary>
                [DataMember]
                public bool CanReadPin { get; set; }

                /// <summary>
                /// Whether cardholder signature can be read.
                /// </summary>
                [DataMember]
                public bool CanReadSignature { get; set; }

                /// <summary>
                /// Maximum number of PIN characters that can be accepted.
                /// </summary>
                [DataMember]
                public uint MaximumPinLength { get; set; }

                /// <summary>
                /// Whether the terminal is unattended (i.e. an ATM).
                /// </summary>
                [DataMember]
                public bool Unattended { get; set; }
            }

            /// <summary>
            /// Contains current characteristics of the terminal.
            /// </summary>
            [DataContract]
            public class StatusData
            {
                /// <summary>
                /// Base constructor.
                /// </summary>
                public StatusData() { }

                /// <summary>
                /// Whether the PIN pad is broken.
                /// </summary>
                [DataMember]
                public bool PinPadIsDown { get; set; }
            }
        }

        /// <summary>
        /// Contains transaction information for an authorization request.
        /// </summary>
        [DataContract]
        public class TransactionData
        {
            /// <summary>
            /// Base constructor.
            /// </summary>
            public TransactionData()
            {
                // Set default values.
                CardholderIsPresent = true;
                CardIsPresent = true;
                Currency = 840;             // US dollars.
                Installments = 1;           // No installments.
                IsRecurring = false;
            }

            /// <summary>
            /// Account type for the account the transfer is coming from.
            /// </summary>
            [DataMember]
            public AccountType AccountFrom { get; set; }

            /// <summary>
            /// Account type for the account the transfer is goint to.
            /// </summary>
            [DataMember]
            public AccountType AccountTo { get; set; }

            /// <summary>
            /// Transaction amount to authorize.
            /// </summary>
            [DataMember]
            public Int64 Amount { get; set; }

            /// <summary>
            /// Boarding fee.
            /// </summary>
            [DataMember]
            public uint BoardingFee { get; set; }

            /// <summary>
            /// The way card data was entered.
            /// </summary>
            [DataMember]
            public CardDataEntryMode CardDataEntryMode { get; set; }

            /// <summary>
            /// Whether the cardholder is present at the point of transaction.
            /// </summary>
            [DataMember]
            public bool CardholderIsPresent { get; set; }

            /// <summary>
            /// Whether the card is present at the point of transaction.
            /// </summary>
            [DataMember]
            public bool CardIsPresent { get; set; }

            /// <summary>
            /// Whether the transaction must be completed.
            /// </summary>
            [DataMember]
            public bool CompleteTransaction { get; set; }

            /// <summary>
            /// Currency code for the transaction.
            /// </summary>
            [DataMember]
            public uint Currency { get; set; }

            /// <summary>
            /// Integrated circuit card data read from the card for EMV transactions.
            /// </summary>
            [DataMember]
            public string EmvData { get; set; }

            /// <summary>
            /// Identification of the transaction assigned by the initiating party for the recipient party.
            /// </summary>
            [DataMember]
            public string InitiatorTransactionKey { get; set; }

            /// <summary>
            /// Number of installments.
            /// </summary>
            [DataMember]
            public uint Installments { get; set; }

            /// <summary>
            /// Type of installment.
            /// </summary>
            [DataMember]
            public InstallmentType InstallmentType { get; set; }

            /// <summary>
            /// Key serial number for PIN.
            /// </summary>
            [DataMember]
            public string KsnForPin { get; set; }

            /// <summary>
            /// Track 1 read from the card.
            /// </summary>
            [DataMember]
            public string Track1 { get; set; }

            /// <summary>
            /// Track 2 read from the card.
            /// </summary>
            [DataMember]
            public string Track2 { get; set; }

            /// <summary>
            /// Track 3 read from the card.
            /// </summary>
            [DataMember]
            public string Track3 { get; set; }

            /// <summary>
            /// Date and time at the point of transaction.
            /// </summary>
            [DataMember]
            public DateTime TransactionDateTime { get; set; }

            /// <summary>
            /// Rules the transaction uses.
            /// </summary>
            [DataMember]
            public TransactionRules TransactionRules { get; set; }

            /// <summary>
            /// Indicates whether the transaction is recurring.
            /// </summary>
            [DataMember]
            public bool IsRecurring { get; set; }

            /// <summary>
            /// Whether ICC data is present.
            /// </summary>
            internal bool HasIccData
            {
                get
                {
                    return !string.IsNullOrEmpty(EmvData);
                }
            }

            /// <summary>
            /// Whether any track data is present.
            /// </summary>
            internal bool HasTrackData
            {
                get
                {
                    return !string.IsNullOrEmpty(Track1) || !string.IsNullOrEmpty(Track2) || !string.IsNullOrEmpty(Track3);
                }
            }
        }
    }
}