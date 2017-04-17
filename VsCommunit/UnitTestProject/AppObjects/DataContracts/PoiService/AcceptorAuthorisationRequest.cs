using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Buy4.Services.Sdk.Models.Poi
{
    /// <summary>
    /// Message  sent by an acceptor.
    /// </summary>
    [XmlRoot(ElementName = "Document", Namespace = "urn:AcceptorAuthorisationRequestV02.1", IsNullable = false)]
    public partial class AcceptorAuthorisationRequest
    {
        [XmlElement("AccptrAuthstnReq")]
        public AcceptorAuthorisationRequestData Data { get; set; }

        [XmlRoot(ElementName = "AccptrAuthstnReq")]
        public partial class AcceptorAuthorisationRequestData
        {
            /// <summary>
            /// Authorisation request message management information.
            /// </summary>
            [XmlElement("Hdr")]
            public Header Header { get; set; }

            ///// <summary>
            ///// Information related to the authorisation request.
            ///// </summary>
            [XmlElement("AuthstnReq")]
            public AuthorisationRequestData AuthorisationRequest { get; set; }

            #region Nested Types

            /// <summary>
            /// Information related to the authorisation request.
            /// </summary>
            public partial class AuthorisationRequestData
            {
                /// <summary>
                /// Environment of the transaction
                /// </summary>

                [XmlElement("Envt")]
                public Enviroment Environment { get; set; }

                /// <summary>
                /// Context in which the transaction is performed (payment and sale).
                /// </summary>

                [XmlElement("Cntxt")]
                public ContextData Context { get; set; }

                /// <summary>
                /// Card payment transaction for which the authorisation is requested.

                [XmlElement("Tx")]
                public TransactionData Transaction { get; set; }

                #region Nested types

                /// <summary>
                /// Card payment transaction for which the authorisation is requested.
                /// </summary>
                public partial class TransactionData
                {
                    /// <summary>
                    /// Additional attribute of the service type.
                    /// </summary>
                    [XmlElement("SvcAttr")]
                    public Nullable<ServiceAttribute> ServiceAttribute { get; set; }

                    /// <summary>
                    /// Service in addition to the main service.
                    /// </summary>
                    [XmlElement("AddtlSvc")]
                    public List<AdditionalService> AdditionalService { get; set; }

                    /// <summary>
                    /// Identification of the transaction assigned by the initiating party for the recipient party.
                    /// </summary>

                    [XmlElement("InitrTxId")]
                    public string InitiatorTransactionIdentification { get; set; }

                    /// <summary>
                    /// Flag indicating whether the transaction data must be captured or not in addition to the message process.
                    /// </summary>

                    [XmlElement("TxCaptr")]
                    public string TransactionCapture { get; set; }

                    /// <summary>
                    /// Category code conform to ISO 18245, related to the type of services or goods the
                    ///
                    /// provides for the transaction.
                    /// </summary>

                    [XmlElement("MrchntCtgyCd")]
                    public string MerchantCategoryCode { get; set; }

                    /// <summary>
                    /// Identification of the transaction assigned by the POI (Point Of Interaction).
                    /// </summary>

                    [XmlElement("TxId")]
                    public TransactionIdentificationData TransactionIdentification { get; set; }

                    /// <summary>
                    /// Details of the transaction.
                    /// </summary>

                    [XmlElement("TxDtls")]
                    public TransactionDetailsData TransactionDetails { get; set; }

                    /// <summary>
                    /// Additional information related to the transaction.
                    /// </summary>
                    //
                    //
                    //MaxText(70)
                    [XmlElement("AddtlTxData")]
                    public List<TypeValueData> AdditionalTransactionData { get; set; }

                    public partial class TypeValueData
                    {
                        [XmlElement("DataType")]
                        public string Type { get; set; }

                        [XmlElement("Data")]
                        public string Value { get; set; }
                    }

                    public partial class TransactionDetailsData
                    {
                        #region propertyes

                        /// <summary>
                        /// Currency associated with the transaction.
                        /// </summary>

                        [XmlElement("Ccy")]
                        public string Currency { get; set; }

                        /// <summary>
                        /// Total amount of the transaction.
                        /// </summary>

                        [XmlElement("TtlAmt")]
                        public string TotalAmount { get; set; }

                        /// <summary>
                        /// Type of cardholder account used for the transaction.
                        /// </summary>
                        [XmlElement("AcctTp")]
                        public AccountType AccountType { get; set; }

                        //<summary>
                        //Data related to a financial loan (instalment) or to a recurring transaction.
                        //</summary>
                        [XmlElement("RcrngTx")]
                        public Installment Installment { get; set; }

                        /// <summary>
                        /// Product purchased with the transaction
                        /// </summary>
                        [XmlElement("Pdct")]
                        public List<ProductData> Product { get; set; }

                        /// <summary>
                        /// Data related to an integrated circuit card application
                        /// </summary>

                        [XmlElement("ICCRltdData")]
                        public string ICCRelatedData { get; set; }

                        #endregion

                        /// <summary>
                        /// Product purchased with the transaction.
                        /// </summary>
                        public partial class ProductData
                        {
                            /// <summary>
                            /// Product purchased with the transaction.
                            /// </summary>

                            [XmlElement("PdctCd")]
                            public string ProductCode { get; set; }

                            /// <summary>
                            /// Unit of measure of the item purchased.
                            /// </summary>
                            [XmlElement("UnitOfMeasr")]
                            public string UnitOfMeasure { get; set; }

                            /// <summary>
                            /// Product quantity.
                            /// </summary>

                            [XmlElement("PdctQty")]
                            public float ProductQuantity { get; set; }

                            /// <summary>
                            /// Price per unit of product.
                            /// </summary>

                            [XmlElement("UnitPric")]
                            public float UnitPrice { get; set; }

                            /// <summary>
                            /// Monetary value of purchased product.
                            /// </summary>

                            [XmlElement("PdctAmt")]
                            public float ProductAmount { get; set; }

                            /// <summary>
                            /// Information on tax paid on the product.
                            /// </summary>

                            [XmlElement("TaxTp")]
                            public string TaxType { get; set; }

                            /// <summary>
                            /// Additional information related to the product.
                            /// </summary>

                            [XmlElement("AddtlPdctInf")]
                            public string AdditionalProductInformation { get; set; }
                        }
                    }
                }

                /// <summary>
                /// Data related to a financial loan (instalment) or to a recurring transaction.
                /// </summary>
                public partial class Installment
                {
                    [XmlElement("InstlmtTp")]
                    public InstalmentType InstalmentType { get; set; }

                    /// <summary>
                    /// Total number of instalment payments
                    /// </summary>

                    [XmlElement("TtlNbOfPmts")]
                    public string TotalNumberOfPayments { get; set; }
                }

                /// <summary>
                /// Context in which the transaction is performed (payment and sale).
                /// </summary>

                public partial class ContextData
                {
                    /// <summary>
                    /// Context of the card payment transaction.
                    /// </summary>

                    [XmlElement("PmtCntxt")]
                    public PaymentContextData PaymentContext { get; set; }

                    /// <summary>
                    /// Identification of the sale terminal (electronic cash register) or the sale system.
                    /// </summary>
                    [XmlElement("SaleCntxt")]
                    public SaleContextData SaleContext { get; set; }

                    /// <summary>
                    /// Context of the sale involving the card payment transaction.
                    /// </summary>
                    public partial class SaleContextData
                    {
                        /// <summary>
                        /// Identification of the sale terminal (electronic cash register) or the sale system.
                        /// </summary>

                        [XmlElement("SaleId")]
                        public string SaleIdentification { get; set; }

                        /// <summary>
                        /// Identify a sale transaction assigned by the sale system.
                        /// </summary>

                        [XmlElement("SaleRefNb")]
                        public string SaleReferenceNumber { get; set; }
                    }

                    /// <summary>
                    /// Context of the card payment transaction.
                    /// </summary>
                    [XmlRoot("PmtCntxt")]
                    public partial class PaymentContextData
                    {
                        /// <summary>
                        ///  Indicates whether the transaction has been initiated by a card physically present or not.
                        /// </summary>
                        [XmlElement("CardPres")]
                        public bool CardPresent { get; set; }

                        /// <summary>
                        /// Indicates whether the transaction has been initiated in presence of the cardholder or not.
                        /// </summary>
                        [XmlElement("CrdhldrPres")]
                        public bool CardholderPresent { get; set; }

                        /// <summary>
                        /// On-line or off-line context of the transaction.
                        /// </summary>
                        [XmlElement("OnLineCntxt")]
                        public bool OnLineContext { get; set; }

                        /// <summary>
                        /// Human attendance at the POI location during the transaction.
                        /// </summary>
                        [XmlElement("AttndncCntxt")]
                        public ContextAttendanceCode AttendanceContext { get; set; }

                        /// <summary>
                        ///  Indicates the environment of the transaction.
                        /// </summary>
                        [XmlElement("TxEnvt")]
                        public TransactionEnvironmentCode TransactionEnvironment { get; set; }

                        /// <summary>
                        ///  Identifies the type of the communication channels used by the cardholder to the acceptor system.
                        /// </summary>
                        [XmlElement("TxChanl")]
                        public TransactionChannelCode TransactionChannel { get; set; }

                        /// <summary>
                        /// Indicates whether a message can be sent or not on an attendant display (attendant display present or not)
                        /// </summary>
                        [XmlElement("AttndntMsgCpbl")]
                        public bool AttendantMessageCapable { get; set; }

                        /// <summary>
                        /// Language used to display messages to the attendant.
                        /// </summary>
                        [XmlElement("AttndntLang")]
                        public string AttendantLanguage { get; set; }

                        /// <summary>
                        /// Entry mode of the card data.
                        /// </summary>

                        [XmlElement("CardDataNtryMd")]
                        public PoiCardDataReadingCode CardDataEntryMode { get; set; }

                        /// <summary>
                        /// Indicator of a card entry mode fallback.
                        /// </summary>
                        [XmlElement("FllbckInd")]
                        public bool FallbackIndicator { get; set; }
                    }
                }

                /// <summary>
                /// Identification of the cardholder involved in a transaction.
                /// </summary>
                public partial class Cardholder
                {
                    /// <summary>
                    ///  Identification of the cardholder involved in a transaction.
                    /// </summary>
                    [XmlElement("Id")]
                    public CardHolderIdentification Identification { get; set; }

                    /// <summary>
                    /// Cardholder name associated with the card.
                    /// </summary>
                    [XmlElement("Nm")]
                    public string Name { get; set; }

                    /// <summary>
                    /// Data related to the authentication of the cardholder
                    /// </summary>
                    [XmlElement("Authntcn")]
                    public AuthenticationData Authentication { get; set; }

                    public partial class AuthenticationData
                    {
                        /// <summary>
                        /// Method used to authenticate a cardholder.
                        /// </summary>
                        [XmlElement("AuthntcnMtd")]
                        public AuthenticationMethodCode AuthenticationMethod { get; set; }

                        /// <summary>
                        /// Encrypted personal identification number (PIN) and related information.
                        /// </summary>
                        [XmlElement("CrdhldrOnLinePIN")]
                        public CardholderOnLinePINData CardholderOnLinePIN { get; set; }

                        public partial class CardholderOnLinePINData
                        {
                            /// <summary>
                            /// Encrypted PIN (Personal Identification Number).
                            /// </summary>
                            [XmlElement("NcrptdPINBlck")]
                            public EncryptedPINBlockData EncryptedPINBlock { get; set; }

                            public partial class EncryptedPINBlockData
                            {
                                /// <summary>
                                /// Type of data protection
                                /// </summary>
                                [XmlElement("CnttTp")]
                                public ContentType ContentType { get; set; }

                                /// <summary>
                                /// Data protection by encryption, with a session key.
                                /// </summary>
                                [XmlElement("EnvlpdData")]
                                public EnvelopedDataData EnvelopedData { get; set; }

                                public partial class EnvelopedDataData
                                {
                                    /// <summary>
                                    /// Transport key or key encryption key (KEK) identification for the recipient.
                                    /// </summary>
                                    [XmlElement("Rcpt")]
                                    public RecipientData Recipient { get; set; }

                                    /// <summary>
                                    /// Encrypted data with an encryption key.
                                    /// </summary>
                                    [XmlElement("NcrptdCntt")]
                                    public EncryptedContentData EncryptedContent { get; set; }

                                    public partial class RecipientData
                                    {
                                        [XmlElement("KEK")]
                                        public KEKData KEK { get; set; }

                                        public partial class KEKData
                                        {
                                            /// <summary>
                                            /// Identification of the key encryption key (KEK).
                                            /// </summary>
                                            [XmlElement("KEKId")]
                                            public KEKIdentificationData KEKIdentification { get; set; }

                                            /// <summary>
                                            /// Encryption key using previously distributed symmetric key.
                                            /// </summary>
                                            [XmlElement("NcrptdKey")]
                                            public string EncryptedKey { get; set; }

                                            public partial class KEKIdentificationData
                                            {
                                                /// <summary>
                                                /// Identification used for derivation of a unique key from a master key provided for the data protection.
                                                /// </summary>
                                                [XmlElement("DerivtnId")]
                                                public string DerivationIdentification { get; set; }
                                            }
                                        }
                                    }

                                    public partial class EncryptedContentData
                                    {
                                        /// <summary>
                                        /// Encrypted data with an encryption key
                                        /// </summary>
                                        [XmlElement("NcrptdData")]
                                        public string EncryptedData { get; set; }
                                    }
                                }
                            }
                        }
                    }

                    public class CardHolderIdentification
                    {
                        /// <summary>
                        ///Number assigned by a license authority to a driver's license.
                        /// </summary>
                        [XmlElement("DrvrsLicNb")]
                        public string DriversLicenseNumber { get; set; }

                        /// <summary>
                        ///Number assigned by an agent to identify its customer.
                        /// </summary>
                        [XmlElement("CstmrNb")]
                        public string CustomerNumber { get; set; }

                        /// <summary>
                        ///Number assigned by a social security agency.
                        /// </summary>
                        [XmlElement("SclSctyNb")]
                        public string SocialSecurityNumber { get; set; }

                        /// <summary>
                        ///Number assigned by a social security agency.
                        /// </summary>
                        [XmlElement("AlnRegnNb")]
                        public string AlienRegistrationNumber { get; set; }

                        /// <summary>
                        ///Number assigned by a passport authority to a passport.
                        /// </summary>
                        [XmlElement("PsptNb")]
                        public string PassportNumber { get; set; }

                        /// <summary>
                        ///Number assigned by a tax authority to an entity.
                        /// </summary>
                        [XmlElement("TaxIdNb")]
                        public string TaxIdentificationNumber { get; set; }

                        /// <summary>
                        ///Number assigned by a national authority to an identity card.
                        /// </summary>
                        [XmlElement("IdntyCardNb")]
                        public string IdentityCardNumber { get; set; }

                        /// <summary>
                        ///Number assigned to an employer by a registration authority.
                        /// </summary>
                        [XmlElement("MplyrIdNb")]
                        public string EmployerIdentificationNumber { get; set; }

                        /// <summary>
                        ///Address for electronic mail (e-mail).
                        /// </summary>
                        [XmlElement("EmailAdr")]
                        public string EmailAddress { get; set; }

                        public DateAndPlaceOfBirth DateAndPlaceOfBirth { get; set; }

                        [XmlElement("Othr")]
                        public List<Other> Other { get; set; }
                    }
                }

                /// <summary>
                /// Date and place of birth of a person.
                /// </summary>
                public class DateAndPlaceOfBirth
                {
                    /// <summary>
                    /// Date on which a person is born.
                    /// </summary>
                    public string BirthDate { get; set; }

                    /// <summary>
                    /// Province where a person was born.
                    /// </summary>

                    public string ProviceOfBirth { get; set; }

                    /// <summary>
                    /// City where a person was born.
                    /// </summary>
                    public string CityOfBirth { get; set; }

                    /// <summary>
                    /// Country where a person was born.
                    /// </summary>
                    public string CountryOfBirth { get; set; }
                }

                /// <summary>
                /// Unique identification of a person, as assigned by an institution, using an identification scheme.
                /// </summary>
                public class Other
                {
                    [XmlElement("Id")]
                    public string Identification { get; set; }

                    [XmlElement("IdTp")]
                    public string IdentificationType { get; set; }
                }

                /// <summary>
                /// Environment of the transaction
                /// </summary>
                public partial class Enviroment
                {
                    /// <summary>
                    /// Merchant performing the card payment transaction
                    /// </summary>
                    [XmlElement("Mrchnt")]
                    public MerchantData Merchant { get; set; }

                    [XmlElement("POI")]
                    public Poi Poi { get; set; }

                    /// <summary>
                    /// Payment card performing the transaction.
                    /// </summary>
                    [XmlElement("Card")]
                    public CardData Card { get; set; }

                    /// <summary>
                    /// Cardholder involved in the card payment.
                    /// </summary>
                    [XmlElement("Crdhldr")]
                    public Cardholder Cardholder { get; set; }

                    #region Nested Types

                    /// <summary>
                    /// Merchant performing the card payment transaction
                    /// </summary>
                    public partial class MerchantData
                    {
                        /// <summary>
                        /// Identification of the merchant
                        /// </summary>

                        [XmlElement("Id")]
                        public GenericIdentification Identification { get; set; }

                        /// <summary>
                        /// Name of the merchant as appearing on the receipt.
                        /// </summary>

                        [XmlElement("CmonNm")]
                        public string CommonName { get; set; }

                        /// <summary>
                        /// Location of the merchant where the transaction took place, as appearing on the receipt.
                        /// </summary>

                        [XmlElement("Adr")]
                        public string Address { get; set; }

                        /// <summary>
                        /// Country of the merchant where the transaction took place.
                        /// </summary>

                        [XmlElement("CtryCd")]
                        public string CountryCode { get; set; }
                    }

                    /// <summary>
                    /// Payment card performing the transaction
                    /// </summary>
                    public partial class CardData
                    {
                        /// <summary>
                        /// Sensitive data associated with the card performing the transaction.
                        /// </summary>

                        [XmlElement("PlainCardData")]
                        public PlainCardDataData PlainCardData { get; set; }

                        /// <summary>
                        /// Sensitive data associated with the card performing the transaction.
                        /// </summary>
                        public partial class PlainCardDataData
                        {
                            /// <summary>
                            /// Identify a card inside a set of cards with the same card number (PAN)
                            /// </summary>
                            /// [MinMaxNumericText(2, 3)]
                            [XmlElement("CardSeqNb")]
                            public string CardSequenceNumber { get; set; }

                            /// <summary>
                            /// Primary Account Number (PAN) of the card, or card number.
                            /// </summary>

                            [XmlElement("PAN")]
                            public string PAN { get; set; }

                            /// <summary>
                            /// Expiry date of the card.
                            /// </summary>

                            [XmlElement("XpryDt")]
                            public string ExpiryDate { get; set; }

                            /// <summary>
                            /// Card security code (CSC) associated with the card performing the transaction.
                            /// </summary>
                            [XmlElement("CardSctyCd")]
                            public CardSecurityCodeData CardSecurityCode { get; set; }

                            /// <summary>
                            /// Magnetic track or equivalent payment card data
                            /// </summary>
                            [XmlElement("TrckData")]
                            public List<TrackDataData> TrackData { get; set; }

                            /// <summary>
                            /// Card security code (CSC) associated with the card performing the transaction.
                            /// </summary>
                            public partial class CardSecurityCodeData
                            {
                                /// <summary>
                                /// Card security code (CSC)
                                /// </summary>

                                [XmlElement("CSCVal")]
                                public string CSCValue { get; set; }
                            }

                            public partial class TrackDataData
                            {
                                /// <summary>
                                /// Track number of the card.
                                /// </summary>

                                [XmlElement("TrckNb")]
                                public int TrackNumber { get; set; }

                                /// <summary>
                                /// Card track content or equivalent.
                                /// </summary>

                                [XmlElement("TrckVal")]
                                public string TrackValue { get; set; }
                            }
                        }
                    }

                    #endregion
                }

                #endregion
            }

            /// <summary>
            /// Identification of the transaction assigned by the POI (Point Of Interaction).
            /// </summary>
            public partial class TransactionIdentificationData
            {
                /// <summary>
                /// Local date and time of the transaction assigned by the POI (Point Of Interaction).
                /// </summary>

                [XmlElement("TxDtTm")]
                public string TransactionDateTime { get; set; }

                /// <summary>
                /// Identification of the transaction that has to be unique for a time period.
                /// </summary>

                [XmlElement("TxRef")]
                public string TransactionReference { get; set; }
            }

            #endregion
        }

        public class Poi
        {
            [XmlElement("Id")]
            public GenericIdentification Identification { get; set; }

            [XmlElement("SysNm")]
            public string SystemName { get; set; }

            [XmlElement("Cpblties")]
            public Capabilities Capabilities { get; set; }
        }

        public class Capabilities
        {
            [XmlElement("PrtLineWidth")]
            public int PrintLineWidth { get; set; }
        }
    }
}