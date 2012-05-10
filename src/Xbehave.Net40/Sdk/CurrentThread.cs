﻿// <copyright file="CurrentThread.cs" company="Adam Ralph">
//  Copyright (c) Adam Ralph. All rights reserved.
// </copyright>

namespace Xbehave.Sdk
{
    using System;

    internal static class CurrentThread
    {
        private static ICommandFactory commandFactory = new CommandFactory();

        [ThreadStatic]
        private static Scenario scenario;

        public static Scenario Scenario
        {
            get { return scenario ?? (scenario = new Scenario(commandFactory)); }
        }

        public static void ResetScenario()
        {
            scenario = null;
        }
    }
}