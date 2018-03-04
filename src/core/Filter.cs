using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Dime.ExtJs
{
    /// <summary>
    /// Represents an Ext filter
    /// </summary>
    [DebuggerDisplay("{Property} - {Value}")]
    public class Filter : IFilter
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="Filter"/> class
        /// </summary>
        public Filter()
        {
            this.And = true;
        }

        #endregion Constructor

        #region Properties

        /// <summary>
        /// Gets or sets the property name
        /// </summary>
        public virtual string Property { get; set; }

        /// <summary>
        /// Gets or sets the filter value
        /// </summary>
        public virtual string Value { get; set; }

        /// <summary>
        /// Gets or sets the filter's operator
        /// </summary>
        public virtual string Operator { get; set; }

        /// <summary>
        /// Gets or sets the flag to indicate whether the filter is 'AND' or 'OR'
        /// </summary>
        public virtual bool And { get; set; }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Checks whether the filter needs to be done on an associated model
        /// </summary>
        /// <returns>True if the filter contains a complex model</returns>
        public bool IsComplex
        {
            get
            {
                return (this.Property ?? "").Split('.').Count() > 1;
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        /// <history>
        /// [HB] 03/11/2016 - Refactor into filter class
        /// </history>
        public IDictionary<int, string> GetFields()
        {
            int c = 1;
            Dictionary<int, string> properties = new Dictionary<int, string>();
            this.Property.Split('.').ToList().ForEach(x =>
            {
                properties.Add(c, x);
                c++;
            });

            return properties;
        }

        #endregion Methods
    }
}