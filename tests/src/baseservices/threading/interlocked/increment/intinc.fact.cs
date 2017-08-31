using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _interlocked_increment_intinc_intinc_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_increment_intinc_intinc_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\increment\\intinc\\intinc.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
