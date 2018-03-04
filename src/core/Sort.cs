using Newtonsoft.Json;

namespace Dime.ExtJs
{
    /// <summary>
    /// Represents an Ext sort
    /// </summary>
    public class Sort : Action
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="Sort"/> class
        /// </summary>
        public Sort() : base()
        {
        }

        #endregion Constructor

        #region Methods

        /// <summary>
        /// Casts a string to the sorter
        /// </summary>
        /// <param name="orderString">The order string as passed in by the Ext framework</param>
        public static explicit operator Sort(string orderString)
        {
            Sort order = string.IsNullOrEmpty(orderString) ? null : JsonConvert.DeserializeObject<Sort>(orderString);
            return order;
        }

        #endregion Methods
    }
}