﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace rayshud_Installer.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://837bcb9dc43d459daaaf6afbd0f6bcb0@sentry.io/1270434")]
        public string sentry_io_key {
            get {
                return ((string)(this["sentry_io_key"]));
            }
            set {
                this["sentry_io_key"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://raw.githubusercontent.com/raysfire/rayshud/master/README.md")]
        public string git_hud_readme {
            get {
                return ((string)(this["git_hud_readme"]));
            }
            set {
                this["git_hud_readme"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Steam\\steamapps\\common\\Team Fortress 2\\tf\\custom")]
        public string directory_base {
            get {
                return ((string)(this["directory_base"]));
            }
            set {
                this["directory_base"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("rayshud.zip")]
        public string temp_name {
            get {
                return ((string)(this["temp_name"]));
            }
            set {
                this["temp_name"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("rayshud has been installed")]
        public string msg_installed {
            get {
                return ((string)(this["msg_installed"]));
            }
            set {
                this["msg_installed"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("rayshud has been updated")]
        public string msg_refreshed {
            get {
                return ((string)(this["msg_refreshed"]));
            }
            set {
                this["msg_refreshed"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("rayshud settings applied")]
        public string msg_updateed {
            get {
                return ((string)(this["msg_updateed"]));
            }
            set {
                this["msg_updateed"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("rayshud has been removed")]
        public string msg_removeed {
            get {
                return ((string)(this["msg_removeed"]));
            }
            set {
                this["msg_removeed"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("tf/custom directory not set! Click the browse button to set it before installing")]
        public string directory_not_set {
            get {
                return ((string)(this["directory_not_set"]));
            }
            set {
                this["directory_not_set"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Unable to find the tf/custom directory")]
        public string directory_not_found_hud {
            get {
                return ((string)(this["directory_not_found_hud"]));
            }
            set {
                this["directory_not_found_hud"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Unable to find rayshud in the tf/custom directory")]
        public string directory_not_found {
            get {
                return ((string)(this["directory_not_found"]));
            }
            set {
                this["directory_not_found"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Unable to find the local version number")]
        public string error_version_local {
            get {
                return ((string)(this["error_version_local"]));
            }
            set {
                this["error_version_local"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Unable to find the latest version number")]
        public string error_version_live {
            get {
                return ((string)(this["error_version_live"]));
            }
            set {
                this["error_version_live"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("An error occurred while attempting to download and install rayshud")]
        public string error_install {
            get {
                return ((string)(this["error_install"]));
            }
            set {
                this["error_install"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("An error occurred while attempting to apply changes to rayshud")]
        public string error_update {
            get {
                return ((string)(this["error_update"]));
            }
            set {
                this["error_update"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("An error occurred while loading installer settings")]
        public string error_load {
            get {
                return ((string)(this["error_load"]));
            }
            set {
                this["error_load"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("An error occurred while attempting to remove rayshud")]
        public string error_remove {
            get {
                return ((string)(this["error_remove"]));
            }
            set {
                this["error_remove"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://raw.githubusercontent.com/CriticalFlaw/rayshud-Installer/master/rayshud-I" +
            "nstaller/Properties/AssemblyInfo.cs")]
        public string git_installer_version {
            get {
                return ((string)(this["git_installer_version"]));
            }
            set {
                this["git_installer_version"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("A new version of the installer is available on GitHub! Download it here: https://" +
            "github.com/CriticalFlaw/rayshud-Installer/releases")]
        public string msg_update_installer {
            get {
                return ((string)(this["msg_update_installer"]));
            }
            set {
                this["msg_update_installer"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool v_HUDVersion {
            get {
                return ((bool)(this["v_HUDVersion"]));
            }
            set {
                this["v_HUDVersion"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool v_Scoreboard {
            get {
                return ((bool)(this["v_Scoreboard"]));
            }
            set {
                this["v_Scoreboard"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool v_ChatBox {
            get {
                return ((bool)(this["v_ChatBox"]));
            }
            set {
                this["v_ChatBox"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool v_TeamSelect {
            get {
                return ((bool)(this["v_TeamSelect"]));
            }
            set {
                this["v_TeamSelect"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool v_DisguiseImage {
            get {
                return ((bool)(this["v_DisguiseImage"]));
            }
            set {
                this["v_DisguiseImage"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool v_DefaultMenuBG {
            get {
                return ((bool)(this["v_DefaultMenuBG"]));
            }
            set {
                this["v_DefaultMenuBG"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool v_MenuClassImages {
            get {
                return ((bool)(this["v_MenuClassImages"]));
            }
            set {
                this["v_MenuClassImages"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool v_DamageValuePos {
            get {
                return ((bool)(this["v_DamageValuePos"]));
            }
            set {
                this["v_DamageValuePos"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int v_UberAnimation {
            get {
                return ((int)(this["v_UberAnimation"]));
            }
            set {
                this["v_UberAnimation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("235 226 202 255")]
        public string v_UberBarColor {
            get {
                return ((string)(this["v_UberBarColor"]));
            }
            set {
                this["v_UberBarColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("255 50 255 255")]
        public string v_UberFullColor {
            get {
                return ((string)(this["v_UberFullColor"]));
            }
            set {
                this["v_UberFullColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("255 165 0 255")]
        public string v_UberFlashColor1 {
            get {
                return ((string)(this["v_UberFlashColor1"]));
            }
            set {
                this["v_UberFlashColor1"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("255 69 0 255")]
        public string v_UberFlashColor2 {
            get {
                return ((string)(this["v_UberFlashColor2"]));
            }
            set {
                this["v_UberFlashColor2"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool v_XHairEnabled {
            get {
                return ((bool)(this["v_XHairEnabled"]));
            }
            set {
                this["v_XHairEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int v_XHairStyle {
            get {
                return ((int)(this["v_XHairStyle"]));
            }
            set {
                this["v_XHairStyle"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool v_XHairOutline {
            get {
                return ((bool)(this["v_XHairOutline"]));
            }
            set {
                this["v_XHairOutline"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool v_XHairPulse {
            get {
                return ((bool)(this["v_XHairPulse"]));
            }
            set {
                this["v_XHairPulse"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("20")]
        public int v_XHairSize {
            get {
                return ((int)(this["v_XHairSize"]));
            }
            set {
                this["v_XHairSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("242 242 242 255")]
        public string v_XHairColor {
            get {
                return ((string)(this["v_XHairColor"]));
            }
            set {
                this["v_XHairColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("255 0 0 255")]
        public string v_XHairPulseColor {
            get {
                return ((string)(this["v_XHairPulseColor"]));
            }
            set {
                this["v_XHairPulseColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("48 255 48 255")]
        public string v_HealingDone {
            get {
                return ((string)(this["v_HealingDone"]));
            }
            set {
                this["v_HealingDone"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int v_HealthStyle {
            get {
                return ((int)(this["v_HealthStyle"]));
            }
            set {
                this["v_HealthStyle"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("235 226 202 255")]
        public string v_HealthNormal {
            get {
                return ((string)(this["v_HealthNormal"]));
            }
            set {
                this["v_HealthNormal"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("48 255 48 255")]
        public string v_HealthBuff {
            get {
                return ((string)(this["v_HealthBuff"]));
            }
            set {
                this["v_HealthBuff"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("255 153 0 255")]
        public string v_HealthLow {
            get {
                return ((string)(this["v_HealthLow"]));
            }
            set {
                this["v_HealthLow"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("48 255 48 255")]
        public string v_AmmoClip {
            get {
                return ((string)(this["v_AmmoClip"]));
            }
            set {
                this["v_AmmoClip"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("255 42 130 255")]
        public string v_AmmoClipLow {
            get {
                return ((string)(this["v_AmmoClipLow"]));
            }
            set {
                this["v_AmmoClipLow"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("72 255 255 255")]
        public string v_AmmoReserve {
            get {
                return ((string)(this["v_AmmoReserve"]));
            }
            set {
                this["v_AmmoReserve"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("255 128 28 255")]
        public string v_AmmoReserveLow {
            get {
                return ((string)(this["v_AmmoReserveLow"]));
            }
            set {
                this["v_AmmoReserveLow"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string v_TF2Directory {
            get {
                return ((string)(this["v_TF2Directory"]));
            }
            set {
                this["v_TF2Directory"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string v_LastModified {
            get {
                return ((string)(this["v_LastModified"]));
            }
            set {
                this["v_LastModified"] = value;
            }
        }
    }
}
