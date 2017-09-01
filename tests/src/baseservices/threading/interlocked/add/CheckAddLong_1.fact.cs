using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _interlocked_add_CheckAddLong_1_CheckAddLong_1_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_add_CheckAddLong_1_CheckAddLong_1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\add\\CheckAddLong_1\\CheckAddLong_1.cmd");
        }
    }
}
