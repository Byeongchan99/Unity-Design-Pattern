using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EventBusPattern
{
    public class EventBus
    {
        private Dictionary<Type, Action<object>> eventListeners = new Dictionary<Type, Action<object>>();

        public static EventBus Instance { get; private set; } = new EventBus();

        public void Subscribe<T>(Action<object> listener)
        {
            var eventType = typeof(T);
            if (!eventListeners.ContainsKey(eventType))
            {
                eventListeners[eventType] = listener;
            }
            else
            {
                eventListeners[eventType] += listener;
            }
        }

        public void Unsubscribe<T>(Action<object> listener)
        {
            var eventType = typeof(T);
            if (eventListeners.ContainsKey(eventType))
            {
                eventListeners[eventType] -= listener;
            }
        }

        public void Publish<T>(T eventData)
        {
            var eventType = typeof(T);
            if (eventListeners.ContainsKey(eventType))
            {
                eventListeners[eventType]?.Invoke(eventData);
            }
        }
    }
}
