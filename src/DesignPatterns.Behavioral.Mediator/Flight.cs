namespace DesignPatterns.Behavioral.Mediator
{
    public interface Flight
    {
        void RequestLandingClearance();
        void RequestTakeOffClearance();
        bool IsLandingClearance();
        bool IsTakeOffClearance();
        // parameter bool value
	void SetTakeOffClearance(bool value);
	// parameter bool value
        void SetLandingClearance(bool value);
        // parameter bool value
        void SetCompleteLandingClearance(bool value);
        // parameter bool value
	void SetCompleteTakeOffClearance(bool value);

    }
}
