using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace VacancyManager.Enums
{
    public enum EmploymentEnum
    {
        /// <summary>
        /// Не указано
        /// </summary>
        [Description("Не указано")]
        Default,


        /// <summary>
        /// Полная занятость
        /// </summary>
        [Description("Полная занятость")]
        Full,


        /// <summary>
        /// Частичная занятость
        /// </summary>
        [Description("Частичная занятость")]
        Part,


        /// <summary>
        /// Проектная работа
        /// </summary>
        [Description("Проектная работа")]
        Project,


        /// <summary>
        /// Волонтерство
        /// </summary>
        [Description("Волонтерство")]
        Volunteer,


        /// <summary>
        /// Стажировка
        /// </summary>
        [Description("Стажировка")]
        Probation
    }
}
