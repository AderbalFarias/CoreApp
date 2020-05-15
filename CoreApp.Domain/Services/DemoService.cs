﻿using CoreApp.Domain.Entities;
using CoreApp.Domain.Interfaces.Repositories;
using CoreApp.Domain.Interfaces.Services;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoreApp.Domain.Services
{
    public class DemoService : IDemoService
    {
        private readonly IBaseRepository _baseRepository;
        private readonly IOpenService _openService;
        private readonly ILogger _logger;

        public DemoService
        (
            IBaseRepository baseRepository,
            IOpenService openService,
            ILogger<DemoService> logger
        )
        {
            _baseRepository = baseRepository;
            _openService = openService;
            _logger = logger;
        }

        public async Task<IEnumerable<DemoEntity>> GetAll()
        {
            _logger.LogInformation("Method get all was called");

            return await _baseRepository.GetAsync<DemoEntity>();
        }

        public async Task<DemoEntity> GetById(int id)
        {
            return await _baseRepository
                .GetObjectAsync<DemoEntity>(p => p.Id == id);
        }

        public async Task<DemoEntity> GetDetails(int id, int entityId)
        {
            return await _baseRepository
                .GetObjectAsync<DemoEntity>(p => p.Id == id);
        }

        public async Task Save(DemoEntity entity)
        {
            _logger.LogInformation("Method save called");

            await _baseRepository.Add(entity);
        }

        public Task Update(DemoEntity entity)
        {
            //return Task.CompletedTask;
            var openData = _openService.GetById(1);

            throw new NotImplementedException("Method not Implemented");
        }
    }
}
