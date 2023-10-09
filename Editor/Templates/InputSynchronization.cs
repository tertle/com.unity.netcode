// THIS FILE IS AUTO-GENERATED BY NETCODE PACKAGE SOURCE GENERATORS. DO NOT DELETE, MOVE, COPY, MODIFY, OR COMMIT THIS FILE.
// TO MAKE CHANGES TO THE SERIALIZATION OF A TYPE, REFER TO THE MANUAL.
using Unity.Burst;
using Unity.Burst.Intrinsics;
using System;
using Unity.NetCode.LowLevel.Unsafe;
#region __COMMAND_USING_STATEMENT__
using __COMMAND_USING__;
#endregion

[assembly: RegisterGenericComponentType(typeof(Unity.NetCode.InputBufferData<__COMMAND_COMPONENT_TYPE__>))]
[assembly: RegisterGenericSystemType(typeof(Unity.NetCode.ApplyCurrentInputBufferElementToInputDataSystem<__COMMAND_COMPONENT_TYPE__, __COMMAND_NAMESPACE__.__COMMAND_NAME__EventHelper>))]
[assembly: RegisterGenericSystemType(typeof(Unity.NetCode.CopyInputToCommandBufferSystem<__COMMAND_COMPONENT_TYPE__, __COMMAND_NAMESPACE__.__COMMAND_NAME__EventHelper>))]
[assembly: Unity.Jobs.RegisterGenericJobType(typeof(Unity.NetCode.ApplyInputDataFromBufferJob<__COMMAND_COMPONENT_TYPE__, __COMMAND_NAMESPACE__.__COMMAND_NAME__EventHelper>))]
[assembly: Unity.Jobs.RegisterGenericJobType(typeof(Unity.NetCode.CopyInputToBufferJob<__COMMAND_COMPONENT_TYPE__, __COMMAND_NAMESPACE__.__COMMAND_NAME__EventHelper>))]

namespace __COMMAND_NAMESPACE__
{
    [System.Runtime.CompilerServices.CompilerGenerated]
    internal struct __COMMAND_NAME__EventHelper : IInputEventHelper<__COMMAND_COMPONENT_TYPE__>
    {
        public void DecrementEvents(ref __COMMAND_COMPONENT_TYPE__ input, in __COMMAND_COMPONENT_TYPE__ prevInput)
        {
            #region __DECREMENT_INPUTEVENT__
            input.__EVENTNAME__.Count -= prevInput.__EVENTNAME__.Count;
            #endregion
        }

        public void IncrementEvents(ref __COMMAND_COMPONENT_TYPE__ input, in __COMMAND_COMPONENT_TYPE__ lastInput)
        {
            #region __INCREMENT_INPUTEVENT__
            input.__EVENTNAME__.Count += lastInput.__EVENTNAME__.Count;
            #endregion
        }
    }
}