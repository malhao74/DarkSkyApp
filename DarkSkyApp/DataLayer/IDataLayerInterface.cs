using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    /// <summary>
    /// Custom event data class that is used in all class that implement the IDataLayerInterface
    /// </summary>
    /// <typeparam name="TData"></typeparam>
    internal class DataLayerEventArgs<TData> : EventArgs
    {
        internal TData Item { get; }

        internal DataLayerEventArgs() : base() { }

        internal DataLayerEventArgs(TData item)
           : base()
        {
            Item = item;
        }
    }

    /// <summary>
    /// Interafce to implement a basic data layer
    /// </summary>
    /// <typeparam name="TData"></typeparam>
    internal interface IDataLayerInterface<TData>
    {
        event EventHandler<DataLayerEventArgs<TData>> GotDataEventHandler;
        void GetDataAsync();
    }
}
