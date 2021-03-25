using System.Collections.Generic;

namespace NeuralNetworks
{
    public class Layer
    {
        public List<Neuron> Neurons { get; }
        public int NeuronCounts => Neurons?.Count?? 0;
        public NeuronType NeuronType;
        public Layer(List<Neuron> neurons, NeuronType type = NeuronType.Normal)
        {
            //TODO: проверить все входные нейроны на соответсвие типу
            NeuronType = type;
            Neurons = neurons;
        }

        public List<double> GetSignals()
        {
            var result = new List<double>();
            foreach (var neuron in Neurons)
            {
                result.Add(neuron.Output);
            }
            return result;
        }

        public override string ToString()
        {
            return NeuronType.ToString();
        }
    }
}
