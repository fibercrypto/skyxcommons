/*
 * Python to .Net
 *
 * Still whitout description.
 *
 * OpenAPI spec version: 0.25.1
 * 
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace api_core.Models
{ 
    /// <summary>
    /// Represents a transiction
    /// </summary>
    [DataContract]
    public partial class Transaction : IEquatable<Transaction>
    { 
        /// <summary>
        /// Operation ID. Can be empty. Should be not empty for ransactions that broadcasted using this Blockchain.Api
        /// </summary>
        /// <value>Operation ID. Can be empty. Should be not empty for ransactions that broadcasted using this Blockchain.Api</value>
        [DataMember(Name="operationId")]
        public string OperationId { get; set; }

        /// <summary>
        /// Transaction moment as ISO 8601 in UTC
        /// </summary>
        /// <value>Transaction moment as ISO 8601 in UTC</value>
        [DataMember(Name="timespam")]
        public string Timespam { get; set; }

        /// <summary>
        /// Source address
        /// </summary>
        /// <value>Source address</value>
        [DataMember(Name="fromAddress")]
        public string FromAddress { get; set; }

        /// <summary>
        /// Destination address
        /// </summary>
        /// <value>Destination address</value>
        [DataMember(Name="toAddress")]
        public string ToAddress { get; set; }

        /// <summary>
        /// Asset ID e.g. SKY
        /// </summary>
        /// <value>Asset ID e.g. SKY</value>
        [DataMember(Name="assetId")]
        public string AssetId { get; set; }

        /// <summary>
        /// Amount without fee. Is integer as string, aligned to the asset accuracy. Actual value can be calculated as x &#x3D; sourceAmount * (10 ^ asset.Accuracy)
        /// </summary>
        /// <value>Amount without fee. Is integer as string, aligned to the asset accuracy. Actual value can be calculated as x &#x3D; sourceAmount * (10 ^ asset.Accuracy)</value>
        [DataMember(Name="ammount")]
        public string Ammount { get; set; }

        /// <summary>
        /// Transaction hash as base64 string
        /// </summary>
        /// <value>Transaction hash as base64 string</value>
        [DataMember(Name="hash")]
        public string Hash { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Transaction {\n");
            sb.Append("  OperationId: ").Append(OperationId).Append("\n");
            sb.Append("  Timespam: ").Append(Timespam).Append("\n");
            sb.Append("  FromAddress: ").Append(FromAddress).Append("\n");
            sb.Append("  ToAddress: ").Append(ToAddress).Append("\n");
            sb.Append("  AssetId: ").Append(AssetId).Append("\n");
            sb.Append("  Ammount: ").Append(Ammount).Append("\n");
            sb.Append("  Hash: ").Append(Hash).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((Transaction)obj);
        }

        /// <summary>
        /// Returns true if Transaction instances are equal
        /// </summary>
        /// <param name="other">Instance of Transaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Transaction other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    OperationId == other.OperationId ||
                    OperationId != null &&
                    OperationId.Equals(other.OperationId)
                ) && 
                (
                    Timespam == other.Timespam ||
                    Timespam != null &&
                    Timespam.Equals(other.Timespam)
                ) && 
                (
                    FromAddress == other.FromAddress ||
                    FromAddress != null &&
                    FromAddress.Equals(other.FromAddress)
                ) && 
                (
                    ToAddress == other.ToAddress ||
                    ToAddress != null &&
                    ToAddress.Equals(other.ToAddress)
                ) && 
                (
                    AssetId == other.AssetId ||
                    AssetId != null &&
                    AssetId.Equals(other.AssetId)
                ) && 
                (
                    Ammount == other.Ammount ||
                    Ammount != null &&
                    Ammount.Equals(other.Ammount)
                ) && 
                (
                    Hash == other.Hash ||
                    Hash != null &&
                    Hash.Equals(other.Hash)
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
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (OperationId != null)
                    hashCode = hashCode * 59 + OperationId.GetHashCode();
                    if (Timespam != null)
                    hashCode = hashCode * 59 + Timespam.GetHashCode();
                    if (FromAddress != null)
                    hashCode = hashCode * 59 + FromAddress.GetHashCode();
                    if (ToAddress != null)
                    hashCode = hashCode * 59 + ToAddress.GetHashCode();
                    if (AssetId != null)
                    hashCode = hashCode * 59 + AssetId.GetHashCode();
                    if (Ammount != null)
                    hashCode = hashCode * 59 + Ammount.GetHashCode();
                    if (Hash != null)
                    hashCode = hashCode * 59 + Hash.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Transaction left, Transaction right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Transaction left, Transaction right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
