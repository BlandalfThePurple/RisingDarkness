using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using RisingDarkness;

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
        public int musicIndex = 0;
        
        public Item magicMirror = null;
        public int usedFor = 0;
        
        public bool unpressTeleport = false;
        public bool unpressTeleport2 = false;
        public bool unpressTeleport3 = false;
        public int pressLong = 0;
        
        public void Drink()
        {
            drunkIndex++;
        }
        
        public void Music()
        {
            Music(false, 1);
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
        player.runAcceleration += addToStat(drunkAccl);
        player.maxRunSpeed += addToStat(drunkSpd);
    }
    
    public void PostUpdate()
    {
        if(hasPlayer2)
        {
            hasPlayer = true;
        }
        else
        {
            hasPlayer = false;
        }
        if(hasAutoPlayer2)
        {
            hasAutoPlayer = true;
        }
        else
        {
            hasAutoPlayer = false;
        }
        if(!unpressTeleport2 && unpressTeleport)
        {
            unpressTeleport3 = true;
        }
        else
        {
            unpressTeleport3 = false;
        }
        if(unpressTeleport2)
        {
            unpressTeleport = true;
            Main.NewText("PENIS");
        }
        else
        {
            unpressTeleport = false;
        }
        hasPlayer2 = false;
        hasAutoPlayer2 = false;
        unpressTeleport2 = false;
    
    }
    
    public int addToStat(int drunkStat)
    {
        return 0;
        
    }
    
    
    
    
    }
    
}