﻿namespace Lion.AbpPro.Cli.Core.Lion.AbpPro.Cli.Commands;

public interface ICommandSelector
{
    Type Select(CommandLineArgs commandLineArgs);
}