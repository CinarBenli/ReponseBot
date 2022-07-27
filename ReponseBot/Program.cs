using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Discord;
using Discord.WebSocket;

namespace ReponseBot
{
    class Program
    {

        public static Program Instance { get; private set; }

        private readonly DiscordSocketClient _client;

        static void Main(string[] args)
            => new Program()
                .MainAsync()
                .GetAwaiter()
                .GetResult();

        public Program()
        {
            _client = new DiscordSocketClient(new DiscordSocketConfig() { GatewayIntents = GatewayIntents.All });

            _client.Log += LogAsync;
            _client.Ready += ReadyAsync;
            _client.MessageReceived += MessageReceivedAsync;
            _client.InteractionCreated += InteractionCreatedAsync;
        }

        public async Task MainAsync()
        {
            Instance = this;
            await _client.LoginAsync(TokenType.Bot, "OTgzNzA3MDI2MjcyMTgyMzIy.GLdAGX.mutzpzRrGXQltPA-6vdfYG0GCNEqNGIMNR1hmA");
            await _client.SetGameAsync("Reponce Mod - discord.gg/sgYp48yE8X ", "http://78.111.111.112/");
            _client.UserJoined += AnnounceJoinedUser;
            _client.ModalSubmitted += Modals;

            await _client.StartAsync();
            await Task.Delay(Timeout.Infinite);

        }

