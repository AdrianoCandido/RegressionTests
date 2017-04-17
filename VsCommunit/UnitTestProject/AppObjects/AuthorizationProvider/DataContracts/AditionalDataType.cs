using System.Runtime.Serialization;

namespace Dlp.Buy4.AuthorizationProvider.Operations
{
    [DataContract(Namespace = "http://schemas.datacontract.org/2004/07/Dlp.Buy4.AuthorizationProvider.Core.Operations")]
    public enum AditionalDataType
    {
        [EnumMember]
        FinancingType,

        [EnumMember]
        BuyerIDType,

        [EnumMember]
        BuyerID,

        [EnumMember]
        BuyerPhone,

        [EnumMember]
        PurchaseIdentification,

        [EnumMember]
        InstallmentsCycle,

        [EnumMember]
        InterestRate,

        [EnumMember]
        GracePeriod,

        [EnumMember]
        GracePeriodCycle,

        [EnumMember]
        GracePeriodInterestRate,

        [EnumMember]
        ReferenceField1,

        [EnumMember]
        ReferenceField2,

        [EnumMember]
        ReferenceField3
    }
}