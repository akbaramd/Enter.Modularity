﻿using Enter.ENB.Ddd.Application.Dtos;

namespace Enter.ENB.Application.Services;

public interface IReadOnlyAppService<TEntityDto, in TKey>
    : IReadOnlyAppService<TEntityDto, TEntityDto, TKey, PagedAndSortedResultRequestDto>
{

}

public interface IReadOnlyAppService<TEntityDto, in TKey, in TGetListInput>
    : IReadOnlyAppService<TEntityDto, TEntityDto, TKey, TGetListInput>
{

}

public interface IReadOnlyAppService<TGetOutputDto, TGetListOutputDto, in TKey, in TGetListInput>
    : IApplicationService
{
    Task<TGetOutputDto> GetAsync(TKey id);

    Task<PagedResultDto<TGetListOutputDto>> GetListAsync(TGetListInput input);
}
