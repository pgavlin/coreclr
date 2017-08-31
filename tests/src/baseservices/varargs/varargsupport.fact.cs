using CoreclrTestLib;
using Xunit;

namespace baseservices_varargs
{
    class _varargsupport_varargsupport_
    {
        [Fact]
        public void _varargsupport_varargsupport_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\varargs\\varargsupport\\varargsupport.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
