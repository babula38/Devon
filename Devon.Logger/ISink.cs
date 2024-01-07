namespace Devon.Logger;

public interface ISink
{
    void Process(SinkContext context);
}

