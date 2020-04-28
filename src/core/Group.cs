using Newtonsoft.Json;

namespace Dime.ExtJs
{
    /// <summary>
    /// Represents an Ext group
    /// </summary>
    public class Group : Action
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Group"/> class
        /// </summary>
        public Group() : base()
        {
        }

        /// <summary>
        /// Gets or sets the flag whether this is a complex grouper
        /// </summary>
        public bool ComplexType { get; set; }

        /// <summary>
        /// Casts a string to the group
        /// </summary>
        /// <param name="groupedString">The group string as passed in by the Ext framework</param>
        public static explicit operator Group(string groupedString) 
            => string.IsNullOrEmpty(groupedString) ? null : JsonConvert.DeserializeObject<Group>(groupedString);
    }
}