        private async Task Modals(SocketModal arg)
        {
            switch (arg.Data.CustomId)
            {
                case "food_menu":
                    List<SocketMessageComponentData> components = arg.Data.Components.ToList();
                    string food1 = components.First(x => x.CustomId == "food_name1").Value;
                    string food2 = components.First(x => x.CustomId == "food_name2").Value;
                    string food3 = components.First(x => x.CustomId == "food_name3").Value;
                    string food4 = components.First(x => x.CustomId == "food_name4").Value;

                    var db = new EmbedBuilder().WithTitle("**Steampunk Roleplay - Başvuru**").WithDescription($"{arg.User.Mention}, Adlı Kullanıcının Başvurusu: \n \n **Kendinizden Bahsedin** \n {food1} \n **Polislik Ve Unturned Hakkında** \n {food2 } \n **Plan, Fikir Ve Düşünceleriniz Neler?** \n {food3} \n **Daha Önce Yasaklanmanız Bulunuyor mu?** \n {food4}").WithThumbnailUrl("https://cdn.discordapp.com/attachments/959142220366237796/962008357990977626/122.png").Build();

                    AllowedMentions mentions = new AllowedMentions();
                    mentions.AllowedTypes = AllowedMentionTypes.Users;

                    var channel = _client.GetChannel(983322634819342356) as SocketTextChannel; // Gets the channel to send the message in
                    await channel.SendMessageAsync(" ", false, embed: db);
                    break;

                case "asker":
                    List<SocketMessageComponentData> componentss = arg.Data.Components.ToList();
                    string ffood1 = componentss.First(x => x.CustomId == "asker1").Value;
                    string ffood2 = componentss.First(x => x.CustomId == "asker2").Value;
                    string ffood3 = componentss.First(x => x.CustomId == "asker3").Value;
                    string ffood4 = componentss.First(x => x.CustomId == "asker4").Value;

                    var dbbb = new EmbedBuilder().WithTitle("**Steampunk Roleplay - Başvuru**").WithDescription($"{arg.User.Mention}, Adlı Kullanıcının Başvurusu: \n \n **Kendinizden Bahsedin** \n {ffood1} \n **Polislik Ve Unturned Hakkında** \n {ffood2 } \n **Plan, Fikir Ve Düşünceleriniz Neler?** \n {ffood3} \n **Daha Önce Yasaklanmanız Bulunuyor mu?** \n {ffood4}").WithThumbnailUrl("https://cdn.discordapp.com/attachments/959142220366237796/962008357990977626/122.png").Build();

                    AllowedMentions mentionss = new AllowedMentions();
                    mentionss.AllowedTypes = AllowedMentionTypes.Users;

                    var channell = _client.GetChannel(983325860595634206) as SocketTextChannel; // Gets the channel to send the message in
                    await channell.SendMessageAsync(" ", false, embed: dbbb);
                    break;

                case "baron":
                    List<SocketMessageComponentData> componentsss = arg.Data.Components.ToList();
                    string fffood1 = componentsss.First(x => x.CustomId == "baron1").Value;
                    string fffood2 = componentsss.First(x => x.CustomId == "baron2").Value;
                    string fffood3 = componentsss.First(x => x.CustomId == "baron3").Value;
                    string fffood4 = componentsss.First(x => x.CustomId == "baron4").Value;

                    var dbbbb = new EmbedBuilder().WithTitle("**Steampunk Roleplay - Başvuru**").WithDescription($"{arg.User.Mention}, Adlı Kullanıcının Başvurusu: \n \n **Kendinizden Bahsedin** \n {fffood1} \n **Baronluk Ve Unturned Hakkında** \n {fffood2 } \n **Plan, Fikir Ve Düşünceleriniz Neler?** \n {fffood3} \n **Daha Önce Yasaklanmanız Bulunuyor mu?** \n {fffood4}").WithThumbnailUrl("https://cdn.discordapp.com/attachments/959142220366237796/962008357990977626/122.png").Build();

                    AllowedMentions mentionsss = new AllowedMentions();
                    mentionsss.AllowedTypes = AllowedMentionTypes.Users;

                    var channells = _client.GetChannel(983330028660084736) as SocketTextChannel; // Gets the channel to send the message in
                    await channells.SendMessageAsync(" ", false, embed: dbbbb);
                    break;

                case "mafya":
                    List<SocketMessageComponentData> componentssss = arg.Data.Components.ToList();
                    string ffffood1 = componentssss.First(x => x.CustomId == "mafya1").Value;
                    string ffffood2 = componentssss.First(x => x.CustomId == "mafya2").Value;
                    string ffffood3 = componentssss.First(x => x.CustomId == "mafya3").Value;
                    string ffffood4 = componentssss.First(x => x.CustomId == "mafya4").Value;

                    var dbbbbb = new EmbedBuilder().WithTitle("**Steampunk Roleplay - Başvuru**").WithDescription($"{arg.User.Mention}, Adlı Kullanıcının Başvurusu: \n \n **Kendinizden Bahsedin** \n {ffffood1} \n **Mafyalık Ve Unturned Hakkında** \n {ffffood2 } \n **Plan, Fikir Ve Düşünceleriniz Neler?** \n {ffffood3} \n **Daha Önce Yasaklanmanız Bulunuyor mu?** \n {ffffood4}").WithThumbnailUrl("https://cdn.discordapp.com/attachments/959142220366237796/962008357990977626/122.png").Build();

                    AllowedMentions mentionssss = new AllowedMentions();
                    mentionssss.AllowedTypes = AllowedMentionTypes.Users;

                    var channellss = _client.GetChannel(983330101028614194) as SocketTextChannel; // Gets the channel to send the message in
                    await channellss.SendMessageAsync(" ", false, embed: dbbbbb);
                    break;

                case "terorist":
                    List<SocketMessageComponentData> componentsssss = arg.Data.Components.ToList();
                    string fffffood1 = componentsssss.First(x => x.CustomId == "terorist1").Value;
                    string fffffood2 = componentsssss.First(x => x.CustomId == "terorist2").Value;
                    string fffffood3 = componentsssss.First(x => x.CustomId == "terorist3").Value;
                    string fffffood4 = componentsssss.First(x => x.CustomId == "terorist4").Value;

                    var dbbbbbb = new EmbedBuilder().WithTitle("**Steampunk Roleplay - Başvuru**").WithDescription($"{arg.User.Mention}, Adlı Kullanıcının Başvurusu: \n \n **Kendinizden Bahsedin** \n {fffffood1} \n **Teroristlik Ve Unturned Hakkında** \n {fffffood2 } \n **Plan, Fikir Ve Düşünceleriniz Neler?** \n {fffffood3} \n **Daha Önce Yasaklanmanız Bulunuyor mu?** \n {fffffood4}").WithThumbnailUrl("https://cdn.discordapp.com/attachments/959142220366237796/962008357990977626/122.png").Build();

                    AllowedMentions mentionsssss = new AllowedMentions();
                    mentionsssss.AllowedTypes = AllowedMentionTypes.Users;

                    var channellsss = _client.GetChannel(983330182523944970) as SocketTextChannel; // Gets the channel to send the message in
                    await channellsss.SendMessageAsync(" ", false, embed: dbbbbbb);
                    break;

                case "vagos":
                    List<SocketMessageComponentData> componentssssss = arg.Data.Components.ToList();
                    string ffffffood1 = componentssssss.First(x => x.CustomId == "vagos1").Value;
                    string ffffffood2 = componentssssss.First(x => x.CustomId == "vagos2").Value;
                    string ffffffood3 = componentssssss.First(x => x.CustomId == "vagos3").Value;
                    string ffffffood4 = componentssssss.First(x => x.CustomId == "vagos4").Value;

                    var dbbbbbbb = new EmbedBuilder().WithTitle("**Steampunk Roleplay - Başvuru**").WithDescription($"{arg.User.Mention}, Adlı Kullanıcının Başvurusu: \n \n **Kendinizden Bahsedin** \n {ffffffood1} \n **Vagos Çetesi Ve Unturned Hakkında** \n {ffffffood2 } \n **Plan, Fikir Ve Düşünceleriniz Neler?** \n {ffffffood3} \n **Daha Önce Yasaklanmanız Bulunuyor mu?** \n {ffffffood4}").WithThumbnailUrl("https://cdn.discordapp.com/attachments/959142220366237796/962008357990977626/122.png").Build();

                    AllowedMentions mentionssssss = new AllowedMentions();
                    mentionssssss.AllowedTypes = AllowedMentionTypes.Users;

                    var channellssss = _client.GetChannel(983330227411382292) as SocketTextChannel; // Gets the channel to send the message in
                    await channellssss.SendMessageAsync(" ", false, embed: dbbbbbbb);
                    break;

                case "grove":
                    List<SocketMessageComponentData> componentsssssss = arg.Data.Components.ToList();
                    string fffffffood1 = componentsssssss.First(x => x.CustomId == "grove1").Value;
                    string fffffffood2 = componentsssssss.First(x => x.CustomId == "grove2").Value;
                    string fffffffood3 = componentsssssss.First(x => x.CustomId == "grove3").Value;
                    string fffffffood4 = componentsssssss.First(x => x.CustomId == "grove4").Value;

                    var dbbbbbbbb = new EmbedBuilder().WithTitle("**Steampunk Roleplay - Başvuru**").WithDescription($"{arg.User.Mention}, Adlı Kullanıcının Başvurusu: \n \n **Kendinizden Bahsedin** \n {fffffffood1} \n **Grove Çetesi Ve Unturned Hakkında** \n {fffffffood2 } \n **Plan, Fikir Ve Düşünceleriniz Neler?** \n {fffffffood3} \n **Daha Önce Yasaklanmanız Bulunuyor mu?** \n {fffffffood4}").WithThumbnailUrl("https://cdn.discordapp.com/attachments/959142220366237796/962008357990977626/122.png").Build();

                    AllowedMentions mentionsssssss = new AllowedMentions();
                    mentionsssssss.AllowedTypes = AllowedMentionTypes.Users;

                    var channellsssss = _client.GetChannel(983330268750422026) as SocketTextChannel; // Gets the channel to send the message in
                    await channellsssss.SendMessageAsync(" ", false, embed: dbbbbbbbb);
                    break;

                case "ems":
                    List<SocketMessageComponentData> componentssssssss = arg.Data.Components.ToList();
                    string ffffffffood1 = componentssssssss.First(x => x.CustomId == "ems1").Value;
                    string ffffffffood2 = componentssssssss.First(x => x.CustomId == "ems2").Value;
                    string ffffffffood3 = componentssssssss.First(x => x.CustomId == "ems3").Value;
                    string ffffffffood4 = componentssssssss.First(x => x.CustomId == "ems4").Value;

                    var dbbbbbbbbb = new EmbedBuilder().WithTitle("**Steampunk Roleplay - Başvuru**").WithDescription($"{arg.User.Mention}, Adlı Kullanıcının Başvurusu: \n \n **Kendinizden Bahsedin** \n {ffffffffood1} \n **Grove Çetesi Ve Unturned Hakkında** \n {ffffffffood2 } \n **Plan, Fikir Ve Düşünceleriniz Neler?** \n {ffffffffood3} \n **Daha Önce Yasaklanmanız Bulunuyor mu?** \n {ffffffffood4}").WithThumbnailUrl("https://cdn.discordapp.com/attachments/959142220366237796/962008357990977626/122.png").Build();

                    AllowedMentions mentionssssssss = new AllowedMentions();
                    mentionssssssss.AllowedTypes = AllowedMentionTypes.Users;

                    var channellssssss = _client.GetChannel(983331099654643742) as SocketTextChannel; // Gets the channel to send the message in
                    await channellssssss.SendMessageAsync(" ", false, embed: dbbbbbbbbb);
                    break;

                case "ıcyetkili":
                    List<SocketMessageComponentData> componentsssssssss = arg.Data.Components.ToList();
                    string fffffffffood1 = componentsssssssss.First(x => x.CustomId == "ıcyetkili1").Value;
                    string fffffffffood2 = componentsssssssss.First(x => x.CustomId == "ıcyetkili2").Value;
                    string fffffffffood3 = componentsssssssss.First(x => x.CustomId == "ıcyetkili3").Value;
                    string fffffffffood4 = componentsssssssss.First(x => x.CustomId == "ıcyetkili4").Value;

                    var dbbbbbbbbbb = new EmbedBuilder().WithTitle("**Steampunk Roleplay - Başvuru**").WithDescription($"{arg.User.Mention}, Adlı Kullanıcının Başvurusu: \n \n **Kendinizden Bahsedin** \n {fffffffffood1} \n **Unturned Hakkında** \n {fffffffffood2 } \n **Plan, Fikir Ve Düşünceleriniz Neler?** \n {fffffffffood3} \n **Daha Önce Yasaklanmanız Bulunuyor mu?** \n {fffffffffood4}").WithThumbnailUrl("https://cdn.discordapp.com/attachments/959142220366237796/962008357990977626/122.png").Build();

                    AllowedMentions mentionsssssssss = new AllowedMentions();
                    mentionsssssssss.AllowedTypes = AllowedMentionTypes.Users;

                    var channellsssssss = _client.GetChannel(983336526958194748) as SocketTextChannel; // Gets the channel to send the message in
                    await channellsssssss.SendMessageAsync(" ", false, embed: dbbbbbbbbbb);
                    break;
                case "oocyetkili":
                    List<SocketMessageComponentData> componentssssssssss = arg.Data.Components.ToList();
                    string ffffffffffood1 = componentssssssssss.First(x => x.CustomId == "oocyetkili1").Value;
                    string ffffffffffood2 = componentssssssssss.First(x => x.CustomId == "oocyetkili2").Value;
                    string ffffffffffood3 = componentssssssssss.First(x => x.CustomId == "oocyetkili3").Value;
                    string ffffffffffood4 = componentssssssssss.First(x => x.CustomId == "oocyetkili4").Value;

                    var dbbbbbbbbbbb = new EmbedBuilder().WithTitle("**Steampunk Roleplay - Başvuru**").WithDescription($"{arg.User.Mention}, Adlı Kullanıcının Başvurusu: \n \n **Kendinizden Bahsedin** \n {ffffffffffood1} \n **Unturned Hakkında** \n {ffffffffffood2 } \n **Plan, Fikir Ve Düşünceleriniz Neler?** \n {ffffffffffood3} \n **Daha Önce Yasaklanmanız Bulunuyor mu?** \n {ffffffffffood4}").WithThumbnailUrl("https://cdn.discordapp.com/attachments/959142220366237796/962008357990977626/122.png").Build();

                    AllowedMentions mentionssssssssss = new AllowedMentions();
                    mentionssssssssss.AllowedTypes = AllowedMentionTypes.Users;

                    var channellssssssss = _client.GetChannel(983336658273468416) as SocketTextChannel; // Gets the channel to send the message in
                    await channellssssssss.SendMessageAsync(" ", false, embed: dbbbbbbbbbbb);
                    break;

                case "uyarıver":
                    List<SocketMessageComponentData> componentsssssssssssss = arg.Data.Components.ToList();
                    string fffffffffffffood1 = componentsssssssssssss.First(x => x.CustomId == "uyarıver1").Value;
                    string fffffffffffffood2 = componentsssssssssssss.First(x => x.CustomId == "uyarıver2").Value;
                    string fffffffffffffood3 = componentsssssssssssss.First(x => x.CustomId == "uyarıver3").Value;
                    string fffffffffffffood4 = componentsssssssssssss.First(x => x.CustomId == "uyarıver4").Value;

                    var dbbbbbbbbbbbb = new EmbedBuilder().WithTitle("**Steampunk Roleplay - Uyarı**").WithDescription($"{arg.User.Mention}, Adlı Yetkilinin Verdiği Uyarı Bilgileri: \n \n **OOC Ad:** \n {fffffffffffffood1} \n **IC Ad:** \n {fffffffffffffood2 } \n **Steam64 ID:** \n {fffffffffffffood3} \n **Discord Nick:** \n {fffffffffffffood4}").WithThumbnailUrl("https://cdn.discordapp.com/attachments/959142220366237796/962008357990977626/122.png").Build();

                    AllowedMentions mentionsssssssssss = new AllowedMentions();
                    mentionsssssssssss.AllowedTypes = AllowedMentionTypes.Users;

                    var channellsssssssss = _client.GetChannel(983347592433905734) as SocketTextChannel; // Gets the channel to send the message in
                    await channellsssssssss.SendMessageAsync(" ", false, embed: dbbbbbbbbbbbb);
                    break;
                case "banneden":
                    List<SocketMessageComponentData> componentssssssssssssss = arg.Data.Components.ToList();
                    string ffffffffffffffood1 = componentssssssssssssss.First(x => x.CustomId == "uyarıver1").Value;
                    string ffffffffffffffood2 = componentssssssssssssss.First(x => x.CustomId == "uyarıver2").Value;
                    string ffffffffffffffood3 = componentssssssssssssss.First(x => x.CustomId == "uyarıver3").Value;
                    string ffffffffffffffood4 = componentssssssssssssss.First(x => x.CustomId == "uyarıver4").Value;

                    var dbbbbbbbbbbbbb = new EmbedBuilder().WithTitle("**Steampunk Roleplay - Ban Bilgi**").WithDescription($"{arg.User.Mention}, Adlı Yetkilinin Banladığı Kişinin Bilgileri: \n \n **OOC/IC Ad:** \n {ffffffffffffffood1} \n **Ban Nedeni:** \n {ffffffffffffffood2 } \n **Steam64 ID:** \n {ffffffffffffffood3} \n **Discord Nick:** \n {ffffffffffffffood4}").WithThumbnailUrl("https://cdn.discordapp.com/attachments/959142220366237796/962008357990977626/122.png").Build();

                    AllowedMentions mentionssssssssssss = new AllowedMentions();
                    mentionssssssssssss.AllowedTypes = AllowedMentionTypes.Users;

                    var channellssssssssss = _client.GetChannel(983347632653074452) as SocketTextChannel; // Gets the channel to send the message in
                    await channellssssssssss.SendMessageAsync(" ", false, embed: dbbbbbbbbbbbbb);
                    break;

                case "yetkilisikayet":
                    List<SocketMessageComponentData> componentsssssssssssssss = arg.Data.Components.ToList();
                    string fffffffffffffffood1 = componentsssssssssssssss.First(x => x.CustomId == "yetkilisikayet1").Value;
                    string fffffffffffffffood2 = componentsssssssssssssss.First(x => x.CustomId == "yetkilisikayet2").Value;

                    var dbbbbbbbbbbbbbb = new EmbedBuilder().WithTitle("**Steampunk Roleplay - Yetkili Şikayet**").WithDescription($"{arg.User.Mention}, Adlı Oyuncunun Yetkili Şikayeti: \n \n **Yetkili:** \n {fffffffffffffffood1} \n **Şikayeti::** \n {fffffffffffffffood2 }").WithThumbnailUrl("https://cdn.discordapp.com/attachments/959142220366237796/962008357990977626/122.png").Build();

                    AllowedMentions mentionsssssssssssss = new AllowedMentions();
                    mentionsssssssssssss.AllowedTypes = AllowedMentionTypes.Users;

                    var channellsssssssssss = _client.GetChannel(983347483868536872) as SocketTextChannel; // Gets the channel to send the message in
                    await channellsssssssssss.SendMessageAsync(" ", false, embed: dbbbbbbbbbbbbbb);
                    break;

                case "YetkiliPuanlama":
                    List<SocketMessageComponentData> componentssssssssssssssss = arg.Data.Components.ToList();
                    string ffffffffffffffffood1 = componentssssssssssssssss.First(x => x.CustomId == "YetkiliPuanlama1").Value;

                    var dbbbbbbbbbbbbbbb = new EmbedBuilder().WithTitle("**Reponse Mod - Puanlama**").WithDescription($"{arg.User.Mention}, Adlı Kullanıcının Puanlaması: \n \n **Puanlaması:** \n {ffffffffffffffffood1}").WithThumbnailUrl("https://cdn.discordapp.com/attachments/959142220366237796/962008357990977626/122.png").Build();

                    AllowedMentions mentionssssssssssssss = new AllowedMentions();
                    mentionssssssssssssss.AllowedTypes = AllowedMentionTypes.Users;

                    var channellssssssssssss = _client.GetChannel(983716868294578236) as SocketTextChannel; // Gets the channel to send the message in
                    await channellssssssssssss.SendMessageAsync(" ", false, embed: dbbbbbbbbbbbbbbb);
                    break;

                case "öneri":
                    List<SocketMessageComponentData> componentsssssssssssssssss = arg.Data.Components.ToList();
                    string fffffffffffffffffood1 = componentsssssssssssssssss.First(x => x.CustomId == "öneri1").Value;

                    var dbbbbbbbbbbbbbbbb = new EmbedBuilder().WithTitle("**Reponse Mod - Öneri**").WithDescription($"{arg.User.Mention}, Adlı Oyuncunun Önerisi: \n \n **Öneri:** \n {fffffffffffffffffood1}").WithThumbnailUrl("https://cdn.discordapp.com/attachments/959142220366237796/962008357990977626/122.png").Build();

                    AllowedMentions mentionsssssssssssssss = new AllowedMentions();
                    mentionsssssssssssssss.AllowedTypes = AllowedMentionTypes.Users;

                    var channellsssssssssssss = _client.GetChannel(983716350319022140) as SocketTextChannel; // Gets the channel to send the message in
                    await channellsssssssssssss.SendMessageAsync(" ", false, embed: dbbbbbbbbbbbbbbbb);
                    break;
                case "illegal":
                    List<SocketMessageComponentData> componentssssssssssssssssss = arg.Data.Components.ToList();
                    string ffffffffffffffffffood1 = componentssssssssssssssssss.First(x => x.CustomId == "illegal1").Value;

                    var dbbbbbbbbbbbbbbbbb = new EmbedBuilder().WithTitle("**Steampunk Roleplay - İllegal Rol**").WithDescription($"{arg.User.Mention}, Adlı Oyuncunun İllegal Rol: \n \n **Rol:** \n {ffffffffffffffffffood1}").WithThumbnailUrl("https://cdn.discordapp.com/attachments/959142220366237796/962008357990977626/122.png").Build();

                    AllowedMentions mentionssssssssssssssss = new AllowedMentions();
                    mentionssssssssssssssss.AllowedTypes = AllowedMentionTypes.Users;

                    var channellssssssssssssss = _client.GetChannel(983367502325231627) as SocketTextChannel; // Gets the channel to send the message in
                    await channellssssssssssssss.SendMessageAsync(" ", false, embed: dbbbbbbbbbbbbbbbbb);
                    break;
            }


        }
        public async Task AnnounceJoinedUser(SocketGuildUser user) //Welcomes the new user
        {
            SocketGuild guild = _client.GetGuild(953334465076273163);
            var channel = _client.GetChannel(983709131468865536) as SocketTextChannel; // Gets the channel to send the message in
            var rep = new EmbedBuilder();
            rep.WithTitle($"Reponse Mod");
            rep.WithColor(153, 136, 204);
            rep.WithAuthor("Reponse Mod", "https://cdn.discordapp.com/attachments/959142220366237796/962008357990977626/122.png");
            rep.WithThumbnailUrl("https://cdn.discordapp.com/attachments/959142220366237796/962008357990977626/122.png");
            rep.WithFooter("Reponse Mod", "https://cdn.discordapp.com/attachments/959142220366237796/962008357990977626/122.png");
            rep.WithDescription($"**{user.Username}** Adlı Kullanıcı **Reponse Moda** Giriş Yaptı! \n \n **İşte Bilgileri;** \n Adı: {user.Username} \n Kodu : {user.DiscriminatorValue}");
            await channel.SendMessageAsync($"", false, rep.Build());

            await (user as IGuildUser).AddRoleAsync(guild.GetRole(953337065066606602));

        }


