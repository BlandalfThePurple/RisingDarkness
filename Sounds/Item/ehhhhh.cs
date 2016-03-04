using Microsoft.Xna.Framework.Audio;
using Terraria;
using Terraria.ModLoader;

namespace RisingDarkness.Sounds.Item
{
	public class ehhhhh : ModSound
	{
		public override void PlaySound(ref SoundEffectInstance soundInstance, float volume, float pan, SoundType type)
		{
			soundInstance = sound.CreateInstance();
			soundInstance.Volume = volume * 0.5f;
			soundInstance.Pan = pan;
            if(Main.rand.Next(100)==99){
                soundInstance.Pitch = -1.0f;
            }else{
			soundInstance.Pitch = Main.rand.Next(-5,5)/10f;
            }
			Main.PlaySoundInstance(soundInstance);
		}
	}
}
