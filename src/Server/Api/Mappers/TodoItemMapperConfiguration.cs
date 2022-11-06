using HelpFullUi.Server.Api.Models.TodoItem;
using HelpFullUi.Shared.Dtos.TodoItem;

namespace HelpFullUi.Server.Api.Mappers;

public class TodoItemMapperConfiguration : Profile
{
    public TodoItemMapperConfiguration()
    {
        CreateMap<TodoItem, TodoItemDto>().ReverseMap();
    }
}
