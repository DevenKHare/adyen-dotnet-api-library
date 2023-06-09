/*
* Adyen Payment API
*
*
* The version of the OpenAPI document: 68
* 
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

namespace Adyen.Model.Payment
{
    /// <summary>
    /// FraudCheckResultWrapper
    /// </summary>
    [DataContract(Name = "FraudCheckResultWrapper")]
    public partial class FraudCheckResultWrapper : IEquatable<FraudCheckResultWrapper>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FraudCheckResultWrapper" /> class.
        /// </summary>
        /// <param name="fraudCheckResult">fraudCheckResult.</param>
        public FraudCheckResultWrapper(FraudCheckResult fraudCheckResult = default(FraudCheckResult))
        {
            this.FraudCheckResult = fraudCheckResult;
        }

        /// <summary>
        /// Gets or Sets FraudCheckResult
        /// </summary>
        [DataMember(Name = "FraudCheckResult", EmitDefaultValue = false)]
        public FraudCheckResult FraudCheckResult { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FraudCheckResultWrapper {\n");
            sb.Append("  FraudCheckResult: ").Append(FraudCheckResult).Append("\n");
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
            return this.Equals(input as FraudCheckResultWrapper);
        }

        /// <summary>
        /// Returns true if FraudCheckResultWrapper instances are equal
        /// </summary>
        /// <param name="input">Instance of FraudCheckResultWrapper to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FraudCheckResultWrapper input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FraudCheckResult == input.FraudCheckResult ||
                    (this.FraudCheckResult != null &&
                    this.FraudCheckResult.Equals(input.FraudCheckResult))
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
                if (this.FraudCheckResult != null)
                {
                    hashCode = (hashCode * 59) + this.FraudCheckResult.GetHashCode();
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
