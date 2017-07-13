
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace Customweb.Wallee.Model
{
    /// <summary>
    /// ApplicationUserCreate model.
    /// </summary>
    [DataContract]
    public partial class ApplicationUserCreate :  IEquatable<ApplicationUserCreate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationUserCreate" /> class.
        /// </summary>
        /// <param name="Id">The ID is the primary key of the entity. The ID identifies the entity uniquely.</param>
        /// <param name="PlannedPurgeDate">The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.</param>
        /// <param name="Scope">The scope to which the user belongs to.</param>
        /// <param name="State">State</param>
        /// <param name="UserType">UserType</param>
        /// <param name="Version">The version number indicates the version of the entity. The version is incremented whenever the entity is changed.</param>
        /// <param name="Name">The user name is used to identify the application user in administrative interfaces.</param>
        /// <param name="PrimaryAccount">The account that this user is associated with. The account owner will be able to manage this user.</param>
        public ApplicationUserCreate(long? Id = default(long?), DateTime? PlannedPurgeDate = default(DateTime?), Scope Scope = default(Scope), CreationEntityState State = default(CreationEntityState), UserType UserType = default(UserType), long? Version = default(long?), string Name = default(string), long? PrimaryAccount = default(long?))
        {
            this.Id = Id;
            this.PlannedPurgeDate = PlannedPurgeDate;
            this.Scope = Scope;
            this.State = State;
            this.UserType = UserType;
            this.Version = Version;
            this.Name = Name;
            this.PrimaryAccount = PrimaryAccount;
        }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.
        /// </summary>
        /// <value>The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=false)]
        public DateTime? PlannedPurgeDate { get; set; }

        /// <summary>
        /// The scope to which the user belongs to.
        /// </summary>
        /// <value>The scope to which the user belongs to.</value>
        [DataMember(Name="scope", EmitDefaultValue=false)]
        public Scope Scope { get; set; }

        /// <summary>
        /// State
        /// </summary>
        /// <value>State</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public CreationEntityState State { get; set; }

        /// <summary>
        /// UserType
        /// </summary>
        /// <value>UserType</value>
        [DataMember(Name="userType", EmitDefaultValue=false)]
        public UserType UserType { get; set; }

        /// <summary>
        /// The version number indicates the version of the entity. The version is incremented whenever the entity is changed.
        /// </summary>
        /// <value>The version number indicates the version of the entity. The version is incremented whenever the entity is changed.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public long? Version { get; set; }

        /// <summary>
        /// The user name is used to identify the application user in administrative interfaces.
        /// </summary>
        /// <value>The user name is used to identify the application user in administrative interfaces.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The account that this user is associated with. The account owner will be able to manage this user.
        /// </summary>
        /// <value>The account that this user is associated with. The account owner will be able to manage this user.</value>
        [DataMember(Name="primaryAccount", EmitDefaultValue=false)]
        public long? PrimaryAccount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplicationUserCreate {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PlannedPurgeDate: ").Append(PlannedPurgeDate).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  UserType: ").Append(UserType).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PrimaryAccount: ").Append(PrimaryAccount).Append("\n");
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
            return this.Equals(obj as ApplicationUserCreate);
        }

        /// <summary>
        /// Returns true if ApplicationUserCreate instances are equal
        /// </summary>
        /// <param name="other">Instance of ApplicationUserCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicationUserCreate other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.PlannedPurgeDate == other.PlannedPurgeDate ||
                    this.PlannedPurgeDate != null &&
                    this.PlannedPurgeDate.Equals(other.PlannedPurgeDate)
                ) && 
                (
                    this.Scope == other.Scope ||
                    this.Scope != null &&
                    this.Scope.Equals(other.Scope)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.UserType == other.UserType ||
                    this.UserType != null &&
                    this.UserType.Equals(other.UserType)
                ) && 
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.PrimaryAccount == other.PrimaryAccount ||
                    this.PrimaryAccount != null &&
                    this.PrimaryAccount.Equals(other.PrimaryAccount)
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
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.PlannedPurgeDate != null)
                    hash = hash * 59 + this.PlannedPurgeDate.GetHashCode();
                if (this.Scope != null)
                    hash = hash * 59 + this.Scope.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                if (this.UserType != null)
                    hash = hash * 59 + this.UserType.GetHashCode();
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.PrimaryAccount != null)
                    hash = hash * 59 + this.PrimaryAccount.GetHashCode();
                return hash;
            }
        }

    }

}