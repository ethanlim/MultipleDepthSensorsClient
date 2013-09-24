﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.IO;

namespace MultipleKinectsPlatform.MultipleKinectsPlatform.Data
{
    [DataContract(Name="Joint")]
    public class Joint
    {
        [DataMember]
        public float X;

        [DataMember]
        public float Y;

        [DataMember]
        public float Z;

        public Joint(float i_x, float i_y, float i_z)
        {
            X = i_x;
            Y = i_y;
            Z = i_z;
        }
    }
}
