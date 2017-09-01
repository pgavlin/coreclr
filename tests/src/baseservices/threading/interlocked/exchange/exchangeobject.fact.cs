using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _interlocked_exchange_exchangeobject_exchangeobject_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_exchange_exchangeobject_exchangeobject_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\exchange\\exchangeobject\\exchangeobject.cmd");
        }
    }
}
