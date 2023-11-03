namespace SampleBlazorApp.Data;

public class MydataService
{
    private List<MyData> datos = new()
    {
        new MyData("Taro","hoge", "taro@yamada"),
        new MyData("Hanako", "foo", "hanako@flower"),
        new MyData("Schiko", "bar", "sachiko@happy")
    };

    public Task<MyData> GetMydataAsync(int n)
    {
        int num = n < 0 ? 0 : n > datos.Count ? datos.Count - 1 : n;
        return Task.FromResult(datos[num]);
    }
}

