using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_port__dbglcs__dbglcs_
    {
        [OuterLoop]
        [Fact]
        public void _VT_port__dbglcs__dbglcs_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\port\\_dbglcs\\_dbglcs.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
