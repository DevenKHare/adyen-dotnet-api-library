/*
* Legal Entity Management API
*
*
* The version of the OpenAPI document: 3
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

namespace Adyen.Model.LegalEntityManagement
{
    /// <summary>
    /// AcceptTermsOfServiceRequest
    /// </summary>
    [DataContract(Name = "AcceptTermsOfServiceRequest")]
    public partial class AcceptTermsOfServiceRequest : IEquatable<AcceptTermsOfServiceRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AcceptTermsOfServiceRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AcceptTermsOfServiceRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AcceptTermsOfServiceRequest" /> class.
        /// </summary>
        /// <param name="acceptedBy">The individual legal entity ID of the user accepting the Terms of Service. For organizations, this must be the legal entity ID of an authorized signatory for the organization. (required).</param>
        /// <param name="ipAddress">The IP address of the user accepting the Terms of Service..</param>
        public AcceptTermsOfServiceRequest(string acceptedBy = default(string), string ipAddress = default(string))
        {
            this.AcceptedBy = acceptedBy;
            this.IpAddress = ipAddress;
        }

        /// <summary>
        /// The individual legal entity ID of the user accepting the Terms of Service. For organizations, this must be the legal entity ID of an authorized signatory for the organization.
        /// </summary>
        /// <value>The individual legal entity ID of the user accepting the Terms of Service. For organizations, this must be the legal entity ID of an authorized signatory for the organization.</value>
        [DataMember(Name = "acceptedBy", IsRequired = false, EmitDefaultValue = false)]
        public string AcceptedBy { get; set; }

        /// <summary>
        /// The IP address of the user accepting the Terms of Service.
        /// </summary>
        /// <value>The IP address of the user accepting the Terms of Service.</value>
        [DataMember(Name = "ipAddress", EmitDefaultValue = false)]
        public string IpAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AcceptTermsOfServiceRequest {\n");
            sb.Append("  AcceptedBy: ").Append(AcceptedBy).Append("\n");
            sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
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
            return this.Equals(input as AcceptTermsOfServiceRequest);
        }

        /// <summary>
        /// Returns true if AcceptTermsOfServiceRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AcceptTermsOfServiceRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AcceptTermsOfServiceRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AcceptedBy == input.AcceptedBy ||
                    (this.AcceptedBy != null &&
                    this.AcceptedBy.Equals(input.AcceptedBy))
                ) && 
                (
                    this.IpAddress == input.IpAddress ||
                    (this.IpAddress != null &&
                    this.IpAddress.Equals(input.IpAddress))
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
                if (this.AcceptedBy != null)
                {
                    hashCode = (hashCode * 59) + this.AcceptedBy.GetHashCode();
                }
                if (this.IpAddress != null)
                {
                    hashCode = (hashCode * 59) + this.IpAddress.GetHashCode();
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
