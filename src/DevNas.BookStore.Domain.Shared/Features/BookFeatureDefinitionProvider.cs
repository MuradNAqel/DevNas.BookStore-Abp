using DevNas.BookStore.Localization;
using Volo.Abp.Features;
using Volo.Abp.Localization;
using Volo.Abp.Validation.StringValues;

namespace DevNas.BookStore.Features
{
    public class BookFeatureDefinitionProvider : FeatureDefinitionProvider
    {

        public override void Define(IFeatureDefinitionContext context)
        {
            var BookGroup = context.AddGroup("BookGroup");

            BookGroup.AddFeature(name: "BookGroup.SpecialFeature", defaultValue: "false"
                    , displayName: LocalizableString.Create<BookStoreResource>("SpecialFeature")
                    , valueType: new ToggleStringValueType());

            BookGroup.AddFeature(name: "BookGroup.SpecialFeatureForOldUsers", defaultValue: "5"
                , valueType: new FreeTextStringValueType(
                               new NumericValueValidator(0, 1000000)));
        }
    }
}
