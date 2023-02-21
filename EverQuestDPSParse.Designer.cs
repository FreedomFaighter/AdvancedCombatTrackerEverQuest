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
        ///   Looks up a localized string similar to pierce|gore|crush|slash|hit|kick|slam|bash|shoot|strike|bite.
        /// </summary>
        internal static string attackTypes {
            get {
                return ResourceManager.GetString("attackTypes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?&lt;attacker&gt;(You|.+)) is (?&lt;damageShieldDamageType&gt;\S+) by (?&lt;victim&gt;(YOUR|.+)) (?&lt;damageShieldType&gt;\S+) for (?&lt;damagePoints&gt;[\d]+) points of non-melee damage..
        /// </summary>
        internal static string DamageShield {
            get {
                return ResourceManager.GetString("DamageShield", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?&lt;healer&gt;.+) healed (?&lt;healingTarget&gt;.+) over time for (?&lt;healingPoints&gt;[\d]+) ((?&lt;overHealPoints&gt;[\d]+)) hit points by (&lt;healingSpell&gt;.+).(?:\((?&lt;healingSpecial&gt;.+)\)){0,1}.
        /// </summary>
        internal static string Healing {
            get {
                return ResourceManager.GetString("Healing", resourceCulture);
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
        ///   Looks up a localized string similar to EverQuest DPS Parse.
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
    }
}
