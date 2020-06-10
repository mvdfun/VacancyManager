using System.ComponentModel;

namespace VacancyManager.Enums
{
    public enum ExperienceEnum
    {
        /// <summary>
        /// Не указано
        /// </summary>
        [Description("Не указано")]
        Default,

        /// <summary>
        /// Без опыта
        /// </summary>
        [Description("Без опыта")]
        NoExperience,

        /// <summary>
        /// От 1 года до 3 лет
        /// </summary>
        [Description("От 1 года до 3 лет")]
        Between1And3,

        /// <summary>
        /// От 3 до 6 лет
        /// </summary>
        [Description("От 3 до 6 лет")]
        Between3And6,

        /// <summary>
        /// Более 6 лет
        /// </summary>
        [Description("Более 6 лет")]
        MoreThan6
    }
}
