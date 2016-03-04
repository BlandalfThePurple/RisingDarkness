using Microsoft.Xna.Framework.Audio;
using Terraria;
using Terraria.ModLoader;

namespace RisingDarkness.Sounds.Item
{
	public class MmmCranberries : ModSound
	{
		public override void PlaySound(ref SoundEffectInstance soundInstance, float volume, float pan, SoundType type)
		{
			soundInstance = sound.CreateInstance();
			soundInstance.Volume = volume * 0.75f;
			soundInstance.Pan = pan;
			soundInstance.Pitch = 0.2f;
			Main.PlaySoundInstance(soundInstance);
		}
	}
}
