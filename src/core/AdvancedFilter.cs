namespace Dime.ExtJs
{
    /// <summary>
    ///
    /// </summary>
    public class AdvancedFilter : Filter
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="AdvancedFilter"/> class
        /// </summary>
        public AdvancedFilter() : base()
        {
        }

        #endregion Constructor

        #region Properties

        /// <summary>
        /// Gets or sets the filter's condition
        /// </summary>
        public string Condition { get; set; }

        /// <summary>
        /// Gets or sets the flag to indicate whether the filter is 'AND' or 'OR'
        /// </summary>
        public override bool And
        {
            get
            {
                return this.Condition != "OR";
            }
        }

        #endregion Properties
    }
}