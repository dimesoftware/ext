namespace Dime.ExtJs
{
    /// <summary>
    /// Represents the base class for any Ext action
    /// </summary>
    public abstract class Action
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="Action"/> class
        /// </summary>
        public Action()
        {
        }

        #endregion Constructor

        #region Properties

        /// <summary>
        /// Gets or sets the property on which the action to invoke
        /// </summary>
        public string Property { get; set; }

        /// <summary>
        /// Gets or sets the direction of the action.
        /// <para>Possible values include 'ASC' and 'DESC'</para>
        /// </summary>
        public string Direction { get; set; }

        /// <summary>
        /// Gets or sets the flag to indicate whether the action will be performed on a complex property
        /// </summary>
        public bool IsComplexType { get; set; }

        /// <summary>
        /// Gets or sets the property name of the complex type
        /// </summary>
        public string ComplexTypeProperty { get; set; }

        /// <summary>
        /// Gets or sets the name of the complex type
        /// </summary>
        public string ComplexTypeName { get; set; }

        #endregion Properties
    }
}