﻿using Gnn.NeuralNet.Structures.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gnn.NeuralNet.Structures {

    public class Variable : INode {
        public float Value { get; set; }

        public float Output => Value;

        public Variable(float init = 0) {
            Value = init;
        }
    }
}