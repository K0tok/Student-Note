using Newtonsoft.Json;
using System;

public class AuditoriumConverter : JsonConverter<string>
{
    public override string ReadJson(JsonReader reader, Type objectType, string existingValue, bool hasExistingValue, JsonSerializer serializer)
    {
        var value = reader.Value?.ToString();

        // Проверяем, является ли значение числом
        if (int.TryParse(value, out _))
        {
            return value;
        }

        // Если значение не является числом, проверяем на допустимость текста
        if (!string.IsNullOrWhiteSpace(value))
        {
            return value; // Допустимые текстовые обозначения
        }

        // Если данные некорректны, возвращаем "N/A" или другое значение по умолчанию
        return "N/A";
    }

    public override void WriteJson(JsonWriter writer, string value, JsonSerializer serializer)
    {
        writer.WriteValue(value);
    }
}

namespace ConsoleApp3
{
    internal class AuditoriumConverter
    {
    }
}
