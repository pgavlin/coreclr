using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _interlocked_add_CheckAddLong_CheckAddLong_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_add_CheckAddLong_CheckAddLong_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\add\\CheckAddLong\\CheckAddLong.cmd");
        }
    }
}
