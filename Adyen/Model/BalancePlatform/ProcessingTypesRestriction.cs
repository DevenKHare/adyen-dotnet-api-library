/*
* Configuration API
*
*
* The version of the OpenAPI document: 2
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

namespace Adyen.Model.BalancePlatform
{
    /// <summary>
    /// ProcessingTypesRestriction
    /// </summary>
    [DataContract(Name = "ProcessingTypesRestriction")]
    public partial class ProcessingTypesRestriction : IEquatable<ProcessingTypesRestriction>, IValidatableObject
    {
        /// <summary>
        /// Defines Value
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ValueEnum
        {
            /// <summary>
            /// Enum AtmWithdraw for value: atmWithdraw
            /// </summary>
            [EnumMember(Value = "atmWithdraw")]
            AtmWithdraw = 1,

            /// <summary>
            /// Enum BalanceInquiry for value: balanceInquiry
            /// </summary>
            [EnumMember(Value = "balanceInquiry")]
            BalanceInquiry = 2,

            /// <summary>
            /// Enum Ecommerce for value: ecommerce
            /// </summary>
            [EnumMember(Value = "ecommerce")]
            Ecommerce = 3,

            /// <summary>
            /// Enum Moto for value: moto
            /// </summary>
            [EnumMember(Value = "moto")]
            Moto = 4,

            /// <summary>
            /// Enum Pos for value: pos
            /// </summary>
            [EnumMember(Value = "pos")]
            Pos = 5,

            /// <summary>
            /// Enum Recurring for value: recurring
            /// </summary>
            [EnumMember(Value = "recurring")]
            Recurring = 6,

            /// <summary>
            /// Enum Token for value: token
            /// </summary>
            [EnumMember(Value = "token")]
            Token = 7,

            /// <summary>
            /// Enum Unknown for value: unknown
            /// </summary>
            [EnumMember(Value = "unknown")]
            Unknown = 8

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessingTypesRestriction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProcessingTypesRestriction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessingTypesRestriction" /> class.
        /// </summary>
        /// <param name="operation">Defines how the condition must be evaluated. (required).</param>
        /// <param name="value">List of processing types.  Possible values: **atmWithdraw**, **balanceInquiry**, **ecommerce**, **moto**, **pos**, **recurring**, **token**.  .</param>
        public ProcessingTypesRestriction(string operation = default(string), List<ValueEnum> value = default(List<ValueEnum>))
        {
            this.Operation = operation;
            this.Value = value;
        }

        /// <summary>
        /// Defines how the condition must be evaluated.
        /// </summary>
        /// <value>Defines how the condition must be evaluated.</value>
        [DataMember(Name = "operation", IsRequired = false, EmitDefaultValue = false)]
        public string Operation { get; set; }

        /// <summary>
        /// List of processing types.  Possible values: **atmWithdraw**, **balanceInquiry**, **ecommerce**, **moto**, **pos**, **recurring**, **token**.  
        /// </summary>
        /// <value>List of processing types.  Possible values: **atmWithdraw**, **balanceInquiry**, **ecommerce**, **moto**, **pos**, **recurring**, **token**.  </value>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public List<ProcessingTypesRestriction.ValueEnum> Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProcessingTypesRestriction {\n");
            sb.Append("  Operation: ").Append(Operation).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as ProcessingTypesRestriction);
        }

        /// <summary>
        /// Returns true if ProcessingTypesRestriction instances are equal
        /// </summary>
        /// <param name="input">Instance of ProcessingTypesRestriction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProcessingTypesRestriction input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Operation == input.Operation ||
                    (this.Operation != null &&
                    this.Operation.Equals(input.Operation))
                ) && 
                (
                    this.Value == input.Value ||
                    this.Value != null &&
                    input.Value != null &&
                    this.Value.SequenceEqual(input.Value)
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
                if (this.Operation != null)
                {
                    hashCode = (hashCode * 59) + this.Operation.GetHashCode();
                }
                if (this.Value != null)
                {
                    hashCode = (hashCode * 59) + this.Value.GetHashCode();
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
