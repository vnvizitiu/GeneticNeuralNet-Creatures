﻿using Gnn.Visual.GameObjects;
using Gnn.Visual.GameObjects.Base;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gnn.Visual {

    public class World {
        public List<GameObject> GameObjs { get; }

        public World() {
            GameObjs = new List<GameObject>();
        }

        public void Initialize(MainGameContent res) {
            GameObjs.AddRange(new Creature[] {
                new Creature(res.TCreature, new Vector2(300, 300)),
                new Creature(res.TCreature, new Vector2(300, 400)),
                new Creature(res.TCreature, new Vector2(300, 500)),
                new Creature(res.TCreature, new Vector2(400, 300)),
                new Creature(res.TCreature, new Vector2(400, 400)),
                new Creature(res.TCreature, new Vector2(400, 500)),
                new Creature(res.TCreature, new Vector2(500, 300)),
                new Creature(res.TCreature, new Vector2(500, 400)),
                new Creature(res.TCreature, new Vector2(500, 500)),
            });
        }

        public void Update(MouseState mState, KeyboardState kState, Point mPosInWorld) {
            foreach(var c in GameObjs) {
                c.Move();
            }
            foreach(var c in GameObjs) {
                c.Interact(GameObjs);
            }
        }

        public void Draw(SpriteBatch sb) {
            foreach(var c in GameObjs) {
                c.Draw(sb);
            }
        }
    }
}