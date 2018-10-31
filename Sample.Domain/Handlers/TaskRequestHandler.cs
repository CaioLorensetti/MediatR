using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Sample.Domain.Requests;

namespace Sample.Domain.Handlers
{
    public class TaskRequestHandler : IRequestHandler<TaskCreateRequest, TaskCreateResponse>
    {
        public Task<TaskCreateResponse> Handle(TaskCreateRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}