﻿using System;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;

namespace rayshud_installer
{
    public class HUDFileWriter
    {
        private Properties.Settings settings = new Properties.Settings();
        private ResourceManager resources = new ResourceManager("strings", Assembly.GetExecutingAssembly());
        private string rayshud = new Properties.Settings().app_hud_directory + "\\rayshud";

        /// <summary>
        /// Set the main menu style
        /// </summary>
        public void mainMenuStyle()
        {
            try
            {
                var dir_menu_classic = rayshud + resources.GetString("dir_menu_classic");
                var dir_menu_modern = rayshud + resources.GetString("dir_menu_modern");

                if (settings.hud_menu_classic)
                {
                    if (settings.hud_default_backgrounds)
                        CopyMenuFiles(dir_menu_classic, true);
                    else
                        CopyMenuFiles(dir_menu_classic, false);
                }
                else
                {
                    if (settings.hud_default_backgrounds)
                        CopyMenuFiles(dir_menu_modern, true);
                    else
                        CopyMenuFiles(dir_menu_modern, false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(resources.GetString("error_writer_main_menu") + "\n" + ex.Message, "Error: Main Menu Style", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Set the scoreboard style
        /// </summary>
        public void scoreboardStyle()
        {
            try
            {
                var dir_scoreboard = rayshud + resources.GetString("dir_resource_ui") + "\\scoreboard.res";
                var dir_scoreboard_custom = rayshud + resources.GetString("dir_scoreboard_custom");
                var style = settings.hud_scoreboard_minimal ? "-minimal.res" : "-default.res";
                File.Copy(dir_scoreboard_custom + style, dir_scoreboard, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(resources.GetString("error_writer_scoreboard") + "\n" + ex.Message, "Error: Scoreboard Style", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Set the main menu backgrounds
        /// </summary>
        public void defaultBackgrounds()
        {
            try
            {
                var dir_console = rayshud + resources.GetString("dir_console");
                var dir_backgrounds = rayshud + resources.GetString("dir_backgrounds");

                if (Directory.Exists(dir_console + "_off") && File.Exists(dir_backgrounds + "_off.txt"))
                {
                    Directory.Move(dir_console + "_off", dir_console);
                    File.Move(dir_backgrounds + "_off.txt", dir_backgrounds);
                }

                if (settings.hud_default_backgrounds)
                {
                    Directory.Move(dir_console, dir_console + "_off");
                    File.Move(dir_backgrounds, dir_backgrounds + "_off.txt");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(resources.GetString("error_writer_backgrounds") + "\n" + ex.Message, "Error: Main Menu Backgrounds", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Set the team and class selection style
        /// </summary>
        public void teamSelect()
        {
            try
            {
                var dir_team = rayshud + resources.GetString("dir_resource_ui") + "\\teammenu.res";
                var dir_class = rayshud + resources.GetString("dir_resource_ui") + "\\classselection.res";
                var dir_team_custom = rayshud + resources.GetString("dir_team_custom");
                var dir_class_custom = rayshud + resources.GetString("dir_class_custom");

                if (settings.hud_team_class_center)
                {
                    File.Copy($"{dir_team_custom}-center.res", dir_team, true);
                    File.Copy($"{dir_class_custom}-center.res", dir_class, true);
                }
                else
                {
                    File.Copy($"{dir_team_custom}-left.res", dir_team, true);
                    File.Copy($"{dir_class_custom}-left.res", dir_class, true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(resources.GetString("error_writer_team_select") + "\n" + ex.Message, "Error: Team Select Position", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Set the player health style
        /// </summary>
        public void healthStyle()
        {
            try
            {
                var dir_health = rayshud + resources.GetString("dir_resource_ui") + "\\hudplayerhealth.res";
                var dir_health_custom = rayshud + resources.GetString("dir_health_custom");
                switch (settings.hud_health_style)
                {
                    case 0:
                        File.Copy($"{dir_health_custom}-default.res", dir_health, true);
                        break;

                    case 1:
                        File.Copy($"{dir_health_custom}-teambar.res", dir_health, true);
                        break;

                    case 2:
                        File.Copy($"{dir_health_custom}-cross.res", dir_health, true);
                        break;

                    case 3:
                        File.Copy($"{dir_health_custom}-broesel.res", dir_health, true);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(resources.GetString("error_writer_health_style") + "\n" + ex.Message, "Error: Health Style", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Set the visibility of the Spy's disguise image
        /// </summary>
        public void disguiseImage()
        {
            try
            {
                var dir_animations = rayshud + resources.GetString("dir_animations");
                var lines = File.ReadAllLines(dir_animations);
                var disguiseIndexStart = 150;
                var disguiseIndexEnd = 156;
                lines[disguiseIndexStart] = "//" + lines[disguiseIndexStart];
                lines[disguiseIndexStart++] = "//" + lines[disguiseIndexStart++];
                lines[disguiseIndexEnd] = "//" + lines[disguiseIndexEnd];
                lines[disguiseIndexEnd++] = "//" + lines[disguiseIndexEnd++];

                if (settings.hud_disguise_image)
                {
                    lines[disguiseIndexStart] = lines[disguiseIndexStart].Replace("//", string.Empty);
                    lines[disguiseIndexStart++] = lines[disguiseIndexStart++].Replace("//", string.Empty);
                    lines[disguiseIndexEnd] = lines[disguiseIndexEnd].Replace("//", string.Empty);
                    lines[disguiseIndexEnd++] = lines[disguiseIndexEnd++].Replace("//", string.Empty);
                }
                File.WriteAllLines(dir_animations, lines);
            }
            catch (Exception ex)
            {
                MessageBox.Show(resources.GetString("error_writer_disguise_image") + "\n" + ex.Message, "Error: Disguise Image", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Set the ubercharge style
        /// </summary>
        public void uberAnimation()
        {
            try
            {
                var dir_animations = rayshud + resources.GetString("dir_animations");
                var lines = File.ReadAllLines(dir_animations);
                var uberchargeIndex = 72;
                lines[uberchargeIndex] = "//" + lines[uberchargeIndex];
                lines[uberchargeIndex++] = "//" + lines[uberchargeIndex++];
                lines[uberchargeIndex + 2] = "//" + lines[uberchargeIndex + 2];

                switch (settings.hud_uber_animation)
                {
                    default:
                        lines[uberchargeIndex] = lines[uberchargeIndex].Replace("//", string.Empty);
                        break;

                    case 2:
                        lines[uberchargeIndex++] = lines[uberchargeIndex++].Replace("//", string.Empty);
                        break;

                    case 3:
                        lines[uberchargeIndex + 2] = lines[uberchargeIndex + 2].Replace("//", string.Empty);
                        break;
                }
                File.WriteAllLines(dir_animations, lines);
            }
            catch (Exception ex)
            {
                MessageBox.Show(resources.GetString("error_writer_uber_animation") + "\n" + ex.Message, "Error: Uber Animation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Set the crosshair hitmarker
        /// </summary>
        public void crosshairPulse()
        {
            try
            {
                var dir_animations = rayshud + resources.GetString("dir_animations");
                var lines = File.ReadAllLines(dir_animations);
                var crosshairIndex = 133;
                lines[crosshairIndex] = "//" + lines[crosshairIndex];
                lines[crosshairIndex++] = "//" + lines[crosshairIndex++];

                if (settings.hud_xhair_pulse)
                {
                    lines[crosshairIndex] = lines[crosshairIndex].Replace("//", string.Empty);
                    lines[crosshairIndex++] = lines[crosshairIndex++].Replace("//", string.Empty);
                }
                File.WriteAllLines(dir_animations, lines);
            }
            catch (Exception ex)
            {
                MessageBox.Show(resources.GetString("error_writer_xhair_pulse") + "\n" + ex.Message, "Error: Crosshair Pulse", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Set the visibility of the main menu class image
        /// </summary>
        public void classImage()
        {
            try
            {
                var dir_menu = rayshud + resources.GetString("dir_resource_ui") + "\\mainmenuoverride.res";
                var lines = File.ReadAllLines(dir_menu);
                var index = settings.hud_menu_classic ? 239 : 970;
                lines[index] = "\t\t\"xpos\"\t\t\t\"9999\"";
                lines[index++] = "\t\t\"ypos\"\t\t\t\"9999\"";

                if (settings.hud_menu_class_image)
                {
                    lines[index] = "\t\t\"xpos\"\t\t\"c-250\"";
                    lines[index++] = "\t\t\"ypos\"\t\t\"-80\"";
                }
                File.WriteAllLines(dir_menu, lines);
            }
            catch (Exception ex)
            {
                MessageBox.Show(resources.GetString("error_writer_class_image") + "\n" + ex.Message, "Error: Class Image", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Set the position of the chatbox
        /// </summary>
        public void chatboxPos()
        {
            try
            {
                var dir_chat = rayshud + resources.GetString("dir_resource_ui") + "\\basechat.res";
                var lines = File.ReadAllLines(dir_chat);
                var value = settings.hud_chat_bottom ? 360 : 30;
                lines[9] = $"\t\t\"ypos\"\t\t\t\t\"{value}\"";
                File.WriteAllLines(dir_chat, lines);
            }
            catch (Exception ex)
            {
                MessageBox.Show(resources.GetString("error_writer_chatbox_pos") + "\n" + ex.Message, "Error: Chatbox Position", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Set the crosshair
        /// </summary>
        public void crosshair(string xhairSize)
        {
            try
            {
                var size = int.Parse(xhairSize);
                var dir_layout = rayshud + resources.GetString("dir_layout");
                var lines = File.ReadAllLines(dir_layout);
                for (int x = 12; x <= 50; x += 19)
                {
                    lines[x] = "\t\t\"visible\"\t\t\"0\"";
                    lines[x++] = "\t\t\"enabled\"\t\t\"0\"";
                    lines[x + 7] = lines[x + 7].Replace("Outline", null);
                    File.WriteAllLines(dir_layout, lines);
                }

                if (settings.hud_xhair_enable)
                {
                    if (settings.hud_xhair_style <= 10) // RaysCrosshair
                    {
                        var index = 12;
                        lines[index] = "\t\t\"visible\"\t\t\"1\"";
                        lines[index++] = "\t\t\"enabled\"\t\t\"1\"";
                        lines[index + 7] = settings.hud_xhair_outline ? $"\t\t\"font\"\t\t\t\"Crosshairs{size}Outline\"" : $"\t\t\"font\"\t\t\t\"Crosshairs{size}\"";
                    }
                    else if (settings.hud_xhair_style == 11) // KonrWings
                    {
                        var index = 31;
                        lines[index] = "\t\t\"visible\"\t\t\"1\"";
                        lines[index++] = "\t\t\"enabled\"\t\t\"1\"";
                        lines[index + 7] = settings.hud_xhair_outline ? $"\t\t\"font\"\t\t\t\"KonrWings{size}Outline\"" : $"\t\t\"font\"\t\t\t\"KonrWings{size}\"";
                    }
                    else    // KnuckleCrosses
                    {
                        var index = 50;
                        lines[index] = "\t\t\"visible\"\t\t\"1\"";
                        lines[index++] = "\t\t\"enabled\"\t\t\"1\"";
                        lines[index + 7] = settings.hud_xhair_outline ? $"\t\t\"font\"\t\t\t\"KnucklesCrosses{size}Outline\"" : $"\t\t\"font\"\t\t\t\"KnucklesCrosses{size}\"";
                    }
                    SetCrosshairStyle(dir_layout, lines);
                    File.WriteAllLines(dir_layout, lines);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(resources.GetString("error_writer_xhair}") + "\n" + ex.Message, "Error: Setting Crosshair", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Set the client scheme colors
        /// </summary>
        public void colors()
        {
            try
            {
                var dir_colors = rayshud + resources.GetString("dir_colors");
                var lines = File.ReadAllLines(dir_colors);
                // Health and Ammo
                lines[31] = $"\t\t\"Ammo In Clip\"\t\t\t\t\t\"{RGBConverter(settings.hud_ammo_clip)}\"";
                lines[32] = $"\t\t\"Ammo In Reserve\"\t\t\t\t\"{RGBConverter(settings.hud_ammo_reserve)}\"";
                lines[33] = $"\t\t\"Ammo In Clip Low\"\t\t\t\t\"{RGBConverter(settings.hud_ammo_clip_low)}\"";
                lines[34] = $"\t\t\"Ammo In Reserve Low\"\t\t\t\"{RGBConverter(settings.hud_ammo_reserve_low)}\"";
                lines[35] = $"\t\t\"Health Normal\"\t\t\t\t\t\"{RGBConverter(settings.hud_health_normal)}\"";
                lines[36] = $"\t\t\"Health Buff\"\t\t\t\t\t\"{RGBConverter(settings.hud_health_buff)}\"";
                lines[37] = $"\t\t\"Health Hurt\"\t\t\t\t\t\"{RGBConverter(settings.hud_health_low)}\"";
                lines[38] = $"\t\t\"Heal Numbers\"\t\t\t\t\t\"{RGBConverter(settings.hud_healing_done)}\"";
                // Crosshair
                lines[45] = $"\t\t\"Crosshair\"\t\t\t\t\t\t\"{RGBConverter(settings.hud_xhair_color_base)}\"";
                lines[46] = $"\t\t\"CrosshairDamage\"\t\t\t\t\"{RGBConverter(settings.hud_xhair_color_pulse)}\"";
                // Ubercharge
                lines[49] = $"\t\t\"Uber Bar Color\"\t\t\t\t\"{RGBConverter(settings.hud_uber_color_bar)}\"";
                lines[50] = $"\t\t\"Solid Color Uber\"\t\t\t\t\"{RGBConverter(settings.hud_uber_color_full)}\"";
                lines[51] = $"\t\t\"Flashing Uber Color1\"\t\t\t\"{RGBConverter(settings.hud_uber_color_flash1)}\"";
                lines[52] = $"\t\t\"Flashing Uber Color2\"\t\t\t\"{RGBConverter(settings.hud_uber_color_flash2)}\"";
                File.WriteAllLines(dir_colors, lines);
            }
            catch (Exception ex)
            {
                MessageBox.Show(resources.GetString("error_writer_colors") + "\n" + ex.Message, "Error: Setting Colors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Set the position of the damage value
        /// </summary>
        public void damagePos()
        {
            try
            {
                var dir_damage = rayshud + resources.GetString("dir_resource_ui") + "\\huddamageaccount.res";
                var lines = File.ReadAllLines(dir_damage);
                var value = settings.hud_damage_above ? 108 : 188;
                lines[20] = $"\t\t\"xpos\"\t\t\t\"c-{value}\"";
                File.WriteAllLines(dir_damage, lines);
            }
            catch (Exception ex)
            {
                MessageBox.Show(resources.GetString("error_writer_damage_pos") + "\n" + ex.Message, "Error: Damage Position", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Copies the the selected main menu style into rayshud
        /// </summary>
        public void CopyMenuFiles(string source, bool defaultBG)
        {
            File.Copy($"{source}\\resource\\ui\\mainmenuoverride.res", rayshud + resources.GetString("dir_resource_ui") + "\\mainmenuoverride.res", true);
            File.Copy($"{source}\\resource\\gamemenu.res", rayshud + "\\resource\\gamemenu.res", true);
            if (!defaultBG)
            {
                File.Copy($"{source}\\materials\\console\\background_upward.vtf", rayshud + resources.GetString("dir_console") + "\\background_upward.vtf", true);
                File.Copy($"{source}\\materials\\console\\background_upward_widescreen.vtf", rayshud + resources.GetString("dir_console") + "\\background_upward_widescreen.vtf", true);
            }
        }

        /// <summary>
        /// Set the rayshud crosshair position and style
        /// </summary>
        public void SetCrosshairStyle(string dir_layout, string[] lines)
        {
            try
            {
                var crosshairIndex = 15;
                switch (settings.hud_xhair_style)
                {
                    case 0: // BasicCross
                        lines[crosshairIndex] = "\t\t\"xpos\"\t\t\t\"c-102\"";
                        lines[crosshairIndex++] = "\t\t\"ypos\"\t\t\t\"c-99\"";
                        lines[crosshairIndex + 2] = "\t\t\"labelText\"\t\t\"2\"";
                        break;

                    case 1: // BasicDot
                        lines[crosshairIndex] = "\t\t\"xpos\"\t\t\t\"c-103\"";
                        lines[crosshairIndex++] = "\t\t\"ypos\"\t\t\t\"c-100\"";
                        lines[crosshairIndex + 2] = "\t\t\"labelText\"\t\t\"3\"";
                        break;

                    case 2: // CircleDot
                        lines[crosshairIndex] = "\t\t\"xpos\"\t\t\t\"c-100\"";
                        lines[crosshairIndex++] = "\t\t\"ypos\"\t\t\t\"c-96\"";
                        lines[crosshairIndex + 2] = "\t\t\"labelText\"\t\t\"8\"";
                        break;

                    case 3: // OpenCross
                        lines[crosshairIndex] = "\t\t\"xpos\"\t\t\t\"c-85\"";
                        lines[crosshairIndex++] = "\t\t\"ypos\"\t\t\t\"c-100\"";
                        lines[crosshairIndex + 2] = "\t\t\"labelText\"\t\t\"i\"";
                        break;

                    case 4: // OpenCrossDot
                        lines[crosshairIndex] = "\t\t\"xpos\"\t\t\t\"c-85\"";
                        lines[crosshairIndex++] = "\t\t\"ypos\"\t\t\t\"c-100\"";
                        lines[crosshairIndex + 2] = "\t\t\"labelText\"\t\t\"h\"";
                        break;

                    case 5: // ScatterSpread
                        lines[crosshairIndex] = "\t\t\"xpos\"\t\t\t\"c-99\"";
                        lines[crosshairIndex++] = "\t\t\"ypos\"\t\t\t\"c-99\"";
                        lines[crosshairIndex + 2] = "\t\t\"labelText\"\t\t\"0\"";
                        break;

                    case 6: // ThinCircle
                        lines[crosshairIndex] = "\t\t\"xpos\"\t\t\t\"c-100\"";
                        lines[crosshairIndex++] = "\t\t\"ypos\"\t\t\t\"c-96\"";
                        lines[crosshairIndex + 2] = "\t\t\"labelText\"\t\t\"9\"";
                        break;

                    case 7: // Wings
                        lines[crosshairIndex] = "\t\t\"xpos\"\t\t\t\"c-100\"";
                        lines[crosshairIndex++] = "\t\t\"ypos\"\t\t\t\"c-97\"";
                        lines[crosshairIndex + 2] = "\t\t\"labelText\"\t\t\"d\"";
                        break;

                    case 8: // WingsPlus
                        lines[crosshairIndex] = "\t\t\"xpos\"\t\t\t\"c-100\"";
                        lines[crosshairIndex++] = "\t\t\"ypos\"\t\t\t\"c-97\"";
                        lines[crosshairIndex + 2] = "\t\t\"labelText\"\t\t\"c\"";
                        break;

                    case 9: // WingsSmall
                        lines[crosshairIndex] = "\t\t\"xpos\"\t\t\t\"c-100\"";
                        lines[crosshairIndex++] = "\t\t\"ypos\"\t\t\t\"c-97\"";
                        lines[crosshairIndex + 2] = "\t\t\"labelText\"\t\t\"g\"";
                        break;

                    case 10: // WingsSmallDot
                        lines[crosshairIndex] = "\t\t\"xpos\"\t\t\t\"c-100\"";
                        lines[crosshairIndex++] = "\t\t\"ypos\"\t\t\t\"c-97\"";
                        lines[crosshairIndex + 2] = "\t\t\"labelText\"\t\t\"f\"";
                        break;

                    case 11: // xHairCircle
                        lines[crosshairIndex] = "\t\t\"xpos\"\t\t\t\"c-100\"";
                        lines[crosshairIndex++] = "\t\t\"ypos\"\t\t\t\"c-102\"";
                        lines[crosshairIndex + 2] = "\t\t\"labelText\"\t\t\"0\"";
                        break;
                }
                File.WriteAllLines(dir_layout, lines);
            }
            catch (Exception ex)
            {
                MessageBox.Show(resources.GetString("error_writer_xhair") + "\n" + ex.Message, "Error: Setting Crosshair", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Convert color HEX code to RGB
        /// </summary>
        private static string RGBConverter(string hex)
        {
            var color = System.Drawing.ColorTranslator.FromHtml(hex);
            return $"{color.R} {color.G} {color.B} {color.A}";
        }
    }
}