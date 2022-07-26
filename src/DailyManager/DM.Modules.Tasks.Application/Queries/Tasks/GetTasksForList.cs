﻿using DM.Modules.Tasks.Shared.Models.Tasks;
using DM.Shared.Application.Queries;

namespace DM.Modules.Tasks.Application.Queries.Tasks
{
    public class GetTasksForList : IQuery<IEnumerable<TaskListItemModel>>
    {
        public Guid ListId { get; set; }
    }
}
