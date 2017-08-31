using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_port__dbglcs_gcref__dbglcs_gcref_
    {
        [Fact]
        public void _VT_port__dbglcs_gcref__dbglcs_gcref_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\port\\_dbglcs_gcref\\_dbglcs_gcref.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
