using MarketGrowthStrategy.TheApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketGrowthStrategy.TheApp.Features.Profile.Templates
{
    public class StepTemplateSelector : DataTemplateSelector
    {
        public DataTemplate FirstStepTemplate { get; set; }
        public DataTemplate OtherStepTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            if (item is not ProcessStep processStep)
            {
                throw new ArgumentException("Parameter must be of type ProcessStep");
            }

            return processStep.IsFirst ? FirstStepTemplate : OtherStepTemplate;
        }
    }
}
