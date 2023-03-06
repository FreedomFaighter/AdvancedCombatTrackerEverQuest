﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ACT_Plugin {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class EverQuestDPSParse {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal EverQuestDPSParse() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ACT_Plugin.EverQuestDPSParse", typeof(EverQuestDPSParse).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to pierce|gore|crush|slash|hit|kick|slam|bash|shoot|strike|bite|grab.
        /// </summary>
        internal static string attackTypes {
            get {
                return ResourceManager.GetString("attackTypes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?&lt;victim&gt;(You|.+)) is (?&lt;damageShieldDamageType&gt;\S+) by (?&lt;attacker&gt;(YOUR|.+)) (?&lt;damageShieldType&gt;\S+) for (?&lt;damagePoints&gt;[\d]+) points of non-melee damage..
        /// </summary>
        internal static string DamageShield {
            get {
                return ResourceManager.GetString("DamageShield", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?&lt;healer&gt;.+) healed (?&lt;healingTarget&gt;.+) over time for (?&lt;healingPoints&gt;[\d]+)(?:[\s\(](?&lt;overHealPoints&gt;[\d]+)[\)]){0,1} hit points by (?&lt;healingSpell&gt;.*\.)(?:[\s][\(](?&lt;healingSpecial&gt;.+)[\)]){0,1}.
        /// </summary>
        internal static string HealingOverTime {
            get {
                return ResourceManager.GetString("HealingOverTime", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hit Points Healing Over Time.
        /// </summary>
        internal static string HitpointsHealingOverTime {
            get {
                return ResourceManager.GetString("HitpointsHealingOverTime", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?&lt;healer&gt;.+) healed (?&lt;healingTarget&gt;.+) for (?&lt;healingPoints&gt;[\d]+)(?:[\s\(](?&lt;overHealPoints&gt;[\d]+)[\)]){0,1} hit points by (?&lt;healingSpell&gt;.*\.)(?:[\s][\(](?&lt;healingSpecial&gt;.+)[\)]){0,1}.
        /// </summary>
        internal static string InstantHeal {
            get {
                return ResourceManager.GetString("InstantHeal", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to --You have looted a Steel Ingot from Lieutenant Dagarok&apos;s corpse.--.
        /// </summary>
        internal static string LootedCorpse {
            get {
                return ResourceManager.GetString("LootedCorpse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?&lt;attacker&gt;(You|.+)) (?&lt;attackType&gt;({0})+) (?&lt;victim&gt;.+) for (?&lt;damageAmount&gt;[\d]+) (point[|s]) of damage.(?:\s\((?&lt;damageSpecial&gt;.+)\)){0,1}.
        /// </summary>
        internal static string MeleeAttack {
            get {
                return ResourceManager.GetString("MeleeAttack", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {EverQuestDPSParse.TimeStamp} (?&lt;attacker&gt;.+) (?:tr(ies|y)) to (?&lt;attackType&gt;({attackTypes})+) (?&lt;victim&gt;.+), but (?:miss(|es))!.
        /// </summary>
        internal static string MissedMeleeAttack {
            get {
                return ResourceManager.GetString("MissedMeleeAttack", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?:(?&lt;attacker&gt;\S+)(`s pet)).
        /// </summary>
        internal static string PetMelee {
            get {
                return ResourceManager.GetString("PetMelee", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 96.
        /// </summary>
        internal static string pluginId {
            get {
                return ResourceManager.GetString("pluginId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to EverQuest English Parsing Plugin.
        /// </summary>
        internal static string PluginName {
            get {
                return ResourceManager.GetString("PluginName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Config\ACT_EverQuest_English_Parser.config.xml.
        /// </summary>
        internal static string PluginSettingsFileName {
            get {
                return ResourceManager.GetString("PluginSettingsFileName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Data Correction\EQ English Settings.
        /// </summary>
        internal static string PluginSettingsSectionName {
            get {
                return ResourceManager.GetString("PluginSettingsSectionName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?&lt;attacker&gt;.+) have slain (?&lt;victim&gt;.+)!.
        /// </summary>
        internal static string SlainMessage {
            get {
                return ResourceManager.GetString("SlainMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Crippling Blow.
        /// </summary>
        internal static string SpecialCripplingBlow {
            get {
                return ResourceManager.GetString("SpecialCripplingBlow", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Critical.
        /// </summary>
        internal static string SpecialCritical {
            get {
                return ResourceManager.GetString("SpecialCritical", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Double Bow Shot.
        /// </summary>
        internal static string SpecialDoubleBowShot {
            get {
                return ResourceManager.GetString("SpecialDoubleBowShot", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Flurry.
        /// </summary>
        internal static string SpecialFlurry {
            get {
                return ResourceManager.GetString("SpecialFlurry", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Locked.
        /// </summary>
        internal static string SpecialLocked {
            get {
                return ResourceManager.GetString("SpecialLocked", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Lucky.
        /// </summary>
        internal static string SpecialLucky {
            get {
                return ResourceManager.GetString("SpecialLucky", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Riposte.
        /// </summary>
        internal static string SpecialRiposte {
            get {
                return ResourceManager.GetString("SpecialRiposte", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Strikethrough.
        /// </summary>
        internal static string SpecialStrikethrough {
            get {
                return ResourceManager.GetString("SpecialStrikethrough", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?&lt;attacker&gt;.+) hit (?&lt;victim&gt;.+) for (?&lt;damagePoints&gt;[\d]+) (?:point[|s]) of (?&lt;typeOfDamage&gt;.+) damage by (?:(?&lt;damageEffect&gt;.+).)(?:\s\((?&lt;spellSpeicals&gt;.+)\)).
        /// </summary>
        internal static string SpellDamage {
            get {
                return ResourceManager.GetString("SpellDamage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to \[(?&lt;dateTimeOfLogLine&gt;.+)\].
        /// </summary>
        internal static string TimeStamp {
            get {
                return ResourceManager.GetString("TimeStamp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You have entered (?:the Drunken Monkey stance adequately|(?&lt;zoneName&gt;.+))..
        /// </summary>
        internal static string ZoneChange {
            get {
                return ResourceManager.GetString("ZoneChange", resourceCulture);
            }
        }
    }
}
