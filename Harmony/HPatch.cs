using System;
using System.Reflection;
using Harmony;
using Microsoft.Xna.Framework;
using StardewValley;
using StardewValley.Buildings;

namespace PlayerIncomeStats.Harmony
{
    public class HPatch
    {
        public static HarmonyInstance harmony;

        public static void Patch()
        {
            harmony = HarmonyInstance.Create(ModEntry.instance.Helper.ModRegistry.ModID);
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }
    }

    [HarmonyPatch(typeof(ShippingBin), "shipItem")]
    public static class ShippingBin_shipItem
    {
        public static void Postfix(Item i, Farmer who)
        {
            if (i != null)
                ModEntry.instance.OnItemShipped(i, who);
        }
    }

    [HarmonyPatch(typeof(ShippingBin), "leftClicked")]
    public static class ShippingBin_leftClicked
    {
        public static void Postfix(bool __result)
        {
            if (__result)
                ModEntry.instance.OnItemShipped(Game1.getFarm().lastItemShipped, Game1.player);
        }
    }
}