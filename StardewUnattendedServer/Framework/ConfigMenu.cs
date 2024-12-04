using StardewModdingAPI;
using StardewUnattendedServer;
using StardewUnattendedServer.Framework;

namespace StardewUnattendedServer.Framework
{
    class ConfigMenu
    {
        public ConfigMenu(StardewUnattendedServer sus, ModConfig config)
        {
            var configMenu = sus.Helper.ModRegistry.GetApi<IGenericModConfigMenuApi>("spacechase0.GenericModConfigMenu");
            if (configMenu is not null)
            {
                // register mod
                configMenu.Register(
                    mod: sus.ModManifest,
                    reset: () => config = new ModConfig(),
                    save: () => sus.Helper.WriteConfig(config)
                );

                configMenu.AddSectionTitle(
                    mod: sus.ModManifest,
                    text: () => sus.Helper.Translation.Get("config.mainTitle")
                );

                configMenu.AddKeybind(
                    mod: sus.ModManifest,
                    name: () => sus.Helper.Translation.Get("config.serverKeyName"),
                    tooltip: () => sus.Helper.Translation.Get("config.serverKeyTT"),
                    getValue: () => config.serverHotKey,
                    setValue: value => config.serverHotKey = value
                );

                configMenu.AddBoolOption(
                    mod: sus.ModManifest,
                    name: () => sus.Helper.Translation.Get("config.serverAutoName"),
                    tooltip: () => sus.Helper.Translation.Get("config.serverAutoTT"),
                    getValue: () => config.autoLevel,
                    setValue: value => config.autoLevel = value
                );

                configMenu.AddNumberOption(
                    mod: sus.ModManifest,
                    name: () => sus.Helper.Translation.Get("config.serverHouseName"),
                    tooltip: () => sus.Helper.Translation.Get("config.serverHouseTT"),
                    getValue: () => config.upgradeHouse,
                    setValue: value => config.upgradeHouse = value,
                    min: 0,
                    max: 3,
                    interval: 1
                );

                configMenu.AddTextOption(
                    mod: sus.ModManifest,
                    name: () => sus.Helper.Translation.Get("config.serverPetName"),
                    tooltip: () => sus.Helper.Translation.Get("config.serverPetTT"),
                    getValue: () => config.petname,
                    setValue: value => config.petname = value
                );

                configMenu.AddBoolOption(
                    mod: sus.ModManifest,
                    name: () => sus.Helper.Translation.Get("config.serverCaveName"),
                    tooltip: () => sus.Helper.Translation.Get("config.serverCaveTT"),
                    getValue: () => config.farmcavechoicemushrooms,
                    setValue: value => config.farmcavechoicemushrooms = value
                );

                configMenu.AddBoolOption(
                    mod: sus.ModManifest,
                    name: () => sus.Helper.Translation.Get("config.serverCCName"),
                    tooltip: () => sus.Helper.Translation.Get("config.serverCCTT"),
                    getValue: () => config.communitycenterrun,
                    setValue: value => config.communitycenterrun = value
                );

                configMenu.AddNumberOption(
                    mod: sus.ModManifest,
                    name: () => sus.Helper.Translation.Get("config.serverSleepName"),
                    tooltip: () => sus.Helper.Translation.Get("config.serverSleepTT"),
                    getValue: () => config.timeOfDayToSleep,
                setValue: value => config.timeOfDayToSleep = value,
                min: 0610,
                max: 2600,
                interval: 10
                );

                configMenu.AddBoolOption(
                    mod: sus.ModManifest,
                    name: () => sus.Helper.Translation.Get("config.serverChestName"),
                    tooltip: () => sus.Helper.Translation.Get("config.serverChestTT"),
                    getValue: () => config.lockPlayerChests,
                    setValue: value => config.lockPlayerChests = value
                );

                configMenu.AddBoolOption(
                    mod: sus.ModManifest,
                    name: () => sus.Helper.Translation.Get("config.serverPauseName"),
                    tooltip: () => sus.Helper.Translation.Get("config.serverPauseTT"),
                    getValue: () => config.clientsCanPause,
                    setValue: value => config.clientsCanPause = value
                );

                configMenu.AddBoolOption(
                    mod: sus.ModManifest,
                    name: () => sus.Helper.Translation.Get("config.serverInviteCodeName"),
                    tooltip: () => sus.Helper.Translation.Get("config.serverInviteCodeTT"),
                    getValue: () => config.copyInviteCodeToClipboard,
                    setValue: value => config.copyInviteCodeToClipboard = value
                );

                configMenu.AddBoolOption(
                    mod: sus.ModManifest,
                    name: () => sus.Helper.Translation.Get("config.serverFestivalsName"),
                    tooltip: () => sus.Helper.Translation.Get("config.serverFestivalsTT"),
                    getValue: () => config.festivalsOn,
                    setValue: value => config.festivalsOn = value
                );

                configMenu.AddSectionTitle(
                    mod: sus.ModManifest,
                    text: () => sus.Helper.Translation.Get("config.serverKeyTitle")
                );

                configMenu.AddSectionTitle(
                    mod: sus.ModManifest,
                    text: () => sus.Helper.Translation.Get("config.serverKeySubTitle")
                );

                configMenu.AddTextOption(
                    mod: sus.ModManifest,
                    name: () => sus.Helper.Translation.Get("config.serverSleepWordName"),
                    tooltip: () => sus.Helper.Translation.Get("config.serverSleepWordTT"),
                    getValue: () => config.sleepKeyword,
                    setValue: value => config.sleepKeyword = value
                );

                configMenu.AddTextOption(
                    mod: sus.ModManifest,
                    name: () => sus.Helper.Translation.Get("config.serverFestivalWordName"),
                    tooltip: () => sus.Helper.Translation.Get("config.serverFestivalWordTT"),
                    getValue: () => config.festivalKeyword,
                    setValue: value => config.festivalKeyword = value
                );

                configMenu.AddTextOption(
                    mod: sus.ModManifest,
                    name: () => sus.Helper.Translation.Get("config.serverEventWordName"),
                    tooltip: () => sus.Helper.Translation.Get("config.serverEventWordTT"),
                    getValue: () => config.eventKeyword,
                    setValue: value => config.eventKeyword = value
                );

                configMenu.AddTextOption(
                    mod: sus.ModManifest,
                    name: () => sus.Helper.Translation.Get("config.serverLeaveWordName"),
                    tooltip: () => sus.Helper.Translation.Get("config.serverLeaveWordTT"),
                    getValue: () => config.leaveKeyword,
                    setValue: value => config.leaveKeyword = value
                );

                configMenu.AddTextOption(
                    mod: sus.ModManifest,
                    name: () => sus.Helper.Translation.Get("config.serverUnstickWordName"),
                    tooltip: () => sus.Helper.Translation.Get("config.serverUnstickWordTT"),
                    getValue: () => config.unstickKeyword,
                    setValue: value => config.unstickKeyword = value
                );

                configMenu.AddTextOption(
                    mod: sus.ModManifest,
                    name: () => sus.Helper.Translation.Get("config.serverPauseWordName"),
                    tooltip: () => sus.Helper.Translation.Get("config.serverPauseWordTT"),
                    getValue: () => config.pauseKeyword,
                    setValue: value => config.pauseKeyword = value
                );

                configMenu.AddTextOption(
                    mod: sus.ModManifest,
                    name: () => sus.Helper.Translation.Get("config.serverUnpauseWordName"),
                    tooltip: () => sus.Helper.Translation.Get("config.serverUnpauseWordTT"),
                    getValue: () => config.unpauseKeyword,
                    setValue: value => config.unpauseKeyword = value
                );

                configMenu.AddSectionTitle(
                    mod: sus.ModManifest,
                    text: () => sus.Helper.Translation.Get("config.serverFestivalCDTitle")
                );

                configMenu.AddNumberOption(
                    mod: sus.ModManifest,
                    name: () => sus.Helper.Translation.Get("festival.event.egg"),
                    tooltip: () => sus.Helper.Translation.Get("config.serverCDTT"),
                    getValue: () => config.eggHuntCountDownConfig,
                    setValue: value => config.eggHuntCountDownConfig = value,
                    min: 30,
                    max: 1200,
                    interval: 30
                );

                configMenu.AddNumberOption(
                    mod: sus.ModManifest,
                    name: () => sus.Helper.Translation.Get("festival.event.flower"),
                    tooltip: () => sus.Helper.Translation.Get("config.serverCDTT"),
                    getValue: () => config.flowerDanceCountDownConfig,
                    setValue: value => config.flowerDanceCountDownConfig = value,
                    min: 30,
                    max: 1200,
                    interval: 30
                );

                configMenu.AddNumberOption(
                    mod: sus.ModManifest,
                    name: () => sus.Helper.Translation.Get("festival.luau.name"),
                    tooltip: () => sus.Helper.Translation.Get("config.serverCDTT"),
                    getValue: () => config.luauSoupCountDownConfig,
                    setValue: value => config.luauSoupCountDownConfig = value,
                    min: 30,
                    max: 1200,
                    interval: 30
                );

                configMenu.AddNumberOption(
                    mod: sus.ModManifest,
                    name: () => sus.Helper.Translation.Get("festival.event.dance"),
                    tooltip: () => sus.Helper.Translation.Get("config.serverCDTT"),
                    getValue: () => config.jellyDanceCountDownConfig,
                    setValue: value => config.jellyDanceCountDownConfig = value,
                    min: 30,
                    max: 1200,
                    interval: 30
                );

                configMenu.AddNumberOption(
                    mod: sus.ModManifest,
                    name: () => sus.Helper.Translation.Get("festival.fair.name"),
                    tooltip: () => sus.Helper.Translation.Get("config.serverCDTT"),
                    getValue: () => config.grangeDisplayCountDownConfig,
                    setValue: value => config.grangeDisplayCountDownConfig = value,
                    min: 30,
                    max: 1200,
                    interval: 30
                );

                configMenu.AddNumberOption(
                    mod: sus.ModManifest,
                    name: () => sus.Helper.Translation.Get("festival.ice.name"),
                    tooltip: () => sus.Helper.Translation.Get("config.serverCDTT"),
                    getValue: () => config.iceFishingCountDownConfig,
                    setValue: value => config.iceFishingCountDownConfig = value,
                    min: 30,
                    max: 1200,
                    interval: 30
                );

                configMenu.AddNumberOption(
                    mod: sus.ModManifest,
                    name: () => sus.Helper.Translation.Get("festival.winterStar.name"),
                    tooltip: () => sus.Helper.Translation.Get("config.serverCDTT"),
                    getValue: () => config.winterFeastCountDown,
                    setValue: value => config.winterFeastCountDown = value,
                    min: 30,
                    max: 1200,
                    interval: 30
                );

                configMenu.AddSectionTitle(
                    mod: sus.ModManifest,
                    text: () => sus.Helper.Translation.Get("config.serverFestivalTOTitle")
                );

                configMenu.AddNumberOption(
                    mod: sus.ModManifest,
                    name: () => sus.Helper.Translation.Get("festival.event.egg"),
                    tooltip: () => sus.Helper.Translation.Get("config.serverTOTT", new { eventName =sus.Helper.Translation.Get("festival.event.egg") }),
                    getValue: () => config.eggFestivalTimeOut,
                    setValue: value => config.eggFestivalTimeOut = value,
                    min: 30,
                    max: 1200,
                    interval: 30
                );

                configMenu.AddNumberOption(
                    mod: sus.ModManifest,
                    name: () => sus.Helper.Translation.Get("festival.event.flower"),
                    tooltip: () => sus.Helper.Translation.Get("config.serverTOTT", new { eventName =sus.Helper.Translation.Get("festival.event.flower") }),
                    getValue: () => config.flowerDanceTimeOut,
                    setValue: value => config.flowerDanceTimeOut = value,
                    min: 30,
                    max: 1200,
                    interval: 30
                );

                configMenu.AddNumberOption(
                    mod: sus.ModManifest,
                    name: () => sus.Helper.Translation.Get("festival.luau.name"),
                    tooltip: () => sus.Helper.Translation.Get("config.serverTOTT", new { eventName =sus.Helper.Translation.Get("festival.luau.name") }),
                    getValue: () => config.luauTimeOut,
                    setValue: value => config.luauTimeOut = value,
                    min: 30,
                    max: 1200,
                    interval: 30
                );

                configMenu.AddNumberOption(
                    mod: sus.ModManifest,
                    name: () => sus.Helper.Translation.Get("festival.event.dance"),
                    tooltip: () => sus.Helper.Translation.Get("config.serverTOTT", new { eventName =sus.Helper.Translation.Get("festival.event.dance") }),
                    getValue: () => config.danceOfJelliesTimeOut,
                    setValue: value => config.danceOfJelliesTimeOut = value,
                    min: 30,
                    max: 1200,
                    interval: 30
                );

                configMenu.AddNumberOption(
                    mod: sus.ModManifest,
                    name: () => sus.Helper.Translation.Get("festival.fair.name"),
                    tooltip: () => sus.Helper.Translation.Get("config.serverTOTT", new { eventName =sus.Helper.Translation.Get("festival.fair.name") }),
                    getValue: () => config.fairTimeOut,
                    setValue: value => config.fairTimeOut = value,
                    min: 30,
                    max: 1200,
                    interval: 30
                );

                configMenu.AddNumberOption(
                    mod: sus.ModManifest,
                    name: () => sus.Helper.Translation.Get("festival.ice.name"),
                    tooltip: () => sus.Helper.Translation.Get("config.serverTOTT", new { eventName =sus.Helper.Translation.Get("festival.ice.name") }),
                    getValue: () => config.festivalOfIceTimeOut,
                    setValue: value => config.festivalOfIceTimeOut = value,
                    min: 30,
                    max: 1200,
                    interval: 30
                );

                configMenu.AddNumberOption(
                    mod: sus.ModManifest,
                    name: () => sus.Helper.Translation.Get("festival.winterStar.name"),
                    tooltip: () => sus.Helper.Translation.Get("config.serverTOTT", new { eventName =sus.Helper.Translation.Get("festival.winterStar.name") }),
                    getValue: () => config.winterStarTimeOut,
                    setValue: value => config.winterStarTimeOut = value,
                    min: 30,
                    max: 1200,
                    interval: 30
                );

                configMenu.AddNumberOption(
                    mod: sus.ModManifest,
                    name: () => sus.Helper.Translation.Get("festival.spiritsEve.name"),
                    tooltip: () => sus.Helper.Translation.Get("config.serverSpiritTOTT"),
                    getValue: () => config.spiritsEveTimeOut,
                    setValue: value => config.spiritsEveTimeOut = value,
                    min: 30,
                    max: 1200,
                    interval: 30
                );

                configMenu.AddNumberOption(
                    mod: sus.ModManifest,
                    name: () => sus.Helper.Translation.Get("config.serverEndOfDayName"),
                    tooltip: () => sus.Helper.Translation.Get("config.serverEndOfDayTT"),
                    getValue: () => config.endofdayTimeOut,
                    setValue: value => config.endofdayTimeOut = value,
                    min: 60,
                    max: 1200,
                    interval: 30
                );
            }
        }
    }
}