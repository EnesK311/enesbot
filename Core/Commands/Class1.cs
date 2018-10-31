using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using Discord;
using Discord.Commands;

namespace DsicordBotEnes10_30_18.Core.Commands
{
    public class Class1 : ModuleBase<SocketCommandContext>

    {
        [Command("Enes")]
        public async Task Enes()
        {
            await Context.Channel.SendMessageAsync("wa iser pic");
        }
        [Command("LIVE")]
        public async Task LIVE()
        {
            await Context.Channel.SendMessageAsync("https://www.twitch.tv/enesk311 \nhttps://www.twitch.tv/enesk311\nhttps://www.twitch.tv/enesk311\nhttps://www.twitch.tv/enesk311\nhttps://www.twitch.tv/enesk311\nhttps://www.twitch.tv/enesk311");
        }
        [Command("Besar")]
        public async Task Besar()
        {
            await Context.Channel.SendMessageAsync("Is een echte broer");
        }
        [Command("Miko")]
        public async Task Miko()
        {
            await Context.Channel.SendMessageAsync("Welke? Mikail Holding of Mikail In?");
        }
        [Command("Mikail Holding")]
        public async Task MikailHolding()
        {
            await Context.Channel.SendMessageAsync("die kakt geld");
        }
        [Command("Mikail In")]
        public async Task MikailIn()
        {
            await Context.Channel.SendMessageAsync("sws bezig met SlothGot");
        }
        [Command("Doly")]
        public async Task Doly()
        {
            await Context.Channel.SendMessageAsync("sucks dick");
        }
        [Command("Furkan")]
        public async Task Furkan()
        {
            await Context.Channel.SendMessageAsync("Starting a new Era like Fatih Sultan Mehmet");
        }
        [Command("ENES")]
        public async Task EnesRoep()
        {
            await Context.Channel.SendMessageAsync("WA ROEP GIJ PIC!");
        }
        [Command("fy")]
        public async Task fy()
        {
            await Context.Channel.SendMessageAsync("fy2 PIC TEGE WIE ZEG GIJ DA LEN AMK DOLU");
        }
    }
}
