using Harmony;

namespace BiggerStorageMod
{
    [HarmonyPatch(typeof(Immigration), "Sim200ms")]
    internal class BiggerStorageMod_Immigration_Sim200ms
    {
        private static void Postfix(float dt,Immigration __instance,ref bool ___stopped,ref bool ___bImmigrantAvailable)
        {
            if (!___stopped && !___bImmigrantAvailable)
            {
                __instance.timeBeforeSpawn -= dt * 59f;
            }
        }
    }
}
