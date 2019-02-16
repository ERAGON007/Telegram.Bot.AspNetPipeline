﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using Telegram.Bot.AspNetPipeline.Mvc.Controllers;
using Telegram.Bot.AspNetPipeline.Mvc.Controllers.ModelBinding;

namespace Telegram.Bot.AspNetPipeline.Mvc.Builder
{
    internal class AddMvcBuilder : IAddMvcBuilder
    {
        public bool ConfigureBotExtWithMvc { get; }

        /// <summary>
        /// All will be registered as services.
        /// </summary>
        public IList<Type> Controllers  { get; set; } = new List<Type>();

        /// <summary>
        /// Without ModelBinderProvider and more simpler.
        /// But you can build your own asp-like model binding middleware, if needed.
        /// </summary>
        public IList<IModelBinder> ModelBinders { get; set; } = new List<IModelBinder>();

        public IServiceCollection ServiceCollection { get; }

        public AddMvcBuilder(
            MvcOptions addMvcOptions,
            IServiceCollection serviceCollection
            )
        {
            ConfigureBotExtWithMvc = addMvcOptions.ConfigureBotExtWithMvc;
            ServiceCollection = serviceCollection;
        }
    }


}
