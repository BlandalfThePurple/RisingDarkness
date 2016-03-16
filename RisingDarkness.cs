using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RisingDarkness
{
public class RisingDarkness : Mod
{
    
    public bool firstPress = true;
    public bool firstPress2 = true;
    
    public override void SetModInfo(out String name, ref ModProperties properties)
    {
        
        name = "RisingDarkness";
        properties.Autoload = true;
        properties.AutoloadGores = true;
        properties.AutoloadSounds = true;
    }
    
    public override void Load()
    {
        
        RegisterHotKey("Prev Song", "OemCloseBrackets");
        RegisterHotKey("Next Song", "OemOpenBrackets");
        RegisterHotKey("Clear Song", "OemQuotes");
        RegisterHotKey("Teleporty Stuff", "Q");
        RegisterHotKey("Portable Wormhole", "LeftAlt");
        
    }
    
    public override void HotKeyPressed(string name)
    {
        Player player = Main.player[Main.myPlayer];
        DarkPlayer pl = ((DarkPlayer)player.GetModPlayer(this, "DarkPlayer"));
        
        if (Main.myPlayer != -1 && !Main.gameMenu)
        {
            if(firstPress)
            {
            if(pl.hasPlayer2)
            {
            if(name == "Prev Song")
            {
                pl.Music(false, -1);
            }else if (name == "Next Song")
            {
                pl.Music();
            }else if (name == "Clear Song")
            {
                pl.Music(true, 1);
            }

            }
            
            }
        
        if(name == "Teleporty Stuff" && pl.hasAutoPlayer2)
        {
            pl.pressLong++;
        }
        
        if(name == "Portable Wormhole" && pl.hasTruePlayer)
        {
            pl.telePress2 = true;
            pl.teleHold++;

        }
        
            firstPress2 = false;
        }
        
    }
    
        public override void UpdateMusic(ref int music)
		{
            
            Player player = Main.player[Main.myPlayer];
            DarkPlayer pl = ((DarkPlayer)player.GetModPlayer(this, "DarkPlayer"));

            if(pl.teleHold > 30 && !pl.telePrev)
            {
                if (pl.selPlayer == -1)
                {
                    pl.NewText("No player selected!", 255, 0, 0);
                }
                else
                {
                    player.UnityTeleport(Main.player[pl.selPlayer].position);
                }
                pl.telePrev = true;
                pl.teleHold = 0;
            }

            if (!pl.telePress2 && pl.telePress)
            {
                if (!pl.telePrev)
                {
                    // pl.NewText("Early");
                    // pl.ClearText();
                    // pl.NewText("Before");

                    if (pl.IncrementPlayer())
                    {
                        pl.NewText("[Selected] > " + Main.player[pl.selPlayer].name);
                    }
                    else
                    {
                        pl.NewText("No valid players to select!", 255, 0, 0);
                    }
                    // pl.NewText("After");
                }
                else
                {
                    pl.telePrev = false;
                }
                pl.teleHold = 0;
            }

            
            if(!pl.telePress2)
            {
                pl.telePress = false;
            }
            else
            {
                pl.telePress = true;
            }

            if (!pl.hasTruePlayer2)
            {
                pl.hasTruePlayer = false;
            }
            else
            {
                pl.hasTruePlayer = true;
            }

            pl.hasTruePlayer2 = false;
            pl.telePress2 = false;
            
            if(!firstPress2)
            {
                firstPress = false;
                firstPress2 = true;
            }
            else
            {
                firstPress = true;
            }
			if (Main.myPlayer != -1 && !Main.gameMenu && ((DarkPlayer)Main.player[Main.myPlayer].GetModPlayer(this, "DarkPlayer")).hasPlayer2)
            {
               
                if(player.active && pl.musicIndex > 0)
                {
                    music = pl.musicIndex;
                }
            }
            
            
            //Is it weird that I put this here?
            //It wouldn't call anywhere else, but still.
          
            Item item = pl.magicMirror;
            
            if(item != null)
        {
            
            
               //Imported from Player.cs in the Terraria source code.
               //I do not claim any ownership of this code, and I intend no infringement by using it.
               
                if (Main.rand.Next(2) == 0)
				{
					Dust.NewDust(player.position, player.width, player.height, 15, 0f, 0f, 150, default(Color), 1.1f);
				}
				if (pl.usedFor == 0)
				{
					pl.usedFor = item.useTime;
				}
				else if (--pl.usedFor <= item.useTime / 2)
				{
					for (int num315 = 0; num315 < 70; num315++)
					{
						Dust.NewDust(player.position, player.width, player.height, 15, player.velocity.X * 0.5f, player.velocity.Y * 0.5f, 150, default(Color), 1.5f);
					}
					player.grappling[0] = -1;
					player.grapCount = 0;
					for (int num316 = 0; num316 < 1000; num316++)
					{
						if (Main.projectile[num316].active && Main.projectile[num316].owner == Main.myPlayer && Main.projectile[num316].aiStyle == 7)
						{
							Main.projectile[num316].Kill();
						}
					}
					player.Spawn();
					for (int num317 = 0; num317 < 70; num317++)
					{
						Dust.NewDust(player.position, player.width, player.height, 15, 0f, 0f, 150, default(Color), 1.5f);
					}
                    
                    pl.magicMirror = null;
                    pl.usedFor = 0;
                    pl.mirrorUsed = true;
				}
                
                //End import
                
        }
                
                item = pl.discord;
                
                if(item != null)
                {
                    
                    //Same as above.

					Vector2 vector14;
					vector14.X = (float)Main.mouseX + Main.screenPosition.X;
					if (player.gravDir == 1f)
					{
						vector14.Y = (float)Main.mouseY + Main.screenPosition.Y - (float)player.height;
					}
					else
					{
						vector14.Y = Main.screenPosition.Y + (float)Main.screenHeight - (float)Main.mouseY;
					}
					vector14.X -= (float)(player.width / 2);
					if (vector14.X > 50f && vector14.X < (float)(Main.maxTilesX * 16 - 50) && vector14.Y > 50f && vector14.Y < (float)(Main.maxTilesY * 16 - 50))
					{
						int num245 = (int)(vector14.X / 16f);
						int num246 = (int)(vector14.Y / 16f);
						if ((Main.tile[num245, num246].wall != 87 || (double)num246 <= Main.worldSurface || NPC.downedPlantBoss) && !Collision.SolidCollision(vector14, player.width, player.height))
						{
							player.Teleport(vector14, 1, 0);
							NetMessage.SendData(65, -1, -1, "", 0, (float)player.whoAmI, vector14.X, vector14.Y, 1, 0, 0);
							if (player.chaosState)
							{
								player.statLife -= player.statLifeMax2 / 7;
								if (Lang.lang <= 1)
								{
									string deathText = " didn't materialize";
									if (Main.rand.Next(2) == 0)
									{
										if (player.Male)
										{
											deathText = "'s legs appeared where his head should be";
										}
										else
										{
											deathText = "'s legs appeared where her head should be";
										}
									}
									if (player.statLife <= 0)
									{
										player.KillMe(1.0, 0, false, deathText);
									}
								}
								else if (player.statLife <= 0)
								{
									player.KillMe(1.0, 0, false, "");
								}
								player.lifeRegenCount = 0;
								player.lifeRegenTime = 0;
							}
							player.AddBuff(88, 360, true);
                            
                            pl.discord = null;
                            
                        
                        
						}
					
                    
                 }
                    //End import
            }
                

        }
}

}