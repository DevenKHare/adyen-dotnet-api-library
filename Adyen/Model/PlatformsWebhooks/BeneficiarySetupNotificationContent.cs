/*
* Classic Platforms - Notifications
*
*
* The version of the OpenAPI document: 6
*
* NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
* https://openapi-generator.tech
* Do not edit the class manually.
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Adyen.ApiSerialization.OpenAPIDateConverter;

namespace Adyen.Model.PlatformsWebhooks
{
    /// <summary>
    /// BeneficiarySetupNotificationContent
    /// </summary>
    [DataContract(Name = "BeneficiarySetupNotificationContent")]
    public partial class BeneficiarySetupNotificationContent : IEquatable<BeneficiarySetupNotificationContent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BeneficiarySetupNotificationContent" /> class.
        /// </summary>
        /// <param name="destinationAccountCode">The code of the beneficiary account..</param>
        /// <param name="destinationAccountHolderCode">The code of the beneficiary Account Holder..</param>
        /// <param name="invalidFields">A listing of the invalid fields which have caused the Setup Beneficiary request to fail. If this is empty, the Setup Beneficiary request has succeeded..</param>
        /// <param name="merchantReference">The reference provided by the merchant..</param>
        /// <param name="sourceAccountCode">The code of the benefactor account..</param>
        /// <param name="sourceAccountHolderCode">The code of the benefactor Account Holder..</param>
        /// <param name="transferDate">The date on which the beneficiary was set up and funds transferred from benefactor to beneficiary..</param>
        public BeneficiarySetupNotificationContent(string destinationAccountCode = default(string), string destinationAccountHolderCode = default(string), List<ErrorFieldType> invalidFields = default(List<ErrorFieldType>), string merchantReference = default(string), string sourceAccountCode = default(string), string sourceAccountHolderCode = default(string), DateTime transferDate = default(DateTime))
        {
            this.DestinationAccountCode = destinationAccountCode;
            this.DestinationAccountHolderCode = destinationAccountHolderCode;
            this.InvalidFields = invalidFields;
            this.MerchantReference = merchantReference;
            this.SourceAccountCode = sourceAccountCode;
            this.SourceAccountHolderCode = sourceAccountHolderCode;
            this.TransferDate = transferDate;
        }

        /// <summary>
        /// The code of the beneficiary account.
        /// </summary>
        /// <value>The code of the beneficiary account.</value>
        [DataMember(Name = "destinationAccountCode", EmitDefaultValue = false)]
        public string DestinationAccountCode { get; set; }

        /// <summary>
        /// The code of the beneficiary Account Holder.
        /// </summary>
        /// <value>The code of the beneficiary Account Holder.</value>
        [DataMember(Name = "destinationAccountHolderCode", EmitDefaultValue = false)]
        public string DestinationAccountHolderCode { get; set; }

        /// <summary>
        /// A listing of the invalid fields which have caused the Setup Beneficiary request to fail. If this is empty, the Setup Beneficiary request has succeeded.
        /// </summary>
        /// <value>A listing of the invalid fields which have caused the Setup Beneficiary request to fail. If this is empty, the Setup Beneficiary request has succeeded.</value>
        [DataMember(Name = "invalidFields", EmitDefaultValue = false)]
        public List<ErrorFieldType> InvalidFields { get; set; }

        /// <summary>
        /// The reference provided by the merchant.
        /// </summary>
        /// <value>The reference provided by the merchant.</value>
        [DataMember(Name = "merchantReference", EmitDefaultValue = false)]
        public string MerchantReference { get; set; }

        /// <summary>
        /// The code of the benefactor account.
        /// </summary>
        /// <value>The code of the benefactor account.</value>
        [DataMember(Name = "sourceAccountCode", EmitDefaultValue = false)]
        public string SourceAccountCode { get; set; }

        /// <summary>
        /// The code of the benefactor Account Holder.
        /// </summary>
        /// <value>The code of the benefactor Account Holder.</value>
        [DataMember(Name = "sourceAccountHolderCode", EmitDefaultValue = false)]
        public string SourceAccountHolderCode { get; set; }

        /// <summary>
        /// The date on which the beneficiary was set up and funds transferred from benefactor to beneficiary.
        /// </summary>
        /// <value>The date on which the beneficiary was set up and funds transferred from benefactor to beneficiary.</value>
        [DataMember(Name = "transferDate", EmitDefaultValue = false)]
        public DateTime TransferDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BeneficiarySetupNotificationContent {\n");
            sb.Append("  DestinationAccountCode: ").Append(DestinationAccountCode).Append("\n");
            sb.Append("  DestinationAccountHolderCode: ").Append(DestinationAccountHolderCode).Append("\n");
            sb.Append("  InvalidFields: ").Append(InvalidFields).Append("\n");
            sb.Append("  MerchantReference: ").Append(MerchantReference).Append("\n");
            sb.Append("  SourceAccountCode: ").Append(SourceAccountCode).Append("\n");
            sb.Append("  SourceAccountHolderCode: ").Append(SourceAccountHolderCode).Append("\n");
            sb.Append("  TransferDate: ").Append(TransferDate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as BeneficiarySetupNotificationContent);
        }

        /// <summary>
        /// Returns true if BeneficiarySetupNotificationContent instances are equal
        /// </summary>
        /// <param name="input">Instance of BeneficiarySetupNotificationContent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BeneficiarySetupNotificationContent input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DestinationAccountCode == input.DestinationAccountCode ||
                    (this.DestinationAccountCode != null &&
                    this.DestinationAccountCode.Equals(input.DestinationAccountCode))
                ) && 
                (
                    this.DestinationAccountHolderCode == input.DestinationAccountHolderCode ||
                    (this.DestinationAccountHolderCode != null &&
                    this.DestinationAccountHolderCode.Equals(input.DestinationAccountHolderCode))
                ) && 
                (
                    this.InvalidFields == input.InvalidFields ||
                    this.InvalidFields != null &&
                    input.InvalidFields != null &&
                    this.InvalidFields.SequenceEqual(input.InvalidFields)
                ) && 
                (
                    this.MerchantReference == input.MerchantReference ||
                    (this.MerchantReference != null &&
                    this.MerchantReference.Equals(input.MerchantReference))
                ) && 
                (
                    this.SourceAccountCode == input.SourceAccountCode ||
                    (this.SourceAccountCode != null &&
                    this.SourceAccountCode.Equals(input.SourceAccountCode))
                ) && 
                (
                    this.SourceAccountHolderCode == input.SourceAccountHolderCode ||
                    (this.SourceAccountHolderCode != null &&
                    this.SourceAccountHolderCode.Equals(input.SourceAccountHolderCode))
                ) && 
                (
                    this.TransferDate == input.TransferDate ||
                    (this.TransferDate != null &&
                    this.TransferDate.Equals(input.TransferDate))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.DestinationAccountCode != null)
                {
                    hashCode = (hashCode * 59) + this.DestinationAccountCode.GetHashCode();
                }
                if (this.DestinationAccountHolderCode != null)
                {
                    hashCode = (hashCode * 59) + this.DestinationAccountHolderCode.GetHashCode();
                }
                if (this.InvalidFields != null)
                {
                    hashCode = (hashCode * 59) + this.InvalidFields.GetHashCode();
                }
                if (this.MerchantReference != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantReference.GetHashCode();
                }
                if (this.SourceAccountCode != null)
                {
                    hashCode = (hashCode * 59) + this.SourceAccountCode.GetHashCode();
                }
                if (this.SourceAccountHolderCode != null)
                {
                    hashCode = (hashCode * 59) + this.SourceAccountHolderCode.GetHashCode();
                }
                if (this.TransferDate != null)
                {
                    hashCode = (hashCode * 59) + this.TransferDate.GetHashCode();
                }
                return hashCode;
            }
        }
        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
