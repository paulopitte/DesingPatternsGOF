namespace _01_Sample
{
    public class Email
    {
        public string To { get; set; }
        public string From { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }

        public override string ToString()
            =>($"{To} - {From}\n {Subject}\n {Body}\n");
        
    }

}
