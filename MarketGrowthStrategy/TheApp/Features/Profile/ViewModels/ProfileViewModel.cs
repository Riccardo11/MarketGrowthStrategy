using CommunityToolkit.Mvvm.ComponentModel;
using MarketGrowthStrategy.TheApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketGrowthStrategy.TheApp.Features.Profile.ViewModels
{
    public class ProfileViewModel : ObservableObject
    {
        public ObservableCollection<ProcessStep> Steps { get; }
        public ObservableCollection<Flow> Flows { get; }

        public ProfileViewModel()
        {
            Steps = new ObservableCollection<ProcessStep>
            {
                new ProcessStep
                {
                    IsFirst = true,
                    Title = "Add task",
                    Description = "Creative for branging"
                },
                new ProcessStep
                {
                    Title = "Review",
                    Description = "Verification process with team"
                },
                new ProcessStep
                {
                    Title = "Third step",
                    Description = "Description for third step"
                }
            };

            Flows = new ObservableCollection<Flow>
            {
                new Flow
                {
                    Title = "Document verification",
                    DateTime = DateTime.Now - TimeSpan.FromMinutes(3)
                },
                new Flow
                {
                    Title = "Newbie onboarding",
                    DateTime = DateTime.Now - TimeSpan.FromDays(5)
                }
            };
        }
    }
}
