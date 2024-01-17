using System.Text.Json;
using System.Text.Json.Serialization;
using shop_2._0.Models;

namespace shop_2._0.JsonConverters.Converters;

public class ProductTypeJsonConverter : JsonConverter<ProductType>
{
    public override ProductType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }

    public override void Write(Utf8JsonWriter writer, ProductType value, JsonSerializerOptions options)
    {
        switch (value)
        {
            case ProductType.Undefined:
                writer.WriteStringValue("Неизвестный");
                break;
            case ProductType.Adventure:
                writer.WriteStringValue("Фентези");
                break;
            case ProductType.Fantasy:
                writer.WriteStringValue("Приключения");
                break;
            case ProductType.Detective:
                writer.WriteStringValue("Детектив");
                break;
            case ProductType.Historical:
                writer.WriteStringValue("Исторические");
                break;
        }
    }
}