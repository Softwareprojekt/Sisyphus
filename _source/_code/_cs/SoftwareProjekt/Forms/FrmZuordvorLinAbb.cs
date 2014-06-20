/**
 * @title: Thema Zuordnungsvorschrift lineare Abbildung 
 * @author: Michael Eimer
 * @date: 23.02.2014
 * 
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SoftwareProjekt.Classes.EventArguments;
using SoftwareProjekt.Classes.Math;
using SoftwareProjekt.Enums;
using SoftwareProjekt.Interfaces;
using SoftwareProjekt.Classes.Xml;

namespace SoftwareProjekt.Forms
{
    public partial class FrmZuordvorLinAbb :  AbstractView 
    {
        string _functionBlock;
        string _xVector;

        public FrmZuordvorLinAbb()
        {
            InitializeComponent();

            _functionBlock = "<mn>f</mn>\n";
            _functionBlock += "<mo>&ApplyFunction;</mo>\n";
            _functionBlock += "<mrow>\n";
            _functionBlock += "<mo>(</mo>\n";
            _functionBlock += "<mover>\n";
            _functionBlock += "\t<mi>x</mi>\n";
            _functionBlock += "\t<mo>&rarr;</mo>\n";
            _functionBlock += "</mover>\n";
            _functionBlock += "<mo>)</mo>\n";
            _functionBlock += "</mrow>\n";

            _xVector += "<mfenced open='(' close=')' separators=''>\n";
            _xVector += "<mtable>\n";

            _xVector += "\t<mtr>\n";
            _xVector += "\t\t<mtd>\n";
            _xVector += "\t\t\t<msub>\n";
            _xVector += "\t\t\t\t<mi>x</mi>\n";
            _xVector += "\t\t\t\t<mn>1</mn>\n";
            _xVector += "\t\t\t</msub>\n";
            _xVector += "\t\t</mtd>\n";
            _xVector += "\t</mtr>\n";

            _xVector += "\t<mtr>\n";
            _xVector += "\t\t<mtd>\n";
            _xVector += "\t\t\t<msub>\n";
            _xVector += "\t\t\t\t<mi>x</mi>\n";
            _xVector += "\t\t\t\t<mn>2</mn>\n";
            _xVector += "\t\t\t</msub>\n";
            _xVector += "\t\t</mtd>\n";
            _xVector += "\t</mtr>\n";

            _xVector += "</mtable>\n";
            _xVector += "</mfenced>\n";

            MathXmlGenerator xmlGen = new MathXmlGenerator();

            xmlGen.AddNode(_functionBlock);

            xmlGen.AddSign(EMathSign.Assignment);

            Matrix m = new Matrix();
            m.X11 = 0;
            m.X12 = 0;
            m.X21 = 0;
            m.X22 = 0;

            xmlGen.AddMatrix(m, Color.Purple, Color.Violet);
            xmlGen.AddSign(EMathSign.Multiply);

            xmlGen.AddNode(_xVector);
            xmlGen.AddSign(EMathSign.Assignment);

            List<string> expressions = new List<string>();
            expressions.Add(m.X11.ToString());
            expressions.Add("<msub><mi>x</mi><mn>1</mn></msub>");
            expressions.Add(m.X12.ToString());
            expressions.Add("<msub><mi>x</mi><mn>2</mn></msub>");
            expressions.Add(m.X21.ToString());
            expressions.Add("<msub><mi>x</mi><mn>1</mn></msub>");
            expressions.Add(m.X22.ToString());
            expressions.Add("<msub><mi>x</mi><mn>2</mn></msub>");

            List<Color> colors = new List<Color>();

            colors.Add(Color.Purple);
            colors.Add(Color.Black);
            colors.Add(Color.Violet);
            colors.Add(Color.Black);

            colors.Add(Color.Purple);
            colors.Add(Color.Black);
            colors.Add(Color.Violet);
            colors.Add(Color.Black);

            xmlGen.AddMathExpression(expressions, colors, EMathSign.Plus, EMathType.ComplexVector);
            xmlGen.AddSign(EMathSign.Assignment);

            xmlGen.AddNode("<msub><mi>x</mi><mn>1</mn></msub>");
            xmlGen.AddSign(EMathSign.Multiply);

            Vector v1 = new Vector(m.X11, m.X21);
            xmlGen.AddVector(v1, Color.Purple);

            xmlGen.AddSign(EMathSign.Plus);

            xmlGen.AddNode("<msub><mi>x</mi><mn>2</mn></msub>");
            xmlGen.AddSign(EMathSign.Multiply);

            Vector v2 = new Vector(m.X12, m.X22);
            xmlGen.AddVector(v2, Color.Violet);



            xmlGen.Finish();

            ctlMathEqua.WriteEquationToPicBox(xmlGen.XmlDoc);
        }

        public override Dictionary<string, Object> GetInputData()
        {
            Dictionary<string, Object> retVal = new Dictionary<string, object>();

            /*retVal.Add("EV1", _vector.Einheitsvector1);
            retVal.Add("EV2", _vector.Einheitsvector2);
            retVal.Add("VectorX", _vector.VectorX);
            retVal.Add("Angle", _vector.Angle);*/

            return retVal;
        }

        public override void ExerciseChanged(IExercise sender, ExerciseEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void butFunctionX_Click(object sender, EventArgs e)
        {
            this.OnViewChanged(new ViewEventArgs(EClickedButton.StartCalculation));
        }

        private void rtxtNotes_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
