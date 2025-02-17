﻿using Kingmaker.Blueprints;
using Kingmaker.Blueprints.Classes;
using Kingmaker.Designers.Mechanics.Facts;
using Kingmaker.UnitLogic.Abilities.Blueprints;
using Kingmaker.UnitLogic.FactLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kadynsWOTRMods;
using kadynsWOTRMods.Utilities;
using kadynsWOTRMods.Extensions;

namespace kadynsWOTRMods.Tweaks.Classes.ClassFeatures {
    internal class OathbreakersBaneFeature {

        public static void AddOathbreakersBaneFeature() {
            var OBBaneIcon = AssetLoader.LoadInternal("Skills", "Icon_OBBane.png");
            var SmiteEvilAbility = Resources.GetBlueprint<BlueprintAbility>("7bb9eb2042e67bf489ccd1374423cdec");
            var SmiteEvilFeature = Resources.GetBlueprint<BlueprintFeature>("3a6db57fce75b0244a6a5819528ddf26");
            var OathbreakersBaneAbility = Resources.GetModBlueprint<BlueprintAbility>("OathbreakersBaneAbility");
            var OathbreakersBaneResource = Resources.GetModBlueprint<BlueprintAbilityResource>("OathbreakersBaneResource");
            var OathbreakersBaneFeature = Helpers.CreateBlueprint<BlueprintFeature>("OathbreakersBaneFeature", bp => {
                bp.SetName("Oathbreaker's Bane");
                bp.SetDescription("An Oathbreaker is particularly ruthless against those who have harmed her or her allies. " +
              "Once per day as a swift action, she can channel her anger at one target within sight who is engaged in melee combat with her or an ally. " +
              "She adds her Charisma modifier to her attack rolls and adds her Oathbreaker level to damage rolls against the target of her bane. " +
              "In addition, while Oathbreaker's Bane is in effect, the Oathbreaker gains a deflection bonus equal to her Charisma bonus (if any) " +
              "to her AC against attacks by the target of the smite.  The Oathbreaker's Bane effect remains until the target of the Oathbreaker's Bane is dead or the next time the Oathbreaker rests " +
              "and regains her uses of this ability.At 4th level and every 3 levels thereafter, the Oathbreaker can invoke her Oathbreaker's Bane " +
              "one additional time per day, to a maximum of seven times per day at 19th level.");
                bp.m_DescriptionShort = Helpers.CreateString("$OathbreakersBaneFeature.DescriptionShort", "Once per day as a swift action, she can channel her anger at one target within sight who is engaged in melee combat with her or an ally. " +
              "She adds her Charisma modifier to her attack rolls and adds her Oathbreaker level to damage rolls against the target of her bane. " +
              "In addition, while Oathbreaker's Bane is in effect, the Oathbreaker gains a deflection bonus equal to her Charisma bonus (if any) " +
              "to her AC against attacks by the target of the smite.");
                bp.Ranks = 1;
                bp.IsClassFeature = true;
                bp.m_Icon = OBBaneIcon;
                bp.AddComponent<AddAbilityResources>(c => {
                    c.m_Resource = OathbreakersBaneResource.ToReference<BlueprintAbilityResourceReference>();
                });
                bp.AddComponent<AddFacts>(c => {
                    c.m_Facts = new BlueprintUnitFactReference[] {
                        OathbreakersBaneAbility.ToReference<BlueprintUnitFactReference>(),

                    };
                });
            });
            var OathbreakersBaneUse = Helpers.CreateBlueprint<BlueprintFeature>("OathbreakersBaneUse", bp => {
                bp.SetName("Oathbreaker's Bane - Additional Use");
                bp.SetDescription("An Oathbreaker is particularly ruthless against those who have harmed her or her allies. " +
              "Once per day as a swift action, she can channel her anger at one target within sight who is engaged in melee combat with her or an ally. " +
              "She adds her Charisma modifier to her attack rolls and adds her Oathbreaker level to damage rolls against the target of her bane. " +
              "In addition, while Oathbreaker's Bane is in effect, the Oathbreaker gains a deflection bonus equal to her Charisma bonus (if any) " +
              "to her AC against attacks by the target of the smite.  The Oathbreaker's Bane effect remains until the target of the Oathbreaker's Bane is dead or the next time the Oathbreaker rests " +
              "and regains her uses of this ability.At 4th level and every 3 levels thereafter, the Oathbreaker can invoke her Oathbreaker's Bane " +
              "one additional time per day, to a maximum of seven times per day at 19th level.");
                bp.m_Icon = OBBaneIcon;
                bp.Ranks = 1;
                bp.IsClassFeature = true;
            });


        }



    }
}

