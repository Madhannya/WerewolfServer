/*
 * Werewolf Engine
 *
 * This is a werewolf game engine for REST access. It is primarily developed for CPE200 class at Computer Engineering, Chiang Mai University.
 *
 * OpenAPI spec version: 0.1.0
 * Contact: pruetboonma@gmail.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace DNWS.Werewolf 
{ 
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    [DataContract]
    public partial class Game
    { 
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="gameid")]
        public long GameId { get; set; }

        /// <summary>
        /// Gets or Sets Hash
        /// </summary>
        [DataMember(Name="hash")]
        public string Hash { get; set; }

        /// <summary>
        /// Gets or Sets Day
        /// </summary>
        [DataMember(Name="day")]
        public int? Day { get; set; }

        /// <summary>
        /// Game status in the system
        /// </summary>
        /// <value>Game status in the system</value>
        public enum StatusEnum
        { 
            /// <summary>
            /// Enum PlayingEnum for playing
            /// </summary>
            [EnumMember(Value = "playing")]
            PlayingEnum = 1,
            
            /// <summary>
            /// Enum WaitingEnum for waiting
            /// </summary>
            [EnumMember(Value = "waiting")]
            WaitingEnum = 2,
            
            /// <summary>
            /// Enum EndedEnum for ended
            /// </summary>
            [EnumMember(Value = "ended")]
            EndedEnum = 3
        }

        /// <summary>
        /// Game status in the system
        /// </summary>
        /// <value>Game status in the system</value>
        [DataMember(Name="status")]
        public StatusEnum? Status { get; set; }

        public enum PeriodEnum
        { 
            /// <summary>
            /// Enum DayEnum for day
            /// </summary>
            [EnumMember(Value = "day")]
            DayEnum = 1,
            
            /// <summary>
            /// Enum NightEnum for night
            /// </summary>
            [EnumMember(Value = "night")]
            NightEnum = 2,

            /// <summary>
            /// Enum ProcessingEnum for processing
            /// </summary>
            [EnumMember(Value = "processing")]
            ProcessingEnum = 3,
        }

        [DataMember(Name="period")]
        public PeriodEnum? Period { get; set; }

        [DataMember(Name="players")]
        public virtual ICollection<Player> Players {get; set;}

        public Game()
        {
            Players = new HashSet<Player>();
        }
    }
}
