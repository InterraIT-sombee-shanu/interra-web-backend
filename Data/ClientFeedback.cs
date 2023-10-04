namespace InterraWebBackend.Data
{
    public class ClientFeedback
    {
        public int Id { get; set; }

        public string ClientName { get; set; }

        public string ClientProfile { get; set; }
        public string Feedback { get; set; }

        public int Rating { get; set; }
    }
}
