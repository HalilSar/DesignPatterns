namespace DesignPatterns.Behavioral.Mediator
{
    public interface Flight
    {
        void RequestLandingClearance();
        void RequestTakeOffClearance();
        bool IsLandingClearance();
        bool IsTakeOffClearance();
        void SetTakeOffClearance(bool value);
        void SetLandingClearance(bool value);

        void SetCompleteLandingClearance(bool value);
        void SetCompleteTakeOfClearance(bool value);

    }
}