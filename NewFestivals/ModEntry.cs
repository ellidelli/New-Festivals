using System;
using Microsoft.Xna.Framework;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewModdingAPI.Utilities;
using StardewValley;

namespace NewFestivals
{
    //mod entry point
    public class ModEntry : Mod
    {
        public override void Entry(IModHelper helper)
        {
            //add to the game loop to check what the day is
            helper.Events.GameLoop.DayStarted += OnDayStarted;
        }

        private void OnDayStarted(object sender, EventArgs e)
        {
            //access smapi api
            IModHelper helper = this.Helper;

            //check if it's fall 28
            if (Game1.currentSeason == "fall" && Game1.dayOfMonth == 28)
            {
                //display a message in the smapi console
                this.Monitor.Log("it is fall 28", LogLevel.Debug);
            }
        }
    }
}