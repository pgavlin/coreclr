using CoreclrTestLib;
using Xunit;

namespace baseservices_varargs
{
    class _varargsupport_r_varargsupport_r_
    {
        [Fact]
        public void _varargsupport_r_varargsupport_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\varargs\\varargsupport_r\\varargsupport_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
