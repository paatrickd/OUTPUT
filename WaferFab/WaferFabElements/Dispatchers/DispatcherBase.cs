﻿using WaferFabSim.WaferFabElements.Utilities;
using CSSL.Modeling.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace WaferFabSim.WaferFabElements.Dispatchers
{
    public abstract class DispatcherBase : SchedulingElementBase, IGetDateTime
    {
        public DispatcherBase(ModelElementBase workCenter, string name) : base(workCenter, name)
        {
            wc = (WorkCenter)workCenter;
        }

        protected WorkCenter wc { get; }

        public Lot DepartingLot { get; protected set; }

        public DateTime GetDateTime => wc.GetDateTime;

        public abstract void HandleArrival(Lot lot);

        public abstract void HandleDeparture();

        public abstract void HandleFirstDeparture();

        public abstract void HandleInitialization(List<Lot> lots);

        public enum Type
        {
            MIVS,
            EPTOVERTAKING,
            BQF,
            RANDOM
        }
    }



}
