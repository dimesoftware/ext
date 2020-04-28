using Newtonsoft.Json;

namespace Dime.ExtJs
{
    /// <summary>
    /// Represents an Ext sort
    /// </summary>
    public class Sort : Action
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Sort"/> class
        /// </summary>
        public Sort() : base()
        {
        }

        /// <summary>
        /// Casts a string to the sorter
        /// </summary>
        /// <param name="orderString">The order string as passed in by the Ext framework</param>
        public static explicit operator Sort(string orderString) 
            => string.IsNullOrEmpty(orderString) ? null : JsonConvert.DeserializeObject<Sort>(orderString);
    }
}