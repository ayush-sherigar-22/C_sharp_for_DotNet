namespace EventsPractice
{
    public class TextMessageService
    {
        public void OnVideoEncoded(object source, EventArgs e)
        {
            Console.WriteLine("TextMessageService : Sending a Text Message....");
        }
    }
    


}
