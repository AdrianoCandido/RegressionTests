namespace Buy4.Services.Sdk.Models.Poi
{
    public enum ServiceAttribute
    {
        /// <summary>
        /// Initial reservation.
        /// </summary>
        IRES,

        /// <summary>
        /// Update reservation.
        /// </summary>
        URES,

        /// <summary>
        /// Payment reservation.
        /// </summary>
        PRES,

        /// <summary>
        /// AdditionalPayment.
        /// </summary>
        ARES,

        /// <summary>
        /// First recurring.
        /// </summary>
        FREC,

        /// <summary>
        /// Following recurring.
        /// </summary>
        RREC
    }
}