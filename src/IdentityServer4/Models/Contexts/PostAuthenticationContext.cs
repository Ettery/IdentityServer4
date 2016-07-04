﻿// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

namespace IdentityServer4.Models
{
    /// <summary>
    /// Class describing the context of the post-authentication stage
    /// </summary>
    public class PostAuthenticationContext
    {
        /// <summary>
        /// Gets or sets the sign in message.
        /// </summary>
        /// <value>
        /// The sign in message.
        /// </value>
        public AuthorizationRequest SignInRequest { get; set; }

        /// <summary>
        /// Gets or sets the authenticate result.
        /// </summary>
        /// <value>
        /// The authenticate result.
        /// </value>
        public AuthenticateResult AuthenticateResult { get; set; }
    }
}