        private Task LogAsync(LogMessage log)
        {
            Console.WriteLine(log.ToString());
            return Task.CompletedTask;
        }



        private Task ReadyAsync()
        {
            Console.WriteLine($"{_client.CurrentUser} is connected!");

            return Task.CompletedTask;
        }




        private async Task MessageReceivedAsync(SocketMessage message)
        {
            SocketGuild guild = _client.GetGuild(953334465076273163);

            if (message.Author.Id == _client.CurrentUser.Id)
                return;

            switch (message.Content)
            {



                case "!kayıtaç":

                    var cbss = new ComponentBuilder().WithButton("Kayıt Ol!", "kayıt", ButtonStyle.Success).Build();
                    var db = new EmbedBuilder().WithTitle("**Reponse Mod - Register System**").WithDescription("Reponse Moda Hoşgeldin, İçeride seni yep yeni süprizler bekliyor hadi daha ne bekliyorsun?").WithThumbnailUrl("https://cdn.discordapp.com/attachments/959142220366237796/962008357990977626/122.png").Build();
                    await message.Channel.SendMessageAsync(" ", embed: db, components: cbss);
                    break;

                case "!oyuncupanel":

                    var cccccccbssss = new ComponentBuilder().WithButton("Reponse Mod Puanlama", "yetkilipuan", ButtonStyle.Success).WithButton("Öneri", "öneri", ButtonStyle.Success).Build();
                    var dbbbbbbbbbb = new EmbedBuilder().WithTitle("**Reponse Mod - Member Panel**").WithDescription("Bu Panel Güzel Oyuncularımızın Konforlu Bir Şekilde Akıllarındakileri Kayda Geçirmesi İçin Yapılmıştır.").WithThumbnailUrl("https://cdn.discordapp.com/attachments/959142220366237796/962008357990977626/122.png").Build();
                    await message.Channel.SendMessageAsync(" ", embed: dbbbbbbbbbb, components: cccccccbssss);
                    break;

                case "!adminpanel":

                    var ccccccbssss = new ComponentBuilder().WithButton("Uyarı Ver", "uyarıver", ButtonStyle.Success).WithButton("Ban Bildir", "banneden", ButtonStyle.Success).Build();
                    var dbbbbbbbbb = new EmbedBuilder().WithTitle("**Steampunk - Admin Panel**").WithDescription("Bu Panel Yetkililerimizin Daha İyi Ve Hızlı Şekilde Hareket Edilmesi İçin Yapıldı!.").WithThumbnailUrl("https://cdn.discordapp.com/attachments/959142220366237796/962008357990977626/122.png").Build();
                    await message.Channel.SendMessageAsync(" ", embed: dbbbbbbbbb, components: ccccccbssss);
                    break;

                case "!destekçağır":

                    var cbssss = new ComponentBuilder().WithButton("IC Destek Ekibi Çağır!", "ıcdestek", ButtonStyle.Success).WithButton("OOC Destek Ekibi Çağır!", "oocdestek", ButtonStyle.Success).Build();
                    var dbbbb = new EmbedBuilder().WithTitle("**Steampunk - Destek Çağır**").WithDescription("Gereksiz Yere Destek Ekibi Çağıran Kişiler Uyarı Alacaktır Bilginize.").WithThumbnailUrl("https://cdn.discordapp.com/attachments/959142220366237796/962008357990977626/122.png").Build();
                    await message.Channel.SendMessageAsync(" ", embed: dbbbb, components: cbssss);
                    break;

                case "!destekaç":


                    var cbs = new ComponentBuilder().WithButton("🔓 Destek Talebi Oluştur!", "destekac", ButtonStyle.Success).Build();
                    var dbb = new EmbedBuilder().WithTitle("**Reponse Mod - Support System**").WithDescription("Satın Alma Ve Plugin Destek İçin Asşağıdaki Butona Basmanız Gerekmekte!.").WithThumbnailUrl("https://cdn.discordapp.com/attachments/959142220366237796/962008357990977626/122.png").Build();

                    await message.Channel.SendMessageAsync(" ", embed: dbb, components: cbs);

                    break;

                case "!başvuru":


                    var cbbs = new ComponentBuilder().WithButton("Polis", "polis", ButtonStyle.Primary).WithButton("Asker", "asker", ButtonStyle.Primary).WithButton("Baron", "baron", ButtonStyle.Danger).WithButton("Mafya", "mafya", ButtonStyle.Danger).WithButton("Terorist", "terorist", ButtonStyle.Danger).WithButton("Vagos", "vagos", ButtonStyle.Danger).WithButton("Grove", "grove", ButtonStyle.Danger).WithButton("Ems", "ems", ButtonStyle.Success).WithButton("IC Yetkili", "ıcyetkili", ButtonStyle.Secondary).WithButton("OOC Yetkili", "oocyetkili", ButtonStyle.Secondary).Build();
                    var dbbb = new EmbedBuilder().WithTitle("**Steampunk - Başvuru**").WithDescription("Başvurmak İçin Asşağıdan Başvuracağınız Alanı Seçiniz. \n \n **Dip Not:** \n Hata Oluştu Alır İseniz Önemsemeyiniz.").WithThumbnailUrl("https://cdn.discordapp.com/attachments/959142220366237796/962008357990977626/122.png").Build();

                    await message.Channel.SendMessageAsync(" ", embed: dbbb, components: cbbs);

                    break;

            }




        }


