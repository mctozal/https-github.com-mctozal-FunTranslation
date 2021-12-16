using AdvancedField.FunTranslation.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedField.FunTranslation.IServices
{
    public interface IFunTranslationService
    {
        FunTranslationResponseModel GetConvertedString(string text);
    }
}
