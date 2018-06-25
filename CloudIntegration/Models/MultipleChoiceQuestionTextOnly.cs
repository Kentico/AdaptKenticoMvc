// This code was generated by a cloud-generators-net tool 
// (see https://github.com/Kentico/cloud-generators-net).
// 
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated. 
// For further modifications of the class, create a separate file with the partial class.

using System;
using System.Collections.Generic;
using KenticoCloud.Delivery;

namespace CloudIntegration.Models
{
    public partial class MultipleChoiceQuestionTextOnly : BaseComponent
    {
        public const string Codename = "multiple_choice_question__text_only_";
        public const string FeedbackIfPartlyCorrectCodename = "feedback_if_partly_correct";
        public const string BasecomponentDisplayTitleCodename = "basecomponent__display_title";
        public const string BasecomponentIsRequiredCodename = "basecomponent__is_required_";
        public const string BasecomponentLayoutCodename = "basecomponent__layout";
        public const string QuestionTextCodename = "question_text";
        public const string BasecomponentIncludeInProgressCodename = "basecomponent__include_in_progress_";
        public const string AnswersCodename = "answers";
        public const string BasecomponentCompontentClassesCodename = "basecomponent__compontent_classes";
        public const string BasecomponentTitleCodename = "basecomponent__title";
        public const string FeedbackIfIncorrectCodename = "feedback_if_incorrect";
        public const string FeedbackIfCorrectCodename = "feedback_if_correct";
        public const string BasecomponentInstructionsCodename = "basecomponent__instructions";

        public string FeedbackIfPartlyCorrect { get; set; }
        public string BasecomponentDisplayTitle { get; set; }
        public IEnumerable<MultipleChoiceOption> BasecomponentIsRequired { get; set; }
        public IEnumerable<MultipleChoiceOption> BasecomponentLayout { get; set; }
        public string QuestionText { get; set; }
        public IEnumerable<MultipleChoiceOption> BasecomponentIncludeInProgress { get; set; }
        public IEnumerable<object> Answers { get; set; }
        public IEnumerable<TaxonomyTerm> BasecomponentCompontentClasses { get; set; }
        public string BasecomponentTitle { get; set; }
        public string FeedbackIfIncorrect { get; set; }
        public string FeedbackIfCorrect { get; set; }
        public string BasecomponentInstructions { get; set; }
        public override ContentItemSystemAttributes System { get; set; }
    }
}