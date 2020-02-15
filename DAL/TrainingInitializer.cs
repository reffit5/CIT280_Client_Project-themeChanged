using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WarriorCombatAcademyTrainer.Models;

namespace WarriorCombatAcademyTrainer.DAL
{
    public class TrainingInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<TrainingContext>
    {
        protected override void Seed(TrainingContext context)
        {
            var students = new List<Student>
            {
                new Student{ FirstName="PJ",LastName="Ruddy", Email="yeah@yeah.com", SparingCount= 10, FighterRank= RanksEnum.expert,RankID=4},
                new Student{ FirstName="Jim",LastName="Lyons", Email="No@yeah.com", SparingCount= 20, FighterRank= RanksEnum.veteran,RankID=3},
                new Student{ FirstName="Andy",LastName="Lopez", Email="yeah@No.com", SparingCount= 5, FighterRank= RanksEnum.initiate,RankID=1},
                new Student{ FirstName="Kameron",LastName="Reffit", Email="no@no.com", SparingCount= 8, FighterRank= RanksEnum.intermediate,RankID=2}
            };

            students.ForEach(x => context.Students.Add(x));
            context.SaveChanges();

            var ranks = new List<Rank>
            {
                new Rank{ ID=1, RankType= RanksEnum.initiate},
                new Rank{ ID=2, RankType= RanksEnum.intermediate},
                new Rank{ ID=3, RankType= RanksEnum.veteran},
                new Rank{ ID=4, RankType= RanksEnum.expert}
            };

            ranks.ForEach(x => context.Ranks.Add(x));
            context.SaveChanges();

            var videos = new List<Video>
            {
                new Video{ IsVideoComplete=false, RankID=4, VideoRank= RanksEnum.expert, VideoTitle= "creative title", VideoSrc="https://www.youtube.com/watch?v=hY35pBOfSNk"},
                new Video{ IsVideoComplete=false, RankID=3, VideoRank= RanksEnum.veteran, VideoTitle= "creative title", VideoSrc="https://www.youtube.com/watch?v=775gXyYzB08"},
                new Video{ IsVideoComplete=false, RankID=2, VideoRank= RanksEnum.intermediate, VideoTitle= "creative title", VideoSrc="https://www.youtube.com/watch?v=S_vtppaNxoc"},
                new Video{ IsVideoComplete=false, RankID=1, VideoRank= RanksEnum.initiate, VideoTitle= "creative title", VideoSrc="https://www.youtube.com/watch?v=pw_9ZZLkkNI"}
            };

            videos.ForEach(x => context.Videos.Add(x));
            context.SaveChanges();

            var submissionLogs = new List<SubmissionLog>
            {
                new SubmissionLog { StudentID=1, OpponentName= "Billy Bob", Position= MoveEnum.RearNackedChoke, WinLoss=WinEnum.Win, DateOfEvent=DateTime.Today},
                new SubmissionLog { StudentID=2, OpponentName= "John Jones", Position= MoveEnum.Armbar, WinLoss=WinEnum.Loss, DateOfEvent=DateTime.Today},
                new SubmissionLog { StudentID=3, OpponentName= "Anderson Silva", Position= MoveEnum.Guillatine, WinLoss=WinEnum.Win, DateOfEvent=DateTime.Today},
                new SubmissionLog { StudentID=4, OpponentName= "Vandelat Silva", Position= MoveEnum.RearNackedChoke, WinLoss=WinEnum.Loss, DateOfEvent=DateTime.Today}
            };

            submissionLogs.ForEach(x => context.SubmissionLogs.Add(x));
            context.SaveChanges();
        }
    }
}