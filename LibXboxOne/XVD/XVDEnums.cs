﻿namespace LibXboxOne
{
    public enum XvdContentType : uint
    {
        // ReSharper disable InconsistentNaming
        Data = 0,
        GameContainer = 1,
        SystemOS = 2, // system.xvd / sharedOS
        EraOS = 3, // era.xvd / exclusiveOS
        Scratch = 4,
        ResetData = 5,
        Application = 6,
        HostOS = 7, // host.xvd / hostOS
        // 8
        // 9
        // 0xA
        Updater = 0xB,
        // 0xC
        Template = 0xD, // sostmpl.xvd SettingsTemplate.xvd
        // 0xE
        // 0xF
        // 0x10
        // 0x11
        // 0x12
        SystemTools = 0x13,
        SystemAux = 0x14,
        // 0x15
        // 0x16
        // 0x17
        // 0x18
        DownloadableContent = 0x19
        // ReSharper restore InconsistentNaming
    }

    public enum XvcRegionFlags : uint
    {
        Resident = 1,
        InitialPlay = 2, // might be 4, or maybe InitialPlay stuff in XvcInfo struct should be swapped with Preview
        Preview = 4,
        FileSystemMetadata = 8
    }

    public enum XvdVolumeFlags : uint
    {
        ReadOnly = 1,
        EncryptionDisabled = 2, // data decrypted, no encrypted CIKs
        DataIntegrityDisabled = 4, // unsigned and unhashed
        SystemFile = 8, // only observed in system files
        Unknown = 0x40, // unsure, never set on unsigned/unhashed files
    }
}
