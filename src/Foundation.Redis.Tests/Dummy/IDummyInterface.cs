﻿using System;
using System.Threading.Tasks;

namespace Foundation.Redis.Tests.Dummy
{
    public interface IDummyInterface
    {
        DateTime DummyMetod();
        Task<DateTime> DummyMetodAsync();
    }
}