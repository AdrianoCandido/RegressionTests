using Buy4.Services.Sdk.Models.Poi;
using System;
using System.Collections.Generic;
using UnitTestProject1.AppObjects.DataContracts;

namespace PoiServiceRegressionTests.AppObjects.DataContracts.PoiService
{
    /// <summary>
    /// Factory class to request classes.
    /// </summary>
    public class RequestFactory
    {
        public static AcceptorAuthorisationRequest CreateAuthorizationRequest(SimpleAuthorizationRequest request)
        {
            AcceptorAuthorisationRequest acceptorRequest = new AcceptorAuthorisationRequest();

            acceptorRequest.Data = new AcceptorAuthorisationRequest.AcceptorAuthorisationRequestData();
            acceptorRequest.Data.Header = new Header();
            acceptorRequest.Data.Header.MessageFunction = MessageFunctionCode.AuthorisationRequest;
            acceptorRequest.Data.Header.ProtocolVersion = "2.0";

            acceptorRequest.Data.AuthorisationRequest = new AcceptorAuthorisationRequest.AcceptorAuthorisationRequestData.AuthorisationRequestData();
            acceptorRequest.Data.AuthorisationRequest.Environment = new AcceptorAuthorisationRequest.AcceptorAuthorisationRequestData.AuthorisationRequestData.Enviroment();
            acceptorRequest.Data.AuthorisationRequest.Context = new AcceptorAuthorisationRequest.AcceptorAuthorisationRequestData.AuthorisationRequestData.ContextData();
            acceptorRequest.Data.AuthorisationRequest.Transaction = new AcceptorAuthorisationRequest.AcceptorAuthorisationRequestData.AuthorisationRequestData.TransactionData();

            var rq = acceptorRequest.Data.AuthorisationRequest;
            var envt = acceptorRequest.Data.AuthorisationRequest.Environment;
            var ctx = acceptorRequest.Data.AuthorisationRequest.Context;
            var tx = acceptorRequest.Data.AuthorisationRequest.Transaction;

            envt.Merchant = new AcceptorAuthorisationRequest.AcceptorAuthorisationRequestData.AuthorisationRequestData.Enviroment.MerchantData();
            envt.Merchant.Identification = new GenericIdentification();
            envt.Merchant.Identification.Identification = request.SaleAffiliationKey;
            envt.Merchant.Identification.ShortName = request.SoftDescriptor;

            envt.Card = new AcceptorAuthorisationRequest.AcceptorAuthorisationRequestData.AuthorisationRequestData.Enviroment.CardData();
            envt.Card.PlainCardData = new AcceptorAuthorisationRequest.AcceptorAuthorisationRequestData.AuthorisationRequestData.Enviroment.CardData.PlainCardDataData();
            envt.Card.PlainCardData.PAN = request.CardNumber;
            envt.Card.PlainCardData.ExpiryDate = request.ExpirationDate;

            if (string.IsNullOrEmpty(request.Track1) == false)
            {
                envt.Card.PlainCardData.TrackData = new List<AcceptorAuthorisationRequest.AcceptorAuthorisationRequestData.AuthorisationRequestData.Enviroment.CardData.PlainCardDataData.TrackDataData>();
                var track = new AcceptorAuthorisationRequest.AcceptorAuthorisationRequestData.AuthorisationRequestData.Enviroment.CardData.PlainCardDataData.TrackDataData();
                track.TrackNumber = 1;
                track.TrackValue = request.Track1;
                envt.Card.PlainCardData.TrackData.Add(track);
            }

            if (string.IsNullOrEmpty(request.Track2) == false)
            {
                envt.Card.PlainCardData.TrackData = envt.Card.PlainCardData.TrackData ?? new List<AcceptorAuthorisationRequest.AcceptorAuthorisationRequestData.AuthorisationRequestData.Enviroment.CardData.PlainCardDataData.TrackDataData>();
                var track = new AcceptorAuthorisationRequest.AcceptorAuthorisationRequestData.AuthorisationRequestData.Enviroment.CardData.PlainCardDataData.TrackDataData();
                track.TrackNumber = 2;
                track.TrackValue = request.Track2;
                envt.Card.PlainCardData.TrackData.Add(track);
            }

            envt.Cardholder = new AcceptorAuthorisationRequest.AcceptorAuthorisationRequestData.AuthorisationRequestData.Cardholder();
            envt.Cardholder.Authentication = new AcceptorAuthorisationRequest.AcceptorAuthorisationRequestData.AuthorisationRequestData.Cardholder.AuthenticationData();

            if (string.IsNullOrEmpty(request.EncryptedPinData) == false)
            {
                envt.Cardholder.Authentication.AuthenticationMethod = AuthenticationMethodCode.OnLinePIN;
                envt.Cardholder.Authentication.CardholderOnLinePIN = new AcceptorAuthorisationRequest.AcceptorAuthorisationRequestData.AuthorisationRequestData.Cardholder.AuthenticationData.CardholderOnLinePINData();
                envt.Cardholder.Authentication.CardholderOnLinePIN.EncryptedPINBlock = new AcceptorAuthorisationRequest.AcceptorAuthorisationRequestData.AuthorisationRequestData.Cardholder.AuthenticationData.CardholderOnLinePINData.EncryptedPINBlockData();
                envt.Cardholder.Authentication.CardholderOnLinePIN.EncryptedPINBlock.ContentType = ContentType.EncryptedData;
                envt.Cardholder.Authentication.CardholderOnLinePIN.EncryptedPINBlock.EnvelopedData = new AcceptorAuthorisationRequest.AcceptorAuthorisationRequestData.AuthorisationRequestData.Cardholder.AuthenticationData.CardholderOnLinePINData.EncryptedPINBlockData.EnvelopedDataData();
                envt.Cardholder.Authentication.CardholderOnLinePIN.EncryptedPINBlock.EnvelopedData.Recipient = new AcceptorAuthorisationRequest.AcceptorAuthorisationRequestData.AuthorisationRequestData.Cardholder.AuthenticationData.CardholderOnLinePINData.EncryptedPINBlockData.EnvelopedDataData.RecipientData();
                envt.Cardholder.Authentication.CardholderOnLinePIN.EncryptedPINBlock.EnvelopedData.Recipient.KEK = new AcceptorAuthorisationRequest.AcceptorAuthorisationRequestData.AuthorisationRequestData.Cardholder.AuthenticationData.CardholderOnLinePINData.EncryptedPINBlockData.EnvelopedDataData.RecipientData.KEKData();
                envt.Cardholder.Authentication.CardholderOnLinePIN.EncryptedPINBlock.EnvelopedData.Recipient.KEK.EncryptedKey = request.KeySerialNumber.Substring(10, 10);
                envt.Cardholder.Authentication.CardholderOnLinePIN.EncryptedPINBlock.EnvelopedData.Recipient.KEK.KEKIdentification = new AcceptorAuthorisationRequest.AcceptorAuthorisationRequestData.AuthorisationRequestData.Cardholder.AuthenticationData.CardholderOnLinePINData.EncryptedPINBlockData.EnvelopedDataData.RecipientData.KEKData.KEKIdentificationData();
                envt.Cardholder.Authentication.CardholderOnLinePIN.EncryptedPINBlock.EnvelopedData.Recipient.KEK.KEKIdentification.DerivationIdentification = request.KeySerialNumber.Substring(0, 10);
                envt.Cardholder.Authentication.CardholderOnLinePIN.EncryptedPINBlock.EnvelopedData.EncryptedContent = new AcceptorAuthorisationRequest.AcceptorAuthorisationRequestData.AuthorisationRequestData.Cardholder.AuthenticationData.CardholderOnLinePINData.EncryptedPINBlockData.EnvelopedDataData.EncryptedContentData();
                envt.Cardholder.Authentication.CardholderOnLinePIN.EncryptedPINBlock.EnvelopedData.EncryptedContent.EncryptedData = request.EncryptedPinData;
            }

            ctx.PaymentContext = new AcceptorAuthorisationRequest.AcceptorAuthorisationRequestData.AuthorisationRequestData.ContextData.PaymentContextData();

            if (request.EntryMode == CardDataEntryMode.Ecommerce)
            {
                ctx.PaymentContext.TransactionEnvironment = TransactionEnvironmentCode.Merchant;
                ctx.PaymentContext.TransactionChannel = TransactionChannelCode.ElectronicCommerce;
            }
            else if (request.EntryMode == CardDataEntryMode.Chip)
            {
                ctx.PaymentContext.CardDataEntryMode = PoiCardDataReadingCode.ICC;
            }
            else if (request.EntryMode == CardDataEntryMode.Magnetic)
            {
                ctx.PaymentContext.CardDataEntryMode = PoiCardDataReadingCode.MagneticStripe;
            }
            else if (request.EntryMode == CardDataEntryMode.ContactLess)
            {
                ctx.PaymentContext.CardDataEntryMode = PoiCardDataReadingCode.ProximityReader;
            }

            tx.TransactionCapture = request.TransactionCapture.ToString();
            tx.TransactionIdentification = new AcceptorAuthorisationRequest.AcceptorAuthorisationRequestData.TransactionIdentificationData();
            tx.TransactionIdentification.TransactionDateTime = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
            tx.TransactionIdentification.TransactionReference = request.InitiatorTransactionkey;
            tx.TransactionDetails = new AcceptorAuthorisationRequest.AcceptorAuthorisationRequestData.AuthorisationRequestData.TransactionData.TransactionDetailsData();

            tx.MerchantCategoryCode = request.Mcc?.ToString();
            tx.TransactionDetails.AccountType = request.AccountType;

            tx.TransactionDetails.Currency = "986";
            tx.TransactionDetails.TotalAmount = request.AmountInCents.ToString();
            tx.TransactionDetails.ICCRelatedData = request.EmvData;
            tx.TransactionDetails.Installment = new AcceptorAuthorisationRequest.AcceptorAuthorisationRequestData.AuthorisationRequestData.Installment();

            tx.TransactionDetails.Installment.InstalmentType = request.Installment;

            tx.TransactionDetails.Installment.TotalNumberOfPayments = request.InstalmentQuantity.ToString();
            return acceptorRequest;
        }

