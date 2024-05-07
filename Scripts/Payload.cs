using System;

public static partial class Ollama
{
    private static class Request
    {
        public class Generate
        {
            public string model;
            public string prompt;
            public bool stream;

            public Generate(string model, string prompt, bool stream)
            {
                this.model = model;
                this.prompt = prompt;
                this.stream = stream;
            }
        }
    }

    private static class Response
    {
        public class Generate : BaseResponse
        {
            public string response;
        }

        public abstract class BaseResponse
        {
            public string model;
            public DateTime created_at;
            public bool done;
            public int[] context;
            public long total_duration;
            public long load_duration;
            public int prompt_eval_count;
            public long prompt_eval_duration;
            public int eval_count;
            public long eval_duration;
        }
    }
}
