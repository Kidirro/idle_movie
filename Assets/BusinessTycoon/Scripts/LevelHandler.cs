using System;
using System.Collections.Generic;

public class LevelHandler
{
    public static LevelData CreateGameData()
    {
        // When adding new items, make sure to use an ID not used before in each category.
        // Example: Last ID now is 643 for "Milestones", so next id Should be 644 or higher. It does have to come in order, just unique

        return new LevelData
        {
            TotalBalance = 0,
            InvestorEffect = 0.02,
            Balance = 0,
            TimeStamp = DateTime.Now.ToOADate(),
            Businesses = new List<Business>()
                {
                    new Business
                    {
                        Id = 1,
                        Name = "Ужасы",
                        PurchasedCount = 1,
                        BaseCost = 3.738318f,
                        BaseProfit = 1,
                        TimerInSeconds = 0.6,
                        CurrentTime = 0,
                        CostMultiplier = 1.07f
                    },
                    new Business
                    {
                        Id = 2,
                        Name = "Мелодрама",
                        PurchasedCount = 0,
                        BaseCost = 60,
                        BaseProfit = 60,
                        TimerInSeconds = 3,
                        CurrentTime = 0,
                        CostMultiplier = 1.15f
                    },
                    new Business
                    {
                        Id = 3,
                        Name = "Комедия",
                        PurchasedCount = 0,
                        BaseCost = 720,
                        BaseProfit = 540,
                        TimerInSeconds = 6,
                        CurrentTime = 0,
                        CostMultiplier = 1.14f
                    },
                    new Business
                    {
                        Id = 4,
                        Name = "Детектив",
                        PurchasedCount = 0,
                        BaseCost = 8640,
                        BaseProfit = 4320,
                        TimerInSeconds = 12,
                        CurrentTime = 0,
                        CostMultiplier = 1.13f
                    },
                    new Business
                    {
                        Id = 5,
                        Name = "Криминал",
                        PurchasedCount = 0,
                        BaseCost = 103680,
                        BaseProfit = 51840,
                        TimerInSeconds = 24,
                        CurrentTime = 0,
                        CostMultiplier = 1.12f
                    },
                    new Business
                    {
                        Id = 6,
                        Name = "Мистика",
                        PurchasedCount = 0,
                        BaseCost = 1244160,
                        BaseProfit = 622080,
                        TimerInSeconds = 96,
                        CurrentTime = 0,
                        CostMultiplier = 1.11f
                    },
                    new Business
                    {
                        Id = 7,
                        Name = "Исторический",
                        PurchasedCount = 0,
                        BaseCost = 14929920,
                        BaseProfit = 7464960,
                        TimerInSeconds = 384,
                        CurrentTime = 0,
                        CostMultiplier = 1.1f
                    },
                    new Business
                    {
                        Id = 8,
                        Name = "Боевик",
                        PurchasedCount = 0,
                        BaseCost = 179159040,
                        BaseProfit = 89579520,
                        TimerInSeconds = 1536,
                        CurrentTime = 0,
                        CostMultiplier = 1.09f
                    },
                    new Business
                    {
                        Id = 9,
                        Name = "Фантастика",
                        PurchasedCount = 0,
                        BaseCost = 2149908480,
                        BaseProfit = 1074954240,
                        TimerInSeconds = 6144,
                        CurrentTime = 0,
                        CostMultiplier = 1.08f
                    },
                    new Business
                    {
                        Id = 10,
                        Name = "Мультфильм",
                        PurchasedCount = 0,
                        BaseCost = 25798901760,
                        BaseProfit = 29668737024,
                        TimerInSeconds = 36864,
                        CurrentTime = 0,
                        CostMultiplier = 1.07f
                    },
                },
            Managers = new List<Manager>()
                {
                    new Manager
                    {
                        Id = 1,
                        BusinessId = 1,
                        CurrencyId = 0,
                        Name = "Александр Громов",
                        Cost = 1000,
                        EffectType = "Run",
                        Effect = 0,
                        Unlocked = false
                    },
                    new Manager
                    {
                        Id = 2,
                        BusinessId = 2,
                        CurrencyId = 0,
                        Name = "Лариса Стрелецкая",
                        Cost = 10000,
                        EffectType = "Run",
                        Effect = 0,
                        Unlocked = false
                    },
                    new Manager
                    {
                        Id = 3,
                        BusinessId = 3,
                        CurrencyId = 0,
                        Name = "Игорь Белозёров",
                        Cost = 100000,
                        EffectType = "Run",
                        Effect = 0,
                        Unlocked = false
                    },
                    new Manager
                    {
                        Id = 4,
                        BusinessId = 4,
                        CurrencyId = 0,
                        Name = "Мария Коваленко",
                        Cost = 500000,
                        EffectType = "Run",
                        Effect = 0,
                        Unlocked = false
                    },
                    new Manager
                    {
                        Id = 5,
                        BusinessId = 5,
                        CurrencyId = 0,
                        Name = "Дмитрий Савинов",
                        Cost = 1000000,
                        EffectType = "Run",
                        Effect = 0,
                        Unlocked = false
                    },
                    new Manager
                    {
                        Id = 6,
                        BusinessId = 6,
                        CurrencyId = 0,
                        Name = "Анна Черникова",
                        Cost = 10000000,
                        EffectType = "Run",
                        Effect = 0,
                        Unlocked = false
                    },
                    new Manager
                    {
                        Id = 7,
                        BusinessId = 7,
                        CurrencyId = 0,
                        Name = "Павел Шилов",
                        Cost = 100000000,
                        EffectType = "Run",
                        Effect = 0,
                        Unlocked = false
                    },
                    new Manager
                    {
                        Id = 8,
                        BusinessId = 8,
                        CurrencyId = 0,
                        Name = "Екатерина Воронова",
                        Cost = 500000000,
                        EffectType = "Run",
                        Effect = 0,
                        Unlocked = false
                    },
                    new Manager
                    {
                        Id = 9,
                        BusinessId = 9,
                        CurrencyId = 0,
                        Name = "Сергей Тихомиров",
                        Cost = 10000000000,
                        EffectType = "Run",
                        Effect = 0,
                        Unlocked = false
                    },
                    new Manager
                    {
                        Id = 10,
                        BusinessId = 10,
                        CurrencyId = 0,
                        Name = "Ольга Лебедева",
                        Cost = 100000000000,
                        EffectType = "Run",
                        Effect = 0,
                        Unlocked = false
                    },
                    new Manager
                    {
                        Id = 11,
                        BusinessId = 10,
                        CurrencyId = 0,
                        Name = "Виктор Дроздов",
                        Cost = 100E+12,
                        EffectType = "Cost",
                        Effect = 0.100000001490116,
                        Unlocked = false
                    },
                    new Manager
                    {
                        Id = 12,
                        BusinessId = 9,
                        CurrencyId = 0,
                        Name = "Александра Власова",
                        Cost = 100E+15,
                        EffectType = "Cost",
                        Effect = 0.100000001490116,
                        Unlocked = false
                    },
                    new Manager
                    {
                        Id = 13,
                        BusinessId = 8,
                        CurrencyId = 0,
                        Name = "Михаил Платонов",
                        Cost = 100E+18,
                        EffectType = "Cost",
                        Effect = 0.100000001490116,
                        Unlocked = false
                    },
                    new Manager
                    {
                        Id = 14,
                        BusinessId = 7,
                        CurrencyId = 0,
                        Name = "Наталья Костина",
                        Cost = 100E+21,
                        EffectType = "Cost",
                        Effect = 0.100000001490116,
                        Unlocked = false
                    },
                    new Manager
                    {
                        Id = 15,
                        BusinessId = 6,
                        CurrencyId = 0,
                        Name = "Роман Глебов",
                        Cost = 100E+24,
                        EffectType = "Cost",
                        Effect = 0.100000001490116,
                        Unlocked = false
                    },
                    new Manager
                    {
                        Id = 16,
                        BusinessId = 5,
                        CurrencyId = 0,
                        Name = "Евгения Соколовская",
                        Cost = 100E+27,
                        EffectType = "Cost",
                        Effect = 0.100000001490116,
                        Unlocked = false
                    },
                    new Manager
                    {
                        Id = 17,
                        BusinessId = 4,
                        CurrencyId = 0,
                        Name = "Иван Мельников",
                        Cost = 100E+30,
                        EffectType = "Cost",
                        Effect = 0.100000001490116,
                        Unlocked = false
                    },
                    new Manager
                    {
                        Id = 18,
                        BusinessId = 3,
                        CurrencyId = 0,
                        Name = "Кристина Герасимова",
                        Cost = 100E+33,
                        EffectType = "Cost",
                        Effect = 0.100000001490116,
                        Unlocked = false
                    },
                    new Manager
                    {
                        Id = 19,
                        BusinessId = 2,
                        CurrencyId = 0,
                        Name = "Юрий Сафронов",
                        Cost = 100E+36,
                        EffectType = "Cost",
                        Effect = 0.100000001490116,
                        Unlocked = false
                    },
                    new Manager
                    {
                        Id = 20,
                        BusinessId = 1,
                        CurrencyId = 0,
                        Name = "Валентина Артемьева",
                        Cost = 100E+39,
                        EffectType = "Cost",
                        Effect = 0.100000001490116,
                        Unlocked = false
                    },
                    new Manager
                    {
                        Id = 21,
                        BusinessId = 2,
                        CurrencyId = 0,
                        Name = "Константин Рубцов",
                        Cost = 1E+103,
                        EffectType = "Cost",
                        Effect = 0.999989986419678,
                        Unlocked = false
                    },
                    new Manager
                    {
                        Id = 22,
                        BusinessId = 7,
                        CurrencyId = 0,
                        Name = "Вера Кравченко",
                        Cost = 7.5E+106,
                        EffectType = "Cost",
                        Effect = 0.999989986419678,
                        Unlocked = false
                    },
                    new Manager
                    {
                        Id = 23,
                        BusinessId = 8,
                        CurrencyId = 0,
                        Name = "Максим Долгов",
                        Cost = 2.5E+110,
                        EffectType = "Cost",
                        Effect = 0.999989986419678,
                        Unlocked = false
                    },
                    new Manager
                    {
                        Id = 24,
                        BusinessId = 4,
                        CurrencyId = 0,
                        Name = "Татьяна Фролова",
                        Cost = 1E+113,
                        EffectType = "Cost",
                        Effect = 0.999989986419678,
                        Unlocked = false
                    },
                    new Manager
                    {
                        Id = 25,
                        BusinessId = 9,
                        CurrencyId = 0,
                        Name = "Андрей Кузьмин",
                        Cost = 5E+115,
                        EffectType = "Cost",
                        Effect = 0.999989986419678,
                        Unlocked = false
                    },
                    new Manager
                    {
                        Id = 26,
                        BusinessId = 5,
                        CurrencyId = 0,
                        Name = "Людмила Пономарёва",
                        Cost = 3E+117,
                        EffectType = "Cost",
                        Effect = 0.999989986419678,
                        Unlocked = false
                    },
                    new Manager
                    {
                        Id = 27,
                        BusinessId = 6,
                        CurrencyId = 0,
                        Name = "Григорий Остапенко",
                        Cost = 7.5E+119,
                        EffectType = "Cost",
                        Effect = 0.999989986419678,
                        Unlocked = false
                    },
                    new Manager
                    {
                        Id = 28,
                        BusinessId = 3,
                        CurrencyId = 0,
                        Name = "София Беляева",
                        Cost = 3E+120,
                        EffectType = "Cost",
                        Effect = 0.999989986419678,
                        Unlocked = false
                    },
                    new Manager
                    {
                        Id = 29,
                        BusinessId = 10,
                        CurrencyId = 0,
                        Name = "Владимир Рогов",
                        Cost = 3.3E+124,
                        EffectType = "Cost",
                        Effect = 0.999989986419678,
                        Unlocked = false
                    },
                    new Manager
                    {
                        Id = 30,
                        BusinessId = 1,
                        CurrencyId = 0,
                        Name = "Елена Седова",
                        Cost = 9E+126,
                        EffectType = "Cost",
                        Effect = 0.999989986419678,
                        Unlocked = false
                    },
                },
            Upgrades = new List<Upgrade>()
                {
                    new Upgrade
                    {
                        Id = 1,
                        BusinessId = 1,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 250000,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 2,
                        BusinessId = 2,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 500000,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 3,
                        BusinessId = 3,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1000000,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 4,
                        BusinessId = 4,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 5000000,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 5,
                        BusinessId = 5,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 10000000,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 6,
                        BusinessId = 6,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 25000000,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 7,
                        BusinessId = 7,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 500000000,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 8,
                        BusinessId = 8,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 10000000000,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 9,
                        BusinessId = 9,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 50000000000,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 10,
                        BusinessId = 10,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 250000000000,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 11,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1000000000000,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 12,
                        BusinessId = 1,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 20000000000000,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 13,
                        BusinessId = 2,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 50000000000000,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 14,
                        BusinessId = 3,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 100000000000000,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 15,
                        BusinessId = 4,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 500000000000000,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 16,
                        BusinessId = 5,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+15,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 17,
                        BusinessId = 6,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 2E+15,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 18,
                        BusinessId = 7,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 5E+15,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 19,
                        BusinessId = 9,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+16,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 20,
                        BusinessId = 10,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 2E+16,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 21,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 5E+16,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 22,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Эффективность",
                        Cost = 1E+17,
                        EffectType = "iEffect",
                        Effect = 0.01,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 23,
                        BusinessId = 8,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 7E+15,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 24,
                        BusinessId = 1,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 2E+18,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 25,
                        BusinessId = 2,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 5E+18,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 26,
                        BusinessId = 3,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 7E+18,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 27,
                        BusinessId = 4,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+19,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 28,
                        BusinessId = 6,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 3.5E+19,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 29,
                        BusinessId = 7,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 5E+19,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 30,
                        BusinessId = 8,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 7.5E+19,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 31,
                        BusinessId = 9,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+20,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 32,
                        BusinessId = 10,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 2E+20,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 33,
                        BusinessId = 5,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 2E+19,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 34,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 5E+20,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 35,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Эффективность",
                        Cost = 1E+21,
                        EffectType = "iEffect",
                        Effect = 0.01,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 36,
                        BusinessId = 1,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 2.5E+22,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 37,
                        BusinessId = 2,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 5E+22,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 38,
                        BusinessId = 3,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+23,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 39,
                        BusinessId = 4,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 2E+23,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 40,
                        BusinessId = 5,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 3E+23,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 41,
                        BusinessId = 6,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 4E+23,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 42,
                        BusinessId = 7,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 5E+23,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 43,
                        BusinessId = 8,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 6E+23,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 44,
                        BusinessId = 9,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 7E+23,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 45,
                        BusinessId = 10,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 8E+23,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 46,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 9E+23,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 47,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Эффективность",
                        Cost = 1E+25,
                        EffectType = "iEffect",
                        Effect = 0.02,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 48,
                        BusinessId = 1,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+27,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 49,
                        BusinessId = 2,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 5E+27,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 50,
                        BusinessId = 3,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 2.5E+28,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 51,
                        BusinessId = 4,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+29,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 52,
                        BusinessId = 5,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 2.5E+29,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 53,
                        BusinessId = 6,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 5E+29,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 54,
                        BusinessId = 7,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+30,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 55,
                        BusinessId = 8,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 5E+30,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 56,
                        BusinessId = 9,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 2.5E+31,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 57,
                        BusinessId = 10,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 5E+31,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 58,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 7.5E+31,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 59,
                        BusinessId = 0,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 10000,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 60,
                        BusinessId = 0,
                        CurrencyId = 1,
                        Name = "Эффективность",
                        Cost = 100000,
                        EffectType = "iEffect",
                        Effect = 0.02,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 61,
                        BusinessId = 0,
                        CurrencyId = 1,
                        Name = "Эффективность",
                        Cost = 100000000,
                        EffectType = "iEffect",
                        Effect = 0.02,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 62,
                        BusinessId = 0,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 1000000000,
                        EffectType = "Profit",
                        Effect = 5,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 63,
                        BusinessId = 0,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 100000000000,
                        EffectType = "Profit",
                        Effect = 9,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 64,
                        BusinessId = 2,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 25000000,
                        EffectType = "Buy",
                        Effect = 10,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 65,
                        BusinessId = 3,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 25000000,
                        EffectType = "Buy",
                        Effect = 10,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 66,
                        BusinessId = 4,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 25000000,
                        EffectType = "Buy",
                        Effect = 10,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 67,
                        BusinessId = 5,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 25000000,
                        EffectType = "Buy",
                        Effect = 10,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 68,
                        BusinessId = 2,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 250000000,
                        EffectType = "Buy",
                        Effect = 50,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 69,
                        BusinessId = 3,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 250000000,
                        EffectType = "Buy",
                        Effect = 50,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 70,
                        BusinessId = 4,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 250000000,
                        EffectType = "Buy",
                        Effect = 50,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 71,
                        BusinessId = 5,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 250000000,
                        EffectType = "Buy",
                        Effect = 50,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 72,
                        BusinessId = 2,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 25000000000,
                        EffectType = "Buy",
                        Effect = 50,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 73,
                        BusinessId = 3,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 25000000000,
                        EffectType = "Buy",
                        Effect = 50,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 74,
                        BusinessId = 4,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 25000000000,
                        EffectType = "Buy",
                        Effect = 50,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 75,
                        BusinessId = 5,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 25000000000,
                        EffectType = "Buy",
                        Effect = 50,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 76,
                        BusinessId = 0,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 1000000000000,
                        EffectType = "Profit",
                        Effect = 11,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 77,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+42,
                        EffectType = "Profit",
                        Effect = 7,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 78,
                        BusinessId = 2,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 5E+42,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 79,
                        BusinessId = 3,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 2.5E+43,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 80,
                        BusinessId = 4,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 5E+43,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 81,
                        BusinessId = 5,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+44,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 82,
                        BusinessId = 6,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 2.5E+44,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 83,
                        BusinessId = 7,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 5E+44,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 84,
                        BusinessId = 8,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+45,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 85,
                        BusinessId = 9,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 5E+45,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 86,
                        BusinessId = 10,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+46,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 87,
                        BusinessId = 1,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 2.5E+46,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 88,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+47,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 89,
                        BusinessId = 2,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 250000000000000,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 90,
                        BusinessId = 3,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 750000000000000,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 91,
                        BusinessId = 4,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 2E+15,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 92,
                        BusinessId = 5,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 5E+15,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 93,
                        BusinessId = 6,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 1E+16,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 94,
                        BusinessId = 7,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 2.5E+16,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 95,
                        BusinessId = 8,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 7.5E+16,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 96,
                        BusinessId = 9,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 2E+17,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 97,
                        BusinessId = 10,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 4E+17,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 98,
                        BusinessId = 1,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 1E+18,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 99,
                        BusinessId = 2,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 2.5E+47,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 100,
                        BusinessId = 3,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 5E+47,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 101,
                        BusinessId = 4,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 7.5E+47,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 102,
                        BusinessId = 5,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+48,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 103,
                        BusinessId = 6,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 5E+48,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 104,
                        BusinessId = 7,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1.5E+49,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 105,
                        BusinessId = 8,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 5E+49,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 106,
                        BusinessId = 9,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+50,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 107,
                        BusinessId = 10,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 2.5E+50,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 108,
                        BusinessId = 1,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 5E+50,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 109,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+51,
                        EffectType = "Profit",
                        Effect = 7,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 110,
                        BusinessId = 0,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 1E+21,
                        EffectType = "Profit",
                        Effect = 15,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 111,
                        BusinessId = 2,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 1E+22,
                        EffectType = "Buy",
                        Effect = 75,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 112,
                        BusinessId = 3,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 1E+22,
                        EffectType = "Buy",
                        Effect = 75,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 113,
                        BusinessId = 4,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 1E+22,
                        EffectType = "Buy",
                        Effect = 75,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 114,
                        BusinessId = 5,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 1E+22,
                        EffectType = "Buy",
                        Effect = 75,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 115,
                        BusinessId = 6,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 1E+22,
                        EffectType = "Buy",
                        Effect = 75,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 116,
                        BusinessId = 2,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 1E+23,
                        EffectType = "Buy",
                        Effect = 75,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 117,
                        BusinessId = 3,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 1E+23,
                        EffectType = "Buy",
                        Effect = 75,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 118,
                        BusinessId = 4,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 1E+23,
                        EffectType = "Buy",
                        Effect = 75,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 119,
                        BusinessId = 5,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 1E+23,
                        EffectType = "Buy",
                        Effect = 75,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 120,
                        BusinessId = 6,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 1E+23,
                        EffectType = "Buy",
                        Effect = 75,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 121,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+54,
                        EffectType = "Profit",
                        Effect = 5,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 122,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+60,
                        EffectType = "Profit",
                        Effect = 7,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 123,
                        BusinessId = 2,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+61,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 124,
                        BusinessId = 3,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+62,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 125,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+66,
                        EffectType = "Profit",
                        Effect = 9,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 126,
                        BusinessId = 4,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+67,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 127,
                        BusinessId = 5,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+68,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 128,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+72,
                        EffectType = "Profit",
                        Effect = 11,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 129,
                        BusinessId = 6,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+73,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 130,
                        BusinessId = 7,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+74,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 131,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+75,
                        EffectType = "Profit",
                        Effect = 13,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 132,
                        BusinessId = 8,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+76,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 133,
                        BusinessId = 9,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+77,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 134,
                        BusinessId = 2,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 1E+31,
                        EffectType = "Buy",
                        Effect = 100,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 135,
                        BusinessId = 3,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 1E+32,
                        EffectType = "Buy",
                        Effect = 100,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 136,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+78,
                        EffectType = "Profit",
                        Effect = 15,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 137,
                        BusinessId = 10,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+79,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 138,
                        BusinessId = 1,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+80,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 139,
                        BusinessId = 0,
                        CurrencyId = 1,
                        Name = "Эффективность",
                        Cost = 1E+33,
                        EffectType = "iEffect",
                        Effect = 0.1,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 140,
                        BusinessId = 0,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 1E+34,
                        EffectType = "Profit",
                        Effect = 15,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 141,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+84,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 142,
                        BusinessId = 0,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 1E+36,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 143,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 3E+87,
                        EffectType = "Profit",
                        Effect = 3.14159250259399,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 144,
                        BusinessId = 2,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+90,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 145,
                        BusinessId = 3,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 5E+90,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 146,
                        BusinessId = 4,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 2.5E+91,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 147,
                        BusinessId = 5,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 5E+91,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 148,
                        BusinessId = 6,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+92,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 149,
                        BusinessId = 7,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 2.5E+92,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 150,
                        BusinessId = 8,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 5E+92,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 151,
                        BusinessId = 9,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+93,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 152,
                        BusinessId = 10,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 5E+93,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 153,
                        BusinessId = 1,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+94,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 154,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 5E+95,
                        EffectType = "Profit",
                        Effect = 2,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 155,
                        BusinessId = 2,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 2E+96,
                        EffectType = "Profit",
                        Effect = 2,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 156,
                        BusinessId = 3,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1.1E+97,
                        EffectType = "Profit",
                        Effect = 2,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 157,
                        BusinessId = 4,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 6.6E+97,
                        EffectType = "Profit",
                        Effect = 2,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 158,
                        BusinessId = 5,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 2.3E+98,
                        EffectType = "Profit",
                        Effect = 2,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 159,
                        BusinessId = 6,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 4E+98,
                        EffectType = "Profit",
                        Effect = 2,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 160,
                        BusinessId = 7,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 7E+98,
                        EffectType = "Profit",
                        Effect = 2,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 161,
                        BusinessId = 8,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 4E+99,
                        EffectType = "Profit",
                        Effect = 2,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 162,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+100,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 163,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 2E+100,
                        EffectType = "Profit",
                        Effect = 6,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 164,
                        BusinessId = 9,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 2.9E+100,
                        EffectType = "Profit",
                        Effect = 2,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 165,
                        BusinessId = 10,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1.45E+101,
                        EffectType = "Profit",
                        Effect = 2,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 166,
                        BusinessId = 1,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 3E+101,
                        EffectType = "Profit",
                        Effect = 2,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 167,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 5E+101,
                        EffectType = "Profit",
                        Effect = 2,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 168,
                        BusinessId = 0,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 1E+40,
                        EffectType = "Profit",
                        Effect = 5,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 169,
                        BusinessId = 0,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 1E+42,
                        EffectType = "Profit",
                        Effect = 5,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 170,
                        BusinessId = 2,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 2E+42,
                        EffectType = "Buy",
                        Effect = 50,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 171,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+102,
                        EffectType = "Profit",
                        Effect = 5,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 172,
                        BusinessId = 3,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 5E+102,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 173,
                        BusinessId = 3,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1.5E+104,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 174,
                        BusinessId = 3,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 1E+47,
                        EffectType = "Profit",
                        Effect = 4,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 175,
                        BusinessId = 3,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 4E+104,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 176,
                        BusinessId = 4,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 9E+104,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 177,
                        BusinessId = 4,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 6E+105,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 178,
                        BusinessId = 4,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 2E+47,
                        EffectType = "Profit",
                        Effect = 6,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 179,
                        BusinessId = 4,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1.5E+106,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 180,
                        BusinessId = 5,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 6E+106,
                        EffectType = "Profit",
                        Effect = 2,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 181,
                        BusinessId = 5,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1.85E+107,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 182,
                        BusinessId = 5,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 7E+47,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 183,
                        BusinessId = 5,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 5E+107,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 184,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 6E+107,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 185,
                        BusinessId = 6,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 7.5E+107,
                        EffectType = "Profit",
                        Effect = 2,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 186,
                        BusinessId = 6,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 5E+108,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 187,
                        BusinessId = 6,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 2E+48,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 188,
                        BusinessId = 6,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 4.5E+109,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 189,
                        BusinessId = 7,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1.25E+110,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 190,
                        BusinessId = 7,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 3E+110,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 191,
                        BusinessId = 7,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 2.5E+49,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 192,
                        BusinessId = 7,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 9E+110,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 193,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+111,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 194,
                        BusinessId = 8,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 5E+111,
                        EffectType = "Profit",
                        Effect = 2,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 195,
                        BusinessId = 8,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 7E+112,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 196,
                        BusinessId = 8,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 5E+50,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 197,
                        BusinessId = 8,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 2.5E+113,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 198,
                        BusinessId = 9,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 5E+113,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 199,
                        BusinessId = 9,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 9E+113,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 200,
                        BusinessId = 9,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 2E+52,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 201,
                        BusinessId = 9,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 3E+114,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 202,
                        BusinessId = 10,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1.5E+115,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 203,
                        BusinessId = 10,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 7.5E+115,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 204,
                        BusinessId = 10,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 8E+52,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 205,
                        BusinessId = 10,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 4E+116,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 206,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 4.5E+116,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 207,
                        BusinessId = 1,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 5E+116,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 208,
                        BusinessId = 1,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 7.5E+116,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 209,
                        BusinessId = 1,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 1.5E+53,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 210,
                        BusinessId = 1,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+117,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 211,
                        BusinessId = 2,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 2E+117,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 212,
                        BusinessId = 2,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 2E+118,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 213,
                        BusinessId = 2,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 3E+53,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 214,
                        BusinessId = 2,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1.5E+119,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 215,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 3.5E+119,
                        EffectType = "Profit",
                        Effect = 5,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 216,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 5E+119,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 217,
                        BusinessId = 2,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 7E+119,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 218,
                        BusinessId = 3,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 9.5E+119,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 219,
                        BusinessId = 4,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 4E+120,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 220,
                        BusinessId = 5,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 9E+120,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 221,
                        BusinessId = 6,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 2.4E+121,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 222,
                        BusinessId = 7,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1.11E+122,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 223,
                        BusinessId = 8,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 2.22E+122,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 224,
                        BusinessId = 9,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 3.33E+122,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 225,
                        BusinessId = 10,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 4.44E+122,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 226,
                        BusinessId = 1,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 5.55E+122,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 227,
                        BusinessId = 0,
                        CurrencyId = 1,
                        Name = "Эффективность",
                        Cost = 5E+53,
                        EffectType = "iEffect",
                        Effect = 0.1,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 228,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 6.66E+122,
                        EffectType = "Profit",
                        Effect = 6.65999984741211,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 229,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+123,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 230,
                        BusinessId = 2,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 3E+123,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 231,
                        BusinessId = 3,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 6E+123,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 232,
                        BusinessId = 4,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1.2E+124,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 233,
                        BusinessId = 5,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 2.4E+124,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 234,
                        BusinessId = 6,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 4.8E+124,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 235,
                        BusinessId = 7,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 9.6E+124,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 236,
                        BusinessId = 8,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1.92E+125,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 237,
                        BusinessId = 9,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 3.84E+125,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 238,
                        BusinessId = 10,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 7.68E+125,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 239,
                        BusinessId = 1,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+126,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 240,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+127,
                        EffectType = "Profit",
                        Effect = 5,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 241,
                        BusinessId = 2,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 1E+54,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 242,
                        BusinessId = 3,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 4E+54,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 243,
                        BusinessId = 4,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 9E+54,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 244,
                        BusinessId = 5,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 2.5E+55,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 245,
                        BusinessId = 6,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 7.5E+55,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 246,
                        BusinessId = 7,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 1.77E+56,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 247,
                        BusinessId = 8,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 3E+56,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 248,
                        BusinessId = 9,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 5E+56,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 249,
                        BusinessId = 10,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 8E+56,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 250,
                        BusinessId = 1,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 1E+57,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 251,
                        BusinessId = 2,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 3E+61,
                        EffectType = "Buy",
                        Effect = 30,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 252,
                        BusinessId = 3,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 3E+61,
                        EffectType = "Buy",
                        Effect = 30,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 253,
                        BusinessId = 4,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 3E+61,
                        EffectType = "Buy",
                        Effect = 30,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 254,
                        BusinessId = 5,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 3E+61,
                        EffectType = "Buy",
                        Effect = 30,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 255,
                        BusinessId = 7,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 3E+61,
                        EffectType = "Buy",
                        Effect = 30,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 256,
                        BusinessId = 0,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 1E+62,
                        EffectType = "Profit",
                        Effect = 5,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 257,
                        BusinessId = 3,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 2E+129,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 258,
                        BusinessId = 9,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 5E+129,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 259,
                        BusinessId = 4,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1.3E+130,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 260,
                        BusinessId = 10,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 2.9E+130,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 261,
                        BusinessId = 1,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 7.1E+130,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 262,
                        BusinessId = 7,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1.77E+131,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 263,
                        BusinessId = 2,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 2.5E+131,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 264,
                        BusinessId = 8,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 3.1E+131,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 265,
                        BusinessId = 5,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 5.55E+131,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 266,
                        BusinessId = 6,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 7.36E+131,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 267,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 9E+131,
                        EffectType = "Profit",
                        Effect = 2,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 268,
                        BusinessId = 2,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 5E+132,
                        EffectType = "Profit",
                        Effect = 2,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 269,
                        BusinessId = 3,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 9.5E+133,
                        EffectType = "Profit",
                        Effect = 2,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 270,
                        BusinessId = 4,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 2.13E+134,
                        EffectType = "Profit",
                        Effect = 2,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 271,
                        BusinessId = 5,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 4E+134,
                        EffectType = "Profit",
                        Effect = 2,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 272,
                        BusinessId = 6,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 9.85E+134,
                        EffectType = "Profit",
                        Effect = 2,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 273,
                        BusinessId = 7,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 8E+135,
                        EffectType = "Profit",
                        Effect = 2,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 274,
                        BusinessId = 8,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 2.9E+136,
                        EffectType = "Profit",
                        Effect = 2,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 275,
                        BusinessId = 9,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 2.22E+137,
                        EffectType = "Profit",
                        Effect = 2,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 276,
                        BusinessId = 10,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 5E+137,
                        EffectType = "Profit",
                        Effect = 2,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 277,
                        BusinessId = 1,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 9E+137,
                        EffectType = "Profit",
                        Effect = 2,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 278,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 5E+138,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 279,
                        BusinessId = 2,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 2E+63,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 280,
                        BusinessId = 3,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 2E+63,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 281,
                        BusinessId = 4,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 2E+63,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 282,
                        BusinessId = 5,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 2E+63,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 283,
                        BusinessId = 6,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 2E+63,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 284,
                        BusinessId = 7,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 2E+63,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 285,
                        BusinessId = 8,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 2E+63,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 286,
                        BusinessId = 9,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 2E+63,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 287,
                        BusinessId = 10,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 2E+63,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 288,
                        BusinessId = 1,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 2E+63,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 289,
                        BusinessId = 2,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1.36E+140,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 290,
                        BusinessId = 3,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 7E+140,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 291,
                        BusinessId = 4,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 9.25E+140,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 292,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 3E+141,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 293,
                        BusinessId = 5,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 2.1E+142,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 294,
                        BusinessId = 6,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 5.5E+142,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 295,
                        BusinessId = 7,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1.11E+143,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 296,
                        BusinessId = 8,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 2.23E+143,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 297,
                        BusinessId = 9,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 3.93E+143,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 298,
                        BusinessId = 10,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 6E+143,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 299,
                        BusinessId = 1,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 7.99E+143,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 300,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 2E+144,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 301,
                        BusinessId = 2,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 3E+144,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 302,
                        BusinessId = 3,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 6E+144,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 303,
                        BusinessId = 4,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 9E+144,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 304,
                        BusinessId = 5,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 2.1E+145,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 305,
                        BusinessId = 6,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 4.4E+145,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 306,
                        BusinessId = 7,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 8.9E+145,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 307,
                        BusinessId = 8,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1.29E+146,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 308,
                        BusinessId = 9,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1.8E+146,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 309,
                        BusinessId = 10,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 2.1E+146,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 310,
                        BusinessId = 1,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 3E+146,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 311,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 4.5E+146,
                        EffectType = "Profit",
                        Effect = 2.71828007698059,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 312,
                        BusinessId = 6,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 5E+147,
                        EffectType = "Profit",
                        Effect = 5,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 313,
                        BusinessId = 2,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 3E+148,
                        EffectType = "Profit",
                        Effect = 5,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 314,
                        BusinessId = 3,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1.8E+149,
                        EffectType = "Profit",
                        Effect = 5,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 315,
                        BusinessId = 9,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 9E+149,
                        EffectType = "Profit",
                        Effect = 5,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 316,
                        BusinessId = 4,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 5E+150,
                        EffectType = "Profit",
                        Effect = 5,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 317,
                        BusinessId = 10,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 2E+151,
                        EffectType = "Profit",
                        Effect = 5,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 318,
                        BusinessId = 5,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 8E+151,
                        EffectType = "Profit",
                        Effect = 5,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 319,
                        BusinessId = 1,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 2.4E+152,
                        EffectType = "Profit",
                        Effect = 5,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 320,
                        BusinessId = 7,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 7.2E+152,
                        EffectType = "Profit",
                        Effect = 5,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 321,
                        BusinessId = 8,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 2.1E+154,
                        EffectType = "Profit",
                        Effect = 5,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 322,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 5E+155,
                        EffectType = "Profit",
                        Effect = 5,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 323,
                        BusinessId = 0,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 1E+65,
                        EffectType = "Profit",
                        Effect = 7,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 324,
                        BusinessId = 2,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 1E+66,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 325,
                        BusinessId = 3,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 4E+66,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 326,
                        BusinessId = 4,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 1.3E+67,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 327,
                        BusinessId = 5,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 2E+67,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 328,
                        BusinessId = 6,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 2.9E+67,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 329,
                        BusinessId = 7,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 3.8E+67,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 330,
                        BusinessId = 8,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 5.2E+67,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 331,
                        BusinessId = 9,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 6.7E+67,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 332,
                        BusinessId = 10,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 7.2E+67,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 333,
                        BusinessId = 1,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 9.6E+67,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 334,
                        BusinessId = 2,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 1.25E+68,
                        EffectType = "Buy",
                        Effect = 50,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 335,
                        BusinessId = 0,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 7.77E+68,
                        EffectType = "Profit",
                        Effect = 7.77777719497681,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 336,
                        BusinessId = 2,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 5E+69,
                        EffectType = "Buy",
                        Effect = 10,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 337,
                        BusinessId = 3,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 5E+69,
                        EffectType = "Buy",
                        Effect = 10,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 338,
                        BusinessId = 4,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 5E+69,
                        EffectType = "Buy",
                        Effect = 10,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 339,
                        BusinessId = 5,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 5E+69,
                        EffectType = "Buy",
                        Effect = 10,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 340,
                        BusinessId = 6,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 5E+69,
                        EffectType = "Buy",
                        Effect = 10,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 341,
                        BusinessId = 7,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 5E+69,
                        EffectType = "Buy",
                        Effect = 10,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 342,
                        BusinessId = 8,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 5E+69,
                        EffectType = "Buy",
                        Effect = 10,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 343,
                        BusinessId = 9,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 5E+69,
                        EffectType = "Buy",
                        Effect = 10,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 344,
                        BusinessId = 10,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 5E+69,
                        EffectType = "Buy",
                        Effect = 10,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 345,
                        BusinessId = 1,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 5E+69,
                        EffectType = "Buy",
                        Effect = 10,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 346,
                        BusinessId = 2,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 1E+72,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 347,
                        BusinessId = 3,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 5E+72,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 348,
                        BusinessId = 4,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 2.2E+73,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 349,
                        BusinessId = 5,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 4.4E+73,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 350,
                        BusinessId = 6,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 1.11E+74,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 351,
                        BusinessId = 7,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 2.22E+74,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 352,
                        BusinessId = 8,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 3.33E+74,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 353,
                        BusinessId = 9,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 4.44E+74,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 354,
                        BusinessId = 10,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 5.55E+74,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 355,
                        BusinessId = 1,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 6.66E+74,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 356,
                        BusinessId = 6,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 7.77E+155,
                        EffectType = "Profit",
                        Effect = 2,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 357,
                        BusinessId = 2,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 8.88E+155,
                        EffectType = "Profit",
                        Effect = 2,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 358,
                        BusinessId = 3,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 9.99E+155,
                        EffectType = "Profit",
                        Effect = 2,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 359,
                        BusinessId = 9,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 2E+156,
                        EffectType = "Profit",
                        Effect = 2,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 360,
                        BusinessId = 4,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 4E+156,
                        EffectType = "Profit",
                        Effect = 2,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 361,
                        BusinessId = 10,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 8E+156,
                        EffectType = "Profit",
                        Effect = 2,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 362,
                        BusinessId = 5,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1.6E+157,
                        EffectType = "Profit",
                        Effect = 2,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 363,
                        BusinessId = 1,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 3.2E+157,
                        EffectType = "Profit",
                        Effect = 2,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 364,
                        BusinessId = 7,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 6.4E+157,
                        EffectType = "Profit",
                        Effect = 2,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 365,
                        BusinessId = 8,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1.28E+158,
                        EffectType = "Profit",
                        Effect = 2,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 366,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 5.14E+158,
                        EffectType = "Profit",
                        Effect = 2.99792456626892,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 367,
                        BusinessId = 6,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+159,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 368,
                        BusinessId = 2,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+160,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 369,
                        BusinessId = 3,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 2.5E+160,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 370,
                        BusinessId = 9,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 5E+160,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 371,
                        BusinessId = 4,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 7.5E+160,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 372,
                        BusinessId = 10,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+161,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 373,
                        BusinessId = 5,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1.5E+161,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 374,
                        BusinessId = 1,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 2E+161,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 375,
                        BusinessId = 7,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 3E+161,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 376,
                        BusinessId = 8,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 4E+161,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 377,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 9E+161,
                        EffectType = "Profit",
                        Effect = 2.35711002349854,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 378,
                        BusinessId = 8,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+162,
                        EffectType = "Profit",
                        Effect = 24,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 379,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 2.5E+164,
                        EffectType = "Profit",
                        Effect = 2,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 380,
                        BusinessId = 2,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 5E+164,
                        EffectType = "Profit",
                        Effect = 22,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 381,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 7.5E+164,
                        EffectType = "Profit",
                        Effect = 2,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 382,
                        BusinessId = 3,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+165,
                        EffectType = "Profit",
                        Effect = 20,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 383,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 2.5E+167,
                        EffectType = "Profit",
                        Effect = 2,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 384,
                        BusinessId = 9,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 5E+167,
                        EffectType = "Profit",
                        Effect = 18,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 385,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 7.5E+167,
                        EffectType = "Profit",
                        Effect = 2,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 386,
                        BusinessId = 6,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+168,
                        EffectType = "Profit",
                        Effect = 16,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 387,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 2.5E+170,
                        EffectType = "Profit",
                        Effect = 2,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 388,
                        BusinessId = 7,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 5E+170,
                        EffectType = "Profit",
                        Effect = 14,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 389,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 7.5E+170,
                        EffectType = "Profit",
                        Effect = 2,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 390,
                        BusinessId = 10,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+171,
                        EffectType = "Profit",
                        Effect = 12,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 391,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 2.5E+173,
                        EffectType = "Profit",
                        Effect = 2,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 392,
                        BusinessId = 1,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 5E+173,
                        EffectType = "Profit",
                        Effect = 10,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 393,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 7.5E+173,
                        EffectType = "Profit",
                        Effect = 2,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 394,
                        BusinessId = 4,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+174,
                        EffectType = "Profit",
                        Effect = 8,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 395,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 2.5E+176,
                        EffectType = "Profit",
                        Effect = 2,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 396,
                        BusinessId = 5,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 5E+176,
                        EffectType = "Profit",
                        Effect = 4,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 397,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+177,
                        EffectType = "Profit",
                        Effect = 1.79999995231628,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 398,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 5.5E+177,
                        EffectType = "Profit",
                        Effect = 5,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 399,
                        BusinessId = 3,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 2.5E+76,
                        EffectType = "Buy",
                        Effect = 25,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 400,
                        BusinessId = 2,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 2.5E+76,
                        EffectType = "Buy",
                        Effect = 25,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 401,
                        BusinessId = 4,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 2.5E+76,
                        EffectType = "Buy",
                        Effect = 25,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 402,
                        BusinessId = 5,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 2.5E+76,
                        EffectType = "Buy",
                        Effect = 25,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 403,
                        BusinessId = 6,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 2.5E+76,
                        EffectType = "Buy",
                        Effect = 25,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 404,
                        BusinessId = 7,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 2.5E+76,
                        EffectType = "Buy",
                        Effect = 25,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 405,
                        BusinessId = 8,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 2.5E+76,
                        EffectType = "Buy",
                        Effect = 25,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 406,
                        BusinessId = 9,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 2.5E+76,
                        EffectType = "Buy",
                        Effect = 25,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 407,
                        BusinessId = 10,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 2.5E+76,
                        EffectType = "Buy",
                        Effect = 25,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 408,
                        BusinessId = 1,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 2.5E+76,
                        EffectType = "Buy",
                        Effect = 25,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 409,
                        BusinessId = 2,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 1.1E+79,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 410,
                        BusinessId = 3,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 2.7E+79,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 411,
                        BusinessId = 4,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 4.3E+79,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 412,
                        BusinessId = 5,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 8.7E+79,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 413,
                        BusinessId = 6,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 1.9E+80,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 414,
                        BusinessId = 7,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 3.21E+80,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 415,
                        BusinessId = 8,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 4.95E+80,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 416,
                        BusinessId = 9,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 6E+80,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 417,
                        BusinessId = 10,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 7.25E+80,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 418,
                        BusinessId = 1,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 8.98E+80,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 419,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 5E+183,
                        EffectType = "Profit",
                        Effect = 9.87654304504395,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 420,
                        BusinessId = 0,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 3E+84,
                        EffectType = "Profit",
                        Effect = 13.1099996566772,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 421,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 5E+189,
                        EffectType = "Profit",
                        Effect = 5,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 422,
                        BusinessId = 0,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 1.3E+88,
                        EffectType = "Profit",
                        Effect = 5,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 423,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 2.7E+193,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 424,
                        BusinessId = 0,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 3E+90,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 425,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1.3E+196,
                        EffectType = "Profit",
                        Effect = 4,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 426,
                        BusinessId = 0,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 1.3E+94,
                        EffectType = "Profit",
                        Effect = 4,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 427,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 2E+198,
                        EffectType = "Profit",
                        Effect = 5,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 428,
                        BusinessId = 0,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 2.4E+97,
                        EffectType = "Profit",
                        Effect = 5,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 429,
                        BusinessId = 1,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+202,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 430,
                        BusinessId = 2,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1.4E+202,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 431,
                        BusinessId = 3,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 9.6E+202,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 432,
                        BusinessId = 4,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1.98E+203,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 433,
                        BusinessId = 5,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 3.22E+203,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 434,
                        BusinessId = 6,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 6.80E+203,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 435,
                        BusinessId = 7,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 8.88E+203,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 436,
                        BusinessId = 8,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1.9E+205,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 437,
                        BusinessId = 9,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 8.0E+205,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 438,
                        BusinessId = 10,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1.99E+206,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 439,
                        BusinessId = 1,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 2.33E+206,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 440,
                        BusinessId = 2,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 4.21E+206,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 441,
                        BusinessId = 3,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 6.07E+206,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 442,
                        BusinessId = 4,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 7.77E+206,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 443,
                        BusinessId = 5,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 9.1E+206,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 444,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Эффективность",
                        Cost = 1E+207,
                        EffectType = "iEffect",
                        Effect = 0.020,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 445,
                        BusinessId = 6,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 2E+207,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 446,
                        BusinessId = 7,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 9E+207,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 447,
                        BusinessId = 8,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 4.5E+208,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 448,
                        BusinessId = 9,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 2E+209,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 449,
                        BusinessId = 10,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 3E+209,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 450,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 6E+209,
                        EffectType = "Profit",
                        Effect = 5,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 451,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Эффективность",
                        Cost = 1E+213,
                        EffectType = "iEffect",
                        Effect = 0.015,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 452,
                        BusinessId = 1,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+214,
                        EffectType = "Profit",
                        Effect = 11,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 453,
                        BusinessId = 2,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+214,
                        EffectType = "Profit",
                        Effect = 11,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 454,
                        BusinessId = 3,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+214,
                        EffectType = "Profit",
                        Effect = 11,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 455,
                        BusinessId = 4,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+214,
                        EffectType = "Profit",
                        Effect = 11,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 456,
                        BusinessId = 5,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+214,
                        EffectType = "Profit",
                        Effect = 11,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 457,
                        BusinessId = 6,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+214,
                        EffectType = "Profit",
                        Effect = 11,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 458,
                        BusinessId = 7,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+214,
                        EffectType = "Profit",
                        Effect = 11,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 459,
                        BusinessId = 8,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+214,
                        EffectType = "Profit",
                        Effect = 11,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 460,
                        BusinessId = 9,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+214,
                        EffectType = "Profit",
                        Effect = 11,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 461,
                        BusinessId = 10,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+214,
                        EffectType = "Profit",
                        Effect = 11,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 462,
                        BusinessId = 1,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1.5E+215,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 463,
                        BusinessId = 2,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1.66E+215,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 464,
                        BusinessId = 3,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1.93E+215,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 465,
                        BusinessId = 4,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 4.1E+215,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 466,
                        BusinessId = 5,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 6.78E+215,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 467,
                        BusinessId = 6,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 9E+215,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 468,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Эффективность",
                        Cost = 1E+216,
                        EffectType = "iEffect",
                        Effect = 0.01,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 469,
                        BusinessId = 7,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1.2E+217,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 470,
                        BusinessId = 8,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 6.7E+217,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 471,
                        BusinessId = 9,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1.23E+218,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 472,
                        BusinessId = 10,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 3.21E+218,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 473,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 5.55E+218,
                        EffectType = "Profit",
                        Effect = 5,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 474,
                        BusinessId = 1,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 8E+218,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 475,
                        BusinessId = 2,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 8E+218,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 476,
                        BusinessId = 3,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 8E+218,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 477,
                        BusinessId = 4,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 9E+218,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 478,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Эффективность",
                        Cost = 1E+219,
                        EffectType = "iEffect",
                        Effect = 0.02,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 479,
                        BusinessId = 5,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 3E+219,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 480,
                        BusinessId = 6,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 4E+219,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 481,
                        BusinessId = 7,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 5E+219,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 482,
                        BusinessId = 8,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 6E+219,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 483,
                        BusinessId = 9,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 3E+221,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 484,
                        BusinessId = 10,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 4.21E+221,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 485,
                        BusinessId = 1,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 6E+221,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 486,
                        BusinessId = 2,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 7.89E+221,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 487,
                        BusinessId = 3,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 8.45E+221,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 488,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Эффективность",
                        Cost = 4.9E+224,
                        EffectType = "iEffect",
                        Effect = 0.05,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 489,
                        BusinessId = 4,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 2E+222,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 490,
                        BusinessId = 5,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 5E+222,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 491,
                        BusinessId = 6,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1.4E+223,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 492,
                        BusinessId = 7,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 5.4E+223,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 493,
                        BusinessId = 8,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1.08E+224,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 494,
                        BusinessId = 9,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 2.19E+224,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 495,
                        BusinessId = 10,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 4.68E+224,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 498,
                        BusinessId = 1,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+228,
                        EffectType = "Profit",
                        Effect = 7,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 499,
                        BusinessId = 2,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+228,
                        EffectType = "Profit",
                        Effect = 7,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 500,
                        BusinessId = 3,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+228,
                        EffectType = "Profit",
                        Effect = 7,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 501,
                        BusinessId = 4,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+228,
                        EffectType = "Profit",
                        Effect = 7,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 502,
                        BusinessId = 5,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+228,
                        EffectType = "Profit",
                        Effect = 7,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 503,
                        BusinessId = 6,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+228,
                        EffectType = "Profit",
                        Effect = 7,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 504,
                        BusinessId = 7,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+228,
                        EffectType = "Profit",
                        Effect = 7,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 505,
                        BusinessId = 8,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+228,
                        EffectType = "Profit",
                        Effect = 7,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 506,
                        BusinessId = 9,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+228,
                        EffectType = "Profit",
                        Effect = 7,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 507,
                        BusinessId = 10,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+228,
                        EffectType = "Profit",
                        Effect = 7,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 508,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+230,
                        EffectType = "Profit",
                        Effect = 5,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 510,
                        BusinessId = 1,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 3E+231,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 511,
                        BusinessId = 2,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 8E+231,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 513,
                        BusinessId = 3,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 6.9E+232,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 514,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+233,
                        EffectType = "Profit",
                        Effect = 2,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 515,
                        BusinessId = 4,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1.88E+233,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 516,
                        BusinessId = 5,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 2.39E+233,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 517,
                        BusinessId = 6,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 4.11E+233,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 518,
                        BusinessId = 7,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 7E+233,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 519,
                        BusinessId = 8,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 9.12E+233,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 520,
                        BusinessId = 9,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1.2E+235,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 521,
                        BusinessId = 10,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 2.4E+235,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 522,
                        BusinessId = 1,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 6.3E+235,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 523,
                        BusinessId = 2,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1.99E+236,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 524,
                        BusinessId = 3,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 3.98E+236,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 525,
                        BusinessId = 4,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 5.66E+236,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 526,
                        BusinessId = 5,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 7E+236,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 527,
                        BusinessId = 6,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 8E+236,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 528,
                        BusinessId = 7,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 9E+236,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 529,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Эффективность",
                        Cost = 2E+238,
                        EffectType = "iEffect",
                        Effect = 0.05,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 530,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+238,
                        EffectType = "Profit",
                        Effect = 4,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 531,
                        BusinessId = 8,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1.2E+238,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 532,
                        BusinessId = 9,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 2.5E+238,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 533,
                        BusinessId = 10,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 5E+238,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 534,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Эффективность",
                        Cost = 2E+240,
                        EffectType = "iEffect",
                        Effect = 0.05,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 535,
                        BusinessId = 1,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+240,
                        EffectType = "Profit",
                        Effect = 2,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 536,
                        BusinessId = 2,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 5E+240,
                        EffectType = "Profit",
                        Effect = 2,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 537,
                        BusinessId = 3,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 9E+240,
                        EffectType = "Profit",
                        Effect = 2,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 538,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+241,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 539,
                        BusinessId = 4,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 2.1E+241,
                        EffectType = "Profit",
                        Effect = 2,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 540,
                        BusinessId = 5,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 4.5E+241,
                        EffectType = "Profit",
                        Effect = 2,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 541,
                        BusinessId = 6,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 8.9E+241,
                        EffectType = "Profit",
                        Effect = 2,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 542,
                        BusinessId = 7,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1.53E+242,
                        EffectType = "Profit",
                        Effect = 2,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 543,
                        BusinessId = 8,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 2.99E+242,
                        EffectType = "Profit",
                        Effect = 2,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 544,
                        BusinessId = 9,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 5.77E+242,
                        EffectType = "Profit",
                        Effect = 2,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 545,
                        BusinessId = 10,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 8.13E+242,
                        EffectType = "Profit",
                        Effect = 2,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 546,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Эффективность",
                        Cost = 1E+243,
                        EffectType = "iEffect",
                        Effect = 0.05,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 547,
                        BusinessId = 1,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 2E+243,
                        EffectType = "Profit",
                        Effect = 2,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 548,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+244,
                        EffectType = "Profit",
                        Effect = 6,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 549,
                        BusinessId = 2,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 2.2E+244,
                        EffectType = "Profit",
                        Effect = 2,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 550,
                        BusinessId = 3,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 4.4E+244,
                        EffectType = "Profit",
                        Effect = 2,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 551,
                        BusinessId = 4,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 6.6E+244,
                        EffectType = "Profit",
                        Effect = 2,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 552,
                        BusinessId = 5,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 8.8E+244,
                        EffectType = "Profit",
                        Effect = 2,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 553,
                        BusinessId = 6,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1.11E+245,
                        EffectType = "Profit",
                        Effect = 2,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 554,
                        BusinessId = 7,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 2.22E+245,
                        EffectType = "Profit",
                        Effect = 2,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 555,
                        BusinessId = 8,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 3.33E+245,
                        EffectType = "Profit",
                        Effect = 2,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 556,
                        BusinessId = 9,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 4.44E+245,
                        EffectType = "Profit",
                        Effect = 2,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 557,
                        BusinessId = 10,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 5.55E+245,
                        EffectType = "Profit",
                        Effect = 2,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 559,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+247,
                        EffectType = "Profit",
                        Effect = 4,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 561,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+250,
                        EffectType = "Profit",
                        Effect = 7,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 562,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Эффективность",
                        Cost = 2E+252,
                        EffectType = "iEffect",
                        Effect = 0.05,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 563,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+252,
                        EffectType = "Profit",
                        Effect = 5,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 564,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+253,
                        EffectType = "Profit",
                        Effect = 2,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 565,
                        BusinessId = 1,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+253,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 566,
                        BusinessId = 2,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+253,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 567,
                        BusinessId = 3,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+253,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 568,
                        BusinessId = 4,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+253,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 569,
                        BusinessId = 5,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+253,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 570,
                        BusinessId = 6,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+253,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 571,
                        BusinessId = 7,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+253,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 572,
                        BusinessId = 8,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+253,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 573,
                        BusinessId = 9,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+253,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 574,
                        BusinessId = 10,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+253,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 575,
                        BusinessId = 1,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 5E+253,
                        EffectType = "Profit",
                        Effect = 9,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 576,
                        BusinessId = 2,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 7.5E+253,
                        EffectType = "Profit",
                        Effect = 9,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 577,
                        BusinessId = 3,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1.25E+254,
                        EffectType = "Profit",
                        Effect = 9,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 578,
                        BusinessId = 4,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 6.25E+254,
                        EffectType = "Profit",
                        Effect = 9,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 580,
                        BusinessId = 5,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 3E+255,
                        EffectType = "Profit",
                        Effect = 9,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 581,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+256,
                        EffectType = "Profit",
                        Effect = 6,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 582,
                        BusinessId = 6,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1.5E+256,
                        EffectType = "Profit",
                        Effect = 9,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 583,
                        BusinessId = 7,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 7.5E+256,
                        EffectType = "Profit",
                        Effect = 9,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 584,
                        BusinessId = 8,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 3.75E+257,
                        EffectType = "Profit",
                        Effect = 9,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 585,
                        BusinessId = 10,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 8E+257,
                        EffectType = "Profit",
                        Effect = 9,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 587,
                        BusinessId = 9,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+258,
                        EffectType = "Profit",
                        Effect = 9,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 588,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 2.5E+258,
                        EffectType = "Profit",
                        Effect = 2,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 589,
                        BusinessId = 1,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 6.4E+258,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 590,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+259,
                        EffectType = "Profit",
                        Effect = 5,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 591,
                        BusinessId = 2,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1.22E+259,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 592,
                        BusinessId = 3,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 2.33E+260,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 593,
                        BusinessId = 4,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 3.99E+260,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 594,
                        BusinessId = 5,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 7.66E+260,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 596,
                        BusinessId = 6,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+261,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 597,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+262,
                        EffectType = "Profit",
                        Effect = 5,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 598,
                        BusinessId = 7,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1.9E+262,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 599,
                        BusinessId = 8,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 9.8E+262,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 600,
                        BusinessId = 9,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 2.6E+263,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 601,
                        BusinessId = 10,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 5.44E+263,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 602,
                        BusinessId = 1,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 7E+263,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 603,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Эффективность",
                        Cost = 2E+264,
                        EffectType = "iEffect",
                        Effect = 0.05,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 604,
                        BusinessId = 2,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+264,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 605,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+265,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 606,
                        BusinessId = 3,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 4.5E+265,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 607,
                        BusinessId = 4,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 6.9E+265,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 608,
                        BusinessId = 5,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 8.9E+265,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 609,
                        BusinessId = 6,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1.89E+266,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 610,
                        BusinessId = 7,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 2.89E+266,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 611,
                        BusinessId = 8,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 4.48E+266,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 612,
                        BusinessId = 9,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 9E+266,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 613,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Эффективность",
                        Cost = 3E+267,
                        EffectType = "iEffect",
                        Effect = 0.05,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 614,
                        BusinessId = 10,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 5E+267,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 615,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+268,
                        EffectType = "Profit",
                        Effect = 7,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 616,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+270,
                        EffectType = "Profit",
                        Effect = 5,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 618,
                        BusinessId = 1,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+273,
                        EffectType = "Profit",
                        Effect = 7,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 620,
                        BusinessId = 2,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 2E+273,
                        EffectType = "Profit",
                        Effect = 7,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 621,
                        BusinessId = 3,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 3E+273,
                        EffectType = "Profit",
                        Effect = 7,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 622,
                        BusinessId = 4,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 6E+273,
                        EffectType = "Profit",
                        Effect = 7,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 623,
                        BusinessId = 5,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 2.5E+274,
                        EffectType = "Profit",
                        Effect = 7,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 624,
                        BusinessId = 6,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 2E+275,
                        EffectType = "Profit",
                        Effect = 7,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 625,
                        BusinessId = 7,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 6E+275,
                        EffectType = "Profit",
                        Effect = 7,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 626,
                        BusinessId = 8,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 9.99E+275,
                        EffectType = "Profit",
                        Effect = 7,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 627,
                        BusinessId = 3,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 9E+283,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 628,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+277,
                        EffectType = "Profit",
                        Effect = 4,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 629,
                        BusinessId = 9,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1.5E+277,
                        EffectType = "Profit",
                        Effect = 7,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 630,
                        BusinessId = 10,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 3E+277,
                        EffectType = "Profit",
                        Effect = 7,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 632,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+280,
                        EffectType = "Profit",
                        Effect = 5,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 634,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+283,
                        EffectType = "Profit",
                        Effect = 7.76999998092651,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 635,
                        BusinessId = 4,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 9E+286,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 636,
                        BusinessId = 2,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+285,
                        EffectType = "Profit",
                        Effect = 13,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 637,
                        BusinessId = 3,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+285,
                        EffectType = "Profit",
                        Effect = 13,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 638,
                        BusinessId = 4,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+285,
                        EffectType = "Profit",
                        Effect = 13,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 639,
                        BusinessId = 5,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+285,
                        EffectType = "Profit",
                        Effect = 13,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 640,
                        BusinessId = 6,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+285,
                        EffectType = "Profit",
                        Effect = 13,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 641,
                        BusinessId = 7,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+285,
                        EffectType = "Profit",
                        Effect = 13,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 642,
                        BusinessId = 8,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+285,
                        EffectType = "Profit",
                        Effect = 13,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 643,
                        BusinessId = 9,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+285,
                        EffectType = "Profit",
                        Effect = 13,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 644,
                        BusinessId = 10,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+285,
                        EffectType = "Profit",
                        Effect = 13,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 645,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+286,
                        EffectType = "Profit",
                        Effect = 7.76999998092651,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 646,
                        BusinessId = 0,
                        CurrencyId = 0,
                        Name = "Профит",
                        Cost = 1E+288,
                        EffectType = "Profit",
                        Effect = 77.7699966430664,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 647,
                        BusinessId = 2,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 1E+102,
                        EffectType = "Buy",
                        Effect = 25,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 648,
                        BusinessId = 3,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 1E+102,
                        EffectType = "Buy",
                        Effect = 25,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 649,
                        BusinessId = 4,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 1E+102,
                        EffectType = "Buy",
                        Effect = 25,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 650,
                        BusinessId = 5,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 1E+102,
                        EffectType = "Buy",
                        Effect = 25,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 651,
                        BusinessId = 6,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 1E+102,
                        EffectType = "Buy",
                        Effect = 25,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 652,
                        BusinessId = 7,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 1E+102,
                        EffectType = "Buy",
                        Effect = 25,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 653,
                        BusinessId = 8,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 1E+102,
                        EffectType = "Buy",
                        Effect = 25,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 654,
                        BusinessId = 9,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 1E+102,
                        EffectType = "Buy",
                        Effect = 25,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 655,
                        BusinessId = 10,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 1E+102,
                        EffectType = "Buy",
                        Effect = 25,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 656,
                        BusinessId = 1,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 1E+102,
                        EffectType = "Buy",
                        Effect = 25,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 657,
                        BusinessId = 0,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 3.33E+110,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 658,
                        BusinessId = 2,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 1E+114,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 659,
                        BusinessId = 3,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 2E+115,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 660,
                        BusinessId = 4,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 5E+115,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 661,
                        BusinessId = 5,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 1E+116,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 662,
                        BusinessId = 6,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 2E+116,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 663,
                        BusinessId = 7,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 3E+116,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 664,
                        BusinessId = 8,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 4E+116,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 665,
                        BusinessId = 9,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 5E+116,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 666,
                        BusinessId = 10,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 7.5E+116,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 667,
                        BusinessId = 1,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 2E+117,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 668,
                        BusinessId = 2,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 1E+129,
                        EffectType = "Buy",
                        Effect = 25,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 669,
                        BusinessId = 3,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 1E+129,
                        EffectType = "Buy",
                        Effect = 25,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 670,
                        BusinessId = 4,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 1E+129,
                        EffectType = "Buy",
                        Effect = 25,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 671,
                        BusinessId = 5,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 1E+129,
                        EffectType = "Buy",
                        Effect = 25,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 672,
                        BusinessId = 6,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 1E+129,
                        EffectType = "Buy",
                        Effect = 25,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 673,
                        BusinessId = 7,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 1E+129,
                        EffectType = "Buy",
                        Effect = 25,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 674,
                        BusinessId = 8,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 1E+129,
                        EffectType = "Buy",
                        Effect = 25,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 675,
                        BusinessId = 9,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 1E+129,
                        EffectType = "Buy",
                        Effect = 25,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 676,
                        BusinessId = 10,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 1E+129,
                        EffectType = "Buy",
                        Effect = 25,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 677,
                        BusinessId = 1,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 1E+129,
                        EffectType = "Buy",
                        Effect = 25,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 678,
                        BusinessId = 2,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 1E+138,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 679,
                        BusinessId = 3,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 1E+138,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 680,
                        BusinessId = 4,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 1E+138,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 681,
                        BusinessId = 5,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 1E+138,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 682,
                        BusinessId = 6,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 1E+138,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 683,
                        BusinessId = 7,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 1E+138,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 684,
                        BusinessId = 8,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 1E+138,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 685,
                        BusinessId = 9,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 1E+138,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 686,
                        BusinessId = 1,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 1E+138,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 687,
                        BusinessId = 10,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 1E+138,
                        EffectType = "Profit",
                        Effect = 3,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 688,
                        BusinessId = 0,
                        CurrencyId = 1,
                        Name = "Профит",
                        Cost = 2E+138,
                        EffectType = "Profit",
                        Effect = 19,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 689,
                        BusinessId = 3,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 2E+138,
                        EffectType = "Buy",
                        Effect = 25,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 690,
                        BusinessId = 6,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 2E+138,
                        EffectType = "Buy",
                        Effect = 25,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 691,
                        BusinessId = 7,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 2E+138,
                        EffectType = "Buy",
                        Effect = 25,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 692,
                        BusinessId = 9,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 2E+138,
                        EffectType = "Buy",
                        Effect = 25,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 693,
                        BusinessId = 4,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 2E+138,
                        EffectType = "Buy",
                        Effect = 25,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 694,
                        BusinessId = 1,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 2E+138,
                        EffectType = "Buy",
                        Effect = 25,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 695,
                        BusinessId = 2,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 3E+138,
                        EffectType = "Buy",
                        Effect = 25,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 696,
                        BusinessId = 5,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 3E+138,
                        EffectType = "Buy",
                        Effect = 25,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 697,
                        BusinessId = 8,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 3E+138,
                        EffectType = "Buy",
                        Effect = 25,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 698,
                        BusinessId = 10,
                        CurrencyId = 1,
                        Name = "Расширение",
                        Cost = 4E+138,
                        EffectType = "Buy",
                        Effect = 25,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 1346,
                        BusinessId = 1,
                        CurrencyId = 3,
                        Name = "Мгновенный Профит",
                        Cost = 20,
                        EffectType = "Multiplier",
                        Effect = 10,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 1347,
                        BusinessId = 3,
                        CurrencyId = 3,
                        Name = "Мгновенный Профит",
                        Cost = 20,
                        EffectType = "Multiplier",
                        Effect = 10,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 1348,
                        BusinessId = 5,
                        CurrencyId = 3,
                        Name = "Мгновенный Профит",
                        Cost = 20,
                        EffectType = "Multiplier",
                        Effect = 10,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 1349,
                        BusinessId = 7,
                        CurrencyId = 3,
                        Name = "Мгновенный Профит",
                        Cost = 20,
                        EffectType = "Multiplier",
                        Effect = 10,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 1350,
                        BusinessId = 9,
                        CurrencyId = 3,
                        Name = "Мгновенный Профит",
                        Cost = 20,
                        EffectType = "Multiplier",
                        Effect = 10,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 1354,
                        BusinessId = 2,
                        CurrencyId = 3,
                        Name = "Мгновенный Профит",
                        Cost = 20,
                        EffectType = "Multiplier",
                        Effect = 10,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 1355,
                        BusinessId = 4,
                        CurrencyId = 3,
                        Name = "Мгновенный Профит",
                        Cost = 20,
                        EffectType = "Multiplier",
                        Effect = 10,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 1356,
                        BusinessId = 6,
                        CurrencyId = 3,
                        Name = "Мгновенный Профит",
                        Cost = 20,
                        EffectType = "Multiplier",
                        Effect = 10,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 1357,
                        BusinessId = 8,
                        CurrencyId = 3,
                        Name = "Мгновенный Профит",
                        Cost = 20,
                        EffectType = "Multiplier",
                        Effect = 10,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 1358,
                        BusinessId = 10,
                        CurrencyId = 3,
                        Name = "Мгновенный Профит",
                        Cost = 20,
                        EffectType = "Multiplier",
                        Effect = 10,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 1373,
                        BusinessId = 1,
                        CurrencyId = 3,
                        Name = "Мгновенный Профит",
                        Cost = 30,
                        EffectType = "Multiplier",
                        Effect = 30,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 1374,
                        BusinessId = 2,
                        CurrencyId = 3,
                        Name = "Мгновенный Профит",
                        Cost = 30,
                        EffectType = "Multiplier",
                        Effect = 30,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 1375,
                        BusinessId = 3,
                        CurrencyId = 3,
                        Name = "Мгновенный Профит",
                        Cost = 30,
                        EffectType = "Multiplier",
                        Effect = 30,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 1376,
                        BusinessId = 4,
                        CurrencyId = 3,
                        Name = "Мгновенный Профит",
                        Cost = 30,
                        EffectType = "Multiplier",
                        Effect = 30,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 1377,
                        BusinessId = 5,
                        CurrencyId = 3,
                        Name = "Мгновенный Профит",
                        Cost = 30,
                        EffectType = "Multiplier",
                        Effect = 30,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 1378,
                        BusinessId = 6,
                        CurrencyId = 3,
                        Name = "Мгновенный Профит",
                        Cost = 30,
                        EffectType = "Multiplier",
                        Effect = 30,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 1379,
                        BusinessId = 7,
                        CurrencyId = 3,
                        Name = "Мгновенный Профит",
                        Cost = 30,
                        EffectType = "Multiplier",
                        Effect = 30,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 1380,
                        BusinessId = 8,
                        CurrencyId = 3,
                        Name = "Мгновенный Профит",
                        Cost = 30,
                        EffectType = "Multiplier",
                        Effect = 30,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 1381,
                        BusinessId = 9,
                        CurrencyId = 3,
                        Name = "Мгновенный Профит",
                        Cost = 30,
                        EffectType = "Multiplier",
                        Effect = 30,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 1382,
                        BusinessId = 10,
                        CurrencyId = 3,
                        Name = "Мгновенный Профит",
                        Cost = 30,
                        EffectType = "Multiplier",
                        Effect = 30,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 1383,
                        BusinessId = 1,
                        CurrencyId = 3,
                        Name = "Мгновенный Профит",
                        Cost = 40,
                        EffectType = "Multiplier",
                        Effect = 60,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 1384,
                        BusinessId = 2,
                        CurrencyId = 3,
                        Name = "Мгновенный Профит",
                        Cost = 40,
                        EffectType = "Multiplier",
                        Effect = 60,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 1385,
                        BusinessId = 3,
                        CurrencyId = 3,
                        Name = "Мгновенный Профит",
                        Cost = 40,
                        EffectType = "Multiplier",
                        Effect = 60,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 1386,
                        BusinessId = 4,
                        CurrencyId = 3,
                        Name = "Мгновенный Профит",
                        Cost = 40,
                        EffectType = "Multiplier",
                        Effect = 60,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 1387,
                        BusinessId = 5,
                        CurrencyId = 3,
                        Name = "Мгновенный Профит",
                        Cost = 40,
                        EffectType = "Multiplier",
                        Effect = 60,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 1388,
                        BusinessId = 6,
                        CurrencyId = 3,
                        Name = "Мгновенный Профит",
                        Cost = 40,
                        EffectType = "Multiplier",
                        Effect = 60,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 1389,
                        BusinessId = 7,
                        CurrencyId = 3,
                        Name = "Мгновенный Профит",
                        Cost = 40,
                        EffectType = "Multiplier",
                        Effect = 60,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 1390,
                        BusinessId = 8,
                        CurrencyId = 3,
                        Name = "Мгновенный Профит",
                        Cost = 40,
                        EffectType = "Multiplier",
                        Effect = 60,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 1391,
                        BusinessId = 9,
                        CurrencyId = 3,
                        Name = "Мгновенный Профит",
                        Cost = 40,
                        EffectType = "Multiplier",
                        Effect = 60,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 1392,
                        BusinessId = 10,
                        CurrencyId = 3,
                        Name = "Мгновенный Профит",
                        Cost = 40,
                        EffectType = "Multiplier",
                        Effect = 60,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 1393,
                        BusinessId = 1,
                        CurrencyId = 3,
                        Name = "Мгновенный Профит",
                        Cost = 50,
                        EffectType = "Multiplier",
                        Effect = 700,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 1394,
                        BusinessId = 2,
                        CurrencyId = 3,
                        Name = "Мгновенный Профит",
                        Cost = 50,
                        EffectType = "Multiplier",
                        Effect = 700,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 1395,
                        BusinessId = 3,
                        CurrencyId = 3,
                        Name = "Мгновенный Профит",
                        Cost = 50,
                        EffectType = "Multiplier",
                        Effect = 700,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 1396,
                        BusinessId = 4,
                        CurrencyId = 3,
                        Name = "Мгновенный Профит",
                        Cost = 50,
                        EffectType = "Multiplier",
                        Effect = 700,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 1397,
                        BusinessId = 5,
                        CurrencyId = 3,
                        Name = "Мгновенный Профит",
                        Cost = 50,
                        EffectType = "Multiplier",
                        Effect = 700,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 1398,
                        BusinessId = 6,
                        CurrencyId = 3,
                        Name = "Мгновенный Профит",
                        Cost = 50,
                        EffectType = "Multiplier",
                        Effect = 700,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 1399,
                        BusinessId = 7,
                        CurrencyId = 3,
                        Name = "Мгновенный Профит",
                        Cost = 50,
                        EffectType = "Multiplier",
                        Effect = 700,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 1400,
                        BusinessId = 8,
                        CurrencyId = 3,
                        Name = "Мгновенный Профит",
                        Cost = 50,
                        EffectType = "Multiplier",
                        Effect = 700,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 1401,
                        BusinessId = 9,
                        CurrencyId = 3,
                        Name = "Мгновенный Профит",
                        Cost = 50,
                        EffectType = "Multiplier",
                        Effect = 700,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 1402,
                        BusinessId = 10,
                        CurrencyId = 3,
                        Name = "Мгновенный Профит",
                        Cost = 50,
                        EffectType = "Multiplier",
                        Effect = 700,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 1403,
                        BusinessId = 1,
                        CurrencyId = 3,
                        Name = "Мгновенный Профит",
                        Cost = 100,
                        EffectType = "Multiplier",
                        Effect = 7000,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 1404,
                        BusinessId = 2,
                        CurrencyId = 3,
                        Name = "Мгновенный Профит",
                        Cost = 100,
                        EffectType = "Multiplier",
                        Effect = 7000,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 1405,
                        BusinessId = 3,
                        CurrencyId = 3,
                        Name = "Мгновенный Профит",
                        Cost = 100,
                        EffectType = "Multiplier",
                        Effect = 7000,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 1406,
                        BusinessId = 4,
                        CurrencyId = 3,
                        Name = "Мгновенный Профит",
                        Cost = 100,
                        EffectType = "Multiplier",
                        Effect = 7000,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 1407,
                        BusinessId = 5,
                        CurrencyId = 3,
                        Name = "Мгновенный Профит",
                        Cost = 100,
                        EffectType = "Multiplier",
                        Effect = 7000,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 1408,
                        BusinessId = 6,
                        CurrencyId = 3,
                        Name = "Мгновенный Профит",
                        Cost = 100,
                        EffectType = "Multiplier",
                        Effect = 7000,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 1409,
                        BusinessId = 7,
                        CurrencyId = 3,
                        Name = "Мгновенный Профит",
                        Cost = 100,
                        EffectType = "Multiplier",
                        Effect = 7000,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 1410,
                        BusinessId = 8,
                        CurrencyId = 3,
                        Name = "Мгновенный Профит",
                        Cost = 100,
                        EffectType = "Multiplier",
                        Effect = 7000,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 1411,
                        BusinessId = 9,
                        CurrencyId = 3,
                        Name = "Мгновенный Профит",
                        Cost = 100,
                        EffectType = "Multiplier",
                        Effect = 7000,
                        Unlocked = false
                    },
                    new Upgrade
                    {
                        Id = 1412,
                        BusinessId = 10,
                        CurrencyId = 3,
                        Name = "Мгновенный Профит",
                        Cost = 100,
                        EffectType = "Multiplier",
                        Effect = 7000,
                        Unlocked = false
                    },
                },
            Products = new List<StoreProduct>()
                {
                    new StoreProduct
                    {
                        Id = 6,
                        BusinessId = 100,
                        CurrencyId = 3,
                        Name = "24 часа пропуска времени",
                        Cost = 10,
                        EffectType = "TimeJump",
                        Effect = 24,
                        Unlocked = false,
                        SKU = ""
                    },
                    new StoreProduct
                    {
                        Id = 10,
                        BusinessId = 100,
                        CurrencyId = 3,
                        Name = "72 часа пропуска времени",
                        Cost = 15,
                        EffectType = "TimeJump",
                        Effect = 72,
                        Unlocked = false,
                        SKU = ""
                    },
                    new StoreProduct
                    {
                        Id = 11,
                        BusinessId = 100,
                        CurrencyId = 3,
                        Name = "7 дней пропуска времени",
                        Cost = 20,
                        EffectType = "TimeJump",
                        Effect = 168,
                        Unlocked = false,
                        SKU = ""
                    },
                },
            Milestones = new List<Milestone>()
                {
                    new Milestone
                    {
                        Id = 1,
                        BusinessId = 1,
                        Count = 25,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 1,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 2,
                        BusinessId = 1,
                        Count = 50,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 1,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 3,
                        BusinessId = 1,
                        Count = 100,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 1,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 4,
                        BusinessId = 1,
                        Count = 200,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 1,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 5,
                        BusinessId = 1,
                        Count = 300,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 1,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 6,
                        BusinessId = 1,
                        Count = 400,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 1,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 7,
                        BusinessId = 1,
                        Count = 500,
                        EffectType = "Profit",
                        Effect = 4,
                        TargetId = 1,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 8,
                        BusinessId = 1,
                        Count = 600,
                        EffectType = "Profit",
                        Effect = 4,
                        TargetId = 1,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 9,
                        BusinessId = 1,
                        Count = 700,
                        EffectType = "Profit",
                        Effect = 4,
                        TargetId = 1,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 10,
                        BusinessId = 1,
                        Count = 800,
                        EffectType = "Profit",
                        Effect = 4,
                        TargetId = 1,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 11,
                        BusinessId = 1,
                        Count = 900,
                        EffectType = "Profit",
                        Effect = 4,
                        TargetId = 1,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 12,
                        BusinessId = 1,
                        Count = 1000,
                        EffectType = "Profit",
                        Effect = 5,
                        TargetId = 1,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 13,
                        BusinessId = 1,
                        Count = 1100,
                        EffectType = "Profit",
                        Effect = 4,
                        TargetId = 1,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 14,
                        BusinessId = 1,
                        Count = 1200,
                        EffectType = "Profit",
                        Effect = 4,
                        TargetId = 1,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 15,
                        BusinessId = 1,
                        Count = 1300,
                        EffectType = "Profit",
                        Effect = 4,
                        TargetId = 1,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 16,
                        BusinessId = 1,
                        Count = 1400,
                        EffectType = "Profit",
                        Effect = 4,
                        TargetId = 1,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 17,
                        BusinessId = 1,
                        Count = 1500,
                        EffectType = "Profit",
                        Effect = 4,
                        TargetId = 1,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 18,
                        BusinessId = 1,
                        Count = 1600,
                        EffectType = "Profit",
                        Effect = 4,
                        TargetId = 1,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 19,
                        BusinessId = 1,
                        Count = 1700,
                        EffectType = "Profit",
                        Effect = 4,
                        TargetId = 1,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 20,
                        BusinessId = 1,
                        Count = 1800,
                        EffectType = "Profit",
                        Effect = 4,
                        TargetId = 1,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 21,
                        BusinessId = 1,
                        Count = 1900,
                        EffectType = "Profit",
                        Effect = 4,
                        TargetId = 1,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 22,
                        BusinessId = 1,
                        Count = 2000,
                        EffectType = "Profit",
                        Effect = 5,
                        TargetId = 1,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 23,
                        BusinessId = 1,
                        Count = 2250,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 1,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 24,
                        BusinessId = 1,
                        Count = 2500,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 1,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 25,
                        BusinessId = 1,
                        Count = 2750,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 1,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 26,
                        BusinessId = 1,
                        Count = 3000,
                        EffectType = "Profit",
                        Effect = 5,
                        TargetId = 1,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 27,
                        BusinessId = 1,
                        Count = 3250,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 1,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 28,
                        BusinessId = 1,
                        Count = 3500,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 1,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 29,
                        BusinessId = 1,
                        Count = 3750,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 1,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 30,
                        BusinessId = 1,
                        Count = 4000,
                        EffectType = "Profit",
                        Effect = 5,
                        TargetId = 1,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 31,
                        BusinessId = 1,
                        Count = 4250,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 1,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 32,
                        BusinessId = 1,
                        Count = 4500,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 1,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 33,
                        BusinessId = 1,
                        Count = 4750,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 1,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 34,
                        BusinessId = 1,
                        Count = 5000,
                        EffectType = "Profit",
                        Effect = 5,
                        TargetId = 1,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 35,
                        BusinessId = 1,
                        Count = 5250,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 1,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 36,
                        BusinessId = 1,
                        Count = 5500,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 1,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 37,
                        BusinessId = 1,
                        Count = 5750,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 1,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 38,
                        BusinessId = 1,
                        Count = 6000,
                        EffectType = "Profit",
                        Effect = 5,
                        TargetId = 1,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 39,
                        BusinessId = 1,
                        Count = 6250,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 1,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 40,
                        BusinessId = 1,
                        Count = 6500,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 1,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 41,
                        BusinessId = 1,
                        Count = 6750,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 1,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 42,
                        BusinessId = 1,
                        Count = 7000,
                        EffectType = "Profit",
                        Effect = 5,
                        TargetId = 1,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 43,
                        BusinessId = 1,
                        Count = 7000,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 1,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 44,
                        BusinessId = 1,
                        Count = 7250,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 1,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 45,
                        BusinessId = 1,
                        Count = 7500,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 1,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 46,
                        BusinessId = 1,
                        Count = 7777,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 1,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 47,
                        BusinessId = 1,
                        Count = 8000,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 1,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 48,
                        BusinessId = 1,
                        Count = 8200,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 1,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 49,
                        BusinessId = 1,
                        Count = 8400,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 1,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 50,
                        BusinessId = 1,
                        Count = 8600,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 1,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 51,
                        BusinessId = 1,
                        Count = 8800,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 1,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 52,
                        BusinessId = 1,
                        Count = 9000,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 1,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 53,
                        BusinessId = 1,
                        Count = 9100,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 1,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 54,
                        BusinessId = 1,
                        Count = 9200,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 1,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 55,
                        BusinessId = 1,
                        Count = 9300,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 1,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 56,
                        BusinessId = 1,
                        Count = 9400,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 1,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 57,
                        BusinessId = 1,
                        Count = 9500,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 1,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 58,
                        BusinessId = 1,
                        Count = 9600,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 1,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 59,
                        BusinessId = 1,
                        Count = 9700,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 1,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 60,
                        BusinessId = 1,
                        Count = 9800,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 1,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 61,
                        BusinessId = 1,
                        Count = 9999,
                        EffectType = "Profit",
                        Effect = 1.99989998340607,
                        TargetId = 1,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 62,
                        BusinessId = 1,
                        Count = 10000,
                        EffectType = "Profit",
                        Effect = 5,
                        TargetId = 1,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 63,
                        BusinessId = 2,
                        Count = 25,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 2,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 64,
                        BusinessId = 2,
                        Count = 50,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 2,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 65,
                        BusinessId = 2,
                        Count = 100,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 2,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 66,
                        BusinessId = 2,
                        Count = 125,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 1,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 67,
                        BusinessId = 2,
                        Count = 150,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 3,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 68,
                        BusinessId = 2,
                        Count = 175,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 4,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 69,
                        BusinessId = 2,
                        Count = 200,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 2,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 70,
                        BusinessId = 2,
                        Count = 225,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 5,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 71,
                        BusinessId = 2,
                        Count = 250,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 1,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 72,
                        BusinessId = 2,
                        Count = 275,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 3,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 73,
                        BusinessId = 2,
                        Count = 300,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 2,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 74,
                        BusinessId = 2,
                        Count = 325,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 4,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 75,
                        BusinessId = 2,
                        Count = 350,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 5,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 76,
                        BusinessId = 2,
                        Count = 375,
                        EffectType = "Profit",
                        Effect = 4,
                        TargetId = 1,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 77,
                        BusinessId = 2,
                        Count = 400,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 2,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 78,
                        BusinessId = 2,
                        Count = 425,
                        EffectType = "Profit",
                        Effect = 4,
                        TargetId = 3,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 79,
                        BusinessId = 2,
                        Count = 450,
                        EffectType = "Profit",
                        Effect = 4,
                        TargetId = 4,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 80,
                        BusinessId = 2,
                        Count = 475,
                        EffectType = "Profit",
                        Effect = 4,
                        TargetId = 5,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 81,
                        BusinessId = 2,
                        Count = 500,
                        EffectType = "Profit",
                        Effect = 11,
                        TargetId = 6,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 82,
                        BusinessId = 2,
                        Count = 525,
                        EffectType = "Profit",
                        Effect = 5,
                        TargetId = 1,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 83,
                        BusinessId = 2,
                        Count = 550,
                        EffectType = "Profit",
                        Effect = 5,
                        TargetId = 3,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 84,
                        BusinessId = 2,
                        Count = 575,
                        EffectType = "Profit",
                        Effect = 5,
                        TargetId = 4,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 85,
                        BusinessId = 2,
                        Count = 600,
                        EffectType = "Profit",
                        Effect = 11,
                        TargetId = 7,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 86,
                        BusinessId = 2,
                        Count = 625,
                        EffectType = "Profit",
                        Effect = 5,
                        TargetId = 5,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 87,
                        BusinessId = 2,
                        Count = 650,
                        EffectType = "Profit",
                        Effect = 6,
                        TargetId = 1,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 88,
                        BusinessId = 2,
                        Count = 675,
                        EffectType = "Profit",
                        Effect = 6,
                        TargetId = 3,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 89,
                        BusinessId = 2,
                        Count = 700,
                        EffectType = "Profit",
                        Effect = 11,
                        TargetId = 8,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 90,
                        BusinessId = 2,
                        Count = 725,
                        EffectType = "Profit",
                        Effect = 6,
                        TargetId = 4,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 91,
                        BusinessId = 2,
                        Count = 750,
                        EffectType = "Profit",
                        Effect = 6,
                        TargetId = 5,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 92,
                        BusinessId = 2,
                        Count = 775,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 1,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 93,
                        BusinessId = 2,
                        Count = 800,
                        EffectType = "Profit",
                        Effect = 11,
                        TargetId = 9,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 94,
                        BusinessId = 2,
                        Count = 825,
                        EffectType = "Profit",
                        Effect = 7,
                        TargetId = 3,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 95,
                        BusinessId = 2,
                        Count = 850,
                        EffectType = "Profit",
                        Effect = 7,
                        TargetId = 4,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 96,
                        BusinessId = 2,
                        Count = 875,
                        EffectType = "Profit",
                        Effect = 7,
                        TargetId = 5,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 97,
                        BusinessId = 2,
                        Count = 900,
                        EffectType = "Profit",
                        Effect = 11,
                        TargetId = 10,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 98,
                        BusinessId = 2,
                        Count = 925,
                        EffectType = "Profit",
                        Effect = 7,
                        TargetId = 6,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 99,
                        BusinessId = 2,
                        Count = 950,
                        EffectType = "Profit",
                        Effect = 7,
                        TargetId = 7,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 100,
                        BusinessId = 2,
                        Count = 975,
                        EffectType = "Profit",
                        Effect = 7,
                        TargetId = 8,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 101,
                        BusinessId = 2,
                        Count = 1000,
                        EffectType = "Profit",
                        Effect = 7777777,
                        TargetId = 2,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 102,
                        BusinessId = 2,
                        Count = 1025,
                        EffectType = "Profit",
                        Effect = 7,
                        TargetId = 9,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 103,
                        BusinessId = 2,
                        Count = 1050,
                        EffectType = "Profit",
                        Effect = 7,
                        TargetId = 10,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 104,
                        BusinessId = 2,
                        Count = 1075,
                        EffectType = "Profit",
                        Effect = 8,
                        TargetId = 3,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 105,
                        BusinessId = 2,
                        Count = 1100,
                        EffectType = "Profit",
                        Effect = 8,
                        TargetId = 4,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 106,
                        BusinessId = 2,
                        Count = 1125,
                        EffectType = "Profit",
                        Effect = 8,
                        TargetId = 5,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 107,
                        BusinessId = 2,
                        Count = 1150,
                        EffectType = "Profit",
                        Effect = 8,
                        TargetId = 6,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 108,
                        BusinessId = 2,
                        Count = 1175,
                        EffectType = "Profit",
                        Effect = 8,
                        TargetId = 7,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 109,
                        BusinessId = 2,
                        Count = 1200,
                        EffectType = "Profit",
                        Effect = 8,
                        TargetId = 8,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 110,
                        BusinessId = 2,
                        Count = 1225,
                        EffectType = "Profit",
                        Effect = 8,
                        TargetId = 9,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 111,
                        BusinessId = 2,
                        Count = 1250,
                        EffectType = "Profit",
                        Effect = 8,
                        TargetId = 10,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 112,
                        BusinessId = 2,
                        Count = 1300,
                        EffectType = "Profit",
                        Effect = 7777,
                        TargetId = 2,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 113,
                        BusinessId = 2,
                        Count = 1350,
                        EffectType = "Profit",
                        Effect = 9,
                        TargetId = 1,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 114,
                        BusinessId = 2,
                        Count = 1400,
                        EffectType = "Profit",
                        Effect = 9,
                        TargetId = 3,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 115,
                        BusinessId = 2,
                        Count = 1450,
                        EffectType = "Profit",
                        Effect = 9,
                        TargetId = 4,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 116,
                        BusinessId = 2,
                        Count = 1500,
                        EffectType = "Profit",
                        Effect = 9,
                        TargetId = 5,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 117,
                        BusinessId = 2,
                        Count = 1550,
                        EffectType = "Profit",
                        Effect = 9,
                        TargetId = 6,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 118,
                        BusinessId = 2,
                        Count = 1600,
                        EffectType = "Profit",
                        Effect = 9,
                        TargetId = 7,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 119,
                        BusinessId = 2,
                        Count = 1650,
                        EffectType = "Profit",
                        Effect = 9,
                        TargetId = 8,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 120,
                        BusinessId = 2,
                        Count = 1700,
                        EffectType = "Profit",
                        Effect = 9,
                        TargetId = 9,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 121,
                        BusinessId = 2,
                        Count = 1750,
                        EffectType = "Profit",
                        Effect = 9,
                        TargetId = 10,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 122,
                        BusinessId = 2,
                        Count = 1800,
                        EffectType = "Profit",
                        Effect = 10,
                        TargetId = 6,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 123,
                        BusinessId = 2,
                        Count = 1850,
                        EffectType = "Profit",
                        Effect = 10,
                        TargetId = 7,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 124,
                        BusinessId = 2,
                        Count = 1900,
                        EffectType = "Profit",
                        Effect = 10,
                        TargetId = 8,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 125,
                        BusinessId = 2,
                        Count = 1950,
                        EffectType = "Profit",
                        Effect = 10,
                        TargetId = 9,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 126,
                        BusinessId = 2,
                        Count = 2000,
                        EffectType = "Profit",
                        Effect = 7777,
                        TargetId = 2,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 127,
                        BusinessId = 2,
                        Count = 2100,
                        EffectType = "Profit",
                        Effect = 15,
                        TargetId = 3,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 128,
                        BusinessId = 2,
                        Count = 2200,
                        EffectType = "Profit",
                        Effect = 15,
                        TargetId = 4,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 129,
                        BusinessId = 2,
                        Count = 2300,
                        EffectType = "Profit",
                        Effect = 15,
                        TargetId = 5,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 130,
                        BusinessId = 2,
                        Count = 2400,
                        EffectType = "Profit",
                        Effect = 15,
                        TargetId = 6,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 131,
                        BusinessId = 2,
                        Count = 2500,
                        EffectType = "Profit",
                        Effect = 777,
                        TargetId = 2,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 132,
                        BusinessId = 2,
                        Count = 2600,
                        EffectType = "Profit",
                        Effect = 15,
                        TargetId = 8,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 133,
                        BusinessId = 2,
                        Count = 2700,
                        EffectType = "Profit",
                        Effect = 15,
                        TargetId = 9,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 134,
                        BusinessId = 2,
                        Count = 2800,
                        EffectType = "Profit",
                        Effect = 15,
                        TargetId = 10,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 135,
                        BusinessId = 2,
                        Count = 2900,
                        EffectType = "Profit",
                        Effect = 15,
                        TargetId = 1,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 136,
                        BusinessId = 2,
                        Count = 3000,
                        EffectType = "Profit",
                        Effect = 777,
                        TargetId = 2,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 137,
                        BusinessId = 2,
                        Count = 3100,
                        EffectType = "Profit",
                        Effect = 20,
                        TargetId = 3,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 138,
                        BusinessId = 2,
                        Count = 3200,
                        EffectType = "Profit",
                        Effect = 20,
                        TargetId = 7,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 139,
                        BusinessId = 2,
                        Count = 3300,
                        EffectType = "Profit",
                        Effect = 20,
                        TargetId = 9,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 140,
                        BusinessId = 2,
                        Count = 3400,
                        EffectType = "Profit",
                        Effect = 20,
                        TargetId = 10,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 141,
                        BusinessId = 2,
                        Count = 3500,
                        EffectType = "Profit",
                        Effect = 777,
                        TargetId = 2,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 142,
                        BusinessId = 2,
                        Count = 3600,
                        EffectType = "Profit",
                        Effect = 25,
                        TargetId = 7,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 143,
                        BusinessId = 2,
                        Count = 3700,
                        EffectType = "Profit",
                        Effect = 25,
                        TargetId = 8,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 144,
                        BusinessId = 2,
                        Count = 3800,
                        EffectType = "Profit",
                        Effect = 25,
                        TargetId = 9,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 145,
                        BusinessId = 2,
                        Count = 3900,
                        EffectType = "Profit",
                        Effect = 25,
                        TargetId = 10,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 146,
                        BusinessId = 2,
                        Count = 4000,
                        EffectType = "Profit",
                        Effect = 30,
                        TargetId = 2,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 147,
                        BusinessId = 2,
                        Count = 4100,
                        EffectType = "Profit",
                        Effect = 30,
                        TargetId = 1,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 148,
                        BusinessId = 2,
                        Count = 4200,
                        EffectType = "Profit",
                        Effect = 30,
                        TargetId = 3,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 149,
                        BusinessId = 2,
                        Count = 4300,
                        EffectType = "Profit",
                        Effect = 30,
                        TargetId = 4,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 150,
                        BusinessId = 2,
                        Count = 4400,
                        EffectType = "Profit",
                        Effect = 30,
                        TargetId = 5,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 151,
                        BusinessId = 2,
                        Count = 4500,
                        EffectType = "Profit",
                        Effect = 30,
                        TargetId = 6,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 152,
                        BusinessId = 2,
                        Count = 4600,
                        EffectType = "Profit",
                        Effect = 30,
                        TargetId = 7,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 153,
                        BusinessId = 2,
                        Count = 4700,
                        EffectType = "Profit",
                        Effect = 30,
                        TargetId = 8,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 154,
                        BusinessId = 2,
                        Count = 4800,
                        EffectType = "Profit",
                        Effect = 30,
                        TargetId = 9,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 155,
                        BusinessId = 2,
                        Count = 4900,
                        EffectType = "Profit",
                        Effect = 30,
                        TargetId = 10,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 156,
                        BusinessId = 2,
                        Count = 5000,
                        EffectType = "Profit",
                        Effect = 50,
                        TargetId = 2,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 157,
                        BusinessId = 2,
                        Count = 5100,
                        EffectType = "Profit",
                        Effect = 50,
                        TargetId = 2,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 158,
                        BusinessId = 2,
                        Count = 5200,
                        EffectType = "Profit",
                        Effect = 50,
                        TargetId = 2,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 159,
                        BusinessId = 2,
                        Count = 5300,
                        EffectType = "Profit",
                        Effect = 50,
                        TargetId = 2,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 160,
                        BusinessId = 2,
                        Count = 5400,
                        EffectType = "Profit",
                        Effect = 50,
                        TargetId = 2,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 161,
                        BusinessId = 3,
                        Count = 25,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 3,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 162,
                        BusinessId = 3,
                        Count = 50,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 3,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 163,
                        BusinessId = 3,
                        Count = 100,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 3,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 164,
                        BusinessId = 3,
                        Count = 200,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 3,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 165,
                        BusinessId = 3,
                        Count = 300,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 3,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 166,
                        BusinessId = 3,
                        Count = 400,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 3,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 167,
                        BusinessId = 3,
                        Count = 500,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 3,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 168,
                        BusinessId = 3,
                        Count = 600,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 3,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 169,
                        BusinessId = 3,
                        Count = 700,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 3,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 170,
                        BusinessId = 3,
                        Count = 800,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 3,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 171,
                        BusinessId = 3,
                        Count = 900,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 3,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 172,
                        BusinessId = 3,
                        Count = 1000,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 3,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 173,
                        BusinessId = 3,
                        Count = 1100,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 3,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 174,
                        BusinessId = 3,
                        Count = 1200,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 3,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 175,
                        BusinessId = 3,
                        Count = 1300,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 3,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 176,
                        BusinessId = 3,
                        Count = 1400,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 3,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 177,
                        BusinessId = 3,
                        Count = 1500,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 3,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 178,
                        BusinessId = 3,
                        Count = 1600,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 3,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 179,
                        BusinessId = 3,
                        Count = 1700,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 3,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 180,
                        BusinessId = 3,
                        Count = 1800,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 3,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 181,
                        BusinessId = 3,
                        Count = 1900,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 3,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 182,
                        BusinessId = 3,
                        Count = 2000,
                        EffectType = "Profit",
                        Effect = 5,
                        TargetId = 3,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 183,
                        BusinessId = 3,
                        Count = 2100,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 3,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 184,
                        BusinessId = 3,
                        Count = 2200,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 3,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 185,
                        BusinessId = 3,
                        Count = 2300,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 3,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 186,
                        BusinessId = 3,
                        Count = 2400,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 3,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 187,
                        BusinessId = 3,
                        Count = 2500,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 3,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 188,
                        BusinessId = 3,
                        Count = 2600,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 3,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 189,
                        BusinessId = 3,
                        Count = 2700,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 3,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 190,
                        BusinessId = 3,
                        Count = 2800,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 3,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 191,
                        BusinessId = 3,
                        Count = 2900,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 3,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 192,
                        BusinessId = 3,
                        Count = 3000,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 3,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 193,
                        BusinessId = 3,
                        Count = 3100,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 3,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 194,
                        BusinessId = 3,
                        Count = 3200,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 3,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 195,
                        BusinessId = 3,
                        Count = 3300,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 3,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 196,
                        BusinessId = 3,
                        Count = 3400,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 3,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 197,
                        BusinessId = 3,
                        Count = 3500,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 3,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 198,
                        BusinessId = 3,
                        Count = 3600,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 3,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 199,
                        BusinessId = 3,
                        Count = 3700,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 3,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 200,
                        BusinessId = 3,
                        Count = 3800,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 3,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 201,
                        BusinessId = 3,
                        Count = 3900,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 3,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 202,
                        BusinessId = 3,
                        Count = 4000,
                        EffectType = "Profit",
                        Effect = 5,
                        TargetId = 3,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 203,
                        BusinessId = 3,
                        Count = 4100,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 3,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 204,
                        BusinessId = 3,
                        Count = 4200,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 3,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 205,
                        BusinessId = 3,
                        Count = 4300,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 3,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 206,
                        BusinessId = 3,
                        Count = 4400,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 3,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 207,
                        BusinessId = 3,
                        Count = 4500,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 3,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 208,
                        BusinessId = 3,
                        Count = 4600,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 3,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 209,
                        BusinessId = 3,
                        Count = 4700,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 3,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 210,
                        BusinessId = 3,
                        Count = 4800,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 3,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 211,
                        BusinessId = 3,
                        Count = 4900,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 3,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 212,
                        BusinessId = 3,
                        Count = 5000,
                        EffectType = "Profit",
                        Effect = 5,
                        TargetId = 3,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 213,
                        BusinessId = 3,
                        Count = 5250,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 3,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 214,
                        BusinessId = 3,
                        Count = 5500,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 3,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 215,
                        BusinessId = 4,
                        Count = 25,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 4,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 216,
                        BusinessId = 4,
                        Count = 50,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 4,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 217,
                        BusinessId = 4,
                        Count = 100,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 4,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 218,
                        BusinessId = 4,
                        Count = 200,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 4,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 219,
                        BusinessId = 4,
                        Count = 300,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 4,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 220,
                        BusinessId = 4,
                        Count = 400,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 4,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 221,
                        BusinessId = 4,
                        Count = 500,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 4,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 222,
                        BusinessId = 4,
                        Count = 600,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 4,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 223,
                        BusinessId = 4,
                        Count = 700,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 4,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 224,
                        BusinessId = 4,
                        Count = 800,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 4,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 225,
                        BusinessId = 4,
                        Count = 900,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 4,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 226,
                        BusinessId = 4,
                        Count = 1000,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 4,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 227,
                        BusinessId = 4,
                        Count = 1100,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 4,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 228,
                        BusinessId = 4,
                        Count = 1200,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 4,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 229,
                        BusinessId = 4,
                        Count = 1300,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 4,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 230,
                        BusinessId = 4,
                        Count = 1400,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 4,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 231,
                        BusinessId = 4,
                        Count = 1500,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 4,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 232,
                        BusinessId = 4,
                        Count = 1600,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 4,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 233,
                        BusinessId = 4,
                        Count = 1700,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 4,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 234,
                        BusinessId = 4,
                        Count = 1800,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 4,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 235,
                        BusinessId = 4,
                        Count = 1900,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 4,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 236,
                        BusinessId = 4,
                        Count = 2000,
                        EffectType = "Profit",
                        Effect = 5,
                        TargetId = 4,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 237,
                        BusinessId = 4,
                        Count = 2100,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 4,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 238,
                        BusinessId = 4,
                        Count = 2200,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 4,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 239,
                        BusinessId = 4,
                        Count = 2300,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 4,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 240,
                        BusinessId = 4,
                        Count = 2400,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 4,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 241,
                        BusinessId = 4,
                        Count = 2500,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 4,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 242,
                        BusinessId = 4,
                        Count = 2600,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 4,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 243,
                        BusinessId = 4,
                        Count = 2700,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 4,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 244,
                        BusinessId = 4,
                        Count = 2800,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 4,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 245,
                        BusinessId = 4,
                        Count = 2900,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 4,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 246,
                        BusinessId = 4,
                        Count = 3000,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 4,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 247,
                        BusinessId = 4,
                        Count = 3100,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 4,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 248,
                        BusinessId = 4,
                        Count = 3200,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 4,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 249,
                        BusinessId = 4,
                        Count = 3300,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 4,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 250,
                        BusinessId = 4,
                        Count = 3400,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 4,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 251,
                        BusinessId = 4,
                        Count = 3500,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 4,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 252,
                        BusinessId = 4,
                        Count = 3600,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 4,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 253,
                        BusinessId = 4,
                        Count = 3700,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 4,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 254,
                        BusinessId = 4,
                        Count = 3800,
                        EffectType = "Profit",
                        Effect = 5,
                        TargetId = 4,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 255,
                        BusinessId = 4,
                        Count = 3900,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 4,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 256,
                        BusinessId = 4,
                        Count = 4000,
                        EffectType = "Profit",
                        Effect = 5,
                        TargetId = 4,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 257,
                        BusinessId = 4,
                        Count = 4100,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 4,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 258,
                        BusinessId = 4,
                        Count = 4200,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 4,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 259,
                        BusinessId = 4,
                        Count = 4300,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 4,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 260,
                        BusinessId = 4,
                        Count = 4400,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 4,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 261,
                        BusinessId = 4,
                        Count = 4500,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 4,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 262,
                        BusinessId = 4,
                        Count = 4600,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 4,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 263,
                        BusinessId = 4,
                        Count = 4700,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 4,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 264,
                        BusinessId = 4,
                        Count = 4800,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 4,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 265,
                        BusinessId = 4,
                        Count = 4900,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 4,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 266,
                        BusinessId = 4,
                        Count = 5000,
                        EffectType = "Profit",
                        Effect = 5,
                        TargetId = 4,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 267,
                        BusinessId = 4,
                        Count = 5250,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 4,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 268,
                        BusinessId = 4,
                        Count = 5500,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 4,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 269,
                        BusinessId = 4,
                        Count = 5750,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 4,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 270,
                        BusinessId = 5,
                        Count = 25,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 5,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 271,
                        BusinessId = 5,
                        Count = 50,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 5,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 272,
                        BusinessId = 5,
                        Count = 100,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 5,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 273,
                        BusinessId = 5,
                        Count = 200,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 5,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 274,
                        BusinessId = 5,
                        Count = 300,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 5,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 275,
                        BusinessId = 5,
                        Count = 400,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 5,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 276,
                        BusinessId = 5,
                        Count = 500,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 5,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 277,
                        BusinessId = 5,
                        Count = 600,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 5,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 278,
                        BusinessId = 5,
                        Count = 700,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 5,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 279,
                        BusinessId = 5,
                        Count = 800,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 5,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 280,
                        BusinessId = 5,
                        Count = 900,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 5,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 281,
                        BusinessId = 5,
                        Count = 1000,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 5,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 282,
                        BusinessId = 5,
                        Count = 1100,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 5,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 283,
                        BusinessId = 5,
                        Count = 1200,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 5,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 284,
                        BusinessId = 5,
                        Count = 1300,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 5,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 285,
                        BusinessId = 5,
                        Count = 1400,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 5,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 286,
                        BusinessId = 5,
                        Count = 1500,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 5,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 287,
                        BusinessId = 5,
                        Count = 1600,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 5,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 288,
                        BusinessId = 5,
                        Count = 1700,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 5,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 289,
                        BusinessId = 5,
                        Count = 1800,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 5,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 290,
                        BusinessId = 5,
                        Count = 1900,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 5,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 291,
                        BusinessId = 5,
                        Count = 2000,
                        EffectType = "Profit",
                        Effect = 5,
                        TargetId = 5,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 292,
                        BusinessId = 5,
                        Count = 2100,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 5,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 293,
                        BusinessId = 5,
                        Count = 2200,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 5,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 294,
                        BusinessId = 5,
                        Count = 2300,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 5,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 295,
                        BusinessId = 5,
                        Count = 2400,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 5,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 296,
                        BusinessId = 5,
                        Count = 2500,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 5,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 297,
                        BusinessId = 5,
                        Count = 2600,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 5,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 298,
                        BusinessId = 5,
                        Count = 2700,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 5,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 299,
                        BusinessId = 5,
                        Count = 2800,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 5,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 300,
                        BusinessId = 5,
                        Count = 2900,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 5,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 301,
                        BusinessId = 5,
                        Count = 3000,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 5,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 302,
                        BusinessId = 5,
                        Count = 3100,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 5,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 303,
                        BusinessId = 5,
                        Count = 3200,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 5,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 304,
                        BusinessId = 5,
                        Count = 3300,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 5,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 305,
                        BusinessId = 5,
                        Count = 3400,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 5,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 306,
                        BusinessId = 5,
                        Count = 3500,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 5,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 307,
                        BusinessId = 5,
                        Count = 3600,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 5,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 308,
                        BusinessId = 5,
                        Count = 3700,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 5,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 309,
                        BusinessId = 5,
                        Count = 3800,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 5,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 310,
                        BusinessId = 5,
                        Count = 3900,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 5,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 311,
                        BusinessId = 5,
                        Count = 4000,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 5,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 312,
                        BusinessId = 5,
                        Count = 4100,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 5,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 313,
                        BusinessId = 5,
                        Count = 4200,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 5,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 314,
                        BusinessId = 5,
                        Count = 4300,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 5,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 315,
                        BusinessId = 5,
                        Count = 4400,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 5,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 316,
                        BusinessId = 5,
                        Count = 4500,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 5,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 317,
                        BusinessId = 5,
                        Count = 4750,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 5,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 318,
                        BusinessId = 5,
                        Count = 5000,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 5,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 319,
                        BusinessId = 5,
                        Count = 5250,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 5,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 320,
                        BusinessId = 5,
                        Count = 5500,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 5,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 321,
                        BusinessId = 5,
                        Count = 5750,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 5,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 322,
                        BusinessId = 5,
                        Count = 6000,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 5,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 323,
                        BusinessId = 5,
                        Count = 6250,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 5,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 324,
                        BusinessId = 6,
                        Count = 25,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 6,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 325,
                        BusinessId = 6,
                        Count = 50,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 6,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 326,
                        BusinessId = 6,
                        Count = 100,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 6,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 327,
                        BusinessId = 6,
                        Count = 200,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 6,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 328,
                        BusinessId = 6,
                        Count = 300,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 6,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 329,
                        BusinessId = 6,
                        Count = 400,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 6,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 330,
                        BusinessId = 6,
                        Count = 500,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 6,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 331,
                        BusinessId = 6,
                        Count = 600,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 6,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 332,
                        BusinessId = 6,
                        Count = 700,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 6,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 333,
                        BusinessId = 6,
                        Count = 800,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 6,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 334,
                        BusinessId = 6,
                        Count = 900,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 6,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 335,
                        BusinessId = 6,
                        Count = 1000,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 6,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 336,
                        BusinessId = 6,
                        Count = 1100,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 6,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 337,
                        BusinessId = 6,
                        Count = 1200,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 6,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 338,
                        BusinessId = 6,
                        Count = 1300,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 6,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 339,
                        BusinessId = 6,
                        Count = 1400,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 6,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 340,
                        BusinessId = 6,
                        Count = 1500,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 6,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 341,
                        BusinessId = 6,
                        Count = 1600,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 6,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 342,
                        BusinessId = 6,
                        Count = 1700,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 6,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 343,
                        BusinessId = 6,
                        Count = 1800,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 6,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 344,
                        BusinessId = 6,
                        Count = 1900,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 6,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 345,
                        BusinessId = 6,
                        Count = 2000,
                        EffectType = "Profit",
                        Effect = 5,
                        TargetId = 6,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 346,
                        BusinessId = 6,
                        Count = 2100,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 6,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 347,
                        BusinessId = 6,
                        Count = 2200,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 6,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 348,
                        BusinessId = 6,
                        Count = 2300,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 6,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 349,
                        BusinessId = 6,
                        Count = 2400,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 6,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 350,
                        BusinessId = 6,
                        Count = 2500,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 6,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 351,
                        BusinessId = 6,
                        Count = 2600,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 6,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 352,
                        BusinessId = 6,
                        Count = 2700,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 6,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 353,
                        BusinessId = 6,
                        Count = 2800,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 6,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 354,
                        BusinessId = 6,
                        Count = 2900,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 6,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 355,
                        BusinessId = 6,
                        Count = 3000,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 6,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 356,
                        BusinessId = 6,
                        Count = 3250,
                        EffectType = "Profit",
                        Effect = 5,
                        TargetId = 6,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 357,
                        BusinessId = 6,
                        Count = 3500,
                        EffectType = "Profit",
                        Effect = 5,
                        TargetId = 6,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 358,
                        BusinessId = 6,
                        Count = 3750,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 6,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 359,
                        BusinessId = 6,
                        Count = 4000,
                        EffectType = "Profit",
                        Effect = 5,
                        TargetId = 6,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 360,
                        BusinessId = 6,
                        Count = 4250,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 6,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 361,
                        BusinessId = 6,
                        Count = 4500,
                        EffectType = "Profit",
                        Effect = 5,
                        TargetId = 6,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 362,
                        BusinessId = 6,
                        Count = 4750,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 6,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 363,
                        BusinessId = 6,
                        Count = 5000,
                        EffectType = "Profit",
                        Effect = 5,
                        TargetId = 6,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 364,
                        BusinessId = 6,
                        Count = 5250,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 6,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 365,
                        BusinessId = 6,
                        Count = 5500,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 6,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 366,
                        BusinessId = 6,
                        Count = 5750,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 6,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 367,
                        BusinessId = 6,
                        Count = 6000,
                        EffectType = "Profit",
                        Effect = 5,
                        TargetId = 6,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 368,
                        BusinessId = 6,
                        Count = 6250,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 6,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 369,
                        BusinessId = 6,
                        Count = 6500,
                        EffectType = "Profit",
                        Effect = 5,
                        TargetId = 6,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 370,
                        BusinessId = 7,
                        Count = 25,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 7,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 371,
                        BusinessId = 7,
                        Count = 50,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 7,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 372,
                        BusinessId = 7,
                        Count = 100,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 7,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 373,
                        BusinessId = 7,
                        Count = 200,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 7,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 374,
                        BusinessId = 7,
                        Count = 300,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 7,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 375,
                        BusinessId = 7,
                        Count = 400,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 7,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 376,
                        BusinessId = 7,
                        Count = 500,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 7,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 377,
                        BusinessId = 7,
                        Count = 600,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 7,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 378,
                        BusinessId = 7,
                        Count = 700,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 7,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 379,
                        BusinessId = 7,
                        Count = 800,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 7,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 380,
                        BusinessId = 7,
                        Count = 900,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 7,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 381,
                        BusinessId = 7,
                        Count = 1000,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 7,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 382,
                        BusinessId = 7,
                        Count = 1100,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 7,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 383,
                        BusinessId = 7,
                        Count = 1200,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 7,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 384,
                        BusinessId = 7,
                        Count = 1300,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 7,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 385,
                        BusinessId = 7,
                        Count = 1400,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 7,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 386,
                        BusinessId = 7,
                        Count = 1500,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 7,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 387,
                        BusinessId = 7,
                        Count = 1600,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 7,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 388,
                        BusinessId = 7,
                        Count = 1700,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 7,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 389,
                        BusinessId = 7,
                        Count = 1800,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 7,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 390,
                        BusinessId = 7,
                        Count = 1900,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 7,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 391,
                        BusinessId = 7,
                        Count = 2000,
                        EffectType = "Profit",
                        Effect = 5,
                        TargetId = 7,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 392,
                        BusinessId = 7,
                        Count = 2100,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 7,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 393,
                        BusinessId = 7,
                        Count = 2200,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 7,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 394,
                        BusinessId = 7,
                        Count = 2300,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 7,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 395,
                        BusinessId = 7,
                        Count = 2400,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 7,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 396,
                        BusinessId = 7,
                        Count = 2500,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 7,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 397,
                        BusinessId = 7,
                        Count = 2600,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 7,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 398,
                        BusinessId = 7,
                        Count = 2700,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 7,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 399,
                        BusinessId = 7,
                        Count = 2800,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 7,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 400,
                        BusinessId = 7,
                        Count = 2900,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 7,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 401,
                        BusinessId = 7,
                        Count = 3000,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 7,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 402,
                        BusinessId = 7,
                        Count = 3250,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 7,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 403,
                        BusinessId = 7,
                        Count = 3500,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 7,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 404,
                        BusinessId = 7,
                        Count = 3750,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 7,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 405,
                        BusinessId = 7,
                        Count = 4000,
                        EffectType = "Profit",
                        Effect = 5,
                        TargetId = 7,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 406,
                        BusinessId = 7,
                        Count = 4250,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 7,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 407,
                        BusinessId = 7,
                        Count = 4500,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 7,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 408,
                        BusinessId = 7,
                        Count = 4750,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 7,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 409,
                        BusinessId = 7,
                        Count = 5000,
                        EffectType = "Profit",
                        Effect = 7,
                        TargetId = 7,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 410,
                        BusinessId = 7,
                        Count = 5250,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 7,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 411,
                        BusinessId = 7,
                        Count = 5500,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 7,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 412,
                        BusinessId = 7,
                        Count = 5750,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 7,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 413,
                        BusinessId = 7,
                        Count = 6000,
                        EffectType = "Profit",
                        Effect = 7,
                        TargetId = 7,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 414,
                        BusinessId = 7,
                        Count = 6250,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 7,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 415,
                        BusinessId = 7,
                        Count = 6500,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 7,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 416,
                        BusinessId = 7,
                        Count = 6750,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 7,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 417,
                        BusinessId = 7,
                        Count = 7000,
                        EffectType = "Profit",
                        Effect = 7,
                        TargetId = 7,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 418,
                        BusinessId = 8,
                        Count = 25,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 8,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 419,
                        BusinessId = 8,
                        Count = 50,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 8,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 420,
                        BusinessId = 8,
                        Count = 100,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 8,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 421,
                        BusinessId = 8,
                        Count = 200,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 8,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 422,
                        BusinessId = 8,
                        Count = 300,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 8,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 423,
                        BusinessId = 8,
                        Count = 400,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 8,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 424,
                        BusinessId = 8,
                        Count = 500,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 8,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 425,
                        BusinessId = 8,
                        Count = 600,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 8,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 426,
                        BusinessId = 8,
                        Count = 700,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 8,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 427,
                        BusinessId = 8,
                        Count = 800,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 8,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 428,
                        BusinessId = 8,
                        Count = 900,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 8,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 429,
                        BusinessId = 8,
                        Count = 1000,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 8,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 430,
                        BusinessId = 8,
                        Count = 1100,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 8,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 431,
                        BusinessId = 8,
                        Count = 1200,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 8,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 432,
                        BusinessId = 8,
                        Count = 1300,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 8,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 433,
                        BusinessId = 8,
                        Count = 1400,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 8,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 434,
                        BusinessId = 8,
                        Count = 1500,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 8,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 435,
                        BusinessId = 8,
                        Count = 1600,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 8,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 436,
                        BusinessId = 8,
                        Count = 1700,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 8,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 437,
                        BusinessId = 8,
                        Count = 1800,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 8,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 438,
                        BusinessId = 8,
                        Count = 1900,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 8,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 439,
                        BusinessId = 8,
                        Count = 2000,
                        EffectType = "Profit",
                        Effect = 5,
                        TargetId = 8,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 440,
                        BusinessId = 8,
                        Count = 2100,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 8,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 441,
                        BusinessId = 8,
                        Count = 2200,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 8,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 442,
                        BusinessId = 8,
                        Count = 2300,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 8,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 443,
                        BusinessId = 8,
                        Count = 2400,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 8,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 444,
                        BusinessId = 8,
                        Count = 2500,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 8,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 445,
                        BusinessId = 8,
                        Count = 2600,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 8,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 446,
                        BusinessId = 8,
                        Count = 2700,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 8,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 447,
                        BusinessId = 8,
                        Count = 2800,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 8,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 448,
                        BusinessId = 8,
                        Count = 2900,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 8,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 449,
                        BusinessId = 8,
                        Count = 3000,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 8,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 450,
                        BusinessId = 8,
                        Count = 3250,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 8,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 451,
                        BusinessId = 8,
                        Count = 3500,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 8,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 452,
                        BusinessId = 8,
                        Count = 3750,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 8,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 453,
                        BusinessId = 8,
                        Count = 4000,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 8,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 454,
                        BusinessId = 8,
                        Count = 4250,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 8,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 455,
                        BusinessId = 8,
                        Count = 4500,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 8,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 456,
                        BusinessId = 8,
                        Count = 4750,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 8,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 457,
                        BusinessId = 8,
                        Count = 5000,
                        EffectType = "Profit",
                        Effect = 5,
                        TargetId = 8,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 458,
                        BusinessId = 8,
                        Count = 5250,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 8,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 459,
                        BusinessId = 8,
                        Count = 5500,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 8,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 460,
                        BusinessId = 8,
                        Count = 5750,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 8,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 461,
                        BusinessId = 8,
                        Count = 6000,
                        EffectType = "Profit",
                        Effect = 9,
                        TargetId = 8,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 462,
                        BusinessId = 8,
                        Count = 6250,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 8,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 463,
                        BusinessId = 8,
                        Count = 6500,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 8,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 464,
                        BusinessId = 8,
                        Count = 6750,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 8,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 465,
                        BusinessId = 8,
                        Count = 7000,
                        EffectType = "Profit",
                        Effect = 9,
                        TargetId = 8,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 466,
                        BusinessId = 8,
                        Count = 7250,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 8,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 467,
                        BusinessId = 8,
                        Count = 7500,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 8,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 468,
                        BusinessId = 8,
                        Count = 7750,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 8,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 469,
                        BusinessId = 9,
                        Count = 25,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 9,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 470,
                        BusinessId = 9,
                        Count = 50,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 9,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 471,
                        BusinessId = 9,
                        Count = 100,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 9,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 472,
                        BusinessId = 9,
                        Count = 200,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 9,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 473,
                        BusinessId = 9,
                        Count = 300,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 9,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 474,
                        BusinessId = 9,
                        Count = 400,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 9,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 475,
                        BusinessId = 9,
                        Count = 500,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 9,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 476,
                        BusinessId = 9,
                        Count = 600,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 9,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 477,
                        BusinessId = 9,
                        Count = 700,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 9,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 478,
                        BusinessId = 9,
                        Count = 800,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 9,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 479,
                        BusinessId = 9,
                        Count = 900,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 9,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 480,
                        BusinessId = 9,
                        Count = 1000,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 9,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 481,
                        BusinessId = 9,
                        Count = 1100,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 9,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 482,
                        BusinessId = 9,
                        Count = 1200,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 9,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 483,
                        BusinessId = 9,
                        Count = 1300,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 9,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 484,
                        BusinessId = 9,
                        Count = 1400,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 9,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 485,
                        BusinessId = 9,
                        Count = 1500,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 9,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 486,
                        BusinessId = 9,
                        Count = 1600,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 9,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 487,
                        BusinessId = 9,
                        Count = 1700,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 9,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 488,
                        BusinessId = 9,
                        Count = 1800,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 9,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 489,
                        BusinessId = 9,
                        Count = 1900,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 9,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 490,
                        BusinessId = 9,
                        Count = 2000,
                        EffectType = "Profit",
                        Effect = 5,
                        TargetId = 9,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 491,
                        BusinessId = 9,
                        Count = 2250,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 9,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 492,
                        BusinessId = 9,
                        Count = 2500,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 9,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 493,
                        BusinessId = 9,
                        Count = 2750,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 9,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 494,
                        BusinessId = 9,
                        Count = 3000,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 9,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 495,
                        BusinessId = 9,
                        Count = 3250,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 9,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 496,
                        BusinessId = 9,
                        Count = 3500,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 9,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 497,
                        BusinessId = 9,
                        Count = 3750,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 9,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 498,
                        BusinessId = 9,
                        Count = 4000,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 9,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 499,
                        BusinessId = 9,
                        Count = 4250,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 9,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 500,
                        BusinessId = 9,
                        Count = 4500,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 9,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 501,
                        BusinessId = 9,
                        Count = 4750,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 9,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 502,
                        BusinessId = 9,
                        Count = 5000,
                        EffectType = "Profit",
                        Effect = 5,
                        TargetId = 9,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 503,
                        BusinessId = 9,
                        Count = 5250,
                        EffectType = "Profit",
                        Effect = 5,
                        TargetId = 9,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 504,
                        BusinessId = 9,
                        Count = 5500,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 9,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 505,
                        BusinessId = 9,
                        Count = 5750,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 9,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 506,
                        BusinessId = 9,
                        Count = 6000,
                        EffectType = "Profit",
                        Effect = 5,
                        TargetId = 9,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 507,
                        BusinessId = 9,
                        Count = 6250,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 9,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 508,
                        BusinessId = 9,
                        Count = 6500,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 9,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 509,
                        BusinessId = 9,
                        Count = 6750,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 9,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 510,
                        BusinessId = 9,
                        Count = 7000,
                        EffectType = "Profit",
                        Effect = 5,
                        TargetId = 9,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 511,
                        BusinessId = 9,
                        Count = 7250,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 9,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 512,
                        BusinessId = 9,
                        Count = 7500,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 9,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 513,
                        BusinessId = 9,
                        Count = 7750,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 9,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 514,
                        BusinessId = 9,
                        Count = 8000,
                        EffectType = "Profit",
                        Effect = 5,
                        TargetId = 9,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 515,
                        BusinessId = 9,
                        Count = 8250,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 9,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 516,
                        BusinessId = 9,
                        Count = 8500,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 9,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 517,
                        BusinessId = 10,
                        Count = 25,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 10,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 518,
                        BusinessId = 10,
                        Count = 50,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 10,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 519,
                        BusinessId = 10,
                        Count = 100,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 10,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 520,
                        BusinessId = 10,
                        Count = 200,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 10,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 521,
                        BusinessId = 10,
                        Count = 300,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 10,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 522,
                        BusinessId = 10,
                        Count = 400,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 10,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 523,
                        BusinessId = 10,
                        Count = 500,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 10,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 524,
                        BusinessId = 10,
                        Count = 600,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 10,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 525,
                        BusinessId = 10,
                        Count = 700,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 10,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 526,
                        BusinessId = 10,
                        Count = 800,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 10,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 527,
                        BusinessId = 10,
                        Count = 900,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 10,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 528,
                        BusinessId = 10,
                        Count = 1000,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 10,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 529,
                        BusinessId = 10,
                        Count = 1100,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 10,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 530,
                        BusinessId = 10,
                        Count = 1200,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 10,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 531,
                        BusinessId = 10,
                        Count = 1300,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 10,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 532,
                        BusinessId = 10,
                        Count = 1400,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 10,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 533,
                        BusinessId = 10,
                        Count = 1500,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 10,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 534,
                        BusinessId = 10,
                        Count = 1600,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 10,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 535,
                        BusinessId = 10,
                        Count = 1700,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 10,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 536,
                        BusinessId = 10,
                        Count = 1800,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 10,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 537,
                        BusinessId = 10,
                        Count = 1900,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 10,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 538,
                        BusinessId = 10,
                        Count = 2000,
                        EffectType = "Profit",
                        Effect = 5,
                        TargetId = 10,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 539,
                        BusinessId = 10,
                        Count = 2250,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 10,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 540,
                        BusinessId = 10,
                        Count = 2500,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 10,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 541,
                        BusinessId = 10,
                        Count = 2750,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 10,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 542,
                        BusinessId = 10,
                        Count = 3000,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 10,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 543,
                        BusinessId = 10,
                        Count = 3250,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 10,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 544,
                        BusinessId = 10,
                        Count = 3500,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 10,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 545,
                        BusinessId = 10,
                        Count = 3750,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 10,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 546,
                        BusinessId = 10,
                        Count = 4000,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 10,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 547,
                        BusinessId = 10,
                        Count = 4250,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 10,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 548,
                        BusinessId = 10,
                        Count = 4500,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 10,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 549,
                        BusinessId = 10,
                        Count = 4750,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 10,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 550,
                        BusinessId = 10,
                        Count = 5000,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 10,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 551,
                        BusinessId = 10,
                        Count = 5250,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 10,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 552,
                        BusinessId = 10,
                        Count = 5500,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 10,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 553,
                        BusinessId = 10,
                        Count = 5750,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 10,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 554,
                        BusinessId = 10,
                        Count = 6000,
                        EffectType = "Profit",
                        Effect = 5,
                        TargetId = 10,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 555,
                        BusinessId = 10,
                        Count = 6250,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 10,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 556,
                        BusinessId = 10,
                        Count = 6500,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 10,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 557,
                        BusinessId = 10,
                        Count = 6750,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 10,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 558,
                        BusinessId = 10,
                        Count = 7000,
                        EffectType = "Profit",
                        Effect = 7,
                        TargetId = 10,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 559,
                        BusinessId = 10,
                        Count = 7250,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 10,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 560,
                        BusinessId = 10,
                        Count = 7500,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 10,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 561,
                        BusinessId = 10,
                        Count = 7750,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 10,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 562,
                        BusinessId = 10,
                        Count = 8000,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 10,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 563,
                        BusinessId = 10,
                        Count = 8250,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 10,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 564,
                        BusinessId = 10,
                        Count = 8500,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 10,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 565,
                        BusinessId = 10,
                        Count = 8750,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 10,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 566,
                        BusinessId = 10,
                        Count = 9000,
                        EffectType = "Profit",
                        Effect = 7,
                        TargetId = 10,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 567,
                        BusinessId = 10,
                        Count = 9250,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 10,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 568,
                        BusinessId = 10,
                        Count = 9500,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 10,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 569,
                        BusinessId = 10,
                        Count = 9750,
                        EffectType = "Profit",
                        Effect = 3,
                        TargetId = 10,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 570,
                        BusinessId = 0,
                        Count = 1,
                        EffectType = "Gold",
                        Effect = 5,
                        TargetId = 0,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 571,
                        BusinessId = 0,
                        Count = 25,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 0,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 572,
                        BusinessId = 0,
                        Count = 50,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 0,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 573,
                        BusinessId = 0,
                        Count = 50,
                        EffectType = "Luck",
                        Effect = 0,
                        TargetId = 0,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 574,
                        BusinessId = 0,
                        Count = 100,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 0,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 575,
                        BusinessId = 0,
                        Count = 100,
                        EffectType = "Gold",
                        Effect = 5,
                        TargetId = 0,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 576,
                        BusinessId = 0,
                        Count = 200,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 0,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 577,
                        BusinessId = 0,
                        Count = 200,
                        EffectType = "Luck",
                        Effect = 0,
                        TargetId = 0,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 578,
                        BusinessId = 0,
                        Count = 300,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 0,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 579,
                        BusinessId = 0,
                        Count = 400,
                        EffectType = "Speed",
                        Effect = 0.5,
                        TargetId = 0,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 580,
                        BusinessId = 0,
                        Count = 400,
                        EffectType = "Luck",
                        Effect = 0,
                        TargetId = 0,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 581,
                        BusinessId = 0,
                        Count = 500,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 0,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 582,
                        BusinessId = 0,
                        Count = 500,
                        EffectType = "Gold",
                        Effect = 10,
                        TargetId = 0,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 583,
                        BusinessId = 0,
                        Count = 600,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 0,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 584,
                        BusinessId = 0,
                        Count = 666,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 0,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 585,
                        BusinessId = 0,
                        Count = 700,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 0,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 586,
                        BusinessId = 0,
                        Count = 777,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 0,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 587,
                        BusinessId = 0,
                        Count = 777,
                        EffectType = "Luck",
                        Effect = 0,
                        TargetId = 0,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 588,
                        BusinessId = 0,
                        Count = 800,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 0,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 589,
                        BusinessId = 0,
                        Count = 900,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 0,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 590,
                        BusinessId = 0,
                        Count = 1000,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 0,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 591,
                        BusinessId = 0,
                        Count = 1000,
                        EffectType = "Gold",
                        Effect = 15,
                        TargetId = 0,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 592,
                        BusinessId = 0,
                        Count = 1100,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 0,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 593,
                        BusinessId = 0,
                        Count = 1111,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 0,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 594,
                        BusinessId = 0,
                        Count = 1200,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 0,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 595,
                        BusinessId = 0,
                        Count = 1200,
                        EffectType = "Luck",
                        Effect = 0,
                        TargetId = 0,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 596,
                        BusinessId = 0,
                        Count = 1300,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 0,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 597,
                        BusinessId = 0,
                        Count = 1400,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 0,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 598,
                        BusinessId = 0,
                        Count = 1500,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 0,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 599,
                        BusinessId = 0,
                        Count = 1600,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 0,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 600,
                        BusinessId = 0,
                        Count = 1700,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 0,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 601,
                        BusinessId = 0,
                        Count = 1800,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 0,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 602,
                        BusinessId = 0,
                        Count = 1900,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 0,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 603,
                        BusinessId = 0,
                        Count = 2000,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 0,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 604,
                        BusinessId = 0,
                        Count = 2000,
                        EffectType = "Luck",
                        Effect = 0,
                        TargetId = 0,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 605,
                        BusinessId = 0,
                        Count = 2100,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 0,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 606,
                        BusinessId = 0,
                        Count = 2200,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 0,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 607,
                        BusinessId = 0,
                        Count = 2222,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 0,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 608,
                        BusinessId = 0,
                        Count = 2300,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 0,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 609,
                        BusinessId = 0,
                        Count = 2400,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 0,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 610,
                        BusinessId = 0,
                        Count = 2500,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 0,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 611,
                        BusinessId = 0,
                        Count = 2500,
                        EffectType = "Gold",
                        Effect = 20,
                        TargetId = 0,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 612,
                        BusinessId = 0,
                        Count = 2600,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 0,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 613,
                        BusinessId = 0,
                        Count = 2700,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 0,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 614,
                        BusinessId = 0,
                        Count = 2800,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 0,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 615,
                        BusinessId = 0,
                        Count = 2900,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 0,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 616,
                        BusinessId = 0,
                        Count = 3000,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 0,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 617,
                        BusinessId = 0,
                        Count = 3000,
                        EffectType = "Luck",
                        Effect = 0,
                        TargetId = 0,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 618,
                        BusinessId = 0,
                        Count = 3100,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 0,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 619,
                        BusinessId = 0,
                        Count = 3200,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 0,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 620,
                        BusinessId = 0,
                        Count = 3300,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 0,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 621,
                        BusinessId = 0,
                        Count = 3333,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 0,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 622,
                        BusinessId = 0,
                        Count = 3400,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 0,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 623,
                        BusinessId = 0,
                        Count = 3500,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 0,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 624,
                        BusinessId = 0,
                        Count = 3500,
                        EffectType = "Luck",
                        Effect = 0,
                        TargetId = 0,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 625,
                        BusinessId = 0,
                        Count = 3600,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 0,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 626,
                        BusinessId = 0,
                        Count = 3700,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 0,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 627,
                        BusinessId = 0,
                        Count = 3800,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 0,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 628,
                        BusinessId = 0,
                        Count = 3900,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 0,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 629,
                        BusinessId = 0,
                        Count = 4000,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 0,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 630,
                        BusinessId = 0,
                        Count = 4000,
                        EffectType = "Gold",
                        Effect = 30,
                        TargetId = 0,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 631,
                        BusinessId = 0,
                        Count = 4000,
                        EffectType = "Luck",
                        Effect = 0,
                        TargetId = 0,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 632,
                        BusinessId = 0,
                        Count = 4100,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 0,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 633,
                        BusinessId = 0,
                        Count = 4200,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 0,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 634,
                        BusinessId = 0,
                        Count = 4300,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 0,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 635,
                        BusinessId = 0,
                        Count = 4400,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 0,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 636,
                        BusinessId = 0,
                        Count = 4500,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 0,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 637,
                        BusinessId = 0,
                        Count = 4500,
                        EffectType = "Luck",
                        Effect = 0,
                        TargetId = 0,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 638,
                        BusinessId = 0,
                        Count = 4600,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 0,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 639,
                        BusinessId = 0,
                        Count = 4700,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 0,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 640,
                        BusinessId = 0,
                        Count = 4800,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 0,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 641,
                        BusinessId = 0,
                        Count = 4900,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 0,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 642,
                        BusinessId = 0,
                        Count = 5000,
                        EffectType = "Profit",
                        Effect = 2,
                        TargetId = 0,
                        Unlocked = false
                    },
                    new Milestone
                    {
                        Id = 643,
                        BusinessId = 0,
                        Count = 5000,
                        EffectType = "Gold",
                        Effect = 50,
                        TargetId = 0,
                        Unlocked = false
                    },
                }
        };
    }
}