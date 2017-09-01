using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _interlocked_add_InterlockedAddLong_2_InterlockedAddLong_2_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_add_InterlockedAddLong_2_InterlockedAddLong_2_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\add\\InterlockedAddLong_2\\InterlockedAddLong_2.cmd");
        }
    }
}
