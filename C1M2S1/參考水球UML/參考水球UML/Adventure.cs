namespace 參考水球UML
{
    public class Adventure
    {
        private int numbers;
        private Student student;
        private Journey journey;
        private TourGroup tourGroup;

        public Adventure(int numbers, Student student, Journey journey)
        {
            this.Numbers = numbers;
            this.Student = student;
            this.Journey = journey;
        }

        public int Numbers { get => numbers; set => numbers = value; }
        public Student Student { get => student; set => student = value; }
        public Journey Journey { get => journey; set => journey = value; }
        internal TourGroup TourGroup { get => tourGroup; set => tourGroup = value; }
    }
}