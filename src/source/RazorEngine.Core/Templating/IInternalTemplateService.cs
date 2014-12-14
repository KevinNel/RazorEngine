﻿using RazorEngine.Configuration;
using RazorEngine.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorEngine.Templating
{
    public interface IInternalTemplateService
    {
        /// <summary>
        /// Gets the template service configuration.
        /// </summary>
        ITemplateServiceConfiguration Configuration { get; }

        /// <summary>
        /// Gets the encoded string factory.
        /// </summary>
        IEncodedStringFactory EncodedStringFactory { get; }

        /// <summary>
        /// Resolves the template, this is for internal use only
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        ITemplate Resolve(string name, object model, ResolveType resolveType);

        /// <summary>
        /// Adds a namespace that will be imported into the template.
        /// </summary>
        /// <param name="ns">The namespace to be imported.</param>
        void AddNamespace(string ns);

        /// <summary>
        /// Creates a new <see cref="ExecuteContext"/> used to tracking templates.
        /// </summary>
        /// <param name="viewBag">The view bag.</param>
        /// <returns>The instance of <see cref="ExecuteContext"/></returns>
        ExecuteContext CreateExecuteContext(DynamicViewBag viewBag = null);
    }
}
