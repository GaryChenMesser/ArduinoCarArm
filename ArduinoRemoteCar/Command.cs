﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArduinoRemoteCar
{
    public class Command
    {
        //Commands definition
        public const string MOT_A_SPD   = "a";
        public const string MOT_B_SPD   = "c";
        public const string FORWARD_CMD = "f";
        public const string BACK_CMD    = "b";
        public const string LEFT_CMD    = "l";
        public const string RIGHT_CMD   = "r";
        public const string STOP_CMD    = "s";
        public const string SOFT_STOP_CMD = "v";

        public const int DEFAULT_MOT_PWM = 100;

        //Arm
        public const string BASE_CMD     = "x";
        public const string SHOULDER_CMD = "u";
        public const string ELBOW_CMD    = "e";
        public const string GRIPPER_CMD  = "g";

        public const int ARM_MOVE_STEP = 5;
    }
}
