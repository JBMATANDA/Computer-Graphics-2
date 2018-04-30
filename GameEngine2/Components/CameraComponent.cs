using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine2.Components
{
    public class CameraComponent : IComponent
    {
        public Matrix View { get; set; }
        public Matrix Projection { get; set; }
        public Matrix World { get; set; }

        public Vector3 Position;
        public Vector3 Direction;
        public Vector3 Movement;
        public Vector3 Rotation;
    }
}
