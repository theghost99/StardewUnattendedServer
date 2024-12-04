using StardewModdingAPI;

namespace StardewUnattendedServer.Framework
{
    class ModConfig
    {
        public SButton serverHotKey { get; set; } = SButton.F9;
        public string sleepKeyword { get; set; } = "sleep";
        public string festivalKeyword { get; set; } = "festival";
        public string eventKeyword { get; set; } = "event";
        public string leaveKeyword { get; set; } = "leave";
        public string unstickKeyword { get; set; } = "unstick";
        public string pauseKeyword { get; set; } = "pause";
        public string unpauseKeyword { get; set; } = "unpause";
        public bool autoLevel { get; set; } = true;
        public int profitmargin { get; set; } = 100;
        public int upgradeHouse { get; set; } = 0;
        public string petname { get; set; } = "Qwerty";
        public bool farmcavechoicemushrooms { get; set; } = true;
        public bool communitycenterrun { get; set; } = true;
        public int timeOfDayToSleep { get; set; } = 2200;

        public bool lockPlayerChests { get; set; } = true;
        public bool clientsCanPause { get; set; } = false;
        public bool copyInviteCodeToClipboard { get; set; } = true;


        public bool festivalsOn { get; set; } = true;
        public int eggHuntCountDownConfig { get; set; } = 120;
        public int flowerDanceCountDownConfig { get; set; } = 120;
        public int luauSoupCountDownConfig { get; set; } = 120;
        public int jellyDanceCountDownConfig { get; set; } = 120;
        public int grangeDisplayCountDownConfig { get; set; } = 120;
        public int iceFishingCountDownConfig { get; set; } = 120;
        public int winterFeastCountDown { get; set; } = 120;

        public int endofdayTimeOut { get; set; } = 300;
        public int fairTimeOut { get; set; } = 120;
        public int spiritsEveTimeOut { get; set; } = 900;
        public int winterStarTimeOut { get; set; } = 120;

        public int eggFestivalTimeOut { get; set; } = 120;
        public int flowerDanceTimeOut { get; set; } = 120;
        public int luauTimeOut { get; set; } = 120;
        public int danceOfJelliesTimeOut { get; set; } = 120;
        public int festivalOfIceTimeOut { get; set; } = 120;

    }
}
