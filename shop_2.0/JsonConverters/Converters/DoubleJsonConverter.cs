using System.Text.Json;
using System.Text.Json.Serialization;

namespace shop_2._0.JsonConverters.Converters;

public class DoubleJsonConverter : JsonConverter<double>
{
    public override double Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var value = reader.GetString();

        if (value == "-ထ")
        {
            return double.NegativeInfinity;
        }

        if (value == "+ထ")
        {
            return double.PositiveInfinity;
        }

        if (value == "\ufffd")
        {
            return double.NaN;
        }

        return Convert.ToDouble(value.Replace(".", ","));
    }

    public override void Write(Utf8JsonWriter writer, double value, JsonSerializerOptions options)
    {
        if (double.IsNegativeInfinity(value))
        {
            writer.WriteStringValue("-ထ");
        }

        if (double.IsPositiveInfinity(value))
        {
            writer.WriteStringValue("+ထ");
        }

        if (double.IsNaN(value))
        {
            writer.WriteStringValue("\ufffd");
        }

        else
        {
            writer.WriteNumberValue(value);
        }
    }
}