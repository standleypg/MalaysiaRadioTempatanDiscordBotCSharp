using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace radio_discord_bot.Services.Interfaces;

public interface IQuoteService
{
    Task<string> GetQuoteAsync();
}
