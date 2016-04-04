﻿/*
    The MIT License (MIT)

    Copyright (c) 2015 JC Snider, Joe Bridges
  
    Website: http://ascensiongamedev.com
    Contact Email: admin@ascensiongamedev.com

    Permission is hereby granted, free of charge, to any person obtaining a copy
    of this software and associated documentation files (the "Software"), to deal
    in the Software without restriction, including without limitation the rights
    to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
    copies of the Software, and to permit persons to whom the Software is
    furnished to do so, subject to the following conditions:

    The above copyright notice and this permission notice shall be included in all
    copies or substantial portions of the Software.

    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
    IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
    FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
    AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
    LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
    OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
    SOFTWARE.
*/

using System.Collections.Generic;
using System.IO;
using IntersectClientExtras.Audio;
using IntersectClientExtras.File_Management;
using Intersect_Client.Classes.Core;
using Intersect_Client_MonoGame.Classes.SFML.Graphics;
using Intersect_MonoGameDx.Classes.SFML.Audio;

namespace Intersect_Client.Classes.Bridges_and_Interfaces.SFML.File_Management
{
    public class MonoContentManager : GameContentManager 
    {
        //Graphic Loading
        public override void LoadTilesets(string[] tilesetnames)
        {
            foreach (var t in tilesetnames)
            {
                if (t == "")
                {
                    GameGraphics.Tilesets.Add(null);
                }
                else
                {
                    if (!File.Exists("Resources/Tilesets/" + t))
                    {
                        GameGraphics.Tilesets.Add(null);
                    }
                    else
                    {
                        GameGraphics.Tilesets.Add(GameGraphics.Renderer.LoadTexture("Resources/Tilesets/" + t));
                    }
                }
            }
        }
        public override void LoadItems()
        {
            if (!Directory.Exists("Resources/Items")) { Directory.CreateDirectory("Resources/Items"); }
            var items = Directory.GetFiles("Resources/Items", "*.png");
            GameGraphics.ItemFileNames = new List<string>();
            GameGraphics.ItemTextures = new MonoTexture[items.Length];
            for (int i = 0; i < items.Length; i++)
            {
                GameGraphics.ItemFileNames.Add(items[i].Replace("Resources/Items\\", ""));
                GameGraphics.ItemTextures[i] = GameGraphics.Renderer.LoadTexture("Resources/Items/" + GameGraphics.ItemFileNames[i]);
            }
        }
        public override void LoadEntities()
        {
            if (!Directory.Exists("Resources/Entities")) { Directory.CreateDirectory("Resources/Entities"); }
            var chars = Directory.GetFiles("Resources/Entities", "*.png");
            GameGraphics.EntityFileNames = new List<string>();
            GameGraphics.EntityTextures = new MonoTexture[chars.Length];
            for (int i = 0; i < chars.Length; i++)
            {
                GameGraphics.EntityFileNames.Add(chars[i].Replace("Resources/Entities\\", ""));
                GameGraphics.EntityTextures[i] = GameGraphics.Renderer.LoadTexture("Resources/Entities/" + GameGraphics.EntityFileNames[i]);
            }
        }
        public override void LoadSpells()
        {
            if (!Directory.Exists("Resources/Spells")) { Directory.CreateDirectory("Resources/Spells"); }
            var spells = Directory.GetFiles("Resources/Spells", "*.png");
            GameGraphics.SpellFileNames = new List<string>();
            GameGraphics.SpellTextures = new MonoTexture[spells.Length];
            for (int i = 0; i < spells.Length; i++)
            {
                GameGraphics.SpellFileNames.Add(spells[i].Replace("Resources/Spells\\", ""));
                GameGraphics.SpellTextures[i] = GameGraphics.Renderer.LoadTexture("Resources/Spells/" + GameGraphics.SpellFileNames[i]);
            }
        }
        public override void LoadAnimations()
        {
            if (!Directory.Exists("Resources/Animations")) { Directory.CreateDirectory("Resources/Animations"); }
            var animations = Directory.GetFiles("Resources/Animations", "*.png");
            GameGraphics.AnimationFileNames = new List<string>();
            GameGraphics.AnimationTextures = new MonoTexture[animations.Length];
            for (int i = 0; i < animations.Length; i++)
            {
                GameGraphics.AnimationFileNames.Add(animations[i].Replace("Resources/Animations\\", ""));
                GameGraphics.AnimationTextures[i] = GameGraphics.Renderer.LoadTexture("Resources/Animations/" + GameGraphics.AnimationFileNames[i]);
            }
        }
        public override void LoadFaces()
        {
            if (!Directory.Exists("Resources/Faces")) { Directory.CreateDirectory("Resources/Faces"); }
            var faces = Directory.GetFiles("Resources/Faces", "*.png");
            GameGraphics.FaceFileNames = new List<string>();
            GameGraphics.FaceTextures = new MonoTexture[faces.Length];
            for (int i = 0; i < faces.Length; i++)
            {
                GameGraphics.FaceFileNames.Add(faces[i].Replace("Resources/Faces\\", ""));
                GameGraphics.FaceTextures[i] = GameGraphics.Renderer.LoadTexture("Resources/Faces/" + GameGraphics.FaceFileNames[i]);
            }
        }
        public override void LoadImages()
        {
            if (!Directory.Exists("Resources/Images")) { Directory.CreateDirectory("Resources/Images"); }
            var images = Directory.GetFiles("Resources/Images", "*.png");
            GameGraphics.ImageFileNames = new List<string>();
            GameGraphics.ImageTextures = new MonoTexture[images.Length];
            for (int i = 0; i < images.Length; i++)
            {
                GameGraphics.ImageFileNames.Add(images[i].Replace("Resources/Images\\", ""));
                GameGraphics.ImageTextures[i] = GameGraphics.Renderer.LoadTexture("Resources/Images/" + GameGraphics.ImageFileNames[i]);
            }
        }
        public override void LoadFogs()
        {
            if (!Directory.Exists("Resources/Fogs")) { Directory.CreateDirectory("Resources/Fogs"); }
            var fogs = Directory.GetFiles("Resources/Fogs", "*.png");
            GameGraphics.FogFileNames = new List<string>();
            GameGraphics.FogTextures = new MonoTexture[fogs.Length];
            for (int i = 0; i < fogs.Length; i++)
            {
                GameGraphics.FogFileNames.Add(fogs[i].Replace("Resources/Fogs\\", ""));
                GameGraphics.FogTextures[i] = GameGraphics.Renderer.LoadTexture("Resources/Fogs/" + GameGraphics.FogFileNames[i]);
            }
        }
        public override void LoadResources()
        {
            if (!Directory.Exists("Resources/Resources")) { Directory.CreateDirectory("Resources/Resources"); }
            var resources = Directory.GetFiles("Resources/Resources", "*.png");
            GameGraphics.ResourceFileNames = new List<string>();
            GameGraphics.ResourceTextures = new MonoTexture[resources.Length];
            for (int i = 0; i < resources.Length; i++)
            {
                GameGraphics.ResourceFileNames.Add(resources[i].Replace("Resources/Resources\\", ""));
                GameGraphics.ResourceTextures[i] = GameGraphics.Renderer.LoadTexture("Resources/Resources/" + GameGraphics.ResourceFileNames[i]);
            }
        }
        public override void LoadPaperdolls()
        {
            if (!Directory.Exists("Resources/Paperdolls")) { Directory.CreateDirectory("Resources/Paperdolls"); }
            var resources = Directory.GetFiles("Resources/Paperdolls", "*.png");
            GameGraphics.PaperdollFileNames = new List<string>();
            GameGraphics.PaperdollTextures = new MonoTexture[resources.Length];
            for (int i = 0; i < resources.Length; i++)
            {
                GameGraphics.PaperdollFileNames.Add(resources[i].Replace("Resources/Paperdolls\\", ""));
                GameGraphics.PaperdollTextures[i] = GameGraphics.Renderer.LoadTexture("Resources/Paperdolls/" + GameGraphics.PaperdollFileNames[i]);
            }
        }
        public override void LoadGui()
        {
            if (!Directory.Exists("Resources/GUI")) { Directory.CreateDirectory("Resources/GUI"); }
            var resources = Directory.GetFiles("Resources/GUI", "*.png");
            GameGraphics.GuiFilenames = new List<string>();
            GameGraphics.GuiTextures = new MonoTexture[resources.Length];
            for (int i = 0; i < resources.Length; i++)
            {
                GameGraphics.GuiFilenames.Add(resources[i].Replace("Resources/GUI\\", ""));
                GameGraphics.GuiTextures[i] = GameGraphics.Renderer.LoadTexture("Resources/GUI/" + GameGraphics.GuiFilenames[i]);
            }
        }
        public override void LoadTarget()
        {
            if (!Directory.Exists("Resources/Misc")) { Directory.CreateDirectory("Resources/Misc"); }
            GameGraphics.TargetTexture = GameGraphics.Renderer.LoadTexture("Resources/Misc/target.png");
        }

