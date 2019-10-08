using SQL;

namespace DataInterface
{
    public interface IBetygsgradManager
    {
        public void AddBetygsgrad(Courses course, int poäng, string betyg);
    }
}
