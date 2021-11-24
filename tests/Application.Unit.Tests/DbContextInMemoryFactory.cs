﻿using Microsoft.EntityFrameworkCore;
using MinimalApiArchitecture.Application.Common.Interfaces;
using MinimalApiArchitecture.Application.Infrastructure.Persistence;
using Moq;

namespace Application.Unit.Tests;

public class DbContextInMemoryFactory
{
    public static ApiDbContext Create()
    {
        var options = new DbContextOptionsBuilder<ApiDbContext>()
            .UseInMemoryDatabase(nameof(ApiDbContext))
            .Options;


        return new ApiDbContext(options, Mock.Of<IDomainEventService>());
    }
}
