using RimWorld;
using Verse;

namespace ArellianCore
{
//Vanilla Defs

    [DefOf]
    public class GeneDefOf
    {
        public static GeneDef Eyes_Arellian;
        public static GeneDef Ears_Arellian;
        public static GeneDef Voice_Arellian;
    }

    public class MayRequireMaru : MayRequireAttribute
    {
        public MayRequireMaru() : base("Farmradish.Nyaron")
        {
        }
    }
    public class MayRequireNyaron : MayRequireAttribute
    {
        public MayRequireNyaron() : base("VAMV.MaruRaceMod")
        {
        }
    }
    [DefOf]
    public class HARRaceDefOf
    {
        [MayRequireNyaron]
        public static ThingDef Alien_Nyaron;
        [MayRequireMaru]
        public static ThingDef Maru;
    }
}