        private async Task InteractionCreatedAsync(SocketInteraction interaction)
        {
            Random rnd = new Random();

            if (interaction is SocketMessageComponent component)
            {

                SocketGuild guild = _client.GetGuild(953334465076273163);
                var user = _client.GetUser(component.User.Id);


                switch (component.Data.CustomId)
                {
                    case "illegal":
                        var mbbbbbbbbbbbbbbbbbbb = new ModalBuilder()
.WithTitle("İllegal Rol")
.WithCustomId("illegal")

.AddTextInput("Rol", "illegal1", TextInputStyle.Paragraph,
"(Rolünüzü Yazınız?)");

                        component.RespondWithModalAsync(mbbbbbbbbbbbbbbbbbbb.Build());

                        break;

                    case "öneri":
                        var mbbbbbbbbbbbbbbbbbb = new ModalBuilder()
.WithTitle("Sunucu Öneri")
.WithCustomId("öneri")

.AddTextInput("Öneri", "öneri1", TextInputStyle.Paragraph,
"(Önerileriniz Nedir?)");

                        component.RespondWithModalAsync(mbbbbbbbbbbbbbbbbbb.Build());

                        break;

                    case "yetkilipuan":
                        var mbbbbbbbbbbbbbbbbb = new ModalBuilder()
.WithTitle("Reponse Mod Puanlama")
.WithCustomId("YetkiliPuanlama")

.AddTextInput("Puanlamanız", "YetkiliPuanlama1", TextInputStyle.Paragraph,
"(Puanınız)");

                        component.RespondWithModalAsync(mbbbbbbbbbbbbbbbbb.Build());

                        break;

                    case "yetkilisikayet":
                        var mbbbbbbbbbbbbbbbb = new ModalBuilder()
.WithTitle("Yetkili Şikayet")
.WithCustomId("yetkilisikayet")

.AddTextInput("Yetkili", "yetkilisikayet1", TextInputStyle.Paragraph,
"(Ad, vb..)")

.AddTextInput("Şikayet?", "yetkilisikayet2", TextInputStyle.Paragraph,
"(Şikayetinizi Yazınız...)");

                        component.RespondWithModalAsync(mbbbbbbbbbbbbbbbb.Build());

                        break;

                    case "banneden":
                        var mbbbbbbbbbbbbbbb = new ModalBuilder()
.WithTitle("Oyuncu Ban Neden")
.WithCustomId("banneden")

.AddTextInput("OOC Ad / IC Ad", "uyarıver1", TextInputStyle.Paragraph,
"(OOC Ad / IC Ad)")

.AddTextInput("Ban Nedeni?", "uyarıver2", TextInputStyle.Paragraph,
"(Ban Nedeni)")

.AddTextInput("Steam64 ID", "uyarıver3", TextInputStyle.Paragraph,
"(Steam64 ID)")

.AddTextInput("Discord Bilgisi", "uyarıver4", TextInputStyle.Paragraph,
"(ID, vb... [Bilmiyor İseniz Bilmiyorum Yazınız])");



                        component.RespondWithModalAsync(mbbbbbbbbbbbbbbb.Build());

                        break;

                    case "uyarıver":
                        var mbbbbbbbbbbbbb = new ModalBuilder()
.WithTitle("Oyuncu Uyarı Ver")
.WithCustomId("uyarıver")

.AddTextInput("OOC Ad", "uyarıver1", TextInputStyle.Paragraph,
"(OOC Ad)")

.AddTextInput("IC Ad", "uyarıver2", TextInputStyle.Paragraph,
"(IC Ad)")

.AddTextInput("Steam64 ID", "uyarıver3", TextInputStyle.Paragraph,
"(Steam64 ID)")

.AddTextInput("Discord Bilgisi", "uyarıver4", TextInputStyle.Paragraph,
"(ID, vb... [Bilmiyor İseniz Bilmiyorum Yazınız])");



                        component.RespondWithModalAsync(mbbbbbbbbbbbbb.Build());

                        break;

                    case "ıcdestek":


                        var channnnnnnel = _client.GetChannel(983329137374679060) as SocketTextChannel; // Gets the channel to send the message in
                        var rep = new EmbedBuilder();
                        rep.WithTitle($"Steampunk IC Destek Ekibi");
                        rep.WithColor(153, 136, 204);
                        rep.WithAuthor("IC Destek Ekibi - Biri Sizi Çağrıyor!", "https://cdn.discordapp.com/attachments/959142220366237796/962008357990977626/122.png");
                        rep.WithThumbnailUrl("https://cdn.discordapp.com/attachments/959142220366237796/962008357990977626/122.png");
                        rep.WithFooter("Reponse Mod", "https://cdn.discordapp.com/attachments/959142220366237796/962008357990977626/122.png");
                        rep.WithDescription($"**{user.Username}** Adlı Kullanıcı **IC Destek Ekibini** Çağrıyor! \n \n **İşte Bilgileri;** \n Adı: {user.Username} \n Kodu : {user.DiscriminatorValue} \n \n <@&978366583053369414>  <@&979670003483828264> <@&979122474648236042> <@&979122761077231668> <@&979122762360692736> <@&979122761836404746> <@&978878035598114886> ");
                        await channnnnnnel.SendMessageAsync($"", false, rep.Build());


                        component.RespondAsync("Başarılı Bir Şekilde IC Destek Ekibi Çağrıldı!", ephemeral: true);

                        break;

                    case "oocdestek":


                        var channnnnnel = _client.GetChannel(983329137374679060) as SocketTextChannel; // Gets the channel to send the message in
                        var rerrrp = new EmbedBuilder();
                        rerrrp.WithTitle($"Steampunk OOC Destek Ekibi");
                        rerrrp.WithColor(153, 136, 204);
                        rerrrp.WithAuthor("OOC Destek Ekibi - Biri Sizi Çağrıyor!", "https://cdn.discordapp.com/attachments/959142220366237796/962008357990977626/122.png");
                        rerrrp.WithThumbnailUrl("https://cdn.discordapp.com/attachments/959142220366237796/962008357990977626/122.png");
                        rerrrp.WithFooter("Reponse Mod", "https://cdn.discordapp.com/attachments/959142220366237796/962008357990977626/122.png");
                        rerrrp.WithDescription($"**{user.Username}** Adlı Kullanıcı **OOC Destek Ekibini** Çağrıyor! \n \n **İşte Bilgileri;** \n Adı: {user.Username} \n Kodu : {user.DiscriminatorValue} \n \n  <@&982631661349011456>  <@&982530788941766687> <@&983088927193845850> <@&983088927726510130> <@&983086063214022686> <@&979122470399397948> <@&982631660224917504> ");
                        await channnnnnel.SendMessageAsync($"", false, rerrrp.Build());


                        component.RespondAsync("Başarılı Bir Şekilde OOC Destek Ekibi Çağrıldı!", ephemeral: true);

                        break;




                    case "oocyetkili":
                        var mbbbbbbbbbbbb = new ModalBuilder()
.WithTitle("OOC Yetkili Başvuru")
.WithCustomId("oocyetkili")

.AddTextInput("Kendinizden Bahsedin", "oocyetkili1", TextInputStyle.Paragraph,
"(Ad, Yaş, Oyun Kullanıcı Adı, Mikrofon Durumu, Tecrübe Ve Benzeri Başlıklar İle Detaylandırınız.)")

.AddTextInput("Unturned Hakkında", "oocyetkili2", TextInputStyle.Paragraph,
"(Daha önceden Unturned'te Bulundunuz mu?, Bulunduysanız hangi konumda?)")

.AddTextInput("Plan, Fikir Ve Düşünceleriniz Neler?", "oocyetkili3", TextInputStyle.Paragraph,
"(Çeşitli ARGE veya fikirlerinizi belirtiniz.)")

.AddTextInput("Daha Önce Yasaklanmanız Bulunuyor mu?", "oocyetkili4", TextInputStyle.Paragraph,
"(Bu tarz bir durum yaşandıysa detaylandırarak açıklayınız.)");



                        component.RespondWithModalAsync(mbbbbbbbbbbbb.Build());

                        break;

                    case "ıcyetkili":
                        var mbbbbbbbbbbb = new ModalBuilder()
.WithTitle("IC Yetkili Başvuru")
.WithCustomId("ıcyetkili")

.AddTextInput("Kendinizden Bahsedin", "ıcyetkili1", TextInputStyle.Paragraph,
"(Ad, Yaş, Oyun Kullanıcı Adı, Mikrofon Durumu, Tecrübe Ve Benzeri Başlıklar İle Detaylandırınız.)")

.AddTextInput("Unturned Hakkında", "ıcyetkili2", TextInputStyle.Paragraph,
"(Daha önceden Unturned'te Bulundunuz mu?, Bulunduysanız hangi konumda?)")

.AddTextInput("Plan, Fikir Ve Düşünceleriniz Neler?", "ıcyetkili3", TextInputStyle.Paragraph,
"(Çeşitli ARGE veya fikirlerinizi belirtiniz.)")

.AddTextInput("Daha Önce Yasaklanmanız Bulunuyor mu?", "ıcyetkili4", TextInputStyle.Paragraph,
"(Bu tarz bir durum yaşandıysa detaylandırarak açıklayınız.)");



                        component.RespondWithModalAsync(mbbbbbbbbbbb.Build());

                        break;

                    case "ems":
                        var mbbbbbbbbbb = new ModalBuilder()
.WithTitle("Ems Başvuru")
.WithCustomId("ems")

.AddTextInput("Kendinizden Bahsedin", "ems1", TextInputStyle.Paragraph,
"(Ad, Yaş, Oyun Kullanıcı Adı, Tecrübe Ve Benzeri Başlıklar İle Detaylandırınız.)")

.AddTextInput("Doktorluk Ve Unturned Hakkında", "ems2", TextInputStyle.Paragraph,
"(Daha önceden Unturned'te Bulundunuz mu?, Bulunduysanız hangi konumda?)")

.AddTextInput("Plan, Fikir Ve Düşünceleriniz Neler?", "ems3", TextInputStyle.Paragraph,
"(Çeşitli ARGE veya fikirlerinizi belirtiniz.)")

.AddTextInput("Daha Önce Yasaklanmanız Bulunuyor mu?", "ems4", TextInputStyle.Paragraph,
"(Bu tarz bir durum yaşandıysa detaylandırarak açıklayınız.)");



                        component.RespondWithModalAsync(mbbbbbbbbbb.Build());

                        break;

                    case "grove":
                        var mbbbbbbb = new ModalBuilder()
.WithTitle("Grove Başvuru")
.WithCustomId("grove")

.AddTextInput("Kendinizden Bahsedin", "grove1", TextInputStyle.Paragraph,
"(Ad, Yaş, Oyun Kullanıcı Adı, Tecrübe Ve Benzeri Başlıklar İle Detaylandırınız.)")

.AddTextInput("Grove Çetesi Ve Unturned Hakkında", "grove2", TextInputStyle.Paragraph,
"(Daha önceden Unturned'te Bulundunuz mu?, Bulunduysanız hangi konumda?)")

.AddTextInput("Plan, Fikir Ve Düşünceleriniz Neler?", "grove3", TextInputStyle.Paragraph,
"(Çeşitli ARGE veya fikirlerinizi belirtiniz.)")

.AddTextInput("Daha Önce Yasaklanmanız Bulunuyor mu?", "grove4", TextInputStyle.Paragraph,
"(Bu tarz bir durum yaşandıysa detaylandırarak açıklayınız.)");



                        component.RespondWithModalAsync(mbbbbbbb.Build());

                        break;

                    case "vagos":
                        var mbbbbbb = new ModalBuilder()
.WithTitle("Vagos Başvuru")
.WithCustomId("vagos")

.AddTextInput("Kendinizden Bahsedin", "vagos1", TextInputStyle.Paragraph,
"(Ad, Yaş, Oyun Kullanıcı Adı, Tecrübe Ve Benzeri Başlıklar İle Detaylandırınız.)")

.AddTextInput("Vagos Çetesi Ve Unturned Hakkında", "vagos2", TextInputStyle.Paragraph,
"(Daha önceden Unturned'te Bulundunuz mu?, Bulunduysanız hangi konumda?)")

.AddTextInput("Plan, Fikir Ve Düşünceleriniz Neler?", "vagos3", TextInputStyle.Paragraph,
"(Çeşitli ARGE veya fikirlerinizi belirtiniz.)")

.AddTextInput("Daha Önce Yasaklanmanız Bulunuyor mu?", "vagos4", TextInputStyle.Paragraph,
"(Bu tarz bir durum yaşandıysa detaylandırarak açıklayınız.)");



                        component.RespondWithModalAsync(mbbbbbb.Build());

                        break;

                    case "terorist":
                        var mbbbbb = new ModalBuilder()
.WithTitle("Terörist Başvuru")
.WithCustomId("terorist")

.AddTextInput("Kendinizden Bahsedin", "terorist1", TextInputStyle.Paragraph,
"(Ad, Yaş, Oyun Kullanıcı Adı, Tecrübe Ve Benzeri Başlıklar İle Detaylandırınız.)")

.AddTextInput("Teroristlik Ve Unturned Hakkında", "terorist2", TextInputStyle.Paragraph,
"(Daha önceden Unturned'te Bulundunuz mu?, Bulunduysanız hangi konumda?)")

.AddTextInput("Plan, Fikir Ve Düşünceleriniz Neler?", "terorist3", TextInputStyle.Paragraph,
"(Çeşitli ARGE veya fikirlerinizi belirtiniz.)")

.AddTextInput("Daha Önce Yasaklanmanız Bulunuyor mu?", "terorist4", TextInputStyle.Paragraph,
"(Bu tarz bir durum yaşandıysa detaylandırarak açıklayınız.)");



                        component.RespondWithModalAsync(mbbbbb.Build());

                        break;

                    case "mafya":
                        var mbbbb = new ModalBuilder()
.WithTitle("Mafya Başvuru")
.WithCustomId("mafya")

.AddTextInput("Kendinizden Bahsedin", "mafya1", TextInputStyle.Paragraph,
"(Ad, Yaş, Oyun Kullanıcı Adı, Tecrübe Ve Benzeri Başlıklar İle Detaylandırınız.)")

.AddTextInput("Mafyalık Ve Unturned Hakkında", "mafya2", TextInputStyle.Paragraph,
"(Daha önceden Unturned'te Bulundunuz mu?, Bulunduysanız hangi konumda?)")

.AddTextInput("Plan, Fikir Ve Düşünceleriniz Neler?", "mafya3", TextInputStyle.Paragraph,
"(Çeşitli ARGE veya fikirlerinizi belirtiniz.)")

.AddTextInput("Daha Önce Yasaklanmanız Bulunuyor mu?", "mafya4", TextInputStyle.Paragraph,
"(Bu tarz bir durum yaşandıysa detaylandırarak açıklayınız.)");



                        component.RespondWithModalAsync(mbbbb.Build());

                        break;















                    case "baron":
                        var mbbb = new ModalBuilder()
.WithTitle("Baron Başvuru")
.WithCustomId("baron")

.AddTextInput("Kendinizden Bahsedin", "baron1", TextInputStyle.Paragraph,
"(Ad, Yaş, Oyun Kullanıcı Adı, Tecrübe Ve Benzeri Başlıklar İle Detaylandırınız.)")

.AddTextInput("Baronluk Ve Unturned Hakkında", "baron2", TextInputStyle.Paragraph,
"(Daha önceden Unturned'te Bulundunuz mu?, Bulunduysanız hangi konumda?)")

.AddTextInput("Plan, Fikir Ve Düşünceleriniz Neler?", "baron3", TextInputStyle.Paragraph,
"(Çeşitli ARGE veya fikirlerinizi belirtiniz.)")

.AddTextInput("Daha Önce Yasaklanmanız Bulunuyor mu?", "baron4", TextInputStyle.Paragraph,
"(Bu tarz bir durum yaşandıysa detaylandırarak açıklayınız.)");



                        component.RespondWithModalAsync(mbbb.Build());

                        break;

                    case "asker":
                        var mbb = new ModalBuilder()
.WithTitle("Asker Başvuru")
.WithCustomId("asker")

.AddTextInput("Kendinizden Bahsedin", "asker1", TextInputStyle.Paragraph,
"(Ad, Yaş, Oyun Kullanıcı Adı, Tecrübe Ve Benzeri Başlıklar İle Detaylandırınız.)")

.AddTextInput("Askerlik Ve Unturned Hakkında", "asker2", TextInputStyle.Paragraph,
"(Daha önceden Unturned'te Bulundunuz mu?, Bulunduysanız hangi konumda?)")

.AddTextInput("Plan, Fikir Ve Düşünceleriniz Neler?", "asker3", TextInputStyle.Paragraph,
"(Çeşitli ARGE veya fikirlerinizi belirtiniz.)")

.AddTextInput("Daha Önce Yasaklanmanız Bulunuyor mu?", "asker4", TextInputStyle.Paragraph,
"(Bu tarz bir durum yaşandıysa detaylandırarak açıklayınız.)");



                        component.RespondWithModalAsync(mbb.Build());

                        break;

                    case "polis":
                        var mb = new ModalBuilder()
.WithTitle("Polis Başvuru")
.WithCustomId("food_menu")

.AddTextInput("Kendinizden Bahsedin", "food_name4", TextInputStyle.Paragraph,
"(Ad, Yaş, Oyun Kullanıcı Adı, Tecrübe Ve Benzeri Başlıklar İle Detaylandırınız.)")

.AddTextInput("Polislik Ve Unturned Hakkında", "food_name2", TextInputStyle.Paragraph,
"(Daha önceden Unturned'te Bulundunuz mu?, Bulunduysanız hangi konumda?)")

.AddTextInput("Plan, Fikir Ve Düşünceleriniz Neler?", "food_name3", TextInputStyle.Paragraph,
"(Çeşitli ARGE veya fikirlerinizi belirtiniz.)")

.AddTextInput("Daha Önce Yasaklanmanız Bulunuyor mu?", "food_name1", TextInputStyle.Paragraph,
"(Bu tarz bir durum yaşandıysa detaylandırarak açıklayınız.)");



                        component.RespondWithModalAsync(mb.Build());

                        break;

                    case "kayıt":


                        await (component.User as IGuildUser).RemoveRoleAsync(guild.GetRole(953337065066606602));
                        await (component.User as IGuildUser).AddRoleAsync(guild.GetRole(983711881913040926));
                        component.RespondAsync("Başarılı Bir Şekilde Kayıt Oldun!", ephemeral: true);
                        break;

                    case "destekac":


                        var channel = guild.Channels.SingleOrDefault(x => x.Name == user.Id.ToString());

                        if (channel == null) // there is no channel with the name of 'log'
                        {
                            // create the channel
                            var newChannel = await guild.CreateTextChannelAsync(name: "Secim-" + user.Id, func: x => { x.CategoryId = 983714945701138553; });
                            component.RespondAsync($"Başarılı Bir Şekilde Destek Odan Açıldı. <#{newChannel.Id}>", ephemeral: true);

                            await newChannel.ModifyAsync(c =>
                            {
                                c.PermissionOverwrites = new[]
                                {
                    new Overwrite(guild.EveryoneRole.Id, PermissionTarget.Role, new OverwritePermissions(viewChannel: PermValue.Deny)),
                    new Overwrite(user.Id, PermissionTarget.User, new OverwritePermissions(viewChannel: PermValue.Allow)),
                            };
                            });

                            var cb = new ComponentBuilder().WithButton("Satın Alma", "genel", ButtonStyle.Primary)
                                      .WithButton("Plugin Destek", "plugin", ButtonStyle.Primary).Build();
                            var db = new EmbedBuilder().WithTitle($"**Departman Seçiniz!**").WithDescription($"{component.User.Mention}, Departmanı Seçtikten Sonra Yetkili Ekibimiz Sizinle İletişime Geçecektir.").WithThumbnailUrl("https://cdn.discordapp.com/attachments/959142220366237796/962008357990977626/122.png").Build();

                            await newChannel.SendMessageAsync($" ", embed: db, components: cb);



                            var newChannelId = newChannel.Id;


                        }
                        else
                        {
                            user.SendMessageAsync("Lütfen Tekrar Deneyiniz");
                        }

                        break;
                    case "genel":
                        var channelssx = guild.Channels.SingleOrDefault(x => x.Id == component.Channel.Id);
                        channelssx.DeleteAsync();


                        var channelss = guild.Channels.SingleOrDefault(x => x.Name == "satis-" + user.Id);

                        if (channelss == null) // there is no channel with the name of 'log'
                        {

                            // create the channel
                            var newChannels = await guild.CreateTextChannelAsync(name: "satis-" + user.Id, func: x => { x.CategoryId = 983720523148177438; });
                            await newChannels.ModifyAsync(c =>
                            {
                                c.PermissionOverwrites = new[]
                                {
                    new Overwrite(guild.EveryoneRole.Id, PermissionTarget.Role, new OverwritePermissions(viewChannel: PermValue.Deny)),
                    new Overwrite(user.Id, PermissionTarget.User, new OverwritePermissions(viewChannel: PermValue.Allow)),
                            };
                            });

                            var cb = new ComponentBuilder().WithButton("Destek Talebini Kapat!", "kapat", ButtonStyle.Danger).Build();
                            var db = new EmbedBuilder().WithTitle($"**Satış Destek Talebi!**").WithDescription($"{component.User.Mention}, Hoşgeldin Sorununu Anlat Ve Yetkililerin Seninle İlgilenmesini Bekle.").WithThumbnailUrl("https://cdn.discordapp.com/attachments/959142220366237796/962008357990977626/122.png").Build();

                            await newChannels.SendMessageAsync($" ", embed: db, components: cb);

                            var newChannelId = newChannels.Id;
                            try
                            {
                                var dc = new EmbedBuilder();
                                dc.WithTitle("Reponse Mod | Support System");
                                dc.WithAuthor("Reponse Mod", "https://cdn.discordapp.com/attachments/959142220366237796/962008357990977626/122.png");
                                dc.WithDescription($"**Başarılı Bir Şekilde Destek Talebin Açıldı.** \n \n Destek Talebi: <#{newChannels.Id}>");
                                dc.WithThumbnailUrl("https://cdn.discordapp.com/attachments/959142220366237796/962008357990977626/122.png");
                                dc.WithColor(Color.Purple);
                                dc.WithImageUrl("https://cdn.discordapp.com/attachments/959142220366237796/962008357990977626/122.png");
                                dc.WithFooter("Reponse Mod | Support System", "https://cdn.discordapp.com/attachments/959142220366237796/962008357990977626/122.png");
                                await user.SendMessageAsync(" ", false, dc.Build());
                            }
                            catch (Exception)
                            {


                            }
                        }

                        break;


                    case "plugin":
                        var channelssssx = guild.Channels.SingleOrDefault(x => x.Id == component.Channel.Id);
                        channelssssx.DeleteAsync();


                        var channelssss = guild.Channels.SingleOrDefault(x => x.Name == "plugin-" + user.Id);

                        if (channelssss == null) // there is no channel with the name of 'log'
                        {

                            // create the channel
                            var newChannels = await guild.CreateTextChannelAsync(name: "plugin-" + user.Id, func: x => { x.CategoryId = 983720523148177438; });
                            await newChannels.ModifyAsync(c =>
                            {
                                c.PermissionOverwrites = new[]
                                {
                    new Overwrite(guild.EveryoneRole.Id, PermissionTarget.Role, new OverwritePermissions(viewChannel: PermValue.Deny)),
                    new Overwrite(user.Id, PermissionTarget.User, new OverwritePermissions(viewChannel: PermValue.Allow)),
                    new Overwrite(983713576583848016 , PermissionTarget.Role, new OverwritePermissions(viewChannel: PermValue.Allow)),
                    new Overwrite(983713316524412928  , PermissionTarget.Role, new OverwritePermissions(viewChannel: PermValue.Allow)),
      
                            };
                            });

                            var cb = new ComponentBuilder().WithButton("Destek Talebini Kapat!", "kapat", ButtonStyle.Danger).Build();
                            var db = new EmbedBuilder().WithTitle($"**Plugin Destek Talebi!**").WithDescription($"{component.User.Mention}, Hoşgeldin Sorununu Anlat Ve Yetkililerin Seninle İlgilenmesini Bekle.").WithThumbnailUrl("https://cdn.discordapp.com/attachments/959142220366237796/962008357990977626/122.png").Build();

                            await newChannels.SendMessageAsync($" ", embed: db, components: cb);

                            var newChannelId = newChannels.Id;
                            try
                            {
                                var dc = new EmbedBuilder();
                                dc.WithTitle("Reponse Mod | Support System");
                                dc.WithAuthor("Reponse Mod", "https://cdn.discordapp.com/attachments/959142220366237796/962008357990977626/122.png");
                                dc.WithDescription($"**Başarılı Bir Şekilde Destek Talebin Açıldı.** \n \n Destek Talebi: <#{newChannels.Id}>");
                                dc.WithThumbnailUrl("https://cdn.discordapp.com/attachments/959142220366237796/962008357990977626/122.png");
                                dc.WithColor(Color.Purple);
                                dc.WithImageUrl("https://cdn.discordapp.com/attachments/959142220366237796/962008357990977626/122.png");
                                dc.WithFooter("Reponse Mod | Support System", "https://cdn.discordapp.com/attachments/959142220366237796/962008357990977626/122.png");
                                await user.SendMessageAsync(" ", false, dc.Build());
                            }
                            catch (Exception)
                            {


                            }
                        }

                        break;

                    case "paket":
                        var channelsssssx = guild.Channels.SingleOrDefault(x => x.Id == component.Channel.Id);
                        channelsssssx.DeleteAsync();


                        var channelsssss = guild.Channels.SingleOrDefault(x => x.Name == "satis-" + user.Id);

                        if (channelsssss == null) // there is no channel with the name of 'log'
                        {

                            // create the channel
                            var newChannels = await guild.CreateTextChannelAsync(name: "satis-" + user.Id, func: x => { x.CategoryId = 983344452888313906; });
                            await newChannels.ModifyAsync(c =>
                            {
                                c.PermissionOverwrites = new[]
                                {
                    new Overwrite(guild.EveryoneRole.Id, PermissionTarget.Role, new OverwritePermissions(viewChannel: PermValue.Deny)),
                    new Overwrite(user.Id, PermissionTarget.User, new OverwritePermissions(viewChannel: PermValue.Allow)),
                    new Overwrite(971482167752413264 , PermissionTarget.Role, new OverwritePermissions(viewChannel: PermValue.Allow)),

                            };
                            });

                            var cb = new ComponentBuilder().WithButton("Destek Talebini Kapat!", "kapat", ButtonStyle.Danger).Build();
                            var db = new EmbedBuilder().WithTitle($"**Satış Destek Talebi!**").WithDescription($"{component.User.Mention}, Hoşgeldin Alacağın Ürün Hakkında Sorun Var İse Yaz Ve Yetkili Kadromuzun Sizinle İletişime Geçmesini Bekle!.").WithThumbnailUrl("https://cdn.discordapp.com/attachments/959142220366237796/962008357990977626/122.png").Build();

                            await newChannels.SendMessageAsync($" ", embed: db, components: cb);

                            var newChannelId = newChannels.Id;
                            try
                            {
                                var dc = new EmbedBuilder();
                                dc.WithTitle("Steampunk | Support System");
                                dc.WithAuthor("Steampunk", "https://cdn.discordapp.com/attachments/959142220366237796/962008357990977626/122.png");
                                dc.WithDescription($"**Başarılı Bir Şekilde Destek Talebin Açıldı.** \n \n Destek Talebi: <#{newChannels.Id}>");
                                dc.WithThumbnailUrl("https://cdn.discordapp.com/attachments/959142220366237796/962008357990977626/122.png");
                                dc.WithColor(Color.Purple);
                                dc.WithImageUrl("https://cdn.discordapp.com/attachments/959142220366237796/962008357990977626/122.png");
                                dc.WithFooter("Steampunk | Support System", "https://cdn.discordapp.com/attachments/959142220366237796/962008357990977626/122.png");
                                await user.SendMessageAsync(" ", false, dc.Build());
                            }
                            catch (Exception)
                            {


                            }
                        }

                        break;
                    case "Partner":
                        var channelssssssx = guild.Channels.SingleOrDefault(x => x.Id == component.Channel.Id);
                        channelssssssx.DeleteAsync();


                        var channelssssss = guild.Channels.SingleOrDefault(x => x.Name == "Partner-" + user.Id);

                        if (channelssssss == null) // there is no channel with the name of 'log'
                        {

                            // create the channel
                            var newChannels = await guild.CreateTextChannelAsync(name: "Partner-" + user.Id, func: x => { x.CategoryId = 962013641002082344; });
                            await newChannels.ModifyAsync(c =>
                            {
                                c.PermissionOverwrites = new[]
                                {
                    new Overwrite(guild.EveryoneRole.Id, PermissionTarget.Role, new OverwritePermissions(viewChannel: PermValue.Deny)),
                    new Overwrite(user.Id, PermissionTarget.User, new OverwritePermissions(viewChannel: PermValue.Allow)),
                    new Overwrite(953337056556351549 , PermissionTarget.Role, new OverwritePermissions(viewChannel: PermValue.Allow)),
                    new Overwrite(953337057701425162  , PermissionTarget.Role, new OverwritePermissions(viewChannel: PermValue.Allow)),
                    new Overwrite(953337057923706941  , PermissionTarget.Role, new OverwritePermissions(viewChannel: PermValue.Allow)),
                    new Overwrite(953337058787733584  , PermissionTarget.Role, new OverwritePermissions(viewChannel: PermValue.Allow)),

                            };
                            });

                            var cb = new ComponentBuilder().WithButton("Destek Talebini Kapat!", "kapat", ButtonStyle.Danger).Build();
                            var db = new EmbedBuilder().WithTitle($"**Departman Seçiniz!**").WithDescription($"{component.User.Mention}, Departmanı Seçtikten Sonra Yetkili Ekibimiz Sizinle İletişime Geçecektir.").WithThumbnailUrl("https://cdn.discordapp.com/attachments/959142220366237796/962008357990977626/122.png").Build();

                            await newChannels.SendMessageAsync($" ", embed: db, components: cb);

                            var newChannelId = newChannels.Id;
                            try
                            {
                                var dc = new EmbedBuilder();
                                dc.WithTitle("Reponse Mod | Support System");
                                dc.WithAuthor("Reponse Mod", "https://cdn.discordapp.com/attachments/959142220366237796/962008357990977626/122.png");
                                dc.WithDescription($"**Başarılı Bir Şekilde Destek Talebin Açıldı.** \n \n Destek Talebi: <#{newChannels.Id}>");
                                dc.WithThumbnailUrl("https://cdn.discordapp.com/attachments/959142220366237796/962008357990977626/122.png");
                                dc.WithColor(Color.Purple);
                                dc.WithImageUrl("https://cdn.discordapp.com/attachments/959142220366237796/962016214031429662/reponse.png");
                                dc.WithFooter("Reponse Mod | Support System", "https://cdn.discordapp.com/attachments/959142220366237796/962008357990977626/122.png");
                                await user.SendMessageAsync(" ", false, dc.Build());
                            }
                            catch (Exception)
                            {


                            }
                        }

                        break;
                    case "ekib":
                        var channelsssx = guild.Channels.SingleOrDefault(x => x.Id == component.Channel.Id);
                        channelsssx.DeleteAsync();


                        var channelsss = guild.Channels.SingleOrDefault(x => x.Name == "ekib-" + user.Id);

                        if (channelsss == null) // there is no channel with the name of 'log'
                        {

                            // create the channel
                            var newChannels = await guild.CreateTextChannelAsync(name: "ekib-" + user.Id, func: x => { x.CategoryId = 962013641002082344; });
                            await newChannels.ModifyAsync(c =>
                            {
                                c.PermissionOverwrites = new[]
                                {
                    new Overwrite(guild.EveryoneRole.Id, PermissionTarget.Role, new OverwritePermissions(viewChannel: PermValue.Deny)),
                    new Overwrite(user.Id, PermissionTarget.User, new OverwritePermissions(viewChannel: PermValue.Allow)),
                    new Overwrite(953337056556351549 , PermissionTarget.Role, new OverwritePermissions(viewChannel: PermValue.Allow)),
                    new Overwrite(953337057701425162  , PermissionTarget.Role, new OverwritePermissions(viewChannel: PermValue.Allow)),
                    new Overwrite(953337057923706941  , PermissionTarget.Role, new OverwritePermissions(viewChannel: PermValue.Allow)),
                    new Overwrite(953337058787733584  , PermissionTarget.Role, new OverwritePermissions(viewChannel: PermValue.Allow)),

                            };
                            });

                            var cb = new ComponentBuilder().WithButton("Destek Talebini Kapat!", "kapat", ButtonStyle.Danger).Build();
                            var db = new EmbedBuilder().WithTitle($"**Departman Seçiniz!**").WithDescription($"{component.User.Mention}, Departmanı Seçtikten Sonra Yetkili Ekibimiz Sizinle İletişime Geçecektir.").WithThumbnailUrl("https://cdn.discordapp.com/attachments/959142220366237796/962008357990977626/122.png").Build();

                            await newChannels.SendMessageAsync($" ", embed: db, components: cb);

                            var newChannelId = newChannels.Id;
                            try
                            {
                                var dc = new EmbedBuilder();
                                dc.WithTitle("Reponse Mod | Support System");
                                dc.WithAuthor("Reponse Mod", "https://cdn.discordapp.com/attachments/959142220366237796/962008357990977626/122.png");
                                dc.WithDescription($"**Başarılı Bir Şekilde Destek Talebin Açıldı.** \n \n Destek Talebi: <#{newChannels.Id}>");
                                dc.WithThumbnailUrl("https://cdn.discordapp.com/attachments/959142220366237796/962008357990977626/122.png");
                                dc.WithColor(Color.Purple);
                                dc.WithImageUrl("https://cdn.discordapp.com/attachments/959142220366237796/962016214031429662/reponse.png");
                                dc.WithFooter("Reponse Mod | Support System", "https://cdn.discordapp.com/attachments/959142220366237796/962008357990977626/122.png");
                                await user.SendMessageAsync(" ", false, dc.Build());
                            }
                            catch (Exception)
                            {


                            }
                        }

                        break;

                    case "kapat":

                        var cbb = new ComponentBuilder().WithButton("Onayla!", "okapat", ButtonStyle.Success).WithButton("Vazgeç!", "ovazgeç", ButtonStyle.Danger).Build();

                        var ss = new EmbedBuilder().WithTitle($"Reponse Mod | Support System").WithDescription($"{component.User.Mention}, Destek Talebinin Kapanmasını Onaylıyor musun?").Build();

                        await component.Channel.SendMessageAsync(" ", embed: ss, components: cbb);


                        break;
                    case "ovazgeç":




                        var aass = new EmbedBuilder().WithTitle($"Reponse Mod | Support System").WithDescription($"{component.User.Mention}, Destek Talebinin Kapama İşlemi İptal Edildi.").Build();

                        await component.Channel.SendMessageAsync(" ", embed: aass);




                        break;

                    case "okapat":


                        var ccchannelsssx = guild.Channels.SingleOrDefault(x => x.Id == component.Channel.Id);
                        ccchannelsssx.DeleteAsync();

                        break;

                }

            }
        }
    }
}
