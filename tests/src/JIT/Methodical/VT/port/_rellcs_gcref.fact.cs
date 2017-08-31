using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_port__rellcs_gcref__rellcs_gcref_
    {
        [Fact]
        public void _VT_port__rellcs_gcref__rellcs_gcref_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\port\\_rellcs_gcref\\_rellcs_gcref.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
