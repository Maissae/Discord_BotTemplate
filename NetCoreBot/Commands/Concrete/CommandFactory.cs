﻿using Discord.WebSocket;
using NetCoreBot.Commands.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreBot.Commands.Concrete
{
    public class CommandFactory : ICommandFactory
    {
        public ICommand BuildCommand(string message, List<string> parameters, MessageDetails messageDetails = null)
        {
            ICommand command = null;
            switch (message)
            {
                case "random":
                    command = new GenerateRandomNumberCommand(parameters, messageDetails);
                    break;
                default:
                    break;
            }
            return command;
        }
    }
}