        public static SimpleAuthorizationResponse CreateAuthorizationResponse(AcceptorAuthorisationResponse response)
        {
            if (response == null)
            {
                return null;
            }

            SimpleAuthorizationResponse sResponse = new SimpleAuthorizationResponse();

            sResponse.AccountType = response.Data.AuthorisationResponse.Transaction.TransactionDetails.AccountType.ToString();
            sResponse.AuthorisationCode = response.Data.AuthorisationResponse.TransactionResponse.AuthorisationResult.AuthorisationCode;
            sResponse.CompletionRequired = response.Data.AuthorisationResponse.TransactionResponse.AuthorisationResult.CompletionRequired;
            sResponse.ICCRltdData = response.Data.AuthorisationResponse.Transaction.TransactionDetails.ICCRelatedData;
            sResponse.RecipientTransactionIdentification = response.Data.AuthorisationResponse.Transaction.RecipientTransactionIdentification;
            sResponse.Response = response.Data.AuthorisationResponse.TransactionResponse.AuthorisationResult.ResponseToAuthorisation.Response.ToString();
            sResponse.ResponseReason = response.Data.AuthorisationResponse.TransactionResponse.AuthorisationResult.ResponseToAuthorisation.ResponseReason.ToString();
            sResponse.TransactionReference = response.Data.AuthorisationResponse.Transaction.TransactionIdentification.TransactionReference;
            sResponse.TransactionDateTime = response.Data.AuthorisationResponse.Transaction.TransactionIdentification.TransactionDateTime;

            return sResponse;
        }

