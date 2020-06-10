using System.ComponentModel;

namespace VacancyManager.Enums
{
    public enum GenderEnum 
    {
        /// <summary>
        /// Не указано
        /// </summary>
        [Description("Не указано")]
        Default,

        /// <summary>
        /// Женский
        /// </summary>
        [Description("Женский")]
        Female,

        /// <summary>
        /// Мужской
        /// </summary>
        [Description("Мужской")]
        Male
    }
}
