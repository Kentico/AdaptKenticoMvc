// This code was generated by a kontent-generators-net tool 
// (see https://github.com/Kentico/kontent-generators-net).
// 
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated. 
// For further modifications of the class, create a separate file with the partial class.

using System;
using System.Collections.Generic;
using Kentico.Kontent.Delivery.Abstractions;

namespace KenticoKontentModels
{
    public partial class NarrativeCodeItem
    {
        public const string Codename = "narrative_code_item";
        public const string AvailableLanguagesLanguageCodename = "available_languages__language";
        public const string CodeCodename = "code";
        public const string TextCodename = "text";
        public const string TitleCodename = "title";

        public IEnumerable<IMultipleChoiceOption> AvailableLanguagesLanguage { get; set; }
        public string Code { get; set; }
        public IContentItemSystemAttributes System { get; set; }
        public string Text { get; set; }
        public string Title { get; set; }
    }
}