        public static AcceptorCompletionAdvice CreateCompletionAdvice(SimpleCompletionAdvice request)
        {
            AcceptorCompletionAdvice r = new AcceptorCompletionAdvice();
            r.Data = new AcceptorCompletionAdvice.AcceptorCompletionAdviceData();
            r.Data.CompletionAdvice = new AcceptorCompletionAdvice.CompletionAdvice();
            r.Data.CompletionAdvice.Environment = new AcceptorCompletionAdvice.Environment();
            r.Data.CompletionAdvice.Environment.Merchant = new AcceptorCompletionAdvice.Merchant();
            r.Data.CompletionAdvice.Transaction = new AcceptorCompletionAdvice.Transaction();
            r.Data.CompletionAdvice.Transaction.OriginalTransaction = new AcceptorCompletionAdvice.OriginalTransaction();
            r.Data.CompletionAdvice.Transaction.OriginalTransaction.InitiatorTransactionIdentification = request.InitiatorTransactionKey;
            r.Data.CompletionAdvice.Transaction.OriginalTransaction.RecipientTransactionIdentification = request.AcquirerTransactionKey;
            r.Data.CompletionAdvice.Transaction.TransactionIdentification = new AcceptorCompletionAdvice.TransactionIdentificationData();
            r.Data.CompletionAdvice.Transaction.TransactionIdentification.TransactionDateTime = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ss");
            r.Data.CompletionAdvice.Transaction.TransactionIdentification.TransactionReference = request.InitiatorTransactionKey;
            r.Data.CompletionAdvice.Transaction.TransactionDetails.Currency = "986";
            r.Data.CompletionAdvice.Transaction.TransactionDetails.TotalAmount = request.Amount.ToString();
            r.Data.Header = new Header();
            r.Data.Header.MessageFunction = MessageFunctionCode.CompletionAdvice;
            r.Data.Header.ProtocolVersion = "2.0";

            return r;
        }

        public static SimpleCompletionAdviceResponse CreateCompletionResponse(AcceptorCompletionAdviceResponse response)
        {
            SimpleCompletionAdviceResponse simpleResponse = new SimpleCompletionAdviceResponse();
            simpleResponse.Completed = response.Data.CompletionAdviceResponse.Transaction.Response == ResponseCode.Approved;

            return simpleResponse;
        }
    }
}