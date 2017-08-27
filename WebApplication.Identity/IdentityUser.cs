using Microsoft.AspNetCore.Identity;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication.Data;

namespace WebApplication.Identity
{

    public class IdentityUser : IdentityUser<string>
    {
       
        public IdentityUser() : base()
        {
            Id = Guid.NewGuid().ToString();
        }
       
        public IdentityUser(string userName) : this()
        {
            UserName = userName;
        }
    }
 
    public class IdentityUser<TKey> : IdentityUser<IdentityRole<TKey>, TKey>
        where TKey : IEquatable<TKey>
    {
       
        public IdentityUser() : base()
        {
        }
       
        public IdentityUser(string userName) : base(userName)
        {
        }
    }
    [BsonIgnoreExtraElements]

    public class IdentityUser<TRole, TKey>
        where TRole : IdentityRole<TKey>
        where TKey : IEquatable<TKey>
    {

        public IdentityUser() { }
        public IdentityUser(string userName) : this()
        {
            UserName = userName;
        }

        public virtual TKey Id { get; set; }
        public virtual string UserName { get; set; }
        public virtual string NormalizedUserName { get; set; }
        public virtual string Email { get; set; }

           public virtual string NormalizedEmail { get; set; }
        public virtual bool EmailConfirmed { get; set; }

        public virtual string PasswordHash { get; set; }

        public virtual string SecurityStamp { get; set; }
        public virtual string PhoneNumber { get; set; }


        public virtual bool PhoneNumberConfirmed { get; set; }


        public virtual bool TwoFactorEnabled { get; set; }

        public virtual DateTime? LockoutEnd { get; set; }

        public virtual bool LockoutEnabled { get; set; }

        public virtual int AccessFailedCount { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }

        public virtual DateTime? DateOfBirth { get; set; }

        public virtual string BirthCountry { get; set; }
         

        public virtual string CurrentCountry { get; set; }

         
        public virtual string Image { get; set; }
         

        public virtual Occurrence CreatedOn { get; private set; }
         
        public virtual Occurrence DeletedOn { get; private set; }

         

        public string AboutMe { get; set; }
         

        public GenderType Gender { get; set; }
             
     
         
        public virtual IList<TRole> Roles
        {
            get { return _roles; }
            set { _roles = value ?? new List<TRole>(); }
        }

         
        private IList<TRole> _roles = new List<TRole>();


         
        public virtual IList<UserActivity> UserActivities
        {
            get { return _userActivities; }
            set { _userActivities = value ?? new List<UserActivity>(); }
        }
         
        private IList<UserActivity> _userActivities = new List<UserActivity>();

        public virtual IList<StockQuotes> StockQuotes
        {
            get { return _StockQuotes; }
            set { _StockQuotes = value ?? new List<StockQuotes>(); }
        }

        private IList<StockQuotes> _StockQuotes = new List<StockQuotes>();
                
        public virtual IList<IdentityClaim> Claims
        {
            get { return _claims; }
            set { _claims = value ?? new List<IdentityClaim>(); }
        }
         
        private IList<IdentityClaim> _claims = new List<IdentityClaim>();
        
        public virtual IList<IdentityClaim> AllClaims
        {
            get
            {
                // as Claims and Roles are virtual and could be overridden with an implementation that allows nulls
                //	- make sure they aren't null just in case
                var clms = Claims ?? new List<IdentityClaim>();
                var rls = Roles ?? new List<TRole>();

                return clms.Concat(rls.Where(r => r.Claims != null).SelectMany(r => r.Claims)).Distinct().ToList();
            }
        }


        // if we didnt ingore this users/index will render but external login provider work
         
        public virtual IList<UserLoginInfo> Logins
        {
            get { return _logins; }
            set { _logins = value ?? new List<UserLoginInfo>(); }
        }
         
        private IList<UserLoginInfo> _logins = new List<UserLoginInfo>();


        public override string ToString()
        {
            return UserName;
        }


        #region IEquatable<TKey> (Equals, GetHashCode(), ==, !=)

        public override bool Equals(object obj)
        {
            if (!(obj is IdentityUser<TRole, TKey>)) return false;

            var thisObj = (IdentityUser<TRole, TKey>)obj;
            return this.Equals(thisObj);
        }

        public virtual bool Equals(IdentityUser<TRole, TKey> obj)
        {
            if (obj == null) return false;

            return this.Id.Equals(obj.Id);
        }

        public static bool operator ==(IdentityUser<TRole, TKey> left, IdentityUser<TRole, TKey> right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(IdentityUser<TRole, TKey> left, IdentityUser<TRole, TKey> right)
        {
            return !Equals(left, right);
        }

        public override int GetHashCode()
        {
            unchecked
            {

                return StringComparer.OrdinalIgnoreCase.GetHashCode(this.Id.ToString());
            }
        }

        #endregion
    }

    public enum GenderType
    {
        MALE,
        FEMALE
       
    }
}
