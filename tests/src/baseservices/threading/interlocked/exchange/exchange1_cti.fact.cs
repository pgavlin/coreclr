using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _interlocked_exchange_exchange1_cti_exchange1_cti_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_exchange_exchange1_cti_exchange1_cti_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\exchange\\exchange1_cti\\exchange1_cti.cmd");
        }
    }
}
