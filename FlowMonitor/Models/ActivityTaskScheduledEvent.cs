﻿//Copyright 2016 Malooba Ltd

//Licensed under the Apache License, Version 2.0 (the "License");
//you may not use this file except in compliance with the License.
//You may obtain a copy of the License at

//    http://www.apache.org/licenses/LICENSE-2.0

//Unless required by applicable law or agreed to in writing, software
//distributed under the License is distributed on an "AS IS" BASIS,
//WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//See the License for the specific language governing permissions and
//limitations under the License.

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FlowMonitor.Models
{
    [JsonObject]
    public class ActivityTaskScheduledEvent
    {
        /// <summary>
        /// Unique ID of activity task
        /// </summary>
        [JsonProperty(PropertyName = "activityId")]
        public string ActivityId{ get; set; }
        [JsonProperty(PropertyName = "activityName")]
        public string ActivityName{ get; set; }
        [JsonProperty(PropertyName = "activityVersion")]
        public string ActivityVersion{ get; set; }
        [JsonProperty(PropertyName = "taskId")]
        public string TaskId{ get; set; }
        [JsonProperty(PropertyName = "input")]
        public JObject Input{ get; set; }
        [JsonProperty(PropertyName = "taskList")]
        public string TaskList{ get; set; }
        [JsonProperty(PropertyName = "taskPriority")]
        public int TaskPriority{ get; set; }
        [JsonProperty(PropertyName = "heartbeatTimeout")]
        public int? HeartbeatTimeout{ get; set; }
        [JsonProperty(PropertyName = "scheduleToCloseTimeout")]
        public int? ScheduleToCloseTimeout{ get; set; }
        [JsonProperty(PropertyName = "scheduleToStartTimeout")]
        public int? ScheduleToStartTimeout{ get; set; }
        [JsonProperty(PropertyName = "startToCloseTimeout")]
        public int? StartToCloseTimeout{ get; set; }
    }
}
