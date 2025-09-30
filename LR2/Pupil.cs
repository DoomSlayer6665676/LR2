namespace LR2
{
    public class ClassRoom
    {
        private Pupil[] pupils;
        public ClassRoom(params Pupil[] pupils)
        {
            if (pupils.Length != 4)
                throw new ArgumentException("Класс должен содержать 4 учеников.");
            this.pupils = pupils;
        }
        public void ShowActivity()
        {
            int i = 1;
            foreach (var pupil in pupils)
            {
                Console.WriteLine($"Ученик номер {i++}");
                pupil.Study();
                pupil.Read();
                pupil.Write();
                pupil.Relax();
                Console.WriteLine();
            }
        }
    }
    public class Pupil
    {
        public Pupil() { }
        public virtual void Study() { Console.WriteLine("Ученик учится"); }
        public virtual void Read() { Console.WriteLine("Ученик читает"); }
        public virtual void Write() { Console.WriteLine("Ученик пишет"); }
        public virtual void Relax() { Console.WriteLine("Ученик отдыхает"); }
    }
    public class ExcelentPupil : Pupil
    {
        public ExcelentPupil() { }
        public override void Study() { Console.WriteLine("Отличник постоянно учится"); }
        public override void Read() { Console.WriteLine("Отличник читает всё и всегда"); }
        public override void Write() { Console.WriteLine("Отличник пишет как диктофон"); }
        public override void Relax() { Console.WriteLine("Отличник вообще не отдыхает - он машина"); }
    }
    public class GoodPupil : Pupil
    {
        public GoodPupil() { }
        public override void Study() { Console.WriteLine("Хороший ученик периодически учится"); }
        public override void Read() { Console.WriteLine("Хороший ученик иногда читает"); }
        public override void Write() { Console.WriteLine("Хороший ученик пишет"); }
        public override void Relax() { Console.WriteLine("Хороший ученик иногда отдыхает"); }
    }
    public class BadPupil : Pupil
    {
        public BadPupil() { }
        public override void Study() { Console.WriteLine("Плохой ученик вообще не учится"); }
        public override void Read() { Console.WriteLine("Плохой ученик не читает"); }
        public override void Write() { Console.WriteLine("Плохой ученик \"лучше воспринимает на слух\""); }
        public override void Relax() { Console.WriteLine("Плохой ученик всегда отдыхает"); }
    }
}
