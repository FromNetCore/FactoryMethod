namespace StandartMessenger
{
    public class TestMessage
    {
        public string Text { get; }
        public string Source { get; }
        public string Target { get; }

        public TestMessage(string text, string source, string target)
        {
            Text = text;
            Source = source;
            Target = target;
        }
    }
}