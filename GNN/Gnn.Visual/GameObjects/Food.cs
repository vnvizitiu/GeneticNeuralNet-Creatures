﻿using Gnn.Visual.GameObjects.Base;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gnn.Visual.GameObjects {

    public class Food : GameObject, IWorldVisible {
        private float health;

        public float Health {
            get { return health; }
            set { health = value > 1 ? 1 : value; }
        }

        public Vector2 Color => new Vector2(0, health);

        public Food(MainGameContent res, Vector2 position) : base(res.TFood, position) {
        }

        public override void Interact(IEnumerable<GameObject> gameObjs, float secsPassed) {
            Health += (1f / 3f) * secsPassed;
        }

        public override void Move(float secsPassed) {
            Rotation += (1f * health) * secsPassed;
        }

        public override void Draw(SpriteBatch sb) {
            var rg = Color;
            var col = new Color(rg.X, rg.Y, 0, Health + 0.3f);
            sb.Draw(Texture, new Rectangle(DrawX, DrawY, Texture.Width, Texture.Height), null, col, Rotation, Origin, SpriteEffects.None, 0);
        }
    }
}