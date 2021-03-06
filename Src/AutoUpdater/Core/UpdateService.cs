﻿using AutoUpdater.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Updater.CommService.Interface;
using Updater.gRPCService.Impl;
using Updater.UpdateService.Interface;

namespace AutoUpdater.Core
{
    internal class UpdateService : IUpdateService
    {
        private ICommService _commService = new GrpcService();

        public CommOptions GetCommOptions()
        {
            return _commService.GetCommOptions();
        }

        public Task<string> GetMajorVersion(string url)
        {
            return _commService.GetStringAsync(url);
        }

        public async Task<IVersionInfo> GetVersionInfo(string url)
        {
            var versionInfo = await _commService.GetStringAsync(url);
            var settings = new JsonSerializerSettings();
            settings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            return JsonConvert.DeserializeObject<VersionInfo>(versionInfo, settings);
        }

        public async Task<bool> DownloadFile(string url, string downloadFilePath)
        {
            var fileBytes = await _commService.GetBytesAsync(url);

            downloadFilePath = Path.GetFullPath(downloadFilePath);
            File.WriteAllBytes(downloadFilePath, fileBytes);

            return true;
        }
    }
}
