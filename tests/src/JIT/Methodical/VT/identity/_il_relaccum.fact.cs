using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_identity__il_relaccum__il_relaccum_
    {
        [OuterLoop]
        [Fact]
        public void _VT_identity__il_relaccum__il_relaccum_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\identity\\_il_relaccum\\_il_relaccum.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
