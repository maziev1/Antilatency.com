﻿using Csml;
using static Tutorials.PrepareRaspberryPiSdCard_Assets;

public partial class Tutorials : Scope {

    public static Material PrepareRaspberryPiSdCard_en => new Material("Prepare SD card image for Raspberry Pi", null, $"")

        [new Section("Raspbian")
            [$"{new ExternalReference("https://www.raspbian.org/", "Raspbian")} is the Raspberry Pi Foundation’s official supported operation system based on Debian GNU/Linux."]
            [$"Images:"]
            [new UnorderedList()
                [$"{new ExternalReference("https://downloads.raspberrypi.org/raspbian_lite_latest", "Raspbian Lite")} - minimal image with command line interface."]
                [$"{new ExternalReference("https://downloads.raspberrypi.org/raspbian_latest", "Raspbian Destop ")} - Raspbian Lite + graphical user interface: {new ExternalReference("https://www.raspberrypi.org/blog/introducing-pixel/", "PIXEL desktop environment")}"]
            ]
            [$"Download preferred type of image and {new ExternalReference("https://www.raspberrypi.org/documentation/installation/installing-images/README.md", "write it to microSD card")} (you can install or remove GUI apps later)."]
        ]

        [new Section("Wireless setup")
            [$"You need to write WiFi network name / password to the Raspberry Pi SD card and enable SSH server before you can get remote access."]
            [$"Insert microSD card to your PC card reader then create two files `wpa_supplicant.conf` and `ssh` in the `boot` folder on the SD card."]

            [$"`wpa_supplicant.conf`:"]
            [WpaSupplicantConf]
            [$"On the Raspberry Pi 3A+, 3B+, 4 and above, you will also need to set the {new ExternalReference("https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2#Officially_assigned_code_elements", "country code")}, so that the 5G networking can choose the correct frequency bands:"]
            [$"`country=GB`"]
            [$"You can edit this settings later, see {new ExternalReference("https://www.raspberrypi.org/documentation/configuration/wireless/wireless-cli.md", "documentation")}."]

            [$"`ssh`:"]
            [$"Just empty file with `ssh` file name without extension."]
        ]

        [new Section("Update installed software")
            [AptUpdate]
        ]

        [new Section($"Power button")
            [$"Add support for {Terms.AntilatencyRPiSocket} power button."]
            [$"Enable software shutdown via GPIO:"]
            [$"See more {new ExternalReference("https://www.stderr.nl/Blog/Hardware/RaspberryPi/PowerButton.html", "PowerButton")}"]
            [GpioShutdown]

            [$"Install WiringPi:"]
            [$"{new ExternalReference("https://pinout.xyz/pinout/wiringpi","WiringPi", "“WiringPi is an attempt to bring Arduino-wiring-like simplicity to the Raspberry Pi. The goal is to have a single common platform and set of functions for accessing the Raspberry Pi GPIO across multiple languages.”")}"]
            [$"`sudo apt update && sudo apt install wiringpi`"]

            [$"Set `RPI_OS_OK GPIO` pin to `HIGH` state:"]
            [RcLocal]
            [$"Add lines:"]
            [RpiOsOkGpioPinRcLocal]
            [$"before `exit 0` line. Then press `Ctrl+o` then press Enter for saving result. Press `Ctrl+x` for exit."]

            [$"Setup `RPI_OFF_OK` GPIO pin:"]
            [RpiOffOkGpioPinSystemD]
        ]

        [new Section($"Prepare installation directory")
            [$"Create package directories for Antilatency software and change owner:"]
            [CreateOptAntilatencyDir]           

            [$"Add rule for Antilatency USB devices:"]
            [AntilatencyUdevRules]
            
        ]
        ;

    

}