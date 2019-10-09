using SimpleAutocompleteAndSearch.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAutocompleteAndSearch.Tests.Fakes
{
    public class FakeJobRepository : IJobsRepository
    {
        public IQueryable<JobTitlesAndDescriptions> SearchJobsByTitle(string title, int count) => new JobTitlesAndDescriptions[]
        {
            new JobTitlesAndDescriptions()
            {
                jobTitle = "Bus Driver",
                jobDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent id elit ultricies, iaculis massa non, vulputate tellus. Quisque quis lectus felis. Cras viverra, risus sit amet dapibus vestibulum, lorem ipsum faucibus metus, id fermentum est tellus at orci. Sed in consequat nisl, pellentesque luctus ex. Vivamus mollis ut enim sit amet venenatis. Curabitur laoreet, augue sit amet volutpat accumsan, ex dui tempor tellus, semper tristique nibh ex ac purus. Maecenas felis lorem, bibendum ac varius id, malesuada in sem. ",
            },
            new JobTitlesAndDescriptions()
            {
                jobTitle = "Full Stack Developer",
                jobDescription = "Nulla lectus lorem, cursus non venenatis sed, porttitor at diam. Donec sed est auctor, interdum ipsum eu, imperdiet nibh. Ut tincidunt quam eget justo elementum scelerisque. Quisque sapien massa, tristique vel leo sed, hendrerit varius arcu. Nulla facilisi. Curabitur elementum mauris in auctor venenatis. Praesent mattis, ante at gravida bibendum, est mi auctor purus, dignissim porta lacus purus et lorem. Suspendisse sagittis porttitor congue. Donec pharetra, libero congue lacinia volutpat, nibh risus eleifend dui, ac auctor tellus ipsum sit amet sem.",
            },
            new JobTitlesAndDescriptions()
            {
                jobTitle = "Angular Developer",
                jobDescription = "Vivamus pellentesque lacus sed mattis imperdiet. Curabitur vitae ultricies est, non viverra elit. Sed ac tortor tincidunt, viverra purus a, pharetra dui. Etiam aliquam nulla ut massa bibendum pellentesque. Nulla sed urna a odio commodo fringilla. Quisque gravida magna eros, quis porta erat gravida in. Nunc finibus, tellus eu accumsan dictum, ante tellus sagittis quam, vitae pellentesque metus libero ut arcu.",
            },
        }.AsQueryable();

        public IQueryable<string> SearchJobsTitle(string str, int count) => new string[] { "Forklift Operator", "System Architect", "Python Developer" }.AsQueryable();
    }
}
