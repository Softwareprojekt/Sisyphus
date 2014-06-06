
#region LicenseHeader
/*
 * Copyright (C) 2014 Technische Hochschule Amberg
 * 
 * This program is free software; you can redistribute it and/or
 * modify it under the terms of the GNU General Public License
 * as published by the Free Software Foundation; either version 2
 * of the License, or (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
 */
#endregion

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SoftwareProjekt
{
    public class MindMapTopicControl : UserControl
    {
        private List<MindMapButtonControl> _mindMapButtonList;
        private ITopic _logicalTopic;
        private List<TopicConnect> _topicConnectionList;


        public MindMapTopicControl()
        {
            _mindMapButtonList = new List<MindMapButtonControl>();
            _topicConnectionList = new List<TopicConnect>();

            _logicalTopic = null;

            InitializeComponent();
        }

        public List<MindMapButtonControl> ButtonList
        {
            get
            {
                return _mindMapButtonList;
            }
        }
        public List<TopicConnect> TopicConnectionList
        {
            get
            {
                return _topicConnectionList;
            }
        }

        public ITopic LogicalTopic
        {
            get
            {
                return _logicalTopic;
            }
        }

        public void RegisterTopic(ITopic topic)
        {
            _logicalTopic = topic;
        }

        public void UnregisterTopic()
        {
            _logicalTopic = null;
        }

        public void OnExerciseButtonClicked(int exerciseID)
        {
            if (_logicalTopic == null)
            {
                return;
            }

            _logicalTopic.StartExercise((Exercises)exerciseID);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // MindMapTopicControl
            // 
            this.Name = "MindMapTopicControl";
            this.Paint += MindMapTopicControl_Paint;
            this.ResumeLayout(false);

        }

        void MindMapTopicControl_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            if (this._logicalTopic == null)
            {
                return;
            }

            string topicName = this._logicalTopic.TopicType().ToString();

            g.DrawEllipse(Pens.Black, 0, 0, this.Width - 2, this.Height - 2);

            g.DrawString(topicName, new Font("Arial", 12.0f), new SolidBrush(Color.Black), new PointF(this.Width / 2 - (topicName.Length * 7.5f / 2), this.Height / 2 - 10));
        }
    }
}
