using AdvancedField.FunTranslation.IServices;
using AdvancedField.FunTranslation.Model;

namespace AdvancedField.HashWeb.Services
{
    public class FunTranslationService : IServices.IFunTranslationService
    {
        private readonly IFunTranslationService _funTranslationService;
        public FunTranslationService(IFunTranslationService _funTranslationService)
        {
            this._funTranslationService = _funTranslationService;
        }

        public FunTranslationResponseModel GetConvertedString(string text)
        {
            return _funTranslationService.GetConvertedString(text);
        }
    }
}
