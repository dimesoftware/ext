
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
    }
}