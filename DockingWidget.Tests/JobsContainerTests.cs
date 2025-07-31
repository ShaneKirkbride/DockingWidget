using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DockingWidget.Models;
using DockingWidget.Shared;
using Xunit;

namespace DockingWidget.Tests
{
    public class JobsContainerTests
    {
        [Fact]
        public async Task UpdateJobAsync_UpdatesStatusAndResetsPayload()
        {
            var jobs = new List<JobModel>
            {
                new JobModel { Id = 1, Description = "Test", Status = JobStatuses.Todo, LastUpdated = DateTime.MinValue }
            };
            var container = new JobsContainer { Jobs = jobs };
            container.Payload = jobs[0];

            await container.UpdateJobAsync(JobStatuses.Completed);

            Assert.Equal(JobStatuses.Completed, jobs[0].Status);
            Assert.NotEqual(DateTime.MinValue, jobs[0].LastUpdated);
            Assert.Null(container.Payload);
        }
    }
}
