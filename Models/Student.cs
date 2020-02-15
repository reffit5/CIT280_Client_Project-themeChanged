using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WarriorCombatAcademyTrainer.Models
{
    /// <summary>
    /// Primary data class used to store student information.
    /// </summary>
    public class Student
    {

        #region FIELDS

        private string _firstName;
        private string _lastName;
        private string _email;
        private RanksEnum _fighterRank;
        private int _sparingCount;
        private ICollection<SubmissionLog> _submissionLogs;
        private int _id;
        private int _rankID;

        #endregion

        #region PROPERTIES
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public RanksEnum FighterRank
        {
            get { return _fighterRank; }
            set { _fighterRank = value; }
        }
        public int SparingCount
        {
            get { return _sparingCount; }
            set { _sparingCount = value; }
        }
        public ICollection<SubmissionLog> SubmissionLogs
        {
            get { return _submissionLogs; }
            set { _submissionLogs = value; }
        }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public int RankID
        {
            get { return _rankID; }
            set { _rankID = value; }
        }


        #endregion

        #region CONSTRUCTORS

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Student()
        {

        }
        #endregion

        #region METHODS

        //todo: Build out a method to sort videos based on the user's rank. 


        #endregion



    }
}