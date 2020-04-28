namespace Dime.ExtJs
{
    /// <summary>
    /// Represents an advanced filter that allows to define the relationship with other instances
    /// </summary>
    public class AdvancedFilter : Filter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdvancedFilter"/> class
        /// </summary>
        public AdvancedFilter() : base()
        {
        }

        /// <summary>
        /// Gets or sets the group key to which this filter belongs
        /// </summary>
        public string Group { get; set; }

        /// <summary>
        /// Gets or sets the filter's condition
        /// </summary>
        public string Condition { get; set; }

        /// <summary>
        /// Gets or sets the flag to indicate whether the filter is 'AND' or 'OR'
        /// </summary>
        public override bool And => Condition != "OR";
    }
}