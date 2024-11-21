using Newtonsoft.Json;
using System;

public class AuditoriumConverter : JsonConverter<string>
{
    public override string ReadJson(JsonReader reader, Type objectType, string? existingValue, bool hasExistingValue, JsonSerializer serializer)
    {
        // Проверяем, что reader.Value не null
        var value = reader.Value?.ToString();

        if (value == null)
        {
            // Если значение null, возвращаем "N/A" или другое значение по умолчанию
            return "N/A";
        }

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

    public override void WriteJson(JsonWriter writer, string? value, JsonSerializer serializer)
    {
        // Проверяем, что value не null перед записью
        writer.WriteValue(value ?? "N/A");
    }
}

namespace ConsoleApp3
{
    internal class AuditoriumConverter
    {
    }
}
