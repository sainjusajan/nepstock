﻿using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace WebApplication.Identity
{
    /// <summary>
    /// Represents a Role entity
    /// </summary>
     [BsonIgnoreExtraElements]
    public class IdentityRole : IdentityRole<string>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public IdentityRole() : base()
        {
            Id = Guid.NewGuid().ToString();
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="roleName"></param>
        public IdentityRole(string roleName) : this()
        {
            Name = roleName;
        }
    }

    /// <summary>
    /// Represents a Role entity
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    /// 
    [BsonIgnoreExtraElements]
    public class IdentityRole<TKey> where TKey : IEquatable<TKey>
    {
        public IdentityRole() { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="roleName"></param>
        public IdentityRole(string roleName) : this()
        {

            Name = roleName;
        }

        /// <summary>
        /// Role id
        /// </summary>
        public virtual TKey Id { get; set; }
        [BsonIgnoreIfNull]
        /// <summary>
        /// Role name
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// NOTE: should not be used except when extending SaanSoft.AspNet.Identity3.MongoDB. 
        /// Value will be overridden by RoleStore.
        /// Used to store the role name that is formatted in a case insensitive way so can do searches on it
        /// </summary>
        /// 
        [BsonIgnoreIfNull]
        public virtual string NormalizedName { get; set; }
        [BsonIgnoreIfNull]
        public virtual string ConcurrencyStamp { get; set; }

        /// <summary>
        /// Navigation property for claims in the role
        /// </summary>
        /// 
        [BsonIgnoreIfNull]
        public virtual IList<IdentityClaim> Claims
        {
            get { return _claims; }
            set { _claims = value ?? new List<IdentityClaim>(); }
        }

        // public string Id { get; set; }
   

        private IList<IdentityClaim> _claims = new List<IdentityClaim>();



        /// <summary>
        /// Returns a friendly name
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Name;
        }


        #region IEquatable<TKey> (Equals, GetHashCode(), ==, !=)

        public override bool Equals(object obj)
        {
            if (!(obj is IdentityRole<TKey>)) return false;

            var thisObj = (IdentityRole<TKey>)obj;
            return this.Equals(thisObj);
        }

        public virtual bool Equals(IdentityRole<TKey> obj)
        {
            if (obj == null) return false;

            return this.Id.Equals(obj.Id);
        }

        public static bool operator ==(IdentityRole<TKey> left, IdentityRole<TKey> right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(IdentityRole<TKey> left, IdentityRole<TKey> right)
        {
            return !Equals(left, right);
        }

        public override int GetHashCode()
        {
            unchecked
            {

                return StringComparer.OrdinalIgnoreCase.GetHashCode( this.Id.ToString());
            }
        }

        #endregion
    }
}
