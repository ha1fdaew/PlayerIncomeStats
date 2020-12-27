using System;
using Microsoft.Xna.Framework;
using StardewModdingAPI.Events;

namespace PlayerIncomeStats.Client.UI
{
    public class UIManager
    {
        public CustomPanel panel;

        public UIManager()
        {
            panel = new CustomPanel(new Rectangle(300, 400, 330, 50));
            ModEntry.instance.Helper.Events.Display.RenderedHud += OnHudRendered;
        }

        public void OnEntriesChanged() => panel.OnEntriesChanged();

        private void OnHudRendered(object sender, RenderedHudEventArgs args)
        {
            panel.Draw();
        }
    }
}