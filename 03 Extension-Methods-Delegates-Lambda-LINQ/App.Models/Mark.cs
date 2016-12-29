namespace App.Models
{
    public struct Mark
    {
        public MarkType Score { get; private set; }
        public string Discipline { get; private set; }

        public Mark(string discipline, MarkType mark)
        {
            this.Discipline = discipline;
            this.Score = mark;
        }
        public Mark(string discipline, int mark)
        {
            this.Discipline = discipline;
            this.Score = (MarkType)mark;
        }
    }
}