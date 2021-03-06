﻿using MediatR;
using Modbus2Mqtt.Infrastructure.YmlConfiguration.Configuration;
using Modbus2Mqtt.Infrastructure.YmlConfiguration.DeviceDefinition;

namespace Modbus2Mqtt.Eventing.Mqtt
{
    public class OutGoingMessageEvent : INotification
    {
        public Slave Slave { get; set; }
        
        public Register Register { get; set; }
        
        public string Message { get; set; }
    }
}