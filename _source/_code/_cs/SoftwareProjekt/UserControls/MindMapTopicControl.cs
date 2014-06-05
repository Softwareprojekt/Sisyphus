
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

        public System.Collections.Generic.List<SoftwareProjekt.MindMapButtonControl> ButtonList
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public ITopic LogicalTopic
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public System.Collections.Generic.List<SoftwareProjekt.TopicConnect> TopicConnectionList
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void RegisterTopic(ITopic topic)
        {
            throw new System.NotImplementedException();
        }

        public void UnregisterTopic()
        {
            throw new System.NotImplementedException();
        }

        public void OnExerciseButtonClicked(int exerciseID)
        {
            throw new System.NotImplementedException();
        }
    }
}
