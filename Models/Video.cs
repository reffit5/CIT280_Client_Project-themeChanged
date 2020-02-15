using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WarriorCombatAcademyTrainer.Models
{
    /// <summary>
    /// Class used to store video information.
    /// </summary>
    public class Video
    {
        #region FIELDS

        private string _videoTitle;
        private string _videoSrc;
        private bool _isVideoComplete;
        private RanksEnum _videoRank;
        private int _id;
        private int _rankID;

        public int RankID
        {
            get { return _rankID; }
            set { _rankID = value; }
        }


        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }




        #endregion

        #region PROPERTIES
        public string VideoTitle
        {
            get { return _videoTitle; }
            set { _videoTitle = value; }
        }
        public string VideoSrc
        {
            get { return _videoSrc; }
            set { _videoSrc = value; }
        }
        public bool IsVideoComplete
        {
            get { return _isVideoComplete; }
            set { _isVideoComplete = value; }
        }
        public RanksEnum VideoRank
        {
            get { return _videoRank; }
            set { _videoRank = value; }
        }

        #endregion

        #region CONSTRUCTORS

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Video()
        {

        }
        #endregion

        #region METHODS

        //todo: Build out a method to sort videos based on a ranking parameter. We will need
        // this to allow the view to present only those vidoes that match the buttons
        // used to access the training videos.                     

        //todo: Build a method that can assign a value to the date completed variable after the video has been watched.

        //todo: (basic) Build out a method that will toggle the is completed boolean variable when the user checks off a video.

        //todo: (advanced) Build a method that can monitor the progress of the video and automatically check it off when complete. 
        #endregion
    }
}