using RimWorld;
using System.Linq;
using Verse;

namespace ArellianCore
{
    //Faction

    public class ThoughtWorker_Faction : ThoughtWorker
    {
        public ThoughtWorker_Faction()
        {
        }
        protected override ThoughtState CurrentSocialStateInternal(Pawn p, Pawn o)
        {
            if ((p.genes.HasActiveGene(GeneDefOf.Eyes_Arellian)) && (p.genes.HasActiveGene(GeneDefOf.Ears_Arellian)) && (p.genes.HasActiveGene(GeneDefOf.Voice_Arellian)))
            {
                if (p.Faction == null)
                {
                    return false;
                }
                else if (p.Faction == o.Faction)
                {
                    //Comrade
                    return ThoughtState.ActiveAtStage(0);

                }
                else if (p.Faction != o.Faction)
                {
                    //Outsider
                    return ThoughtState.ActiveAtStage(1);

                }
            }
            return false;
        }
    }

    //Xenotype

    public class ThoughtWorker_Xeno : ThoughtWorker
    {
        public ThoughtWorker_Xeno()
        {
        }
        protected override ThoughtState CurrentSocialStateInternal(Pawn p, Pawn o)
        {
            if ((p.genes.HasActiveGene(GeneDefOf.Eyes_Arellian)) && (p.genes.HasActiveGene(GeneDefOf.Ears_Arellian)) && (p.genes.HasActiveGene(GeneDefOf.Voice_Arellian)))
            {
                if ((o.def == HARRaceDefOf.Alien_Nyaron || o.def == HARRaceDefOf.Maru) || ((o.genes.HasActiveGene(GeneDefOf.Eyes_Arellian)) && (o.genes.HasActiveGene(GeneDefOf.Ears_Arellian)) && (o.genes.HasActiveGene(GeneDefOf.Ears_Arellian))))
                { return false; }
                else
                {
                    //Xeno
                    return ThoughtState.ActiveAtStage(0);
                }

            }
            return false;
        }
    }
}