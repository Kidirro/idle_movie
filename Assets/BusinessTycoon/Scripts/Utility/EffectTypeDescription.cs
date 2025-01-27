public class EffectTypeDescription
{
    public static string GetDescription(string effectType, double effect, string businessName, string pluralName)
    {
        var description = "";

        switch (effectType)
        {
            case "Run":
                description = "Нанять сценариста для работы над фильмом " + pluralName;
                break;
            case "Buy":
                description = "+" + effect + " " + pluralName;
                break;
            case "Cost":
                if (pluralName == "Все")
                {
                    description = pluralName + " на " + ((float)effect * 100) + "% дешевле";
                }
                else
                {
                    description = pluralName + " на " + ((float)effect * 100) + "% дешевле";
                }
                break;
            case "Profit":
            case "Multiplier":
                description = "Действует на " + pluralName + " x" + (double)effect;
                break;
            case "Speed":
                description = "Ускорение на " + pluralName + " x" + (1 / (float)effect);
                break;
            case "Золото":
                description = effect + " Золота";
                break;
            case "Пропуск времени":
                description = effect + " Часа пропуска времени";
                break;
            case "Luck":
                description = "Испытай удачу";
                break;
            case "iEffect":
                description = "Продюссер эффективней на +" + effect * 100 + "%";
                break;
        }

        return description;
    }
}