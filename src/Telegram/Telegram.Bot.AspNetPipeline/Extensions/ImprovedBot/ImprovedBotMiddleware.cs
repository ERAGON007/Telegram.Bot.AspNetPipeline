﻿using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Telegram.Bot.AspNetPipeline.Builder;
using Telegram.Bot.AspNetPipeline.Core;
using Telegram.Bot.AspNetPipeline.Extensions.ImprovedBot.UpdateContextFastSearching;

namespace Telegram.Bot.AspNetPipeline.Extensions.ImprovedBot
{
    public class ImprovedBotMiddleware : IMiddleware
    {
        readonly IBotExtSingleton _botExtSingleton;

        public ImprovedBotMiddleware(IBotExtSingleton botExtSingleton)
        {
            _botExtSingleton = botExtSingleton;
        }

        public async Task Invoke(UpdateContext ctx, Func<Task> next)
        {
            await _botExtSingleton.OnUpdateInvoke(ctx, next);
        }
    }
}
