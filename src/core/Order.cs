namespace Dime.ExtJs
{
    /// <summary>
    ///
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Order<T>
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="Order"/> class
        /// </summary>
        public Order()
        {
        }

        #endregion Constructor

        #region Properties

        /// <summary>
        /// Gets or sets the property on which to sort on
        /// </summary>
        public string Property { get; set; }

        /// <summary>
        /// Gets or sets the flag if the sort operation is ascending
        /// </summary>
        public bool IsAscending { get; set; }

        #endregion Properties
    }
}