using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;

namespace RisingDarkness
{
    public class DarkPlayer : ModPlayer
    {
        public int pSick = 0;
        public bool sick = false;
        
        public bool drunk = false;
        public bool drunk2 = false;
        
        public int drunkAtk = 0;
        public int drunkDef = 0;
        public int drunkSpd = 0;
        public int drunkAccl = 0;
        public int drunkKB = 0;
        
        public int drunkIndex = 0;
        
        public bool hasPlayer = false;
        public bool hasPlayer2 = false;
        public bool hasAutoPlayer = false;
        public bool hasAutoPlayer2 = false;
        public bool hasTruePlayer = false;
        public bool hasTruePlayer2 = false;
        public int musicIndex = 0;
        
        public Item magicMirror = null;
        public Item discord = null;
        public int usedFor = 0;
        public int dcd = 0;
        public bool mirrorUsed = false;
        
        public bool unpressTeleport = false;
        public bool unpressTeleport2 = false;
        public bool unpressTeleport3 = false;
        public int pressLong = 0;

        public int selPlayer = -1;
        public int teleHold = 0;
        public bool telePress = false;
        public bool telePress2 = false;
        public bool telePrev = false;
        
        public void Drink()
        {
            drunkIndex++;
        }
        
        public void Music()
        {
            Music(false, 1);
        }
        
        public void NewText(string text, int r, int g, int b)
        {
            Main.NewText(text, (byte)r, (byte)g, (byte)b);
        }
        public void NewText(string text)
        {
            NewText(text, 255, 255, 255);
        }
        
        public void ClearText()
        {
            for(int i = 0; i < 7; i++)
            {
                NewText("");
            }
        }
        
        public void ClearedText(string text)
        {
            ClearText();
            NewText(text);
        }
        
        public void Music(bool reset, int increase)
        {
            musicIndex = musicIndex < 39 ? reset ? 0 : musicIndex + increase : 0;
        }
        
        public override void PreUpdateBuffs()
        {
            if(pSick>0)
            {
                pSick--;
                sick = true;
            }else{
                sick = false;
            }
            
            
            
        }
        
        public bool IncrementPlayer()
        {
           return IncrementPlayer(1);
        }
        
        public bool IncrementPlayer(int up)
        {

           int invalid = 0;

            if(selPlayer == -1)
            {
                if(up > 0)
                {
                    selPlayer = 0;
                }
                else if(up < 0)
                {
                    selPlayer = 255;
                }
            }
            while (selPlayer != -1 && !(Main.player[selPlayer].active && !Main.player[selPlayer].dead && selPlayer != Main.myPlayer && ((!Main.player[Main.myPlayer].hostile && !Main.player[selPlayer].hostile) || (Main.player[Main.myPlayer].team == Main.player[selPlayer].team && Main.player[selPlayer].team != 0) || selPlayer == Main.myPlayer)))
            {
                selPlayer += up;
                invalid += up;
                if(selPlayer >= 256)
                {
                    selPlayer = -1;

                    if (invalid >= 256)
                    {
                        return false;
                    }
                }

            }
            return true;

        }
    
    public override void PostUpdateBuffs()
    {
        
        if(drunk)
        {
            drunk2 = true;
        }
        else
        {
            
            drunk2 = false;
            
            drunkAtk = 0;
            drunkDef = 0;
            drunkKB = 0;
            drunkSpd = 0;
            drunkAccl = 0;
            
            drunkIndex = 0;
            
        }
        drunk = false;
    }    
    public override void PostUpdateRunSpeeds()
    {
        player.runAcceleration += AddToStat(drunkAccl);
        player.maxRunSpeed += AddToStat(drunkSpd);
    }
    
    public float AddToStat(int drunkStat)
    {
        return (float)drunkStat * 0.1f;
        
    }
    
    
    
    
    }
    
}