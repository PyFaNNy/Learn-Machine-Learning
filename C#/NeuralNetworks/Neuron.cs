using System;
using System.Collections.Generic;

namespace NeuralNetworks
{
    public class Neuron
    {
        public List<double> Weights { get; }
        public NeuronType NeuronType { get; }
        public double Output { get; private set; }

        public Neuron(int inputCount, NeuronType type = NeuronType.Normal)
        {
            //TODO: Проверка входных значений
            NeuronType = type;
            Weights = new List<double>();
            for (int i=0;i<inputCount;i++)
            {
                Weights.Add(1);
            }
        }
        public double FeedFowrward(List<double> inputs)
        {
            //TODO: Проверка Weights.len==inputs.len
            var sum = 0.0;
            for(int i=0;i<inputs.Count;i++)
            {
                sum += inputs[i] * Weights[i];
            }
            if (NeuronType != NeuronType.Input)
            {
                Output = Sigmoid(sum);
            }
            else
            {
                Output = sum;
            }
            return Output;
        }
        public void SetWeights(params double[] weights)
        {
            //TODO: удалить после добавления возможности обучения сети
            for (int i = 0; i < weights.Length; i++)
            {
                Weights[i] = weights[i];
            }
        }
        private double Sigmoid(double x)
        {
            var result = 1.0 / (1.0 + Math.Pow(Math.E, -x));
            return result;
        }

        public override string ToString()
        {
            return Output.ToString();
        }
    }
}
