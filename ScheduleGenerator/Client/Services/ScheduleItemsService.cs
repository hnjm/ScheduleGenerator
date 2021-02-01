﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using ScheduleGenerator.Shared.Dto;

namespace ScheduleGenerator.Client.Services
{
    public class ScheduleItemsService : IScheduleItemsService
    {
        private readonly IHttpService _httpService;

        public ScheduleItemsService(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<HttpResponseMessage> GetScheduleItemsAsync(int scheduleId)
        {
            return await _httpService.Get($"api/schedules/{scheduleId}/scheduleItems");
        }

        public async Task<HttpResponseMessage> CreateScheduleItemAsync(int scheduleId, ScheduleItemForCreationDto scheduleItem)
        {
            return await _httpService.Post($"api/schedules/{scheduleId}/scheduleItems", scheduleItem);
        }

        public async Task<HttpResponseMessage> UpdateScheduleItemAsync(int scheduleId, int scheduleItemId, ScheduleItemForUpdateDto scheduleItem)
        {
            return await _httpService.Put($"api/schedules/{scheduleId}/scheduleItems/{scheduleItemId}", scheduleItem);

        }

        public async Task<HttpResponseMessage> DeleteScheduleItemAsync(int scheduleId, int scheduleItemId)
        {
            return await _httpService.Delete($"api/schedules/{scheduleId}/scheduleItems/{scheduleItemId}");

        }
    }
}
