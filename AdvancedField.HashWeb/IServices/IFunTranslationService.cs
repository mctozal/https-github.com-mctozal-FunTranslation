using AdvancedField.FunTranslation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedField.HashWeb.IServices
{
    public interface IFunTranslationService
    {
        FunTranslationResponseModel GetConvertedString(string text);
    }
}
