using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WarriorCombatAcademyTrainer.Models
{
    /// <summary>
    /// Class used to store the individual data elements used for the global updates. 
    /// </summary>
    public class GlobalMessages
    {
        // Fields store date, content, and image source data.
        // Overloaded constructor so we have options as to how much data is being provided upon
        // instantiation of a message.  - Jim

        #region FIELDS
        
        private string _messageContent;
        private string _messageImgSrc;
        private DateTime _dateOfMessage;       

        #endregion

        #region PROPERTIES

        public string MessageContent
        {
            get { return _messageContent; }
            set { _messageContent = value; }
        }
        public string MessageImgSrc
        {
            get { return _messageImgSrc; }
            set { _messageImgSrc = value; }
        }
        public DateTime DateOfMessage
        {
            get { return _dateOfMessage; }
            set { _dateOfMessage = value; }
        }

        #endregion

        #region CONSTRUCTORS
        
        /// <summary>
        /// Default Constructor
        /// </summary>
        public GlobalMessages()
        {
            _dateOfMessage = DateTime.Now;
        }

        /// <summary>
        /// Constructor with message content as parameter.
        /// </summary>
        /// <param name="messageContent"></param>
        public GlobalMessages(string messageContent)
        {
            _messageContent = messageContent;
            _dateOfMessage = DateTime.Now;
        }

        /// <summary>
        /// Constructor with message content and image source as parameter.
        /// </summary>
        public GlobalMessages(string messageContent, string imgSrc)
        {
            _messageContent = messageContent;
            _messageImgSrc = imgSrc;
            _dateOfMessage = DateTime.Now;
        }
        
        
        #endregion

        #region METHODS

        #endregion


    }
}