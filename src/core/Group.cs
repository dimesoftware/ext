using Newtonsoft.Json;

namespace Dime.ExtJs
{
    /// <summary>
    /// Represents an Ext group
    /// </summary>
    public class Group : Action
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="Group"/> class
        /// </summary>
        public Group() : base()
        {
        }

        #endregion Constructor

        #region Properties

        /// <summary>
        /// Gets or sets the flag whether this is a comple grouper
        /// </summary>
        public bool ComplexType { get; set; }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Casts a string to the group
        /// </summary>
        /// <param name="groupedString">The group string as passed in by the Ext framework</param>
        public static explicit operator Group(string groupedString) 
            => string.IsNullOrEmpty(groupedString) ? null : JsonConvert.DeserializeObject<Group>(groupedString);

        #endregion Methods
    }
}