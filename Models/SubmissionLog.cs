using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WarriorCombatAcademyTrainer.Models
{
    /// <summary>
    /// Class used to store sparing data.
    /// </summary>
    /// 
    public enum WinEnum
    {
        none,
        Win,
        Loss
    }
    public enum MoveEnum
    {
        None,
        Armbar,
        RearNackedChoke,
        Guillatine,
        LegLock,
    }
    public class SubmissionLog
    {
        // Fields are storing data on sparing matches: Name of fighter, 
        // Submission (position of individual recording this result),
        // Position (the opponent's position), Date of match, and
        // win or loss (as a char, so storing W or L).  The win or loss might be better
        // handled with an Enum, but this should work for now. -Jim


        #region FIELDS


        private string _opponentName;
        private MoveEnum _position;
        private WinEnum _winLoss;
        private DateTime _dateOfEvent;
        private int _studentID;
        public int ID { get; set; }




        #endregion

        #region PROPERTIES

        public string OpponentName
        {
            get { return _opponentName; }
            set { _opponentName = value; }
        }

        public MoveEnum Position
        {
            get { return _position; }
            set { _position = value; }
        }
        public WinEnum WinLoss
        {
            get { return _winLoss; }
            set { _winLoss = value; }
        }
        public DateTime DateOfEvent
        {
            get { return _dateOfEvent; }
            set { _dateOfEvent = value; }
        }

        public int StudentID
        {
            get { return _studentID; }
            set { _studentID = value; }
        }

        #endregion

        #region CONSTRUCTORS

        /// <summary>
        /// Default Constructor
        /// </summary>
        public SubmissionLog()
        {

        }

        #endregion

        #region METHODS

        #endregion





    }
}