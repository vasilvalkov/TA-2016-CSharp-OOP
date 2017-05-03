using Academy.Core.Contracts;
using Academy.Core.Providers;
using Academy.Models;
using Academy.Models.Contracts;
using Academy.Models.Enums;
using Academy.Models.Utils;
using Academy.Models.Utils.Contracts;
using System;
using System.Globalization;

namespace Academy.Core.Factories
{
    public class AcademyFactory : IAcademyFactory
    {
        private static IAcademyFactory instanceHolder = new AcademyFactory();

        // private because of Singleton design pattern
        private AcademyFactory()
        {
        }

        public static IAcademyFactory Instance
        {
            get
            {
                return instanceHolder;
            }
        }

        public ISeason CreateSeason(string startingYear, string endingYear, string initiative)
        {
            var parsedStartingYear = int.Parse(startingYear);
            var parsedEngingYear = int.Parse(endingYear);

            Initiative parsedInitiativeAsEnum;
            Enum.TryParse<Initiative>(initiative, out parsedInitiativeAsEnum);

            return new Season(parsedStartingYear, parsedEngingYear, parsedInitiativeAsEnum);
        }

        public IStudent CreateStudent(string username, string track)
        {
            Track parsedTrackAsEnum;
            bool parsed = Enum.TryParse<Track>(track, out parsedTrackAsEnum);

            if(!parsed)
            {
                throw new ArgumentException("The provided track is not valid!");
            }

            return new Student(username, parsedTrackAsEnum);
        }

        public ITrainer CreateTrainer(string username, string technologies)
        {
            return new Trainer(username, technologies);
        }

        public ICourse CreateCourse(string name, string lecturesPerWeek, string startingDate)
        {
            var parsedLecturesPerWeek = int.Parse(lecturesPerWeek);
            var parsedStartingDate = DateTime.Parse(startingDate);
            return new Course(name, parsedLecturesPerWeek,parsedStartingDate);
        }

        public ILecture CreateLecture(string name, string date, ITrainer trainer)
        {
            var parsedStartingDate = DateTime.Parse(date);
            return new Lecture(name, parsedStartingDate, trainer);
        }

        public ILectureResouce CreateLectureResouce(string type, string name, string url)
        {
            // Use this instead of DateTime.Now if you want any points in BGCoder!!
            var currentDate = DateTimeProvider.Now;

            ILectureResouce resource;

            switch (type)
            {
                case "video": return new VideoResource(name, url, currentDate);
                case "presentation": resource =  new PresentationResource(name, url); break;
                case "demo": resource =  new DemoResource(name, url); break;
                case "homework": resource =  new HomeworkResource(name, url, currentDate); break;
                default: throw new ArgumentException("Invalid lecture resource type");
            }
            // TODO: Implement this
            return resource;
        }

        public ICourseResult CreateCourseResult(ICourse course, string examPoints, string coursePoints)
        {
            var parsedExamResults = float.Parse(examPoints);
            var parsedCoursePoints = float.Parse(coursePoints);

            return new CourseResult(course, parsedExamResults, parsedCoursePoints);
        }        
    }
}
