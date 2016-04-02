using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A6___Flight_Reservation
{
    /// <summary>
    /// Form for adding a passenger to the database
    /// </summary>
    public partial class Add_Passenger : Form
    {
        #region Constructor
        /// <summary>
        /// Default Constructor
        /// </summary>
        public Add_Passenger()
        {
            InitializeComponent();
            // Blank out fields
            tbFirstName.Text = "";
            tbLastName.Text = "";
        }
        #endregion

        #region Methods
        /// <summary>
        /// Saves passenger to database
        /// </summary>
        /// <param name="sender">Button Clicked</param>
        /// <param name="e">Button Args</param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Sets the dialog result to successful
            this.DialogResult = DialogResult.Yes;
            // Closes window
            this.Close();
        }

        /// <summary>
        /// Cancels the current action
        /// </summary>
        /// <param name="sender">Button Clicked</param>
        /// <param name="e">Button Args</param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Sets the dialog result to canceled
            this.DialogResult = DialogResult.Cancel;
            // Closes window
            this.Close();
        }
        #endregion
    }
}
