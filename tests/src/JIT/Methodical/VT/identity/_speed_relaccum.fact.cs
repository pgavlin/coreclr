using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_identity__speed_relaccum__speed_relaccum_
    {
        [OuterLoop]
        [Fact]
        public void _VT_identity__speed_relaccum__speed_relaccum_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\identity\\_speed_relaccum\\_speed_relaccum.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
