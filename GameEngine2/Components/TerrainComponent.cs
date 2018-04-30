using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine2.Components
{
    public class TerrainComponent : IComponent
    {
        public Texture2D HeightMap { get; set; }
        public BasicEffect Effect { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }
}
