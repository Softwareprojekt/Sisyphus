using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftwareProjekt
{
    public class AbstractTopic : ITopic
    {
        public List<IExcercise> ExcerciseList
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }


        public void StartExcercise(Excercises id)
        {
            throw new NotImplementedException();
        }
    }
}
