using VacancyManager.Enums;

namespace VacancyManager.Models
{
    /// <summary>
    /// Модель запроса вакансии
    /// </summary>
    public class Vacancy : BaseModel
    {
        /// <summary>
        /// Текст запроса
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Пол
        /// </summary>
        public GenderEnum Gender { get; set; }

        /// <summary>
        /// Тип занятости
        /// </summary>
        public EmploymentEnum Employment { get; set; }

        /// <summary>
        /// Опыт работы
        /// </summary>
        public ExperienceEnum Experience { get; set; }

        /// <summary>
        /// График работы
        /// </summary>
        public ScheduleEnum Schedule { get; set; }
    }
}
