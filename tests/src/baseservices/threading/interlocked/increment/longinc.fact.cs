using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _interlocked_increment_longinc_longinc_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_increment_longinc_longinc_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\increment\\longinc\\longinc.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
