﻿using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;

namespace WebApplication.Identity
{
    public static class IdentityBuilderExtensions
    {
        public static IdentityBuilder AddMongoDBIdentityStores<TContext>(this IdentityBuilder builder, Action<TContext> optionsAction = null)
            where TContext : IIdentityDatabaseContext<IdentityUser<string>, IdentityRole<string>, string>
        {
            builder.Services.TryAdd(GetDefaultServices(builder.UserType, builder.RoleType, typeof(TContext), null, optionsAction));
            return builder;
        }

        public static IdentityBuilder AddMongoDBIdentityStores<TContext, TUser>(this IdentityBuilder builder, Action<TContext> optionsAction = null)
            where TContext : IIdentityDatabaseContext<TUser, IdentityRole<string>, string>
            where TUser : IdentityUser<string>
        {
            builder.Services.TryAdd(GetDefaultServices(typeof(TUser), builder.RoleType, typeof(TContext), null, optionsAction));
            return builder;
        }

        public static IdentityBuilder AddMongoDBIdentityStores<TContext, TUser, TKey>(this IdentityBuilder builder, Action<TContext> optionsAction = null)
            where TContext : IIdentityDatabaseContext<TUser, IdentityRole<TKey>, TKey>
            where TUser : IdentityUser<TKey>
            where TKey : IEquatable<TKey>
        {
            builder.Services.TryAdd(GetDefaultServices(typeof(TUser), builder.RoleType, typeof(TContext), typeof(TKey), optionsAction));
            return builder;
        }

        public static IdentityBuilder AddMongoDBIdentityStores<TContext, TUser, TRole, TKey>(this IdentityBuilder builder, Action<TContext> optionsAction = null)
            where TContext : IIdentityDatabaseContext<TUser, TRole, TKey>
            where TRole : IdentityRole<TKey>
            where TUser : IdentityUser<TKey>
            where TKey : IEquatable<TKey>
        {
            builder.Services.TryAdd(GetDefaultServices(typeof(TUser), typeof(TRole), typeof(TContext), typeof(TKey), optionsAction));
            return builder;
        }


        private static IServiceCollection GetDefaultServices<TContext>(Type userType, Type roleType, Type contextType, Type keyType = null, Action<TContext> optionsAction = null)
        {
            if (keyType == null) keyType = typeof(string);

            Type userStoreType = typeof(UserStore<,,>).MakeGenericType(userType, roleType, keyType);
            Type roleStoreType = typeof(RoleStore<,,>).MakeGenericType(userType, roleType, keyType);

            var services = new ServiceCollection();
            services.AddScoped(contextType, provider => CreateInstance(provider, optionsAction));
            services.AddScoped(typeof(IIdentityDatabaseContext<,,>).MakeGenericType(userType, roleType, keyType), provider => CreateInstance(provider, optionsAction));

            services.AddScoped(typeof(IUserStore<>).MakeGenericType(userType), userStoreType);
            services.AddScoped(typeof(IUserLoginStore<>).MakeGenericType(userType), userStoreType);
            services.AddScoped(typeof(IUserRoleStore<>).MakeGenericType(userType), userStoreType);
            services.AddScoped(typeof(IUserClaimStore<>).MakeGenericType(userType), userStoreType);
            services.AddScoped(typeof(IUserPasswordStore<>).MakeGenericType(userType), userStoreType);
            services.AddScoped(typeof(IUserSecurityStampStore<>).MakeGenericType(userType), userStoreType);
            services.AddScoped(typeof(IUserEmailStore<>).MakeGenericType(userType), userStoreType);
            services.AddScoped(typeof(IUserLockoutStore<>).MakeGenericType(userType), userStoreType);
            services.AddScoped(typeof(IUserPhoneNumberStore<>).MakeGenericType(userType), userStoreType);
            services.AddScoped(typeof(IQueryableUserStore<>).MakeGenericType(userType), userStoreType);
            services.AddScoped(typeof(IUserTwoFactorStore<>).MakeGenericType(userType), userStoreType);

            services.AddScoped(typeof(IRoleStore<>).MakeGenericType(roleType), roleStoreType);
            services.AddScoped(typeof(IQueryableRoleStore<>).MakeGenericType(roleType), roleStoreType);
            services.AddScoped(typeof(IRoleClaimStore<>).MakeGenericType(roleType), roleStoreType);

            return services;
        }

        private static TContext CreateInstance<TContext>(IServiceProvider serviceProvider, Action<TContext> optionsAction = null)
        {
            TContext instance = (TContext)ActivatorUtilities.CreateInstance(serviceProvider, typeof(TContext));
            if (optionsAction != null) optionsAction(instance);
            return instance;
        }
    }
}
