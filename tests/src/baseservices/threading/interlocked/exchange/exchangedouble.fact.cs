using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _interlocked_exchange_exchangedouble_exchangedouble_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_exchange_exchangedouble_exchangedouble_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\exchange\\exchangedouble\\exchangedouble.cmd");
        }
    }
}
