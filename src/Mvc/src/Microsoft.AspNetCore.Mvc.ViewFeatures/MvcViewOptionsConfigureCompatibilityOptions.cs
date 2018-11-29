﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Microsoft.AspNetCore.Mvc.ViewFeatures
{
    internal class MvcViewOptionsConfigureCompatibilityOptions : ConfigureCompatibilityOptions<MvcViewOptions>
    {
        public MvcViewOptionsConfigureCompatibilityOptions(
            ILoggerFactory loggerFactory,
            IOptions<MvcCompatibilityOptions> compatibilityOptions)
            : base(loggerFactory, compatibilityOptions)
        {
        }

        protected override IReadOnlyDictionary<string, object> DefaultValues
        {
            get
            {
                return new Dictionary<string, object>
                {
                    [nameof(MvcViewOptions.SuppressTempDataAttributePrefix)] = true,
                    [nameof(MvcViewOptions.AllowRenderingMaxLengthAttribute)] = true,
                };
            }
        }
    }
}
