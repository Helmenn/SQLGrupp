using SQL;

namespace DataInterface
{
    public interface IBetygsgradManager
    {
        public void AddBetygsgrad(int courseid, int poäng, string betyg);
    }
}
