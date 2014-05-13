using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftwareProjekt
{
    public interface ITopic
    {
        List<IExcercise> ExcerciseList
        {
            get;
            set;
        }

        void StartExcercise(Excercises id);
    }

    public interface CopyOfITopic
    {
    }
}
