using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameEngine2.Manager;
using GameEngine2.Components;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace GameEngine2.Systems
{
    public class CameraSystem
    {
        public void Update(GameTime gameTime, GraphicsDeviceManager graphics)
        {
            var cameraComponents = ComponentManager.Get.GetComponents<CameraComponent>();

            foreach(var cameraComponent in cameraComponents)
            {
                var camera = cameraComponent.Value as CameraComponent;

                var aspectRatio = graphics.PreferredBackBufferWidth / (float)graphics.PreferredBackBufferHeight;
                var far = 1000f;
                var near = 0.1f;
                var tempMovement = Vector3.Zero;
                var tempRotation = Vector3.Zero;

                camera.Position = new Vector3(0, 0, 20);
                camera.Direction = new Vector3(0, 0, 0);
                camera.View = Matrix.CreateLookAt(camera.Position, camera.Direction, Vector3.Up);
                camera.Projection = Matrix.CreatePerspective(MathHelper.PiOver4, aspectRatio, near, far);
                camera.World = Matrix.Identity;

                if (Keyboard.GetState().IsKeyDown(Keys.W))
                {
                    tempMovement.Y = +camera.Movement.Y;
                }
                if (Keyboard.GetState().IsKeyDown(Keys.W))
                {
                    tempMovement.Y = +camera.Movement.Y;
                }
                if (Keyboard.GetState().IsKeyDown(Keys.W))
                {
                    tempMovement.Y = +camera.Movement.Y;
                }
                if (Keyboard.GetState().IsKeyDown(Keys.W))
                {
                    tempMovement.Y = +camera.Movement.Y;
                }
            }
        }
    }
}
