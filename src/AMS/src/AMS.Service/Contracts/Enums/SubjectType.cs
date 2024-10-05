// *************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.AMS
// *************************************************

namespace Undersoft.AMS.Service.Contracts.Enums
{
    [Flags]
    public enum SubjectType : long
    {
        None = 0,
        Category = 1,
        Group = 2,
        Work = 4,
        Case = 8,
        Aspect = 16,
        Flow = 32,
        Commodity = 64,
        Product = 128,
        SemiProduct = 256,
        Device = 512,
        Project = 1024,
        Service = 2048,
        Variant = 4096,
        Task = 8192,
        Stage = 16384,
        Attribute = 32768,
        RawMaterial = 65536,
        Component = 131072,
        Operation = 262144,
        Parcel = 524288,
        Objective = 1048576,
        Workflow = 2097152,
        Procedure = 4194304,
        Tool = 8388608,
        Input = 16777216,
        Output = 33554432,
        Result = 67108864,
        Completion = 134217728,
        Command = 268435456,
        Query = 536870912,
        Invocation = 1073741824,
        Validation = 2147483648,
        Notification = 4294967296
    }
}