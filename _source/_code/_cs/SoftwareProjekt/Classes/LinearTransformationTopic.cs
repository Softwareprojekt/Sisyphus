using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftwareProjekt
{
    public class LinearTransformationTopic : AbstractTopic
    {
        public override void StartExercise(Exercises id)
        {
            base.StartExercise(id);
        }

        public override ETopic TopicType()
        {
            return ETopic.LinearTransformation;
        }
    }
}
