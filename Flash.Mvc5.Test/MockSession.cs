using System.Collections.Generic;
using System.Web;

namespace Flash.Mvc5.Test
{
    public class MockSession : HttpSessionStateBase
    {
        private readonly Dictionary<string, object> store = new Dictionary<string, object>();

        public override object this[string name]
        {
            get
            {
                return !store.ContainsKey(name) ? null : store[name];
            }
            set
            {
                store[name] = value;
            }
        }
    }
}