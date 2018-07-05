using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// IntradayScheduleData
    /// </summary>
    [DataContract]
    public partial class IntradayScheduleData :  IEquatable<IntradayScheduleData>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="IntradayScheduleData" /> class.
        /// </summary>
        /// <param name="OnQueueTimeSeconds">The total scheduled on-queue time in seconds for all agents in this group.</param>
        /// <param name="ScheduledTimeSeconds">The total scheduled time in seconds for all agents in this group.</param>
        public IntradayScheduleData(int? OnQueueTimeSeconds = null, int? ScheduledTimeSeconds = null)
        {
            this.OnQueueTimeSeconds = OnQueueTimeSeconds;
            this.ScheduledTimeSeconds = ScheduledTimeSeconds;
            
        }
        
        
        
        /// <summary>
        /// The total scheduled on-queue time in seconds for all agents in this group
        /// </summary>
        /// <value>The total scheduled on-queue time in seconds for all agents in this group</value>
        [DataMember(Name="onQueueTimeSeconds", EmitDefaultValue=false)]
        public int? OnQueueTimeSeconds { get; set; }
        
        
        
        /// <summary>
        /// The total scheduled time in seconds for all agents in this group
        /// </summary>
        /// <value>The total scheduled time in seconds for all agents in this group</value>
        [DataMember(Name="scheduledTimeSeconds", EmitDefaultValue=false)]
        public int? ScheduledTimeSeconds { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IntradayScheduleData {\n");
            
            sb.Append("  OnQueueTimeSeconds: ").Append(OnQueueTimeSeconds).Append("\n");
            sb.Append("  ScheduledTimeSeconds: ").Append(ScheduledTimeSeconds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as IntradayScheduleData);
        }

        /// <summary>
        /// Returns true if IntradayScheduleData instances are equal
        /// </summary>
        /// <param name="other">Instance of IntradayScheduleData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IntradayScheduleData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.OnQueueTimeSeconds == other.OnQueueTimeSeconds ||
                    this.OnQueueTimeSeconds != null &&
                    this.OnQueueTimeSeconds.Equals(other.OnQueueTimeSeconds)
                ) &&
                (
                    this.ScheduledTimeSeconds == other.ScheduledTimeSeconds ||
                    this.ScheduledTimeSeconds != null &&
                    this.ScheduledTimeSeconds.Equals(other.ScheduledTimeSeconds)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                
                if (this.OnQueueTimeSeconds != null)
                    hash = hash * 59 + this.OnQueueTimeSeconds.GetHashCode();
                
                if (this.ScheduledTimeSeconds != null)
                    hash = hash * 59 + this.ScheduledTimeSeconds.GetHashCode();
                
                return hash;
            }
        }
    }

}
