namespace RatingAPITest.Repositories
{
    public class RatingRepository
    {
        public  List<Rate> Ratings = new List<Rate>();

        public void AddRating(Rate r)
        {
            Ratings.Add(r);
        }
    }
}
