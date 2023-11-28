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
    /// CompensateNegativeBalanceNotificationContent
    /// </summary>
    [DataContract(Name = "CompensateNegativeBalanceNotificationContent")]
    public partial class CompensateNegativeBalanceNotificationContent : IEquatable<CompensateNegativeBalanceNotificationContent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompensateNegativeBalanceNotificationContent" /> class.
        /// </summary>
        /// <param name="records">A list of the negative balances compensated..</param>
        public CompensateNegativeBalanceNotificationContent(List<CompensateNegativeBalanceNotificationRecord> records = default(List<CompensateNegativeBalanceNotificationRecord>))
        {
            this.Records = records;
        }

        /// <summary>
        /// A list of the negative balances compensated.
        /// </summary>
        /// <value>A list of the negative balances compensated.</value>
        [DataMember(Name = "records", EmitDefaultValue = false)]
        public List<CompensateNegativeBalanceNotificationRecord> Records { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CompensateNegativeBalanceNotificationContent {\n");
            sb.Append("  Records: ").Append(Records).Append("\n");
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
            return this.Equals(input as CompensateNegativeBalanceNotificationContent);
        }

        /// <summary>
        /// Returns true if CompensateNegativeBalanceNotificationContent instances are equal
        /// </summary>
        /// <param name="input">Instance of CompensateNegativeBalanceNotificationContent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompensateNegativeBalanceNotificationContent input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Records == input.Records ||
                    this.Records != null &&
                    input.Records != null &&
                    this.Records.SequenceEqual(input.Records)
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
                if (this.Records != null)
                {
                    hashCode = (hashCode * 59) + this.Records.GetHashCode();
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
