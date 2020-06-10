using System.ComponentModel;

namespace VacancyManager.Enums
{
    public enum ScheduleEnum
    {
        /// <summary>
        /// Не указано
        /// </summary>
        [Description("Не указано")]
        Default,

        /// <summary>
        /// Полный день
        /// </summary>
        [Description("Полный день")]
        FullDay,

        /// <summary>
        /// Сменный график
        /// </summary>
        [Description("Сменный график")]
        Shift,

        /// <summary>
        /// Гибкий график
        /// </summary>
        [Description("Гибкий график")]
        Flexible,

        /// <summary>
        /// Удаленная работа
        /// </summary>
        [Description("Удаленная работа")]
        Remote,

        /// <summary>
        /// Вахтовый метод
        /// </summary>
        [Description("Вахтовый метод")]
        FlyInFlyOut
    }
}
