using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Monogame3DAnimator
{
    public class Animation
    {
        float _time;

        public List<float> KeyframeTimes;

        public List<List<Transformation>> Keyframes;

        public Model AnimatedMesh;

        public void RunAnimation(float dt)
        {
            if(AnimatedMesh == null) return;
            if (KeyframeTimes.Count == 0) return;
            if (Keyframes.Count == 0) return;
            _time += dt;
            for(int i = 0; i < KeyframeTimes.Count; i++)
            {
                if(KeyframeTimes[i] > _time)
                {

                }
            }
        }

    }
}
