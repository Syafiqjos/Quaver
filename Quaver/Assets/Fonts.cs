using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Quaver.Resources;
using Wobble;
using Wobble.Assets;

namespace Quaver.Assets
{
    public static class Fonts
    {
        public static SpriteFont AllerRegular16 { get; set; }
        public static SpriteFont AllerLight16 { get; set; }
        public static SpriteFont AllerBold16 { get; set; }
        public static SpriteFont Exo2Regular24 { get; set; }
        public static SpriteFont Exo2Bold24 { get; set; }
        public static SpriteFont Exo2BoldItalic24 { get; set; }
        public static SpriteFont Exo2ExtraBold24 { get; set; }
        public static SpriteFont Exo2Italic24 { get; set; }

        /// <summary>
        ///     Loads all the fonts for the game.
        /// </summary>
        public static void Load()
        {
            AllerRegular16 = AssetLoader.LoadFont(QuaverResources.ResourceManager, "aller_regular_16");
            AllerLight16 = AssetLoader.LoadFont(QuaverResources.ResourceManager, "aller_light_16");
            AllerBold16 = AssetLoader.LoadFont(QuaverResources.ResourceManager, "aller_bold_16");
            Exo2Regular24 = AssetLoader.LoadFont(QuaverResources.ResourceManager, "exo2_regular_24");
            Exo2Bold24 = AssetLoader.LoadFont(QuaverResources.ResourceManager, "exo_bold_24");
            Exo2BoldItalic24 = AssetLoader.LoadFont(QuaverResources.ResourceManager, "exo_bolditalic_24");
            Exo2ExtraBold24 = AssetLoader.LoadFont(QuaverResources.ResourceManager, "exo_extrabold_24");
            Exo2Italic24 = AssetLoader.LoadFont(QuaverResources.ResourceManager, "exo_italic_24");
        }
    }
}
