using System.Text.Json;

namespace PizzaPlace
{
    public static class DebuggingExtension
    {
        public static string ToJson(this object obj)
            => JsonSerializer.Serialize(obj, obj.GetType());
    }
}
