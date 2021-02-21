using Terraria.ModLoader;
using Terraria;
using Terraria.ID;

namespace OtherworldyMusic
{
    public class OtherworldlyMod : Mod
    {
        public override void UpdateMusic(ref int music, ref MusicPriority priority)
        {
          //  if (Main.musicVolume != 0)
           // {
               // if (Main.myPlayer != -1 && !Main.gameMenu && Main.LocalPlayer.active)
              //  {
                    // BIOME LOW BIOME LOW BIOME LOW BIOME LOW BIOME LOW BIOME LOW BIOME LOW BIOME LOW

                   if (Main.player[Main.myPlayer].active && Main.player[Main.myPlayer].ZoneOverworldHeight && Main.dayTime) // Forest
                   {
                        music = GetSoundSlot(SoundType.Music, "Sounds/Music/ForestDay");

                      priority = MusicPriority.BiomeLow;
                    }

                  else if (Main.player[Main.myPlayer].active && Main.player[Main.myPlayer].ZoneOverworldHeight && Main.dayTime) // Alt Forest
                    {
                       music = GetSoundSlot(SoundType.Music, "Sounds/Music/ForestDay");

                        priority = MusicPriority.BiomeLow;
                    }
                  else  if (Main.player[Main.myPlayer].active && Main.player[Main.myPlayer].ZoneOverworldHeight && !Main.dayTime) // Forest night
                    {
                        music = GetSoundSlot(SoundType.Music, "Sounds/Music/ForestNight");

                        priority = MusicPriority.BiomeLow;
                    }
                    if (Main.player[Main.myPlayer].active && Main.player[Main.myPlayer].ZoneDesert) // desert
                    {
                        music = GetSoundSlot(SoundType.Music, "Sounds/Music/Desert");

                        priority = MusicPriority.BiomeLow;
                    }
                    if (Main.player[Main.myPlayer].active && Main.player[Main.myPlayer].ZoneOverworldHeight && Main.player[Main.myPlayer].ZoneHoly) // hallow
                    {
                        music = GetSoundSlot(SoundType.Music, "Sounds/Music/Hallow");

                        priority = MusicPriority.BiomeLow;
                    }
                  else  if (Main.player[Main.myPlayer].active && Main.player[Main.myPlayer].ZoneDirtLayerHeight && Main.player[Main.myPlayer].ZoneHoly) //  middleground hallow
                    {
                        music = GetSoundSlot(SoundType.Music, "Sounds/Music/UndergroundHallow");

                        priority = MusicPriority.BiomeLow;
                    }
                   else if (Main.player[Main.myPlayer].active && Main.player[Main.myPlayer].ZoneRockLayerHeight && Main.player[Main.myPlayer].ZoneHoly) // underground hallow
                    {
                        music = GetSoundSlot(SoundType.Music, "Sounds/Music/UndergroundHallow");

                        priority = MusicPriority.BiomeLow;
                    }
                    if (Main.player[Main.myPlayer].active && Main.player[Main.myPlayer].ZoneBeach) // ocean
                    {
                        music = GetSoundSlot(SoundType.Music, "Sounds/Music/Ocean");

                        priority = MusicPriority.BiomeLow;
                    }

                    // BIOME MEDIUM BIOME MEDIUM BIOME MEDIUM BIOME MEDIUM BIOME MEDIUM BIOME MEDIUM     

                    if (Main.player[Main.myPlayer].active && Main.player[Main.myPlayer].ZoneDungeon) // dungeon
                    {
                        music = GetSoundSlot(SoundType.Music, "Sounds/Music/Dungeon");

                        priority = MusicPriority.BiomeMedium;
                    }
                  else  if (Main.player[Main.myPlayer].active && Main.player[Main.myPlayer].ZoneDungeon && Main.player[Main.myPlayer].ZoneRockLayerHeight) // underground dungeon
                    {
                        music = GetSoundSlot(SoundType.Music, "Sounds/Music/Dungeon");

                        priority = MusicPriority.BiomeMedium;
                    }
                else    if (Main.player[Main.myPlayer].active && Main.player[Main.myPlayer].ZoneDungeon && Main.player[Main.myPlayer].ZoneDirtLayerHeight) // middleground dungeon
                    {
                        music = GetSoundSlot(SoundType.Music, "Sounds/Music/Dungeon");

                        priority = MusicPriority.BiomeMedium;
                    }
                  else  if (Main.player[Main.myPlayer].active && Main.player[Main.myPlayer].ZoneDungeon && Main.player[Main.myPlayer].ZoneUnderworldHeight) // hell dungeon
                    {
                        music = GetSoundSlot(SoundType.Music, "Sounds/Music/Dungeon");

                        priority = MusicPriority.BiomeMedium;
                    }
                    if (Main.player[Main.myPlayer].active && Main.player[Main.myPlayer].ZoneMeteor) // meteor
                    {
                        music = GetSoundSlot(SoundType.Music, "Sounds/Music/Eerie");

                        priority = MusicPriority.BiomeMedium;
                    }
                    if (Main.player[Main.myPlayer].active && Main.player[Main.myPlayer].ZoneJungle && Main.player[Main.myPlayer].ZoneOverworldHeight) // jungle overworld
                    {
                        music = GetSoundSlot(SoundType.Music, "Sounds/Music/Jungle");

                        priority = MusicPriority.BiomeMedium;
                    }
                 else   if (Main.player[Main.myPlayer].active && Main.player[Main.myPlayer].ZoneJungle && Main.player[Main.myPlayer].ZoneDirtLayerHeight) // jungle middleground
                    {
                        music = GetSoundSlot(SoundType.Music, "Sounds/Music/Jungle");

                        priority = MusicPriority.BiomeMedium;
                    }
                else    if (Main.player[Main.myPlayer].active && Main.player[Main.myPlayer].ZoneJungle && Main.player[Main.myPlayer].ZoneRockLayerHeight) // jungle underground
                    {
                        music = GetSoundSlot(SoundType.Music, "Sounds/Music/Jungle");

                        priority = MusicPriority.BiomeMedium;
                    }
                    if (Main.player[Main.myPlayer].active && Main.player[Main.myPlayer].ZoneSnow && Main.player[Main.myPlayer].ZoneOverworldHeight) // snow
                    {
                        music = GetSoundSlot(SoundType.Music, "Sounds/Music/Snow");

                        priority = MusicPriority.BiomeMedium;
                    }
                else    if (Main.player[Main.myPlayer].active && Main.player[Main.myPlayer].ZoneSnow && Main.player[Main.myPlayer].ZoneRockLayerHeight) // underground snow
                {
                        music = GetSoundSlot(SoundType.Music, "Sounds/Music/UndergroundSnow");

                        priority = MusicPriority.BiomeMedium;
                    }
                else    if (Main.player[Main.myPlayer].active && Main.player[Main.myPlayer].ZoneSnow && Main.player[Main.myPlayer].ZoneDirtLayerHeight) // middleground snow
                {
                        music = GetSoundSlot(SoundType.Music, "Sounds/Music/UndergroundSnow");

                        priority = MusicPriority.BiomeMedium;
                    }
            // BIOME HIGH BIOME HIGH BIOME HIGH BIOME HIGH BIOME HIGH BIOME HIGH BIOME HIGH 

      



            if (Main.player[Main.myPlayer].active && Main.player[Main.myPlayer].ZoneGlowshroom) // mushroom (currently using just cave)
                    {
                        music = GetSoundSlot(SoundType.Music, "Sounds/Music/Cave");

                        priority = MusicPriority.BiomeHigh;
                    }
                    if (Main.player[Main.myPlayer].active && Main.player[Main.myPlayer].ZoneGlowshroom && Main.player[Main.myPlayer].ZoneRockLayerHeight) // mushroom (currently using just cave)
                    {
                        music = GetSoundSlot(SoundType.Music, "Sounds/Music/Cave");

                        priority = MusicPriority.BiomeHigh;
                    }
                    if (Main.player[Main.myPlayer].active && Main.player[Main.myPlayer].ZoneCorrupt && Main.player[Main.myPlayer].ZoneOverworldHeight) // corruption overworld
                    {
                        music = GetSoundSlot(SoundType.Music, "Sounds/Music/Corruption");

                        priority = MusicPriority.BiomeHigh;
                    }
                 else   if (Main.player[Main.myPlayer].active && Main.player[Main.myPlayer].ZoneCorrupt && Main.player[Main.myPlayer].ZoneDirtLayerHeight) // corruption middleground
                    {
                        music = GetSoundSlot(SoundType.Music, "Sounds/Music/UndergroundCorruption");

                        priority = MusicPriority.BiomeHigh;
                    }
                else    if (Main.player[Main.myPlayer].active && Main.player[Main.myPlayer].ZoneCorrupt && Main.player[Main.myPlayer].ZoneRockLayerHeight) // corruption underground
                    {
                        music = GetSoundSlot(SoundType.Music, "Sounds/Music/UndergroundCorruption");

                        priority = MusicPriority.BiomeHigh;
                    }
                    if (Main.player[Main.myPlayer].active && Main.player[Main.myPlayer].ZoneCrimson && Main.player[Main.myPlayer].ZoneOverworldHeight) // crimson overwrold
                    {
                        music = GetSoundSlot(SoundType.Music, "Sounds/Music/Crimson");

                        priority = MusicPriority.BiomeHigh;
                    }
                  else  if (Main.player[Main.myPlayer].active && Main.player[Main.myPlayer].ZoneCrimson && Main.player[Main.myPlayer].ZoneDirtLayerHeight) // crimson middleground
                    {
                        music = GetSoundSlot(SoundType.Music, "Sounds/Music/UndergroundCrimson");

                        priority = MusicPriority.BiomeHigh;
                    }
                  else  if (Main.player[Main.myPlayer].active && Main.player[Main.myPlayer].ZoneCrimson && Main.player[Main.myPlayer].ZoneRockLayerHeight) // crimson underground
                    {
                        music = GetSoundSlot(SoundType.Music, "Sounds/Music/UndergroundCrimson");

                        priority = MusicPriority.BiomeHigh;
                    }

                    // ENVIRONMENT ENVIRONMENT ENVIRONMENT ENVIRONMENT ENVIRONMENT ENVIRONMENT ENVIRONMENT

                    if (Main.player[Main.myPlayer].active && Main.player[Main.myPlayer].ZoneUnderworldHeight) // hell
                    {
                        music = GetSoundSlot(SoundType.Music, "Sounds/Music/Underworld");

                        priority = MusicPriority.Environment;
                    }
                    if (Main.player[Main.myPlayer].active && Main.player[Main.myPlayer].ZoneSkyHeight) // space
                    {
                        music = GetSoundSlot(SoundType.Music, "Sounds/Music/Space");

                        priority = MusicPriority.Environment;
                    }
                    if (Main.player[Main.myPlayer].active && Main.player[Main.myPlayer].ZoneRain) // rain
                    {
                        music = GetSoundSlot(SoundType.Music, "Sounds/Music/Rain");

                        priority = MusicPriority.Environment;
                    }

                    // EVENT EVENT EVENT EVENT EVENT EVENT EVENT EVENT EVENT EVENT EVENT EVENT EVENT

                    if (Main.player[Main.myPlayer].active && Main.player[Main.myPlayer].ZoneOldOneArmy) // old ones army
                    {
                        music = GetSoundSlot(SoundType.Music, "Sounds/Music/Invasion");

                        priority = MusicPriority.Event;
                    }
                    if (Main.player[Main.myPlayer].active && Main.player[Main.myPlayer].ZoneTowerNebula) // pillar nebula
                    {
                        music = GetSoundSlot(SoundType.Music, "Sounds/Music/Pillars");

                        priority = MusicPriority.BossMedium;
                    }
                    if (Main.player[Main.myPlayer].active && Main.player[Main.myPlayer].ZoneTowerSolar) // pillar solar
                    {
                        music = GetSoundSlot(SoundType.Music, "Sounds/Music/Pillars");

                        priority = MusicPriority.BossMedium;
                    }
                    if (Main.player[Main.myPlayer].active && Main.player[Main.myPlayer].ZoneTowerStardust) // pillar stardust
                    {
                        music = GetSoundSlot(SoundType.Music, "Sounds/Music/Pillars");

                        priority = MusicPriority.BossMedium;
                    }
                    if (Main.player[Main.myPlayer].active && Main.player[Main.myPlayer].ZoneTowerVortex) // pillar vortex
                    {
                        music = GetSoundSlot(SoundType.Music, "Sounds/Music/Pillars");

                        priority = MusicPriority.BossMedium;
                    }

                    // OTHER OTHER OTHER OTHER OTHER OTHER OTHER OTHER OTHER OTHER OTHER OTHER

                    if (Main.player[Main.myPlayer].active && !Main.player[Main.myPlayer].ZoneOverworldHeight && !Main.player[Main.myPlayer].ZoneDirtLayerHeight && !Main.player[Main.myPlayer].ZoneRockLayerHeight && !Main.player[Main.myPlayer].ZoneUnderworldHeight)
                    {
                        music = GetSoundSlot(SoundType.Music, "Sounds/Music/Space");        //space

                        priority = MusicPriority.Environment;
                    }

                    // UNDERGROUND ENABLERS UNDERGROUND ENABLERS UNDERGROUND ENABLERS UNDERGROUND ENABLERS UNDERGROUND ENABLERS

             /*       if (Main.player[Main.myPlayer].active && Main.player[Main.myPlayer].ZoneRockLayerHeight && !Main.player[Main.myPlayer].ZoneDungeon) // if not in dungeon while underground, play cave
                    {
                        music = GetSoundSlot(SoundType.Music, "Sounds/Music/Cave");

                        priority = MusicPriority.BiomeLow;
                    }
                    if (Main.player[Main.myPlayer].active && Main.player[Main.myPlayer].ZoneRockLayerHeight && !Main.player[Main.myPlayer].ZoneCorrupt) // if not in dungeon while underground, play cave 
                    {
                        music = GetSoundSlot(SoundType.Music, "Sounds/Music/Cave");

                        priority = MusicPriority.BiomeLow;
                    }
                    if (Main.player[Main.myPlayer].active && Main.player[Main.myPlayer].ZoneRockLayerHeight && !Main.player[Main.myPlayer].ZoneCrimson) // if not in dungeon while underground, play cave
                    {
                        music = GetSoundSlot(SoundType.Music, "Sounds/Music/Cave");

                        priority = MusicPriority.BiomeLow;
                    }
                    if (Main.player[Main.myPlayer].active && Main.player[Main.myPlayer].ZoneRockLayerHeight && !Main.player[Main.myPlayer].ZoneHoly) // if not in dungeon while underground, play cave
                    {
                        music = GetSoundSlot(SoundType.Music, "Sounds/Music/Cave");

                        priority = MusicPriority.BiomeLow;
                    }
                    if (Main.player[Main.myPlayer].active && Main.player[Main.myPlayer].ZoneRockLayerHeight && !Main.player[Main.myPlayer].ZoneDesert) // if not in dungeon while underground, play cave
                    {
                        music = GetSoundSlot(SoundType.Music, "Sounds/Music/Cave");

                        priority = MusicPriority.BiomeLow;
                    }
                    if (Main.player[Main.myPlayer].active && Main.player[Main.myPlayer].ZoneRockLayerHeight && !Main.player[Main.myPlayer].ZoneJungle) // if not in dungeon while underground, play cave
                    {
                        music = GetSoundSlot(SoundType.Music, "Sounds/Music/Cave");

                        priority = MusicPriority.BiomeLow;
                    }
                    if (Main.player[Main.myPlayer].active && Main.player[Main.myPlayer].ZoneRockLayerHeight && !Main.player[Main.myPlayer].ZoneSnow) // if not in dungeon while underground, play cave
                    {
                        music = GetSoundSlot(SoundType.Music, "Sounds/Music/Cave");

                        priority = MusicPriority.BiomeLow;
                    }
                    if (Main.player[Main.myPlayer].active && Main.player[Main.myPlayer].ZoneDirtLayerHeight && !Main.player[Main.myPlayer].ZoneDungeon) // if not in dungeon while dirt layer, play cave
                    {
                        music = GetSoundSlot(SoundType.Music, "Sounds/Music/Cave");

                        priority = MusicPriority.BiomeLow;
                    }
                    if (Main.player[Main.myPlayer].active && Main.player[Main.myPlayer].ZoneDirtLayerHeight && !Main.player[Main.myPlayer].ZoneCorrupt) // if not in dungeon while dirt layer, play cave
                    {
                        music = GetSoundSlot(SoundType.Music, "Sounds/Music/Cave");

                        priority = MusicPriority.BiomeLow;
                    }
                    if (Main.player[Main.myPlayer].active && Main.player[Main.myPlayer].ZoneDirtLayerHeight && !Main.player[Main.myPlayer].ZoneCrimson) // if not in dungeon while dirt layer, play cave
                    {
                        music = GetSoundSlot(SoundType.Music, "Sounds/Music/Cave");

                        priority = MusicPriority.BiomeLow;
                    }
                    if (Main.player[Main.myPlayer].active && Main.player[Main.myPlayer].ZoneDirtLayerHeight && !Main.player[Main.myPlayer].ZoneHoly) // if not in dungeon while dirt layer, play cave
                    {
                        music = GetSoundSlot(SoundType.Music, "Sounds/Music/Cave");

                        priority = MusicPriority.BiomeLow;
                    }
                    if (Main.player[Main.myPlayer].active && Main.player[Main.myPlayer].ZoneDirtLayerHeight && !Main.player[Main.myPlayer].ZoneDesert) // if not in dungeon while dirt layer, play cave
                    {
                        music = GetSoundSlot(SoundType.Music, "Sounds/Music/Cave");

                        priority = MusicPriority.BiomeLow;
                    }
                    if (Main.player[Main.myPlayer].active && Main.player[Main.myPlayer].ZoneDirtLayerHeight && !Main.player[Main.myPlayer].ZoneJungle) // if not in dungeon while dirt layer, play cave
                    {
                        music = GetSoundSlot(SoundType.Music, "Sounds/Music/Cave");

                        priority = MusicPriority.BiomeLow;
                    }
                    if (Main.player[Main.myPlayer].active && Main.player[Main.myPlayer].ZoneDirtLayerHeight && !Main.player[Main.myPlayer].ZoneSnow) // if not in dungeon while dirt layer, play cave
                    {
                        music = GetSoundSlot(SoundType.Music, "Sounds/Music/Cave");

                        priority = MusicPriority.BiomeLow;
                    }
                        */



















                }
            }
        }
