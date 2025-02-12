// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Trigger type of the job. </summary>
    public readonly partial struct ContainerAppJobTriggerType : IEquatable<ContainerAppJobTriggerType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ContainerAppJobTriggerType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ContainerAppJobTriggerType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ScheduledValue = "Scheduled";
        private const string EventValue = "Event";
        private const string ManualValue = "Manual";

        /// <summary> Scheduled. </summary>
        public static ContainerAppJobTriggerType Scheduled { get; } = new ContainerAppJobTriggerType(ScheduledValue);
        /// <summary> Event. </summary>
        public static ContainerAppJobTriggerType Event { get; } = new ContainerAppJobTriggerType(EventValue);
        /// <summary> Manual. </summary>
        public static ContainerAppJobTriggerType Manual { get; } = new ContainerAppJobTriggerType(ManualValue);
        /// <summary> Determines if two <see cref="ContainerAppJobTriggerType"/> values are the same. </summary>
        public static bool operator ==(ContainerAppJobTriggerType left, ContainerAppJobTriggerType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ContainerAppJobTriggerType"/> values are not the same. </summary>
        public static bool operator !=(ContainerAppJobTriggerType left, ContainerAppJobTriggerType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ContainerAppJobTriggerType"/>. </summary>
        public static implicit operator ContainerAppJobTriggerType(string value) => new ContainerAppJobTriggerType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ContainerAppJobTriggerType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ContainerAppJobTriggerType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
