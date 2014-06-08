using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftwareProjekt
{
    public class XmlExercise
    {
        private int _exerciseID;
        private string _exerciseName;

        public int ExerciseID
        {
            get
            {
                return _exerciseID;
            }
            set
            {
                _exerciseID = value;
            }
        }

        public string ExerciseName
        {
            get
            {
                return _exerciseName;
            }
            set
            {
                _exerciseName = value;
            }
        }
    }
}
