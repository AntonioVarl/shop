using System.Text.Json;

namespace shop_2._0.JsonConverters.Policies;

public class SnakeNamePolicy : JsonNamingPolicy
{
    public override string ConvertName(string name)
    {
        var letterCountInNewName = name.Count(char.IsUpper);

        if (letterCountInNewName > 0)
        {
            letterCountInNewName += name.Length - 1;
        }

        var newName = new List<char>(letterCountInNewName) { char.ToLower(name[0]) };

        for (int i = 1; i < name.Length; i++)
        {
            var currentChar = name[i];

            if (char.IsUpper(currentChar))
            {
                newName.Add('_');
                newName.Add(char.ToLower(currentChar));
            }
            else
            {
                newName.Add(currentChar);
            }
        }

        return string.Join("", newName);
    }
}