        public override void LoadSounds()
        {
            if (!Directory.Exists("Resources/Sounds")) { Directory.CreateDirectory("Resources/Sounds"); }
            var wavsounds = Directory.GetFiles("Resources/Sounds", "*.wav");
            GameAudio.SoundFiles = new List<string>();
            GameAudio.SoundSources = new GameAudioSource[wavsounds.Length];
            for (int i = 0; i < wavsounds.Length; i++)
            {
                GameAudio.SoundFiles.Add(RemoveExtension(wavsounds[i].Replace("Resources/Sounds\\", "").ToLower()));
                GameAudio.SoundSources[i + wavsounds.Length] = new MonoSoundSource(wavsounds[i]);
            }
        }

        public override void LoadMusic()
        {
            if (!Directory.Exists("Resources/Music")) { Directory.CreateDirectory("Resources/Music"); }
            var music = Directory.GetFiles("Resources/Music", "*.mp3");
            GameAudio.MusicFiles = new List<string>();
            GameAudio.MusicSources = new GameAudioSource[music.Length];
            for (int i = 0; i < music.Length; i++)
            {
                GameAudio.MusicSources[i] = new MonoMusicSource(music[i]);
                GameAudio.MusicFiles.Add(RemoveExtension(music[i].Replace("Resources/Music\\", "").ToLower()));
            }
        }
    }
}