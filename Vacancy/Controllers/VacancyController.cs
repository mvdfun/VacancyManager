using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using VacancyManager.Models;

namespace VacancyManager.Controllers
{
    /// <summary>
    /// Контроллер Вакансий
    /// </summary>
    [Route("api/[controller]")]
    public class VacancyController : Controller
    {
        #region Props and fields

        /// <summary>
        /// Базовый Url API HeadHunter
        /// </summary>
        private readonly string _baseUrl = @"https://api.hh.ru/";

        #endregion

        #region Ctor

        public VacancyController()
        {

        }

        #endregion

        #region Post methods

        /// <summary>
        /// Получение вакансии по заданному параметру
        /// </summary>
        /// <param name="request">Сущность поискового запроса</param>
        /// <returns>Возвращает все найденные вакансии в запросе</returns>
        public async Task<IActionResult> GetVacancies([FromBody]Vacancy request)
        {
            return Ok();
        }

        #endregion

        /// <summary>
        /// Тестовый метод для сваггера
        /// </summary>
        /// <returns></returns>
        [HttpGet(nameof(Test))]
        public async Task<IActionResult> Test()
        {
            return Ok();
        }
    }
}
